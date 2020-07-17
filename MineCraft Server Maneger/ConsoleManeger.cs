using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger
{
	class ConsoleManeger
	{
		private readonly StreamReader reader;
        private readonly ConsoleRegister rigister = new ConsoleRegister();

        public StreamWriter ConsoleWriter { get; }
        public bool WriteSystemMessageToOutput { get; set; } = false;

		public ConsoleManeger(StreamReader reader, StreamWriter writer)
		{
			this.reader = reader;
            ConsoleWriter = writer;
        }

        public char ReadNextSymbol()
		{
            char simbol = (char)reader.Read();

            rigister.WriteAndSplit(simbol.ToString());
            return simbol;
		}

        //КОСТЫЛЬ ТАКОЙ ЩО П*П*Ц
        //НО Переписывать мне лень:)
        public string ReadConsoleSegment(string start, string end)
        {
            StringBuilder builder = new StringBuilder();
            StringBuilder alphaBuilder = new StringBuilder();
            char g;
            int startCount = 0;

            do
            {
                g = (char)reader.Read();
                alphaBuilder.Append(g);

                if (alphaBuilder.ToString().EndsWith(start)) startCount++;
            }
            while (startCount < 1);

            do
            {
                g = (char)reader.Read();

                if (startCount > 0)
                    builder.Append(g);

                if (builder.ToString().EndsWith(start)) startCount++;
                else if (builder.ToString().EndsWith(end)) startCount--;
            }
            while (startCount != 0);

            var s = builder.ToString();

            if (s.Length - s.Reverse().ToList().IndexOf('\n') - 4 < 2) return /*"[11:24:25 INFO]:"*/ "";

            s = s.Substring(2, s.Length - s.Reverse().ToList().IndexOf('\n') - 4);

            var t = alphaBuilder.ToString();
            t = t.Substring(0, t.Length - (start.Length + "\r\n[11:24:25 INFO]: ".Length));

            if (t != "") t = t.Substring(2) + "\r\n";

            rigister.WriteAndSplit(t);

            if(WriteSystemMessageToOutput == true)
                rigister.WriteAndSplit(s);

            return s;
        }

        public string GetConsole()
		{

            return string.Join(Static.LinesSeparator, rigister.Lines);
        }

		public class ConsoleRegister
		{
            private readonly List<string> lines = new List<string>();
            public const int MaxLength = 1_000_000;


            public IReadOnlyList<string> Lines => lines;


            public void WriteLine(string a)
			{
                CheckLengthAndClear();
                lines.Add(a);
			}

            public void WriteAndSplit(string a)
			{
                var split = a.Replace(Static.LinesSeparator, "\u1234").Split('\u1234');

                if (!a.StartsWith(Static.LinesSeparator))
                {
                    Write(split[0]);
                    split = split.Where((s, i) => i > 0).ToArray();
                }

                foreach (var item in split)
                    WriteLine(item);
            }

			public void Write(string a)
			{
                if (lines.Count == 0) WriteLine(a);

                lines[lines.Count - 1] += a;
			}

            private void CheckLengthAndClear()
            {
                while (lines.Count > MaxLength)
                {
                    lines.RemoveAt(0/*First*/);
                }
            }
        }
    }
}
