using MineCraft_Server_Maneger.Models.Generic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using StandardLibrary.Interfaces;
using MineCraft_Server_Maneger.Interfaces;

namespace MineCraft_Server_Maneger
{
	class VersionManeger
	{

		public static string Path { get; } = Static.Path.binaries + "\\version";
		public static (string gamerule, string effect, string locate) FilesNames { get; } =
			("gamerule.json", "effect.json", "locate.json");

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

		public Locate[] AvailableLocates
		{
			get
			{
				if (availableLocatesCache == null)
				{
					var g = LocatesDictionary.Where((s) => s.Key <= Version).OrderByDescending((q) => q.Key).ToArray();
					availableLocatesCache = g[0].Value;
				}

				return availableLocatesCache;
			}
		}

		private EffectType[] availableEffectCache;
		private Gamerule[] availableGamerulesCache;
		private Locate[] availableLocatesCache;

		private static readonly Dictionary<MCVersion, Gamerule[]> GamerulesDictionary;
		private static readonly Dictionary<MCVersion, EffectType[]> EffectsDictionary;
		private static readonly Dictionary<MCVersion, Locate[]> LocatesDictionary;

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

				file.Close();
			}
			#endregion

			#region effects
			{
				file = File.Open(Path + "\\" + FilesNames.effect, FileMode.Open, FileAccess.Read);
				reader = new StreamReader(file);
				content = reader.ReadToEnd();

				var r = JsonConvert.DeserializeObject<Dictionary<string, JSONGlobalDictionaryValue<EffectType>>>(content);
				EffectsDictionary = JSONParse(r);
				file.Close();
			}
			#endregion

			#region locations
			{
				file = File.Open(Path + "\\" + FilesNames.locate, FileMode.Open, FileAccess.Read);
				reader = new StreamReader(file);
				content = reader.ReadToEnd();

				var r = JsonConvert.DeserializeObject<Dictionary<string, JSONGlobalDictionaryValue<Locate>>>(content);
				LocatesDictionary = JSONParse(r);
				file.Close();
			}
			#endregion
		}

		private static class SubStore
		{
			public class Gamerule : IPrivateNamedObject, ICloneable
			{
				public string Name { get; set; }
				public string Type { get; set; }

				public object Clone()
				{
					return new Gamerule() { Name = Name, Type = Type };
				}
			}
		}

		private class JSONGlobalDictionaryValue<T> where T : IPrivateNamedObject
		{
			public T[] Add { get; set; }
			public string[] Remove { get; set; }
			public SmartEditJSONObject[] SmartEdit { get; set; }
		}

		private class SmartEditJSONObject
		{
			public string Selector { get; set; }
			public FieldFilter FieldsFilter { get; set; }
			public Function TransformFunction { get; set; }

			public class FieldFilter
			{
				public string Name { get; set; }
				public string[] Arguments { get; set; }
			}

			public class Function
			{
				public string Name { get; set; }
				public string Type { get; set; }
				public Argument[] Arguments { get; set; }

				public class Argument
				{
					public string Type { get; set; }
					public string Value { get; set; }
				}
			}
		}

		private static Dictionary<MCVersion, T[]> JSONParse<T>(Dictionary<string, JSONGlobalDictionaryValue<T>> r)
			where T : IPrivateNamedObject, ICloneable
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

					if(selected[j].Value.SmartEdit != null)
					{
						var inst = selected[j].Value.SmartEdit;

						for (int d = 0; d < inst.Length; d++)
						{
							Type ti = typeof(T);
							T[] vals = null;
							int[] selIndexes;

							switch (inst[d].Selector)
							{
								case "All":
								{
									vals = t.ToArray();
									selIndexes = new int[vals.Length];
									selIndexes = selIndexes.Select((s, l) => l).ToArray();

									break;
								}

								default:
								{
									throw new Exception("Error on JSON structure");
								}
							}

							vals = vals.Select((s) => (T)s.Clone()).ToArray();
							
							SmartEditJSONObject.FieldFilter filter = inst[d].FieldsFilter;
							PropertyInfo[] pis = null;

							switch(filter.Name)
							{
								case "Type":
								{
									pis = ti.GetProperties().
										Where((s) => filter.Arguments.Contains(s.PropertyType.FullName)).ToArray();
									break;
								}

								case "Name":
								{
									pis = ti.GetProperties().
										Where((s) => filter.Arguments.Contains(s.Name)).ToArray();
									break;
								}

								default:
								{
									throw new Exception("Error on JSON structure");
								}
							}

							SmartEditJSONObject.Function transform = inst[d].TransformFunction;
							(object obj, Type ti)[] args = new (object obj, Type ti)[transform.Arguments.Length];


							for (int f = 0; f < transform.Arguments.Length; f++)
							{
								var arg = transform.Arguments[f];
								Type tii = Type.GetType(arg.Type);
								Func<string, object> parseFunc = null;
								
								if (tii == null)
								{
									ti = typeof(string);
									parseFunc = (s) => s;
								}
								else
								{
									var mi = tii.GetMethod("Parse",
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

								args[f] = (parseFunc(arg.Value), tii);
							}


							MethodInfo[] miis = new MethodInfo[pis.Length];

							switch (transform.Type)
							{
								case "Instance":
								{
									for (int a = 0; a < pis.Length; a++)
									{
										miis[a] = pis[a].PropertyType.GetMethod(transform.Name,
											args.Select((s) => s.ti).ToArray());

										if (miis[a] == null) throw new Exception("Error on JSON structure");
										else
										{
											if(!(miis[a].Attributes.HasFlag(MethodAttributes.Public)
												|| !miis[a].Attributes.HasFlag(MethodAttributes.Static)))
												throw new Exception("Error on JSON structure");
										}
									}

									
									break;
								}

								default:
								{
									throw new Exception("Error on JSON structure");
								}	
							}

							for (int a = 0; a < pis.Length; a++)
							{
								for (int s = 0; s < vals.Length; s++)
								{
									pis[a].SetValue(vals[s], miis[a].Invoke(pis[a].GetValue(vals[s]),
										args.Select((q) => q.obj).ToArray()));
								}
							}

							for (int l = 0; l < selIndexes.Length; l++)
							{
								t[l] = vals[l];
							}
						}
					}
				}

				result.Add(g[i].Key, t.ToArray());
			}

			return result;
		}

		public (float x, float z) ParseLocateCommandOutput(string v)
		{
			Regex ex = new Regex("\\d+");
			var er = ex.Matches(v);
			return (float.Parse(er[0].Value), float.Parse(er[1].Value));
		}

		public string GetIDFromIDoubleIndicatedElement(IMCDoubleIndicatedObject el)
		{
			if (el is EffectType)
			{
				return Version >= new MCVersion("1.8") ? el.MCStringId : el.MCId.ToString();
			}
			else
				throw new ArgumentException("el isn't has valid type!", nameof(el));
		}
	}
}
