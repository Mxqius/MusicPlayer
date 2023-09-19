using System;
using MusicPlayer.UpdateFolder;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DiscordRPC.Logging;
using DiscordRPC;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using MusicPlayer.Forms;
using WMPLib;
using Button = DiscordRPC.Button;


namespace MusicPlayer
{

    public partial class frm_musicplayer : Form
    {
        // Update Result
        public bool UpdateExist, Theme, autoPlay, SRepeat, mousedown_state, SShuffle;

        // Random index For Shuffle
        private int indexRandom, selectedIndexControl, secound = 0, minute = 0;
        // Favorite Song List 
        public List<MusicFileInformation> favoritesList = new List<MusicFileInformation>();
        // Index Selected Control in Panel Music        
        // Discord Object Client for Activity
        public DiscordRpcClient client;
        public string songInfoURLPassed = "";
        private string filename = "Musicname", URL = "Musicname";
        // Mode Play URL/File
        private string ModePlay = "File";
        private bool st = false;
        // Get Index Music in List
        public int indexPlayerMusic;
        // List Address Musics
        private List<string> files = new List<string>();
        public List<MusicFileInformation> fileInformations = new List<MusicFileInformation>();
        // List Controls in PanelMusics
        public List<ListBoxMusicPlayer> ControlsPanelMusicList = new List<ListBoxMusicPlayer>();
        // ControlPanel ButtonsList
        private Guna2Button[] ControlButtonsList = new Guna2Button[5];
        // Defult Color Setting
        public Color defColor = Color.WhiteSmoke;
        // Old Color :  Color.FromArgb(53, 66, 89);
        // Defult Font Setting
        public Font defFont = new Font("Museo Sans Cyrl 900", 9, FontStyle.Bold);
        // Object IniFile and Create File Ini
        private IniFile iniFile = new IniFile(path);
        public frm_musicplayer()
        {
            InitializeComponent();
            // DPI SCALING
            //this.AutoScaleMode = AutoScaleMode.Dpi;
            //------------------------
            //Dark Icons ControlPanel 
            btn_settings.Image = Properties.Resources.settingDark;
            btn_about.Image = Properties.Resources.aboutDark;
            btn_exit.Image = Properties.Resources.exitDark;
            btn_addfile.Image = Properties.Resources.addDark;
            btn_minimize.Image = Properties.Resources.minimizeDark;
            btn_search.Image = Properties.Resources.searchDark;
            //-----------------------------
            wmp_player.uiMode = "none";
            wmp_player.fullScreen = false;
            // Rest Current Position and TrackBar
            rest_currentPosition();
            wmp_player.enableContextMenu = false;
            wmp_player.settings.volume = tb_volume.Value = 10;
            timer_controls.Stop();
            this.MinimumSize = this.Size;
            // Set ControlPanel Buttons
            ControlButtonsList = new[]
            {
                btn_exit,btn_about,btn_addfile,btn_minimize,btn_settings,btn_search
            };
            // Call Function LoadSettings From IniFile
            LoadSettings();
            // Set Label Text eqauls tb_volume
            lbl_valueVolume.Text = "%" + tb_volume.Value;
            // Open Child Form in Panel Settings
            FormInPanelParent.openChildFormInPanel(new frm_settings(this), pnl_formSetting);
            new UpdateFolder.Updater().CheckForUpdates();
        }

        static string path = Application.StartupPath + @"\Setting.ini";
        public void SaveSettings()
        {
            //if (!System.IO.File.Exists(path))
            //    System.IO.File.Create(path);
            iniFile.Write("ControlPanelColor", pnl_header.FillColor.ToArgb().ToString());
            iniFile.Write("Repeat", SRepeat.ToString());
            iniFile.Write("Shuffle", SShuffle.ToString());
            iniFile.Write("AutoPlay", autoPlay.ToString());
            iniFile.Write("Volume", tb_volume.Value.ToString());
            iniFile.Write("TextColor", lbl_name_app.ForeColor.ToArgb().ToString());
            iniFile.Write("Theme", Theme.ToString());
        }

