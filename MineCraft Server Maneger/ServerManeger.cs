using System.Diagnostics;
using System.IO;
using System.Text;
using System.Linq;
using MineCraft_Server_Maneger.Models.Generic;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MineCraft_Server_Maneger
{
    class ServerManeger
    {
        public static ServerManeger GlobalManeger { get; private set; }

        private readonly Process serverProcess;
        private readonly ControlPluginSubManeger pluginSubManeger;

        private StreamWriter Writer { get => serverProcess.StandardInput; }
		public MCVersion MCVersion { get; }
        public Player[] OnlinePlayers { get => GetPlayersBySelector("@a"); }
        public VersionManeger VersionManeger { get; }
        public ConsoleManeger ConsoleManeger { get; private set; }

        #region VersionManegerProperties
        public Gamerule[] AvailableGamerules { get => VersionManeger.AvailableGamerules; }
        public EffectType[] AvailableEffects { get => VersionManeger.AvailableEffects; }

        #endregion

        public Player[] AllPlayers 
        { 
            get 
            {
                var p = pluginSubManeger.List("players");
                var list = new List<Player>();


                foreach (var i in p)
                {
                    char[] a = new char[i.Length - 4];
                    Array.Copy(i.ToArray(), 4, a, 0, a.Length);
                    string f = new string(a);

                    var player = new Player(f);


                    if (i[0] == '1') player.Tags.Add(Player.PlayerTag.Banned);
                    if (i[1] == '1') player.Tags.Add(Player.PlayerTag.Online);
                    if (i[2] == '1') player.Tags.Add(Player.PlayerTag.Operator);
                    if (i[3] == '1') player.Tags.Add(Player.PlayerTag.Whitelisted);

                    list.Add(player);
                }

                return list.ToArray();
            } 
        }


        public ServerManeger(Process serverProcess, MCVersion version)
        {
            this.serverProcess = serverProcess;
            MCVersion = version;

            pluginSubManeger = new ControlPluginSubManeger(this);
            VersionManeger = new VersionManeger(MCVersion);

            if (GlobalManeger == null) GlobalManeger = this;
        }

        public string SetTime(int a)
        {
            return Execute(new Command("time", "set", a.ToString()));
        }

        public string AddTime(int a)
        {
            return Execute(new Command("time", "add", a.ToString()));
        }

        public Task Start()
        {
            serverProcess.Start();
            ConsoleManeger = new ConsoleManeger(serverProcess.StandardOutput, Writer);

            return Task.Run(() =>
            {
                StringBuilder bilder = new StringBuilder();

                while (!bilder.ToString().EndsWith("Done "))
                    bilder.Append(ConsoleManeger.ReadNextSymbol());
            });
        }

        public void Stop()
        {
            ExecutePrimary(new Command("stop"));
            serverProcess.WaitForExit();

            ConsoleManeger = null;
        }

        public void ClearPlayerInventory(Player player, out string er)
        {
            er = Execute(new Command("clear", player.Name));
        }

        public void ChangeWeather(WeatherStade weather, out string er)
        {
            er = Execute(new Command("weather", weather.ToString().ToLower()));
        }

        public void ChangeDifficulty(Difficulty difficulty, out string er)
        {
            er = Execute(new Command("difficulty", difficulty.ToString().ToLower()));
        }

        public string Execute(Command command)
        {
            var t = pluginSubManeger.Execute(command.Name + " " + string.Join(" ", command.Arguments));
            t = t.Substring("[12:01:19 INFO]: ".Length);
            return t;
        }

        public void ExecutePrimary(Command command)
        {
            pluginSubManeger.Execute(command.Name + " " + string.Join(" ", command.Arguments), true);
        }

        public Player[] GetPlayersBySelector(string selector)
        {
            switch (selector)
            {
                case "@a":
                    return AllPlayers.Where((s) => s.Tags.Contains(Player.PlayerTag.Online)).ToArray();
                case "@r":
                    return new Player[] { GetPlayersBySelector("@a")[new Random().Next(0,
                        GetPlayersBySelector("@a").Length - 1)]};
                default:
                    return new Player[] { GetPlayerByName(selector) };
            }
        }

        public Entity[] GetEntitiesBySelector(string selector)
        {
            if(MCVersion >= new MCVersion("1.8") && selector == "@e")
            {
                return new Entity[0];
            }
            else
            {
                return GetPlayersBySelector(selector).Cast<Entity>().ToArray();
            }
        }

        public Player GetPlayerByName(string name, bool reqOnline = true)
        {
            return AllPlayers.Where((f) => (!reqOnline || f.Tags.Contains(Player.PlayerTag.Online))
                && f.Name == name).Single();
        }

        public string[] ApplyEffectsToEntity(Entity entity, params Effect[] effects)
        {
            List<string> args = new List<string>();
            var h = effects.Select((f) =>
            {
                if (f.ClearEffects)
                {
                    args.Add(entity.Name);
                    args.Add("clear");
                }
                else
                {
                    args.Add(entity.Name);

                    if (MCVersion >= new MCVersion("1.13")) args.Add("give");

                    args.Add(VersionManeger.GetIDFromIDoubleIndicatedElement(f.EffectType));
                    args.Add(f.Time.ToString());
                    args.Add(f.Power.ToString());
                    args.Add(f.HideParticiples.ToString().ToLower());
                }

                var t = Execute
                    (new Command("effect", args.ToArray()));
                args.Clear();
                return t;

            }).ToArray();

            return h;
        }

        public Gamemode GetGamemodeFromPlayer(Player player)
        {
            var tmp = int.Parse(pluginSubManeger.Get("player-gm " + player.Name));

			var r = Enum.GetValues(typeof(Gamemode)).OfType<Gamemode>().Select((s) => (int)s)
				.Where((s) => s != int.MinValue).ToArray();

            if (r.Contains(tmp)) return (Gamemode)tmp;
            else return Gamemode.Other;
        }

        public void SetGamerule<T>(Gamerule<T> rule, T value, out string result)
        {
            result = Execute(new Command("gamerule", rule.Name, value.ToString().ToLower()));
        }

        public T GetGamerule<T>(Gamerule<T> rule)
        {
            var t = Execute(new Command("gamerule", rule.Name));
            return rule.ParseFunction(t.Remove(0, $"{rule.Name} = ".Length));
        }

        public EffectType GetEffectTypeByName(string name)
        {
            return AvailableEffects.Where((s) => s.Name == name).Single();
        }

        public void GiveXp(Player player, int amount, out string result, bool leveled = false)
        {
            result = Execute(new Command("xp", amount + (leveled ? "L" : ""), player.Name));    
        }

        public (float x, float z) Locate(Locate locate)
        {
            return VersionManeger.ParseLocateCommandOutput(DoSimpleActionWithTarget("locate", locate.Id.ToString()));
        }

        public void ToggleBanStatusForPlayer(Player target, bool value, out string result)
		{
            string tmp = "ban";
            if (value == false) tmp = "pardon"; 
			
            result = DoSimpleActionWithTarget(tmp, target.Name);
		}

        public void ToggleBanStatusForPlayer(Player target, out string result)
		{
            ToggleBanStatusForPlayer(target, !target.Tags.Contains(Player.PlayerTag.Banned), out result);
		}

        public void KickPlayer(Player target, out string result)
		{
            result = DoSimpleActionWithTarget("kick", target.Name);
		}

        public void ToggleOperatorStatusForPlayer(Player target, bool value, out string result)
        {
            string tmp = "op";
            if (value == false) tmp = "deop";

            result = DoSimpleActionWithTarget(tmp, target.Name);
        }
        
        public void ToggleOperatorStatusForPlayer(Player target, out string result)
        {
            ToggleOperatorStatusForPlayer(target, !target.Tags.Contains(Player.PlayerTag.Operator), out result);
        }

        public void TeleportPlayer(Player target, (float x, float y, float z) position, out string result)
		{
            result = Execute(new Command("tp", target.Name, position.x, position.y, position.z));
		}

        public void TeleportPlayer(Player target, Player position, out string result)
		{
            result = Execute(new Command("tp", target.Name, position.Name));
		}

        public void ChangePlayerGamemode(Player target, Gamemode gamemode, out string result)
        {
            if (gamemode == Gamemode.Other) throw new ArgumentException("It mustn't be Gamemode.Other", nameof(gamemode));

            result = Execute(new Command("gamemode", target.Name, VersionManeger.TranslateGamemodeObjectToChangeGamemodeCommandInput(gamemode)));
        }

        public void KillPlayer(Player target, out string result)
		{
            result = DoSimpleActionWithTarget("kill", target.Name);
		}


        private string DoSimpleActionWithTarget(string command, string target)
		{
            return Execute(new Command(command, target));
		}

        private class ControlPluginSubManeger
        {
            public ControlPluginSubManeger(ServerManeger maneger)
            {
                Maneger = maneger;
            }

            public ServerManeger Maneger { get; set; }

            public string Execute(string args, bool primary = false)
            {
                if (!primary)
                {
                    InvokeLLLManeger("execute " + args);

                    return Maneger.ConsoleManeger.ReadConsoleSegment("__SqiMSMrr_E_S_d1a6e6d543f8bdc92ed38af4ca0b5b30",
                        "__SqiMSMrr_E_E_d1a6e6d543f8bdc92ed38af4ca0b5b30");
                }
                else
                {
                    Maneger.Writer.WriteLine(args);
                    return null;
                }
            }

            public string Get(string args)
			{
                InvokeLLLManeger("get " + args);

                return Maneger.ConsoleManeger.ReadConsoleSegment("__SqiMSMrr_G_S_d1a6e6d543f8bdc92ed38af4ca0b5b30",
                    "__SqiMSMrr_G_E_d1a6e6d543f8bdc92ed38af4ca0b5b30").Substring("[11:24:25 INFO]: ".Length);
            }

            public string[] List(string args)
            {
                InvokeLLLManeger("list " + args);

                var t = Maneger.ConsoleManeger.ReadConsoleSegment("__SqiMSMrr_L_S_d1a6e6d543f8bdc92ed38af4ca0b5b30",
                    "__SqiMSMrr_L_E_d1a6e6d543f8bdc92ed38af4ca0b5b30");
                var g = t.Replace("\r\n", "\u1234").Split('\u1234');

                if (g[0] == "" && g.Length == 1) return new string[0];

                g = g.Select((s) => s.Substring("[11:24:25 INFO]: ".Length)).ToArray();

                return g;
            }

            private void InvokeLLLManeger(string args)
            {
                Maneger.Writer.WriteLine("_lll_manager_ctrl " + args);
            }
        }
    }
}