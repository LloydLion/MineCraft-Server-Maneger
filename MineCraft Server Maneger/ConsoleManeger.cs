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
        private readonly ServerIOInterface ioInterface;
        private readonly ConsoleRegister rigister = new ConsoleRegister();


        public bool WriteSystemMessageToOutput { get; set; } = false;

		public ConsoleManeger(ServerIOInterface ioInterface)
		{
            this.ioInterface = ioInterface;
        }

        public char ReadNextSymbol()
		{
            char simbol = ioInterface.ReadSimbol();

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
                g = ioInterface.ReadSimbol();
                alphaBuilder.Append(g);

                if (alphaBuilder.ToString().EndsWith(start)) startCount++;
            }
            while (startCount < 1);

            do
            {
                g = ioInterface.ReadSimbol();

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

		public string GetLine(long lineId)
		{
            return rigister.Lines.Single((s) => s.strId == lineId).value;
		}

        public bool IsIdOfLastString(long strId)
		{
            return rigister.Lines[rigister.Lines.Count - 1].strId == strId;
        }

		public string GetConsole()
		{
            return string.Join(Static.LinesSeparator, rigister.Lines);
        }

		public class ConsoleRegister
		{
            private readonly List<(string value, long strId)> lines = new List<(string, long)>();
            private long nextLineId = 0;

            public const int MaxLength = 1_000_000;


            public IReadOnlyList<(string value, long strId)> Lines => lines;


            public void WriteLine(string a)
			{
                CheckLengthAndClear();
                lines.Add((a, ++nextLineId));
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

                lines[lines.Count - 1] = (lines[lines.Count - 1].value + a, lines[lines.Count - 1].strId);
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
