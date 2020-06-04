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
        private StreamReader Reader { get => serverProcess.StandardOutput; }
        private StreamWriter Writer { get => serverProcess.StandardInput; }
        public MCVersion MCVersion { get; }
        public Player[] OnlinePlayers { get => GetPlayersBySelector("@a"); }

        public VersionManeger VersionManeger { get; }

        #region VersionManegerProperties
        public Gamerule[] AvailableGamerules { get => VersionManeger.AvailableGamerules; }
        public EffectType[] AvailableEffects { get => VersionManeger.AvailableEffects; }

        #endregion

        private Player[] Players 
        { 
            get 
            {
                var p = pluginSubManeger.List("players");
                var list = new List<Player>();


                foreach (var i in p)
                {
                    char[] a = new char[i.Length - 1];
                    Array.Copy(i.ToArray(), 1, a, 0, a.Length);
                    string f = new string(a);

                    var player = new Player(f);

                    int d = int.Parse(new string(i[0], 1));

                    if ((d & 1) != 0) player.Tags.Add(Player.PlayerTag.Banned);
                    if ((d & 2) != 0) player.Tags.Add(Player.PlayerTag.Whitelisted);
                    if ((d & 4) != 0) player.Tags.Add(Player.PlayerTag.Operator);
                    if ((d & 8) != 0) player.Tags.Add(Player.PlayerTag.Online);

                    list.Add(player);
                }

                return list.ToArray();
            } 
        }

        private readonly ControlPluginSubManeger pluginSubManeger;

        public ServerManeger(Process serverProcess, MCVersion version)
        {
            pluginSubManeger = new ControlPluginSubManeger(this);
            this.serverProcess = serverProcess;
            MCVersion = version;
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

        public void Start()
        {
            serverProcess.Start();
        }

        public void Stop()
        {
            ExecutePrimary(new Command("stop"));
            serverProcess.WaitForExit();
        }

        public void ClearPlayerInventory(Player player, out string er)
        {
            er = Execute(new Command("clear", player.Name));
        }

        public void ChangeWeather(WeatherStade weather, out string er)
        {
            er = Execute(new Command("weather", weather.ToString().ToLower()));
        }

        public string Execute(Command command)
        {
            var t = pluginSubManeger.Execute(command.Name + " " + string.Join(" ", command.Arguments));
            t = t.Substring("[12:01:19 INFO]: ".Length);
            return t;
        }

        public void ExecutePrimary(Command command)
        {
            pluginSubManeger.Execute(command.Name + " " + string.Join(" ", command.Arguments), false);
        }

        public Player[] GetPlayersBySelector(string selector)
        {
            switch (selector)
            {
                case "@a":
                    return Players.Where((s) => s.Tags.Contains(Player.PlayerTag.Online)).ToArray();
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
            return Players.Where((f) => (!reqOnline || f.Tags.Contains(Player.PlayerTag.Online))
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
            return VersionManeger.ParseLocateCommandOutput(Execute(new Command("locate", locate.Id)));
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

                    return ReadConsoleSegment("__SqiMSMrr_E_S_d1a6e6d543f8bdc92ed38af4ca0b5b30",
                        "__SqiMSMrr_E_E_d1a6e6d543f8bdc92ed38af4ca0b5b30");
                }
                else
                {
                    Maneger.Writer.WriteLine(args);
                    return null;
                }
            }

            public string[] List(string args)
            {
                InvokeLLLManeger("list " + args);

                var t = ReadConsoleSegment("__SqiMSMrr_L_S_d1a6e6d543f8bdc92ed38af4ca0b5b30",
                    "__SqiMSMrr_L_E_d1a6e6d543f8bdc92ed38af4ca0b5b30");
                var g = t.Replace("\r\n", "\u1234").Split('\u1234');
                //var h = new string[g.Length - 1];
                //Array.Copy(g, h, h.Length);

                g = g.Select((s) => s.Substring("[11:24:25 INFO]: ".Length)).ToArray();

                return g;
            }

            private void InvokeLLLManeger(string args)
            {
                Maneger.Writer.WriteLine("_lll_manager_ctrl " + args);
            }

            public string ReadConsoleSegment(string start, string end)
            {
                StringBuilder builder = new StringBuilder();
                StringBuilder alphaBuilder = new StringBuilder();
                char g;
                int startCount = 0;

                do
                {
                    g = (char)Maneger.Reader.Read();
                    alphaBuilder.Append(g);

                    if (alphaBuilder.ToString().EndsWith(start)) startCount++;
                }
                while (startCount < 1);

                do
                {
                    g = (char)Maneger.Reader.Read();

                    if (startCount > 0)
                        builder.Append(g);

                    if (builder.ToString().EndsWith(start)) startCount++;
                    else if (builder.ToString().EndsWith(end)) startCount--;
                }
                while (startCount != 0);

                var s = builder.ToString();
                s = s.Substring(2, s.Length - s.Reverse().ToList().IndexOf('\n') - 4);


                return s;
            }
        }
    }
}