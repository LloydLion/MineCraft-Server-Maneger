using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Remote
{
	class Request
	{
		public ClientOperation Operation { get; private set; }
		public string[] Args { get; private set; }

		private Request()
		{

		}


		public static Request Parse(string a)
		{
			var output = new Request();

			var split1 = a.Split('\u1234');
			output.Operation = (ClientOperation)Enum.Parse(typeof(ClientOperation), split1[0]);

			var split2 = split1[1].Split('\u4321');
			output.Args = split2;

			return output;
		}

		public static Request Create(ClientOperation operation, string[] args)
		{
			return new Request() { Operation = operation, Args = args };
		}

		public override string ToString()
		{
			return Operation.ToString() + '\u1234' + string.Join("\u4321", Args) + "\u1212";
		}
	}
}
