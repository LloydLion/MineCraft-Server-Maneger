using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Remote
{
	class Responce
	{
		public ResponceCode Code { get; private set; }
		public string Data { get; private set; }

		private Responce()
		{

		}


		public static Responce Parse(string a)
		{
			var output = new Responce();

			var split = a.Split('\u1234');

			output.Code = (ResponceCode)int.Parse(split[0]);
			output.Data = split[1];

			return output;
		}

		public static Responce Create(ResponceCode code, string data)
		{
			return new Responce() { Code = code, Data = data };
		}

		public override string ToString()
		{
			return ((int)Code).ToString() + '\u1234' + Data + "\u1212";
		}
	}
}
