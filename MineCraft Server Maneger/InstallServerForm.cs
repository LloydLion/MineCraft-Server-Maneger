using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MineCraft_Server_Maneger.Models;
using MineCraft_Server_Maneger.Models.Generic;
using Newtonsoft.Json;

namespace MineCraft_Server_Maneger
{
    partial class InstallServerForm : Form
    {
        private readonly ServerDownloadInfo[] info;
        private readonly string path;

        public InstallServerForm(string path, ServerDownloadInfo[] info)
        {
            InitializeComponent();
            this.info = info = info.Reverse().ToArray();
            this.path = path;
            
            versionSelectionListView.Items.Clear();
            serverNameATextBox.Enabled = false;

            Font font = new Font("Meiryo UI", 11f, FontStyle.Bold);

            ListViewItem[] items = info.Select((s) => new ListViewItem(s.Name) { Font = font }).ToArray();
            versionSelectionListView.Items.AddRange(items);
        }

        private void VersionSelectionListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (versionSelectionListView.SelectedItems.Count == 0)
            {
                gameVersionLabel.Text = coreTypeLabel.Text = "No server selected";
                serverNameATextBox.Enabled = false;
                serverNameATextBox.Text = "";
            }
            else
            {
                var element = info.Where((d) => d.Name == versionSelectionListView.SelectedItems[0].Text).ToArray()[0];

                gameVersionLabel.Text = element.GameVersion.ToString();
                coreTypeLabel.Text = element.CoreType.ToString();
                serverNameATextBox.Enabled = true;
                serverNameATextBox.Text = element.Name;
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            if (versionSelectionListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Server selected\nSelect a Server in list and Try again");
                return;
            }

            if(string.IsNullOrWhiteSpace(serverNameATextBox.Text))
            {
                MessageBox.Show("Invalid Server name");
            }

            var el = info.Where((d) => d.Name == versionSelectionListView.SelectedItems[0].Text).ToArray()[0];
            var newName = serverNameATextBox.Text;

            var f = el.Clone();
            f.Format(null, null, newName);
            f.Name = newName;

            var g = f.Clone();
            g.Format(path);

            WebClient client = new WebClient();
            client.DownloadProgressChanged += (d, a) =>
            {
                downloadProgressBar.Value = a.ProgressPercentage * 20;
            };

            client.DownloadFileCompleted += (d, a) =>
            {
                MessageBox.Show("Download complited");
                downloadProgressBar.Value = 0;
                serverNameATextBox.Enabled = true;
                versionSelectionListView.Enabled = true;
                downloadButton.Enabled = true;
            };

            serverNameATextBox.Enabled = false;
            versionSelectionListView.Enabled = false;
            downloadButton.Enabled = false;
            client.DownloadFileAsync(new Uri(el.Link), g.Path);

            var metaStream = File.Open($"{path}\\{g.GameVersion}   {g.Name}.meta", FileMode.Create);

            var metaWriter = new StreamWriter(metaStream) { AutoFlush = true };
            metaWriter.WriteLine(JsonConvert.SerializeObject(f));
            metaStream.Close();
        }

        private void CreateServerButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(serverGameVersionMTextBox.Text) ||
               string.IsNullOrWhiteSpace(serverNameMTextBox.Text) ||
               string.IsNullOrWhiteSpace(serverCoreTypeMTextBox.Text) ||
               string.IsNullOrWhiteSpace(serverFilePath))
            {
                MessageBox.Show("Invalid server information\nFill all fields and select a server file then try again");
            }
            else
            {
                var serverName = serverNameMTextBox.Text;
                var serverCoreType = serverCoreTypeMTextBox.Text;
                var serverGameVersion = serverGameVersionMTextBox.Text;

                var f = new ServerInfo()
                {
                    CoreType = new ServerCoreType(true, true, serverCoreType, "server.properties", "op.json", "ban.json", "plugin"),
                    GameVersion = new MCVersion(serverGameVersion), 
                    Name = serverName, 
                    Path = "{0}\\" + $"{serverGameVersion}   {serverName}.jar"
                };

                File.Copy(serverFilePath, string.Format(f.Path, path));

                var metaStream = File.Open($"{path}\\{f.GameVersion}   {f.Name}.meta", FileMode.Create);

                var metaWriter = new StreamWriter(metaStream) { AutoFlush = true };
                metaWriter.WriteLine(JsonConvert.SerializeObject(f));

                metaStream.Close();

                serverCoreTypeMTextBox.Text = serverNameMTextBox.Text  = serverGameVersionMTextBox.Text = "";
                serverFilePath = null;

                selectServerFileButton.Enabled = true;
                selectServerFileButton.Text = "Select server file";

                MessageBox.Show("Server installed");
            }
        }

        string serverFilePath = null;
        private void SelectServerFileButton_Click(object sender, EventArgs e)
        {
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                selectServerFileButton.Enabled = false;
                selectServerFileButton.Text = "Selected";
                serverFilePath = fileDialog.FileName;
            }
            else
            {

            }
        }
    }
}
