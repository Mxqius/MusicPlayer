using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;
using System.Diagnostics;
using System.Net;
using AltoHttp;
using Guna.UI2.WinForms;

namespace MusicPlayer
{
    public partial class frm_dl : Form
    {
        private string DirectoryDownload = string.Empty;
        private AxWMPLib.AxWindowsMediaPlayer _player;
        private AltoHttp.HttpDownloader _downloader;
        public frm_dl(AxWMPLib.AxWindowsMediaPlayer player)
        {
            InitializeComponent();
            _player = player;
        }

        void DownloadSong(string url)
        {
            if (UrlChecker.UrlCheckerMethod(url))
            {
                string downloadUrl = "";
                if (DirectoryDownload == string.Empty)
                    MessageBox.Show("Please First Select a Folder for Save Downloads ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (Path.GetFileNameWithoutExtension(url).Length > 12)
                    {
                        var CorrectUrl = Path.GetFileNameWithoutExtension(url).Split('%');
                        foreach (var text in CorrectUrl)
                        {
                            downloadUrl += text;
                        }

                        if (downloadUrl.Length > 12)
                        {
                            downloadUrl = downloadUrl.Substring(0, 10) + ".mp3";

                        }
                    }
                    try
                    {
                        _downloader = new HttpDownloader(url, Path.Combine(DirectoryDownload, downloadUrl));
                        _downloader.ProgressChanged += _downloader_ProgressChanged;
                        _downloader.DownloadCompleted += _downloader_DownloadCompleted;
                        _downloader.Start();
                        lbl_status.Invoke(new MethodInvoker(delegate { lbl_status.Text = "Downloading..."; }));
                    }
                    catch (Exception)
                    {
                        _downloader.StopReset();
                        MessageBox.Show("There is a problem with the download link.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Error - url invalid, should be valid");
            }

        }

        private void _downloader_DownloadCompleted(object sender, EventArgs e)
        {
            lbl_status.Invoke(new MethodInvoker(delegate { lbl_status.Text = "Download complete"; }));
        }

        private void _downloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            try
            {
                pb_downloadStatus.Value = (int)e.Progress;
                lbl_speed.Invoke(new MethodInvoker(delegate
                {
                    lbl_speed.Text = String.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
                }));
                lbl_downloaded.Invoke(new MethodInvoker(delegate
                {
                    lbl_downloaded.Text = String.Format("{0} MB",
                        (_downloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
                }));
            }
            catch
            {
                return;
            }
            //lbl_speed.Text = String.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            //lbl_downloaded.Text = String.Format("{0} MB", (_downloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
        }

        private void btn_dl_Click(object sender, EventArgs e)
        {
            DownloadSong(txt_url.Text);
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (txt_url.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Field URL is Empty !");
            }
            else
            {
                lbl_status.Text = "Playing Online";
                _player.URL = txt_url.Text.Trim(); ;
                _player.Ctlcontrols.play();
                btn_playOnline.BorderColor = Color.Green;
            }

        }
        public async void asleep(int time)
        {
            await Task.Delay(time);
        }

        private void btn_clear_list_Click(object sender, EventArgs e)
        {
            lb_urls.Items.Clear();
        }

        private void btn_add_url_Click(object sender, EventArgs e)
        {
            if (txt_url.Text.Trim() != string.Empty)
            {
                if (!txt_url.Text.EndsWith(".mp3") && !UrlChecker.UrlCheckerMethod(txt_url.Text))
                {
                    MessageBox.Show("Cannot be download file except Mp3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!lb_urls.Items.ToString().Contains(txt_url.Text))
                        lb_urls.AddItem(txt_url.Text.Trim());
                    else
                        MessageBox.Show("This Url Already Added In List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            _player.Ctlcontrols.stop();
            _player.Ctlcontrols.currentPosition = 0;
            if (_downloader != null)
                _downloader.Pause();
            this.Close();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void pnl_header_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pnl_header_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnl_header_MouseMove(object sender, MouseEventArgs e)
        {

            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void Distacnt()
        {
            for (int i = 0; i < lb_urls.Count; i++)
            {
                for (int j = i + 1; j < lb_urls.Count; j++)
                {
                    if (lb_urls.Items[i].Text == lb_urls.Items[j].Text)
                        lb_urls.Items.RemoveAt(j);
                }
            }
        }
        private void lb_urls_DragDrop(object sender, DragEventArgs e)
        {
            string[] urls = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (urls.Length != 0)
            {
                for (int i = 0; i < urls.Length; i++)
                {
                    using (FileStream fs = new FileStream(urls[i], System.IO.FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            while (!sr.EndOfStream)
                            {
                                if (UrlChecker.UrlCheckerMethod(sr.ReadLine()))
                                    lb_urls.AddItem(sr.ReadLine());
                            }
                        }
                    }

                    Distacnt();
                }
            }
        }

        private void lb_urls_DragEnter(object sender, DragEventArgs e)
        {
            string[] Types = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var type in Types)
            {
                if (type.EndsWith(".txt"))
                {
                    e.Effect = DragDropEffects.All;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private async Task Sleep(int milisecound)
        {
            await Task.Run(() =>
          {
              Thread.Sleep(milisecound);
          });

        }

        private Task<bool> DownloadTask(string DownloadUrl)
        {
            return Task.Run<bool>(() =>
            {
                DownloadSong(DownloadUrl);
                return true;
            });

        }

        private async Task CheckDownloding()
        {
            await Task.Run(() =>
           {
               while (true)
               {
                   if (_downloader.State == Status.Completed)
                       break;
               }

           });
        }
        private async void btn_downloadAll_Click(object sender, EventArgs e)
        {
            if (lb_urls.Items.Count >= 1)
            {
                if (DirectoryDownload != string.Empty)
                    foreach (var item in lb_urls.Items)
                    {
                        await DownloadTask(item.Text);
                        await CheckDownloding();

                    }
                else
                    MessageBox.Show("Please First Select a Folder for Save Downloads ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic_browser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                DirectoryDownload = fbd.SelectedPath;
        }

        private void lb_urls_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            txt_url.Text = lb_urls.SelectedItem.Text;
        }
    }
}
