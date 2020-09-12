using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft_Server_Maneger.Remote
{
	partial class RemoteConnectionForm : Form
	{
		private RemoteConnectionServiceHost host;

		public RemoteConnectionForm()
		{
			InitializeComponent();
		}

		private void ServerOpenButton_Click(object sender, EventArgs e)
		{
			if (host == null)
			{
				serverOpenButton.Text = "Close Host";
				host = new RemoteConnectionServiceHost(serverPasswordTextbox.Text);
				host.Open();
			}
			else
			{
				serverOpenButton.Text = "Open Host";
				host.Close();
				host = null;
			}
		}

		private void ServerUpdateTimer_Tick(object sender, EventArgs e)
		{
			if(host != null) host.Update();
		}

		private void ClientConnectButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			if(host != null) host.Close();

			var hci = new HostClientInterface(IPAddress.Parse(clientHostIpTextBox.Text), clientPasswordTextBox.Text);
			var processMgr = new RemoteProcessSubManeger(hci);
			new MainForm(hci.ServerInfo, processMgr).ShowDialog();

			this.Close();
		}
	}
}
