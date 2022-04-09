using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using DiscordRPC.Logging;
using DiscordRPC;
using DiscordRPC.Helper;
using DiscordRPC.Message;
using TagLib;
using WMPLib;
using Button = DiscordRPC.Button;

namespace MusicPlayer
{
    public partial class frm_musicplayer : Form
    {
        private bool SShuffle;
        private bool SRepeat;
        private bool mousedown_state;
        private int indexR;
        private int secound = 0;
        private int minute = 0;
        // float time;
        public DiscordRpcClient client;
        private string filename = "Musicname";
        private string URL = "Musicname";
        private string ModePlay = "File";
        private bool st = false;
        private List<string> files = new List<string>();
        private List<string> paths = new List<string>();
        public frm_musicplayer()
        {
            InitializeComponent();
            wmp_player.uiMode = "none";
            wmp_player.fullScreen = false;
            rest_currentPosition();
            wmp_player.enableContextMenu = false;
            wmp_player.settings.volume = tb_volume.Value = 10;
            timer_controls.Stop();
            this.MinimumSize = this.Size;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ni_notify.Dispose();
            cms_notify.Dispose();
            Application.Exit();
        }
        void DisableTb_Music()
        {
            if (lb_musics.Items.Count <= 0)
            {
                tb_music.Enabled = false;
            }
            else
            {
                if (lbl_status.Text == "None")
                {
                    tb_music.Enabled = false;
                }
                else
                {
                    tb_music.Enabled = true;
                }
            }
        }
        private void frm_main_Load(object sender, EventArgs e)
        {
            ni_notify.ShowBalloonTip(1000);
            ni_notify.Visible = true;
            DisableTb_Music();
            tb_volume.Value = wmp_player.settings.volume;
            Initialize();
            client.ClearPresence();
            client.SetPresence(new RichPresence()
            {
                Details = "Ideal",
                State = $"State : {lbl_status.Text}",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "music",
                    LargeImageText = "Enjoy",
                },
                Buttons = new[]
                {
                    new Button(){ Label = "Server Discord", Url = "https://discord.gg/TPa9n4Zkau" },
                    new Button(){ Label="Donate❤️", Url = "https://www.cafebede.ir"}
                }
            });
        }
        void Initialize()
        {
            /*
            Create a Discord client
            NOTE: 	If you are using Unity3D, you must use the full constructor and define
                     the pipe connection.
            */
            client = new DiscordRpcClient("883079317893054484");

            //Set the logger
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            //Subscribe to events
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            //Connect to the RPC
            client.Initialize();

            //Set the rich presence
            //  Call this as many times as you want and anywhere in your code.
            ShowDiscordStatus();
        }

