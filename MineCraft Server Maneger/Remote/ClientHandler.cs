using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace MineCraft_Server_Maneger.Remote
{
	class ClientHandler
	{
		private static readonly MethodInfo[] availableOperations = typeof(RequestHandler).GetMethods().Where((s) => s.GetCustomAttribute(typeof(RemoteInteractAttribute)) != null).ToArray();

		private readonly NetworkStream clientStream;
		private readonly StreamWriter writer;
		private readonly StreamReader reader;
		private readonly RequestHandler requestHandler;
		private readonly HostClientInteractor interactor;
		private readonly TcpClient client;

		public ClientHandler(TcpClient client)
		{
			this.client = client;
			clientStream = client.GetStream();

			writer = new StreamWriter(clientStream)
			{
				AutoFlush = true
			};

			reader = new StreamReader(clientStream);

			interactor = new HostClientInteractor();
			requestHandler = new RequestHandler(interactor);
		}

		public bool CheckCommandStatus()
		{
			return clientStream.DataAvailable;
		}

		public void Close()
		{
			client.Close();
			interactor.Kill();
		}

		public Request ReadRequest()
		{
			if (CheckCommandStatus() == false) throw new InvalidOperationException("Client request not available");

			string input = ReadRequestText();
			return Request.Parse(input);
		}

		public void Update()
		{
			if(CheckCommandStatus() == true)
			{
				var req = ReadRequest();

				var operation = availableOperations.Single((s) => s.Name == req.Operation.ToString());
				var res = (Responce)operation.Invoke(requestHandler, new object[] { req.Args });
				writer.WriteLine(res.ToString());
			}
		}

		private string ReadRequestText()
		{
			if(CheckCommandStatus() == false) throw new InvalidOperationException("Client request not available");

			StringBuilder builder = new StringBuilder();

			while (true)
			{
				var g = (char)reader.Read();
				if (g == '\u1212') break; /*end check*/
				builder.Append(g);
			}

			return builder.ToString();
		}
	}
}
