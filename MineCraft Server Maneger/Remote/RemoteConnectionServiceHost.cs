using StandardLibrary.Functions;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Remote
{
	class RemoteConnectionServiceHost
	{
		private string password;
		private TcpListener listener;
		private Task<TcpClient> acceptClientTask;
		private ClientHandler handler;

		public bool IsConnected { get; private set; } = false;

		public RemoteConnectionServiceHost(string password)
		{
			this.password = password;
		}


		public void Open()
		{
			listener = new TcpListener(new IPEndPoint(IPAddress.IPv6Loopback, 44102));

			listener.Start();

			acceptClientTask = listener.AcceptTcpClientAsync();
			acceptClientTask.GetAwaiter().OnCompleted(ConnectionHandler);
		}

		public void Update()
		{
			if(handler != null) handler.Update();
		}

		public void Close()
		{
			handler.Close();
			listener.Stop();
			IsConnected = false;
		}

		private void ConnectionHandler()
		{
			IsConnected = true;

			var client = acceptClientTask.Result;
			var stream = client.GetStream();

			var reader = new StreamReader(stream);
			var writer = new StreamWriter(stream)
			{
				AutoFlush = true
			};

			//Wait stream.DataAvailable == true
			while (stream.DataAvailable == false) _ = 0;
			
			var readed = reader.ReadLine();

			if(readed != password)
			{
				writer.WriteLine(Responce.Create(ResponceCode.InvalidPassword, " "));
				writer.Flush();

				client.Close();
				IsConnected = false;

				this.Close();
				this.Open();
			}
			else
			{
				writer.WriteLine(Responce.Create(ResponceCode.OK, " "));
				writer.Flush();

				handler = new ClientHandler(client);
			}
		}

		~RemoteConnectionServiceHost()
		{
			Close();
		}
	}
}