        void ShowDiscordStatus()
        {
            client.SetPresence(new RichPresence()
            {
                Details = $"Song : {lbl_music_name.Text}",
                State = $"State : {lbl_status.Text}",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "music",
                    LargeImageText = "Enjoy❤️",
                },
                Buttons = new Button[]
                {
                    new Button() { Label = "Server Discord", Url = "https://discord.gg/TPa9n4Zkau" },
                    new Button() { Label="Donate❤️", Url = "https://www.cafebede.ir"}
                }

            });
        }
        void PlayFile(int index)
        {
            wmp_player.URL = paths[index];
            timer_time_muic.Enabled = true;
            wmp_player.Ctlcontrols.play();
            lb_musics.SelectedIndex = lb_musics.SelectedIndex;
            GetInfoFile(wmp_player.URL);
            pb_big_image_music.Image = GetImageFile(wmp_player.URL);
            st = true;
            tsm_name_song.Text = $"Song : {lbl_music_name.Text}";
            CheckMute();

            if (st)
            {
                btn_play_pause.Image = Properties.Resources.icon_pause;
            }
            else
            {
                btn_play_pause.Image = Properties.Resources.icon_play;
            }
        }
        void CheckMute()
        {
            if (btn_mute_volume.Checked)
            {
                wmp_player.settings.mute = true;
            }
        }
        void PlayUrl(int index)
        {
            wmp_player.URL = lb_musics.Items[index].Text;
            lbl_music_name.Text = wmp_player.currentMedia.name;
            lbl_total_time.Text = wmp_player.currentMedia.durationString;
            CheckMute();
        }
        private void btn_play_pause_Click(object sender, EventArgs e)
        {
            if (lb_musics.Items.Count <= 0 || lb_musics.SelectedIndex < 0)
            {
                return;
            }
            if (st)
            {
                wmp_player.Ctlcontrols.currentPosition = tb_music.Value;
                wmp_player.Ctlcontrols.pause();
            }
            else
            {
                wmp_player.Ctlcontrols.play();
            }
            st = !st;
        }

        void SetSingleMusicItemListBox()
        {
            //var newItems = lb_musics.Items.Distinct().ToList();
            //lb_musics.Items.Clear();
            //foreach (var item in newItems)
            //{
            //    lb_musics.Items.Add(item);
            //}

            for (int i = 0; i < lb_musics.Count; i++)
            {
                for (int j = i + 1; j < lb_musics.Count; j++)
                {
                    if (lb_musics.Items[i].Text == lb_musics.Items[j].Text)
                        lb_musics.Items.RemoveAt(j);
                }
            }
        }

        void FileMode()
        {
            // -- |Wav Files |*.wav
            opd_addmusic.Filter = "Mp3 Files|*.mp3|Wav Files|*.wav";
            opd_addmusic.FileName = string.Empty;
            DialogResult dr = opd_addmusic.ShowDialog();
            if (dr == DialogResult.OK)
            {
                files.AddRange(opd_addmusic.SafeFileNames);
                paths.AddRange(opd_addmusic.FileNames);
                paths = paths.Distinct().ToList();
                for (int i = 0; i < files.Count; i++)
                {
                    lb_musics.AddItem(files[i]);
                }
                files.Clear();
                SetSingleMusicItemListBox();
            }
        }
        void UrlMode()
        {
            opd_addmusic.Filter = "Text Files|*.txt";
            opd_addmusic.FileName = string.Empty;
            DialogResult dr = opd_addmusic.ShowDialog();
            if (dr == DialogResult.OK)
            {
                files.AddRange(opd_addmusic.FileNames);
                for (int i = 0; i < files.Count; i++)
                {
                    FileStream fs = new FileStream(files[i], System.IO.FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    while (!sr.EndOfStream)
                    {
                        //Urls.Add(sr.ReadLine());
                        lb_musics.AddItem(sr.ReadLine());
                    }
                }
                files.Clear();
                SetSingleMusicItemListBox();
            }
        }
        private void btn_addfile_Click(object sender, EventArgs e)
        {
            if (ModePlay == "File")
            {
                FileMode();
            }
            else
            {
                UrlMode();
            }
        }

        private void btn_repeat_Click(object sender, EventArgs e)
        {
            if (lb_musics.Items.Count > 0)
            {
                btn_repeat.Checked = !btn_repeat.Checked;
                SRepeat = !SRepeat;
            }
        }
        void rest_currentPosition()
        {
            wmp_player.Ctlcontrols.currentPosition = 0;
        }
        void rest_frm()
        {
            timer_time_muic.Enabled = false;
            tb_music.Value = 0;
            lbl_timestamp.Text = "00:00";
            minute = 0;
            secound = 0;
        }
        private void Stop()
        {
            wmp_player.Ctlcontrols.stop();
            btn_play_pause.Image = Properties.Resources.icon_play;
            st = false;
            rest_currentPosition();
            rest_frm();
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            Stop();
        }
        public Bitmap GetImageFile(string url)
        {
            try
            {
                var mStream = new MemoryStream();
                TagLib.File file = TagLib.File.Create(url);
                var firstPicture = file.Tag.Pictures.FirstOrDefault();
                if (firstPicture != null)
                {
                    byte[] pData = firstPicture.Data.Data;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    var bm = new Bitmap(mStream, false);
                    mStream.Dispose();
                    return bm;
                }
                pb_big_image_music.Image = Properties.Resources.defult_img;
                return null;

            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                paths.RemoveAt(lb_musics.SelectedIndex);
                files.RemoveAt(lb_musics.SelectedIndex);
                lb_musics.Items.RemoveAt(lb_musics.SelectedIndex);
                PlayFile(lb_musics.SelectedIndex + 1);
                return Properties.Resources.defult_img;
            }
            catch (Exception)
            {
                pb_big_image_music.Image = pb_big_image_music.Image = Properties.Resources.defult_img;
                lbl_total_time.Text = "00:00";
                lbl_timestamp.Text = "00:00";
                //  MessageBox.Show("Error, Can not Load Song Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        void GetInfoFile(string Url)
        {
            try
            {
                filename = Path.GetFileName(Url);
                lbl_music_name.Text = filename;
                var tfile = TagLib.File.Create(Url);
                TimeSpan duration = tfile.Properties.Duration;
                string minute_tt = Convert.ToString(duration.Minutes);
                string secound_tt = Convert.ToString(duration.Seconds);
                int a = Convert.ToInt32(minute_tt) * 60;
                tb_music.Maximum = a + Convert.ToInt32(secound_tt) + 1;
                lbl_total_time.Text = $"{minute_tt.PadLeft(2, '0')}:{secound_tt.PadLeft(2, '0')}";
            }
            catch (TagLib.CorruptFileException)
            {
                pb_big_image_music.Image = pb_big_image_music.Image = Properties.Resources.defult_img;
                lbl_total_time.Text = "00:00";
                lbl_timestamp.Text = "00:00";
                MessageBox.Show("Error, Can not Load Song Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Can not Find Song Selected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_play_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbl_status.Text == "Stop" || lbl_status.Text == "Pause" || lbl_status.Text == "None")
                {
                    timer_time_muic.Enabled = true;
                }
            }
            catch (TagLib.UnsupportedFormatException)
            {
                return;
            }
            catch (System.ArgumentException)
            {
                pb_big_image_music.Image = Properties.Resources.defult_img;
            }
        }


        private void NextOrPervious()
        {
            if (ModePlay == "File")
            {
                PlayFile(lb_musics.SelectedIndex);
            }
            else
            {
                PlayUrl(lb_musics.SelectedIndex);
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (lb_musics.SelectedIndex < lb_musics.Items.Count - 1 && lb_musics.Count > 0)
            {
                lb_musics.SelectedIndex++;
                NextOrPervious();
            }
            else if (lb_musics.Count > 0 && lb_musics.SelectedIndex == lb_musics.Count - 1)
            {
                lb_musics.SelectedIndex = 0;
                NextOrPervious();
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (lb_musics.Count > 1 && lb_musics.SelectedIndex != 0 && lb_musics.SelectedIndex != -1)
            {
                lb_musics.SelectedIndex--;
                NextOrPervious();
            }
            else if (lb_musics.SelectedIndex == 0 && lb_musics.Count > 2)
            {
                lb_musics.SelectedIndex = lb_musics.Count - 1;
                NextOrPervious();
            }
        }
        private void Shuffle()
        {
            if (wmp_player.playState == WMPPlayState.wmppsStopped || wmp_player.playState == WMPPlayState.wmppsUndefined)
            {
                if (SShuffle)
                {
                    Random rd = new Random();
                    indexR = rd.Next(0, lb_musics.Items.Count);
                    lb_musics.SelectedIndex = indexR;
                    if (ModePlay == "File")
                    {
                        PlayFile(indexR);
                    }
                    else
                    {
                        PlayUrl(indexR);
                    }
                }
            }
        }
        private void btn_shuffle_Click(object sender, EventArgs e)
        {
            if (lb_musics.Items.Count > 0)
            {
                SShuffle = !SShuffle;
                btn_shuffle.Checked = !btn_shuffle.Checked;
                Shuffle();
            }
        }
        private void Repeat()
        {
            if (wmp_player.playState == WMPPlayState.wmppsStopped && SRepeat)
            {
                rest_frm();
                if (ModePlay == "File")
                {
                    PlayFile(lb_musics.SelectedIndex);
                }
                else
                {
                    PlayUrl(lb_musics.SelectedIndex);
                }
            }
        }

        private void lbl_status_TextChanged(object sender, EventArgs e)
        {
            ShowDiscordStatus();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void pnl_background_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnl_background_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pnl_background_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void lbl_music_name_TextChanged(object sender, EventArgs e)
        {
            rest_currentPosition();
            rest_frm();
            if (lbl_status.Text == "None")
            {
                client.ClearPresence();
                client.SetPresence(new RichPresence()
                {
                    Details = $"Song : {lbl_music_name.Text}",
                    State = $"State : {lbl_status.Text}",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = "music",
                        LargeImageText = "Enjoy",
                        //SmallImageKey = "gloryweb"
                    }
                });
            }
            else
            {
                client.ClearPresence();
                client.SetPresence(new RichPresence()
                {
                    Details = $"Song : {lbl_music_name.Text}",
                    State = $"State : {lbl_status.Text}",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = "music",
                        LargeImageText = "Enjoy",
                        //SmallImageKey = "gloryweb"
                    }
                });
            }
        }
        private void tb_music_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                int value_tb = tb_music.Value;
                minute = value_tb / 60;
                int sec = minute * 60;
                sec = value_tb - sec;
                secound = sec;
                if (wmp_player.URL != string.Empty)
                {
                    lbl_timestamp.Text = $"{minute.ToString().PadLeft(2, '0')}:{secound.ToString().PadLeft(2, '0')}";
                }
            }
            catch
            {
                return;
            }
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Developer: Mxqius
----------------------
Telegram : @Mxqius
Instagram : @Mxqius 
----------------------
Team: GloryWeb
Beta Version", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ltsm_clear_Click(object sender, EventArgs e)
        {
            lb_musics.Items.Clear();
            if (ModePlay == "File")
            {
                paths.Clear();
                files.Clear();
            }
            lbl_shuffle.Text = "Off";
            lbl_shuffle.ForeColor = Color.PaleTurquoise;
            SShuffle = false;
            SRepeat = false;
        }

        private void ltsm_delete_select_Click(object sender, EventArgs e)
        {
            int index = lb_musics.SelectedIndex;
            if (index >= 0)
            {
                lb_musics.Items.RemoveAt(index);
                paths.RemoveAt(index);
            }
        }

        // List for files Enter with drag and add to listbox
        // List<FIleIteam> mediafile = new List<FIleIteam>();
        private void lb_musics_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (ModePlay == "File")
            {
                foreach (string f in file)
                {
                    if (f.EndsWith(".mp3") || f.EndsWith(".wav"))
                    {
                        lb_musics.AddItem(new FIleIteam(f).ToString());
                        paths.Add(f);
                    }
                }
                SetSingleMusicItemListBox();
            }
            else
            {
                for (int i = 0; i < file.Length; i++)
                {
                    FileStream fs = new FileStream(file[i], System.IO.FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    while (!sr.EndOfStream)
                    {
                        //Urls.Add(sr.ReadLine());
                        lb_musics.AddItem(Path.GetFileName(sr.ReadLine()));
                    }
                    SetSingleMusicItemListBox();
                }
            }
        }

        private void lb_musics_DragEnter(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (ModePlay == "File")
            {
                foreach (string f in file)
                {
                    if (!f.EndsWith(".mp3") && !f.EndsWith(".wav"))
                    {
                        e.Effect = DragDropEffects.None;
                    }
                    else
                    {
                        e.Effect = DragDropEffects.All;
                    }
                }
            }
            else
            {
                foreach (string f in file)
                {
                    if (!f.EndsWith(".txt"))
                    {
                        e.Effect = DragDropEffects.None;
                    }
                    else
                    {
                        e.Effect = DragDropEffects.All;
                    }
                }
            }
        }

        private void wmp_player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (wmp_player.playState == WMPPlayState.wmppsPlaying)
            {
                lbl_status.Text = "Playing";
                lbl_status.ForeColor = Color.GreenYellow;
                timer_time_muic.Enabled = true;
                tsm_status.Text = "Status : Playing";
                btn_play_pause.Image = Properties.Resources.icon_pause;
                timer_controls.Stop();

            }
            else if (wmp_player.playState == WMPPlayState.wmppsPaused)
            {
                lbl_status.Text = "Pause";
                lbl_status.ForeColor = Color.Orange;
                tsm_status.Text = "Status : Pause";
                btn_play_pause.Image = Properties.Resources.icon_play;
            }
            else if (wmp_player.playState == WMPPlayState.wmppsStopped || wmp_player.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                lbl_status.Text = "Stopped";
                lbl_status.ForeColor = Color.Red;
                tsm_status.Text = "Status : Stopped";
                timer_time_muic.Enabled = false;
                tb_music.Value = 0;
                lbl_timestamp.Text = "00:00";
                minute = 0;
                secound = 0;
                //-----------
                btn_play_pause.Image = Properties.Resources.icon_play;
                st = false;
                timer_controls.Start();

            }
            DisableTb_Music();
        }

        private void wmp_player_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            try
            // If the Player encounters a corrupt or missing file, 
            // show the hexadecimal error code and URL.
            {
                IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
                IWMPErrorItem errorItem = errSource.Error;
                MessageBox.Show("Error " + errorItem.errorCode.ToString("X")
                                + " in " + errSource.sourceURL);
            }
            catch (InvalidCastException)
            // In case pMediaObject is not an IWMPMedia item.
            {
                MessageBox.Show("Error.");
            }
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            rest_currentPosition();
            ni_notify.Dispose();
            cms_notify.Dispose();
        }
        private void tb_volume_Scroll(object sender, ScrollEventArgs e)
        {
            if (btn_mute_volume.Checked == true)
            {
                wmp_player.settings.mute = true;
                return;
            }
            else
            {
                wmp_player.settings.volume = tb_volume.Value;
            }
            // chng icon for volumes

            if (tb_volume.Value < 50)
            {
                btn_mute_volume.Image = Properties.Resources.icon_vl;
            }
            else
            {
                btn_mute_volume.Image = Properties.Resources.high_vol;
            }


        }

        private void btn_mute_volume_Click(object sender, EventArgs e)
        {
            if (wmp_player.settings.mute)
            {
                wmp_player.settings.mute = false;
                btn_mute_volume.Image = Properties.Resources.icon_vl;
            }
            else
            {
                wmp_player.settings.mute = true;
                btn_mute_volume.Image = Properties.Resources.icon_mute;
            }
        }

        private void pb_big_image_music_DoubleClick(object sender, EventArgs e)
        {
            pb_big_image_music.Visible = false;
            wmp_player.Visible = true;
        }

        private void pnl_header_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(846, 513);/* 846, 513*/
            }
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void tb_music_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown_state = true;
            timer_time_muic.Enabled = false;
        }

        private void tb_music_MouseUp(object sender, MouseEventArgs e)
        {
            if (mousedown_state)
            {
                wmp_player.Ctlcontrols.currentPosition = tb_music.Value;
                mousedown_state = false;
                timer_time_muic.Enabled = true;
            }
        }

        private void tb_music_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                mousedown_state = true;
            }
        }

        private void tb_music_KeyUp(object sender, KeyEventArgs e)
        {
            if (mousedown_state)
            {
                wmp_player.Ctlcontrols.currentPosition = tb_music.Value;
            }
        }

        private void frm_main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                rb_form.Enabled = false;
            }
            else
            {
                rb_form.Enabled = true;
            }
        }

        private void tsm_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_musics_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            if (ModePlay == "File")
            {
                PlayFile(lb_musics.SelectedIndex);
            }
            else
            {
                PlayUrl(lb_musics.SelectedIndex);
            }
            tb_music.Value = (int)wmp_player.Ctlcontrols.currentPosition;
        }

        private void lb_musics_MouseHover(object sender, EventArgs e)
        {
            tt_listbox.SetToolTip(lb_musics, lb_musics.Count.ToString());
            // tt_listbox.Show();
        }

        private void timer_time_muic_Tick(object sender, EventArgs e)
        {
            lbl_timestamp.Text = wmp_player.Ctlcontrols.currentPositionString;
            if (!(tb_music.Value >= tb_music.Maximum - 1))
            {
                tb_music.Value = (int)wmp_player.Ctlcontrols.currentPosition;
            }
        }

        private void timer_controls_Tick(object sender, EventArgs e)
        {
            Repeat();
            Shuffle();
        }

        private void wmp_player_DoubleClickEvent(object sender, AxWMPLib._WMPOCXEvents_DoubleClickEvent e)
        {
            pb_big_image_music.Visible = true;
            wmp_player.Visible = false;
        }

        private void tsm_file_muic_CheckedChanged(object sender, EventArgs e)
        {
            if (tsm_file_muic.Checked)
            {
                lb_musics.Clear();
                tsm_url_music.Checked = false;
                ModePlay = "File";
            }
        }

        private void tsm_url_music_CheckedChanged(object sender, EventArgs e)
        {
            if (tsm_url_music.Checked)
            {
                paths.Clear();
                files.Clear();
                lb_musics.Clear();
                tsm_file_muic.Checked = false;
                ModePlay = "Url";
            }
        }

        private void tsm_url_music_Click(object sender, EventArgs e)
        {
            tsm_url_music.Checked = !tsm_url_music.Checked;
        }

        private void tsm_file_muic_Click(object sender, EventArgs e)
        {
            tsm_file_muic.Checked = !tsm_file_muic.Checked;
        }

        private void btn_downloader_Click(object sender, EventArgs e)
        {
            frm_dl fl = new frm_dl(wmp_player);
            fl.Show();
        }
    }
}
