using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MineCraft_Server_Maneger.Models;
using System.Diagnostics;
using MineCraft_Server_Maneger.Remote;

namespace MineCraft_Server_Maneger
{
    partial class VersionSelectionForm : Form
    {
        private readonly ServerInfo[] info;
        private readonly ServerDownloadInfo[] downloads;

        public VersionSelectionForm()
        {
            InitializeComponent();
            versionSelectionList.Items.Clear();

            string[] files = Directory.GetFiles(Static.Path.server, "*.meta");

            Stream[] streams = files.Select((f) => File.OpenRead(f)).ToArray();
            StreamReader[] readers = streams.Select((d) => new StreamReader(d)).ToArray();
            string[] content = readers.Select((a) => { var t = a.ReadToEnd(); a.Close(); return t; }).ToArray();
            ServerInfo[] info = content.Select((a) => JsonConvert.DeserializeObject<ServerInfo>(a)).ToArray();
            info = info.Select((g) => { g.Format(Static.Path.server); g.Init(); return g; }).ToArray();

            this.info = info;

            Font font = new Font("Meiryo UI", 11f, FontStyle.Bold);

            ListViewItem[] items = info.Select((s) => new ListViewItem(s.Name) { Font = font }).ToArray();
            versionSelectionList.Items.AddRange(items);


            var downloads = JsonConvert.DeserializeObject<Dictionary<string, ServerDownloadInfo>>
                (File.ReadAllText(Static.Path.binaries + "\\links.json"));
            this.downloads = downloads.Select((f) => { f.Value.Format(null, f.Key); return f.Value; }).ToArray();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if(versionSelectionList.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Server selected\nSelect a Server in list and Try again");
                return;
            }

            var t = versionSelectionList.SelectedItems[0];
            this.Hide();
            for (int i = 0; i < info.Length; i++)
            {
                if(info[i].Name == t.Text)
                {
                    new MainForm(info[i]).ShowDialog();
                    break;
                }
            }
            Close();
        }

        private void VersionSelectionList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (versionSelectionList.SelectedItems.Count == 0)
            {
                coreTypeLabel.Text = gameVersionLabel.Text = "No server selected";
            }
            else
            {
                var element = info.Where((d) => d.Name == versionSelectionList.SelectedItems[0].Text).ToArray()[0];

                gameVersionLabel.Text = element.GameVersion.ToString();
                coreTypeLabel.Text = element.CoreType.ToString();
            }
        }

        private void InstallServerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InstallServerForm(Static.Path.server, downloads).ShowDialog();
            Process.Start(Process.GetCurrentProcess().MainModule.FileName);
            this.Close();
        }

		private void RemoteButton_Click(object sender, EventArgs e)
		{
            this.Hide();
            new RemoteConnectionForm().ShowDialog();
            this.Close();
		}
	}
}