        void setupOpenWithWindows()
        {

            // This Command Must run with administrator

            // Replace "MyTextEditor" with the name of your application
            string appName = "Music Player";

            // Get the path to your application executable
            string appPath = Application.ExecutablePath;

            string fileExt = ".txt";

            string keyPath = $@"{fileExt}\OpenWithProgids";

            using (RegistryKey keyR = Registry.ClassesRoot.OpenSubKey(keyPath))
                if (keyR != null && keyR.GetValue(appName) != null)
                    // The application is already registered, so exit the method
                    return;

            // Create a registry key for your application
            RegistryKey key = Registry.ClassesRoot.CreateSubKey("*\\shell\\" + appName);

            // Set the display name for your application in the "Open with" menu
            key.SetValue("", "Open with " + appName);

            // Create a subkey for the command to open your application
            RegistryKey commandKey = key.CreateSubKey("command");

            // Set the command to open your application
            commandKey.SetValue("", "\"" + appPath + "\" \"%1\"");
        }
        public void AddFavoriteSong(string musicAddress)
        {
            var item = ControlsPanelMusicList.Find(n => n.MusicAddress == musicAddress);
            favoritesList.Add(MusicFileInfoReader.GetMusicFileInformation(item.MusicAddress));
            //item.pic_favorite.Image = Properties.Resources.favoriteSelected;
            if (!System.IO.File.Exists(Application.StartupPath + @"\favorites.txt"))
                System.IO.File.Create(Application.StartupPath + @"\favorites.txt");
            using (StreamReader sr = new StreamReader(Application.StartupPath + @"\favorites.txt"))
            {
                string textOld = sr.ReadToEnd();
                sr.Close();
                using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\favorites.txt"))
                {
                    sw.Write(textOld.Trim() + "\n" + item.MusicAddress);
                }
            }
        }
        public bool checkFavorite(string musicAddress)
        {
            return favoritesList.Any(n => n.Path == musicAddress);
        }

