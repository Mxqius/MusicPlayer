using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Diagnostics;
using System.Threading;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Net;
using System.Web;

namespace MusicPlayer
{
    public partial class frm_main : Form
    {
        string filename = null;
        string URL;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        bool st = false;
        List<string> files = new List<string>();
        List<string> paths = new List<string>();
        DialogResult dr = new DialogResult();
        int value;
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frm_main_Load(object sender, EventArgs e)
        {
            //empty
        }
        private void OnButtonPlayClick(object sender, EventArgs args)
        {
            try
            {
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                }
                if (audioFile == null)
                {
                    if (URL == null)
                    {
                        MessageBox.Show("File Not selected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    audioFile = new AudioFileReader(URL);
                    outputDevice.Init(audioFile);
                }
                outputDevice.Play();
                lbl_status.ForeColor = Color.GreenYellow;
                lbl_status.Text = "Playing";
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("File Not selected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void OnButtonStopClick(object sender, EventArgs args)
        {
            if (lbl_status.Text != "None")
            {
                outputDevice?.Stop();
                lbl_status.Text = "Stop";
                lbl_status.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("File Not selected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void OnButtonResumeClick(object sender, EventArgs args)
        {
            var wo = new WaveOutEvent();
            var af = new AudioFileReader(opd_addmusic.FileName);
            var closing = false;
            wo.PlaybackStopped += (s, a) => { if (closing) { wo.Dispose(); af.Dispose(); } };
            wo.Init(af);
            lbl_status.ForeColor = Color.GreenYellow;
            lbl_status.Text = "Resume";
            // f.FormClosing += (s, a) => { closing = true; wo.Stop(); };
            // f.ShowDialog()
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
            st = false;
            lbl_status.ForeColor = Color.Red;
            lbl_status.Text = "Pause";
            btn_play_pause.Image = Image.FromFile(@"F:\C#\MusicPlayer\MusicPlayer\images\icon_play.png");
        }
        private void btn_play_pause_Click(object sender, EventArgs e)
        {
            try
            {
                // Process.Start(opd_addmusic.FileName);
                if (st == true)
                {
                    OnPlaybackStopped(null, null);
                    st = false;
                }
                else
                {
                    OnButtonResumeClick(null, null);
                    //  pb_music_progressbar.Style = ProgressBarStyle.Blocks;
                    // timer.Enabled = true;
                    st = true;
                }

                if (st == true)
                {
                    btn_play_pause.Image = Image.FromFile(@"F:\C#\MusicPlayer\MusicPlayer\images\icon_pause.png");
                }
                else
                {
                    btn_play_pause.Image = Image.FromFile(@"F:\C#\MusicPlayer\MusicPlayer\images\icon_play.png");
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("File Not selected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btn_addfile_Click(object sender, EventArgs e)
        {
            opd_addmusic.Filter = "Wav Files |*.wav|Mp3 Files|*.mp3";
            opd_addmusic.FileName = string.Empty;
            dr = opd_addmusic.ShowDialog();
            if (dr == DialogResult.OK)
            {
                files.AddRange(opd_addmusic.SafeFileNames);
                paths.AddRange(opd_addmusic.FileNames);
                for (int i = 0; i < opd_addmusic.FileNames.Length; i++)
                {
                    lb_musics.Items.Add($"{i + 1} - "+files[i]);
                }
            }

            /*  if (dr == DialogResult.OK)
              {
                  Stream a = opd_addmusic.OpenFile();
                  StreamReader sr = new StreamReader(a);
                  adress = sr.ReadToEnd();
                  MessageBox.Show(adress);
                  sr.Close();
              }*/
        }

        private void btn_repeat_Click(object sender, EventArgs e)
        {
            try
            {
                var wo = new WaveOutEvent();
                var af = new AudioFileReader(URL);
                if (lbl_repeat.Text == "Off")
                {
                    lbl_repeat.ForeColor = Color.GreenYellow;
                    lbl_repeat.Text = "On";
                    timer_repeat.Enabled = true;
                }
                else
                {
                    lbl_repeat.ForeColor = Color.PaleTurquoise;
                    lbl_repeat.Text = "Off";
                    timer_repeat.Enabled = false;
                }

            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("File Not selected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void tb_volume_ValueChanged(object sender, EventArgs e)
        {
            var wo = new WaveOutEvent();
            var af = new AudioFileReader(URL);
            var closing = false;
            wo.PlaybackStopped += (s, a) => { if (closing) { wo.Dispose(); af.Dispose(); } };
            wo.Init(af);
            // Alternative: t.Scroll += (s, a) => af.Volume = t.Value / 100f;
            tb_volume.Scroll += (s, a) => wo.Volume = tb_volume.Value / 100f;
            tb_volume.Scroll += (s, a) => af.Volume = tb_volume.Value / 100f;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            OnButtonStopClick(null, null);
            //timer.Enabled = false;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            OnButtonPlayClick(null, null);
            filename = Path.GetFileName(URL);
            lbl_music_name.Text = filename;
            TagLib.File file = TagLib.File.Create(URL);
            var mStream = new MemoryStream();
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream, false);
                mStream.Dispose();
                pb_image_music.Image = bm;
            }
            else
            {
                // set "no cover" image
            }
        }

        private void btn_play_url_Click(object sender, EventArgs e)
        {
            var url = txt_url_music.Text.Trim();
            if (txt_url_music.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Field URL is Empty !");
                return;
            }
            using (var mf = new MediaFoundationReader(url))
            using (var wo = new WaveOutEvent())
            {
                wo.Init(mf);
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }

        }

        private void lb_musics_SelectedIndexChanged(object sender, EventArgs e)
        {
            URL = paths[lb_musics.SelectedIndex];
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lb_musics.Items.Clear();
            paths.Clear();
            files.Clear();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (lb_musics.SelectedIndex < lb_musics.Items.Count - 1)
            {
                lb_musics.SelectedIndex = lb_musics.SelectedIndex + 1;
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            try
            {
                if (lb_musics.SelectedIndex < lb_musics.Items.Count + 1)
                {
                    lb_musics.SelectedIndex = lb_musics.SelectedIndex - 1;
                }

            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            using (var wo = new WaveOutEvent())
            {
                if (lbl_status.Text == "Playing")
                {
                    return;
                }
                else
                {
                    if (lbl_shuffle.Text == "On")
                    {
                        if (wo.PlaybackState != PlaybackState.Playing)
                        {
                            Random rd = new Random();
                            int r = rd.Next(0, paths.Count);
                            URL = paths[r];
                            btn_play_Click(null, null);
                        }
                    }
                }
            }
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            var result = string.Empty;
            using (var webClient = new WebClient())
            {
                result = webClient.DownloadString(txt_url_music.Text.Trim());
            }
        }

        private void btn_shuffle_Click(object sender, EventArgs e)
        {
            if (lbl_shuffle.Text == "Off")
            {
                lbl_shuffle.Text = "On";
                lbl_shuffle.ForeColor = Color.GreenYellow;
                timer.Enabled = true;
            }
            else
            {
                lbl_shuffle.Text = "Off";
                lbl_shuffle.ForeColor = Color.PaleTurquoise;
                timer.Enabled = false;
            }

        }

        private void timer_repeat_Tick(object sender, EventArgs e)
        {
            if (lbl_status.Text == "Pause")
            {
                btn_play_Click(null, null);

            }
        }
    }
}
