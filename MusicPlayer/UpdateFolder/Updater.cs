using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Guna.UI2.WinForms;

namespace MusicPlayer.UpdateFolder
{
    internal class Updater
    {
        private string currentVersion = Application.ProductVersion; // replace with current version
        private string updateUrl = "https://example.com/update.xml"; // replace with update URL

        public void CheckForUpdates()
        {
            try
            {
                using (WebClient client = new WebClient())
                {

                    string updateXml = client.DownloadString(updateUrl);
                    XDocument updateDoc = XDocument.Parse(updateXml);

                    // Check if there is a newer version available
                    string latestVersion = updateDoc.Root.Element("Version").Value;
                    if (IsVersionNewer(latestVersion, currentVersion))
                    {
                        string downloadUrl = updateDoc.Root.Element("DownloadUrl").Value;
                        string releaseNotes = updateDoc.Root.Element("ReleaseNotes").Value;
                        var messageDialog = new Guna2MessageDialog()
                        {
                            Icon = MessageDialogIcon.Question,
                            Text = "A new version (" + latestVersion + ") is available. Do you want to download and install it?",
                            Style = MessageDialogStyle.Light,
                            Caption = "Update Available",
                            Buttons = MessageDialogButtons.YesNo

                        }.Show();

                        if (messageDialog == DialogResult.Yes)
                        {
                            DownloadUpdate(downloadUrl, releaseNotes);
                        }
                    }
                    else
                    {
                        var messageDialog = new Guna2MessageDialog()
                        {
                            Icon = MessageDialogIcon.Information,
                            Text = "You are already using the latest version.",
                            Style = MessageDialogStyle.Light,
                            Caption = "Update Checker",
                            Buttons = MessageDialogButtons.OK

                        }.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                var messageDialog = new Guna2MessageDialog()
                {
                    Icon = MessageDialogIcon.Error,
                    Text = "An error occurred while checking for updates: " + ex.Message,
                    Style = MessageDialogStyle.Light,
                    Caption = "Update Checker",
                    Buttons = MessageDialogButtons.OK

                }.Show();
            }
        }

        public void DownloadUpdate(string downloadUrl, string releaseNotes)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    // Download the update file to a temporary location
                    string tempFile = Path.GetTempFileName();
                    client.DownloadFile(downloadUrl, tempFile);

                    // Show release notes
                    DialogResult result = MessageBox.Show(releaseNotes, "Release Notes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        // Launch the update file and exit the application
                        Process.Start(tempFile);
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while downloading the update: " + ex.Message, "Update Checker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsVersionNewer(string version1, string version2)
        {
            Version v1 = new Version(version1);
            Version v2 = new Version(version2);
            return v1.CompareTo(v2) > 0;
        }

    }
}