        public async void deleteFavorite(string musicAddress)
        {
            favoritesList.Remove(favoritesList.Find(m => m.Path == musicAddress));
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\favorites.txt"))
            {
                foreach (MusicFileInformation favorite in favoritesList)
                {
                    await sw.WriteAsync(favorite.Path + "\n");
                }
            }

        }
        public void LoadSettings()
        {
            if (System.IO.File.Exists(path))
            {
                pnl_header.FillColor = Color.FromArgb(int.Parse(iniFile.Read("ControlPanelColor")));
                SRepeat = btn_repeat.Checked = bool.Parse(iniFile.Read("Repeat"));
                SShuffle = btn_shuffle.Checked = bool.Parse(iniFile.Read("Shuffle"));
                autoPlay = btn_autoPlay.Checked = bool.Parse(iniFile.Read("AutoPlay"));
                tb_volume.Value = wmp_player.settings.volume = int.Parse(iniFile.Read("Volume"));
                lbl_name_app.ForeColor = Color.FromArgb(int.Parse(iniFile.Read("TextColor")));
                Theme = bool.Parse(iniFile.Read("Theme"));
                if (Theme)
                {
                    // Light

                    btn_settings.Image = Properties.Resources.settings1;
                    btn_about.Image = Properties.Resources.about;
                    btn_exit.Image = Properties.Resources.exit1;
                    btn_addfile.Image = Properties.Resources.add;
                    btn_minimize.Image = Properties.Resources.minimize;
                    btn_search.Image = Properties.Resources.search;
                }
                else
                {
                    // Dark
                    btn_settings.Image = Properties.Resources.settingDark;
                    btn_about.Image = Properties.Resources.aboutDark;
                    btn_exit.Image = Properties.Resources.exitDark;
                    btn_addfile.Image = Properties.Resources.addDark;
                    btn_minimize.Image = Properties.Resources.minimizeDark;
                    btn_search.Image = Properties.Resources.searchDark;
                }
                if (autoPlay)
                {
                    btn_autoPlay.FillColor = Color.FromArgb(18, 174, 64);
                    //                    btn_autoPlay.Text = "AutoPlay On";
                }
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            ni_notify.Dispose();
            cms_notify.Dispose();
            Application.Exit();

        }
        void DisableTb_Music()
        {
            if (ControlsPanelMusicList.Count <= 0)
                tb_music.Enabled = false;
            else
            {
                if (lbl_status.Text == "None")
                    tb_music.Enabled = false;
                else
                    tb_music.Enabled = true;
            }
        }
        private void frm_main_Load(object sender, EventArgs e)
        {
            ni_notify.ShowBalloonTip(1000);
            ni_notify.Visible = true;
            DisableTb_Music();
            tb_volume.Value = wmp_player.settings.volume;
            Initialize();
            LoadFavoritesSongs(true, false);
        }

        public Dictionary<string, string> updateInfo = new Dictionary<string, string>();
        private void checkUpdate()
        {
            string data = UpdateFolder.Update.getUpdateFile("https://mxqius.ir/MusicPlayer/Updates/update.js");
            var json = UpdateFolder.Update.getJson(data);
            if (json.version != Application.ProductVersion)
            {
                UpdateExist = true;
                updateInfo.Add("Name", json.name);
                updateInfo.Add("Version", json.version);
                updateInfo.Add("DatePublisher", json.datePublisher);
                updateInfo.Add("DownloadAddress", json.downloadAddress);
            }

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
        byte[] getBuffersImage(PictureBox picture)
        {
            // Get the byte buffer of the image in the PictureBox control
            byte[] byteBuffer = null;
            using (MemoryStream ms = new MemoryStream())
            {
                picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byteBuffer = ms.ToArray();
            }
            return byteBuffer;
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
                    LargeImageText = "Enjoy❤️"
                },
                Buttons = new[]
                {
                    new Button() { Label = "Server Discord", Url = "https://discord.gg/hC2r8gSKma" },
                    new Button() { Label="Donate❤️", Url = "https://www.cafebede.ir"}
                }

            });
        }
        public void PlayFile(string url)
        {

            wmp_player.URL = url;
            FocusMusic(url);
            selectedIndexControl = ControlsPanelMusicList.FindIndex(n => n.MusicAddress == wmp_player.URL);
            timer_time_muic.Enabled = true;
            wmp_player.Ctlcontrols.play();
            // indexPlayerMusic = ControlsPanelMusicList.FindIndex(n => n.MusicAddress == wmp_player.URL);
            lb_musics.SelectedIndex = lb_musics.SelectedIndex;
            GetInfoFile(wmp_player.URL);
            pb_big_image_music.Image = GetImageFile(wmp_player.URL);
            st = true;
            tsm_name_song.Text = $"Song : {lbl_music_name.Text}";
            CheckMute();
            if (st)
            {
                btn_play_pause.Image = Properties.Resources.pause;
            }
            else
            {
                btn_play_pause.Image = Properties.Resources.play;
            }
        }

