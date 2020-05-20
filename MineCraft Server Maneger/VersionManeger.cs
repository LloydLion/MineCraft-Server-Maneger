using MineCraft_Server_Maneger.Models.Generic;
using MineCraft_Server_Maneger.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger
{
	class VersionManeger
	{

		public static string Path { get; } = Static.Path.binaries + "\\version";
		public static (string gamerule, string effect) FilesNames { get; } = ("gamerule.json", "effect.json");

		public MCVersion Version { get; private set; }

		public Gamerule[] AvailableGamerules
		{
			get
			{
				if (availableGamerulesCache == null)
				{
					var g = GamerulesDictionary.Where((s) => s.Key <= Version).OrderByDescending((q) => q.Key).ToArray();
					availableGamerulesCache = g[0].Value;
				}

				return availableGamerulesCache;
			}
		}

		public EffectType[] AvailableEffects
		{
			get
			{
				if (availableEffectCache == null)
				{
					var g = EffectsDictionary.Where((s) => s.Key <= Version).OrderByDescending((q) => q.Key).ToArray();
					availableEffectCache = g[0].Value;
				}

				return availableEffectCache;
			}
		}



		private EffectType[] availableEffectCache;
		private Gamerule[] availableGamerulesCache;

		private static readonly Dictionary<MCVersion, Gamerule[]> GamerulesDictionary;
		private static readonly Dictionary<MCVersion, EffectType[]> EffectsDictionary;

		public VersionManeger(MCVersion currentVersion)
		{
			Version = currentVersion;
		}

		static VersionManeger()
		{
			FileStream file;
			StreamReader reader;
			string content;

			#region gamerules
			{
				GamerulesDictionary = new Dictionary<MCVersion, Gamerule[]>();

				file = File.Open(Path + "\\" + FilesNames.gamerule, FileMode.Open, FileAccess.Read);
				reader = new StreamReader(file);
				content = reader.ReadToEnd();

				var r = JsonConvert.DeserializeObject<Dictionary<string, JSONGlobalDictionaryValue<SubStore.Gamerule>>>(content);
				//var g = r.Select((s) => new KeyValuePair<MCVersion, JSONGlobalDictionaryValue>
				//	(new MCVersion(s.Key), s.Value)).ToArray();

				//for (int i = 0; i < g.Length; i++)
				//{
				//	KeyValuePair<MCVersion, JSONGlobalDictionaryValue<SubStore.Gamerule>>[] selected =
				//	g.Where((s) => s.Key <= g[i].Key).ToArray();

				//	List<SubStore.Gamerule> t = new List<SubStore.Gamerule>();
				//	for (int j = 0; j < selected.Length; j++)
				//	{
				//		if (selected[j].Value.Add != null)
				//			t.AddRange(selected[j].Value.Add);

				//		if (selected[j].Value.Remove != null)
				//			t.RemoveAll((s) => selected[j].Value.Remove.Contains(s.Name));
				//	}


				var a = JSONParse(r);
				var g = a.ToArray();
				for (int i = 0; i < g.Length; i++)
				{
					var t = g[i].Value;
					Gamerule[] gamerules = new Gamerule[t.Length];
					for (int j = 0; j < t.Length; j++)
					{
						Type ti;
						Func<string, object> parseFunc;
						if (t[j].Type == null)
						{
							ti = typeof(string);
							parseFunc = (s) => s;
						}
						else
						{
							ti = Type.GetType(t[j].Type);
							var mi = ti.GetMethod("Parse",
								new Type[] { typeof(string) });
							if (mi == null) throw new Exception("Error on JSON structure");
							else
							{
								if (!(mi.Attributes.HasFlag(MethodAttributes.Static) ||
									 mi.Attributes.HasFlag(MethodAttributes.Public)))
									throw new Exception("Error on JSON structure");
							}

							parseFunc = (s) => mi.Invoke(null, new object[] { s });
						}

						gamerules[j] = new Gamerule(ti, t[j].Name, parseFunc);
					}

					GamerulesDictionary.Add(g[i].Key, gamerules);
				}
			}
			#endregion

			#region effects
			{
				file = File.Open(Path + "\\" + FilesNames.effect, FileMode.Open, FileAccess.Read);
				reader = new StreamReader(file);
				content = reader.ReadToEnd();

				var r = JsonConvert.DeserializeObject<Dictionary<string, JSONGlobalDictionaryValue<EffectType>>>(content);
				EffectsDictionary = JSONParse(r);
			}
			#endregion
		}

		private static class SubStore
		{
			public class Gamerule : INamedObject
			{
				public string Name { get; set; }
				public string Type { get; set; }
			}

			//public class Effect : INamedObject
			//{
			//	public string Name { get; set; }
			//	public string Id { get; set; }
			//}
		}

		private class JSONGlobalDictionaryValue<T> where T : INamedObject
		{
			public T[] Add { get; set; }
			public string[] Remove { get; set; }
		}


		private static Dictionary<MCVersion, T[]> JSONParse<T>(Dictionary<string, JSONGlobalDictionaryValue<T>> r)
			where T : INamedObject
		{
			Dictionary<MCVersion, T[]> result = new Dictionary<MCVersion, T[]>();


			var g = r.Select((s) => new KeyValuePair<MCVersion, JSONGlobalDictionaryValue<T>>
						(new MCVersion(s.Key), s.Value)).ToArray();

			for (int i = 0; i < g.Length; i++)
			{
				KeyValuePair<MCVersion, JSONGlobalDictionaryValue<T>>[] selected =
					g.Where((s) => s.Key <= g[i].Key).ToArray();

				List<T> t = new List<T>();
				for (int j = 0; j < selected.Length; j++)
				{
					if (selected[j].Value.Add != null)
						t.AddRange(selected[j].Value.Add);

					if (selected[j].Value.Remove != null)
						t.RemoveAll((s) => selected[j].Value.Remove.Contains(s.Name));
				}

				result.Add(g[i].Key, t.ToArray());
			}

			return result;
		}

		public string GetIDFromIDoubleIndicatedElement(IDoubleIndicatedElement el)
		{
			if (el is EffectType || el is ItemInfo || el is BlockInfo)
			{
				return Version >= new MCVersion("1.8") ? el.Id : el.NumId.ToString();
			}
			else
				throw new ArgumentException("el isn't has valid type!", nameof(el));
		}
	}
}
