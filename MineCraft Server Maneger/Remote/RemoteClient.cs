using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Remote
{
	class RemoteClient
	{
		private TcpClient client;
		private NetworkStream stream;
		private StreamWriter writer;
		private StreamReader reader;
		private TaskAwaiter<string> lastRequestAwaiter;
		private bool isLastRequestAwaiterInited = false;

		public RemoteClient(IPAddress host, string password)
		{
			client = new TcpClient(host.ToString(), 44102);

			stream = client.GetStream();
			writer = new StreamWriter(stream)
			{
				AutoFlush = true
			};

			reader = new StreamReader(stream);

			writer.WriteLine(password);

			while (stream.DataAvailable == false) Thread.Sleep(1);

			var responce = Responce.Parse(ReadResponceText());
			if (responce.Code != ResponceCode.OK)
				throw new ServerException($"Server error: code = {responce.Code}");
		}

		public TaskAwaiter<T> InvokeMethod<T>(string name, object[] args)
		{
			var toSend = args.Select((s) => JsonConvert.SerializeObject(new RemoteMethodArgumentContainer(s).ToJSONModel())).Append(name).ToArray();

			var awaiter = SendRequest(Request.Create(ClientOperation.Invoke, toSend));

			return Task.Run(() => JsonConvert.DeserializeObject<T>(awaiter.GetResult())).GetAwaiter();
		}
		
		public TaskAwaiter InvokeMethod(string name, object[] args)
		{
			var toSend = args.Select((s) => JsonConvert.SerializeObject(new RemoteMethodArgumentContainer(s).ToJSONModel())).Append(name).ToArray();

			var awaiter = SendRequest(Request.Create(ClientOperation.Invoke, toSend));

			return Task.Run(() => { awaiter.GetResult(); }).GetAwaiter();
		}

		public TaskAwaiter<T> GetProperty<T>(string name)
		{
			var awaiter = SendRequest(Request.Create(ClientOperation.GetProperty, new string[] { name }));

			return Task.Run(() => JsonConvert.DeserializeObject<T>(awaiter.GetResult())).GetAwaiter();
		}

		public TaskAwaiter<string> SendRequest(Request request)
		{
			if(isLastRequestAwaiterInited == true)
				lastRequestAwaiter.GetResult();

			writer.WriteLine(request.ToString());
			writer.Flush();

			Task<string> task = Task.Run(() =>
			{
				while (stream.DataAvailable == false) Thread.Sleep(1);

				var responce = Responce.Parse(ReadResponceText());
				if (responce.Code != ResponceCode.OK)
					throw new ServerException($"Server error: code = {responce.Code}");
				else
				{
					return responce.Data;
				}
			});

			isLastRequestAwaiterInited = true;
			return lastRequestAwaiter = task.GetAwaiter();
		}

		private string ReadResponceText()
		{
			if (stream.DataAvailable == false) throw new InvalidOperationException("Client request not available");

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