        void FocusMusic(string url)
        {
            foreach (var control in ControlsPanelMusicList)
            {
                if (control.MusicAddress == url)
                {
                    control.BackColor = Color.DarkGray;
                    control.Focus();
                    SetFocusedRight();
                    break;
                }
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
        void SetSingleMusicItemListBoxControlUser()
        {
            for (int i = 0; i < ControlsPanelMusicList.Count; i++)
            {
                for (int j = i + 1; j < ControlsPanelMusicList.Count; j++)
                {
                    if (ControlsPanelMusicList[i].MusicAddress == ControlsPanelMusicList[j].MusicAddress)
                        ControlsPanelMusicList.RemoveAt(j);
                }
            }
        }
        async Task insertControl(List<ListBoxMusicPlayer> list)
        {
            await Task.Run(() =>
            {
                pnl_listMusics.Invoke(new Action(() =>
                {
                    pnl_listMusics.Controls.AddRange(list.ToArray());
                }));
            });
        }
        async Task InsertFilesMusic()
        {
            await Task.Run(() =>
            {
                fileInformations = fileInformations.Distinct().ToList();
                ControlsPanelMusicList.Clear();
                pnl_listMusics.Invoke(new Action(() =>
                {
                    pnl_listMusics.Controls.Clear();
                }));
                for (int i = 0; i < fileInformations.Count; i++)
                {
                    var control = new ListBoxMusicPlayer(this, i, fileInformations[i].Path, fileInformations[i].FileName,
                       MusicFileInfoReader.FormatDuration(fileInformations[i].Duration), ImageConverter.ConvertImageBufferToBitmap(fileInformations[i].ImageBuffer), ControlOnClick, ControlOnMouseHover)
                    {
                        Dock = DockStyle.Top
                    };
                    ControlsPanelMusicList.Add(control);
                    if (favoritesList.Any(n => n.Path == control.MusicAddress))
                        control.pic_favorite.Image = Properties.Resources.favoriteSelected;
                }

                ControlsPanelMusicList.Reverse();
                pnl_listMusics.Invoke(new Action(() =>
                {
                    pnl_listMusics.Controls.AddRange(ControlsPanelMusicList.ToArray());
                }));
            });
        }
        async void FileMode()
        {
            // -- |Wav Files |*.wav
            opd_addmusic.Filter = "Audio File (*.mp3;*.wav)|*.mp3;*.wav";
            opd_addmusic.FileName = string.Empty;
            DialogResult dr = opd_addmusic.ShowDialog();
            if (dr == DialogResult.OK)
            {
                files.AddRange(opd_addmusic.SafeFileNames);
                InsertDataFiles(opd_addmusic.FileNames);
                await InsertFilesMusic();
                files.Clear();
            }

            SetFocusedRight();
            FocusMusic(wmp_player.URL);
        }
        private void InsertDataFiles(string[] fileInformationsList)
        {
            foreach (string path in fileInformationsList)
            {
                fileInformations.Add(MusicFileInfoReader.GetMusicFileInformation(path));
            }
        }
        private void LoadFavoritesSongs(bool favoriteInsert, bool fileInformationsInsert = true)
        {
            if (System.IO.File.Exists(@"favorites.txt"))
            {
                using (StreamReader sr = new StreamReader(Application.StartupPath + @"\favorites.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        if (fileInformationsInsert)
                            fileInformations.Add(MusicFileInfoReader.GetMusicFileInformation(sr.ReadLine()));
                        if (favoriteInsert)
                            favoritesList.Add(MusicFileInfoReader.GetMusicFileInformation(sr.ReadLine()));
                    }
                }
            }
        }
        private void ControlOnMouseHover(object sender, EventArgs e)
        {
            tt_listbox.SetToolTip(((Control)sender), fileInformations.Count.ToString());
        }

        public void SetFocusedRight()
        {
            foreach (var control in ControlsPanelMusicList)
            {
                if (control.MusicAddress == wmp_player.URL)
                    control.BackColor = Color.FromArgb(228, 228, 228);
                else
                    control.BackColor = Color.WhiteSmoke;

            }
        }
        private void ControlOnClick(object sender, EventArgs e)
        {

            if (((Control)sender) is ListBoxMusicPlayer)
            {
                indexPlayerMusic = ((ListBoxMusicPlayer)sender).IndexMusic;
                PlayFile(((ListBoxMusicPlayer)sender).MusicAddress);
                SetFocusedRight();
                ((ListBoxMusicPlayer)sender).BackColor = Color.FromArgb(228, 228, 228);
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
            if (ControlsPanelMusicList.Count > 0)
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
            btn_play_pause.Image = Properties.Resources.play;
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
                //return Properties.Resources.noPictureMusic;
                return Properties.Resources.musicListIcon;

            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                fileInformations.RemoveAt(lb_musics.SelectedIndex);
                files.RemoveAt(lb_musics.SelectedIndex);
                lb_musics.Items.RemoveAt(lb_musics.SelectedIndex);
                // PlayFile(lb_musics.SelectedIndex + 1);
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

        private string getFileName(string url)
        {
            return Path.GetFileName(url);
        }

        private string getDuration(string url)
        {
            var tfile = TagLib.File.Create(url);
            TimeSpan duration = tfile.Properties.Duration;
            string minute = Convert.ToString(duration.Minutes);
            string secound = Convert.ToString(duration.Seconds);
            return $"{minute.PadLeft(2, '0')}:{secound.PadLeft(2, '0')}";
        }
        void GetInfoFile(string Url)
        {
            try
            {
                filename = getFileName(Url);
                lbl_music_name.Text = filename;
                var tfile = TagLib.File.Create(Url);
                TimeSpan duration = tfile.Properties.Duration;
                string minute_tt = Convert.ToString(duration.Minutes);
                string secound_tt = Convert.ToString(duration.Seconds);
                int a = Convert.ToInt32(minute_tt) * 60;
                tb_music.Maximum = a + Convert.ToInt32(secound_tt) + 1;
                lbl_total_time.Text = getDuration(Url);
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


        private void NextOrPervious()
        {
            if (ModePlay == "File")
            {
                PlayFile(ControlsPanelMusicList[selectedIndexControl].MusicAddress);
            }
            else
            {
                PlayUrl(indexPlayerMusic);
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (ControlsPanelMusicList.Count > 1 && selectedIndexControl != 0 && selectedIndexControl != -1)
            {
                selectedIndexControl--;
                NextOrPervious();
            }
            else if (selectedIndexControl == 0 && ControlsPanelMusicList.Count > 2)
            {
                selectedIndexControl = fileInformations.Count - 1;
                NextOrPervious();
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (selectedIndexControl < ControlsPanelMusicList.Count - 1 && ControlsPanelMusicList.Count > 0)
            {
                selectedIndexControl++;
                NextOrPervious();
            }
            else if (ControlsPanelMusicList.Count > 0 && selectedIndexControl == ControlsPanelMusicList.Count - 1)
            {
                selectedIndexControl = 0;
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
                    indexRandom = rd.Next(0, ControlsPanelMusicList.Count);
                    indexPlayerMusic = indexRandom;
                    if (ModePlay == "File")
                    {
                        PlayFile(ControlsPanelMusicList[indexPlayerMusic].MusicAddress);
                    }
                    else
                    {
                        PlayUrl(indexRandom);
                    }
                }
            }
        }
        private void btn_shuffle_Click(object sender, EventArgs e)
        {
            if (ControlsPanelMusicList.Count > 0)
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
                    //PlayFile(ControlsPanelMusicList.Find(n => n.MusicAddress == wmp_player.URL).MusicAddress);
                    PlayFile(wmp_player.URL);
                }
                else
                {
                    //PlayUrl(lb_musics.SelectedIndex);
                    PlayUrl(indexPlayerMusic);
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

        private bool dragging;
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
            if (ControlsPanelMusicList.Count > 0)
            {
                if (SRepeat)
                    btn_repeat_Click(null, null);
                if (SShuffle)
                    btn_shuffle_Click(null, null);
                if (autoPlay)
                    btn_autoPlay_Click(null, null);
                pnl_listMusics.Controls.Clear();
                ControlsPanelMusicList.Clear();
                if (ModePlay == "File")
                {
                    fileInformations.Clear();
                    files.Clear();
                }

                lbl_shuffle.Text = "Off";
                lbl_shuffle.ForeColor = Color.PaleTurquoise;
                indexPlayerMusic = selectedIndexControl = 0;
            }
        }

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
                        fileInformations.Add(MusicFileInfoReader.GetMusicFileInformation(f));
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
                btn_play_pause.Image = Properties.Resources.pause;
                timer_controls.Stop();

            }
            else if (wmp_player.playState == WMPPlayState.wmppsPaused)
            {
                lbl_status.Text = "Pause";
                lbl_status.ForeColor = Color.Orange;
                tsm_status.Text = "Status : Pause";
                btn_play_pause.Image = Properties.Resources.play;
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
                btn_play_pause.Image = Properties.Resources.play;
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
                                + " in " + errSource.sourceURL, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidCastException)
            // In case pMediaObject is not an IWMPMedia item.
            {
                MessageBox.Show("Error");
            }
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            rest_currentPosition();
            ni_notify.Dispose();
            cms_notify.Dispose();
        }
        private void tb_volume_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_valueVolume.Text = "%" + tb_volume.Value;
            if (btn_mute_volume.Checked)
            {
                wmp_player.settings.mute = true;
                return;
            }
            wmp_player.settings.volume = tb_volume.Value;
            // chng icon for volumes

            if (tb_volume.Value < 1)
                btn_mute_volume.Image = Properties.Resources.mute;
            else if (tb_volume.Value < 50)
                btn_mute_volume.Image = Properties.Resources.medium_volume;
            else
                btn_mute_volume.Image = Properties.Resources.high_volume;
        }

        private void btn_mute_volume_Click(object sender, EventArgs e)
        {
            if (wmp_player.settings.mute)
            {
                if (tb_volume.Value < 1)
                    btn_mute_volume.Image = Properties.Resources.mute;
                else if (tb_volume.Value < 50)
                    btn_mute_volume.Image = Properties.Resources.medium_volume;
                else
                    btn_mute_volume.Image = Properties.Resources.high_volume;
            }
            else
            {
                wmp_player.settings.mute = true;
                btn_mute_volume.Image = Properties.Resources.mute;
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

            mousedown_state = !mousedown_state;
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
                //PlayFile(lb_musics.SelectedIndex);
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
        }

        private void timer_time_muic_Tick(object sender, EventArgs e)
        {
            lbl_timestamp.Text = wmp_player.Ctlcontrols.currentPositionString;
            if (!(tb_music.Value >= tb_music.Maximum - 1))
            {
                tb_music.Value = (int)wmp_player.Ctlcontrols.currentPosition;
            }
        }

        private void AutoPlay()
        {
            if (autoPlay)
                btn_next_Click(null, null);
            //    PlayFile(ControlsPanelMusicList[--selectedIndexControl].MusicAddress);
        }
        private void timer_controls_Tick(object sender, EventArgs e)
        {
            Repeat();
            AutoPlay();
            Shuffle();
        }

        private void wmp_player_DoubleClickEvent(object sender, AxWMPLib._WMPOCXEvents_DoubleClickEvent e)
        {
            pb_big_image_music.Visible = true;
            wmp_player.Visible = false;
        }
        private void pnl_listMusics_MouseHover(object sender, EventArgs e)
        {
            tt_listbox.SetToolTip(pnl_listMusics, fileInformations.Count.ToString());
        }

        private void pnl_listMusics_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (ModePlay == "File")
            {
                foreach (string f in file)
                {
                    if (f.EndsWith(".mp3") || f.EndsWith(".wav"))
                    {
                        fileInformations.Add(MusicFileInfoReader.GetMusicFileInformation(f));
                    }
                }

                InsertFilesMusic();
            }
        }

        private void pnl_listMusics_DragEnter(object sender, DragEventArgs e)
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
        private void btn_autoPlay_Click(object sender, EventArgs e)
        {
            if (ControlsPanelMusicList.Count > 1)
            {
                btn_autoPlay.FillColor = !autoPlay ? Color.FromArgb(18, 174, 64) : Color.FromArgb(255, 0, 1);
                autoPlay = !autoPlay;
            }
        }

        private void FocusButtonsControl(object sender, MouseEventArgs e)
        {
            foreach (var control in ControlButtonsList)
            {
                if (control.Name == ((Control)sender).Name)
                    control.ImageSize = new Size(34, 34);
                else
                    control.ImageSize = new Size(30, 30);
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            pnl_formSetting.Visible = true;
            //pnl_formSetting.Refresh();
            //  lbl_name_app.Text = "MusicPlayer / Settings";
        }

        private async void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.Trim().Length <= 1)
            {
                pnl_listMusics.Controls.Clear();
                await insertControl(ControlsPanelMusicList);
            }
            var searchResult = ControlsPanelMusicList.FindAll(x => x.SetName.Contains(txt_search.Text.Trim()));
            if (searchResult.Count > 0)
            {
                pnl_listMusics.Controls.Clear();
                await insertControl(searchResult);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            txt_search.Visible = btn_autoPlay.Visible;
            btn_autoPlay.Visible = !txt_search.Visible;
        }

        private void headerControls_MouseLeave(object sender, EventArgs e)
        {
            ((Guna2Button)sender).ImageSize = new Size(30, 30);
        }


        private void tb_music_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_music.Value += 10;
        }

        private void tsm_info_Click(object sender, EventArgs e)
        {

            try
            {
                new frm_songInfo(fileInformations[indexPlayerMusic]).ShowDialog();
            }
            catch
            {
                return;
            }            
        }

        private async void tsm_loadFavorites_Click(object sender, EventArgs e)
        {
            LoadFavoritesSongs(false);
            await InsertFilesMusic();
        }

        private void ni_notify_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private async void tsm_savePicture_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Title = "Save Picture",
                Filter = "PNG File|*.png",
                FileName = RandomString(12)
            };
            if (sfd.ShowDialog() == DialogResult.OK)
                using (Bitmap b = new Bitmap(pb_big_image_music.Image))
                    b.Save(sfd.FileName);

        }

    }
}
