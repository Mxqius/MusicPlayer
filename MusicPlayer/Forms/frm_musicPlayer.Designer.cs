
namespace MusicPlayer
{
    partial class frm_musicplayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_musicplayer));
            this.opd_addmusic = new System.Windows.Forms.OpenFileDialog();
            this.blf_frm_main = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.timer_time_muic = new System.Windows.Forms.Timer(this.components);
            this.pnl_music_main = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_formSetting = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_listMusics = new System.Windows.Forms.Panel();
            this.cms_list_musics = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsm_loadFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_info = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsm_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_musics = new MaterialSkin.Controls.MaterialListBox();
            this.pb_big_image_music = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cms_pictureOptions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsm_savePicture = new System.Windows.Forms.ToolStripMenuItem();
            this.wmp_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnl_header = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_autoPlay = new Guna.UI2.WinForms.Guna2Button();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_minimize = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_about = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_repeat = new System.Windows.Forms.Label();
            this.pb_icon_header = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_shuffle = new System.Windows.Forms.Label();
            this.lbl_name_app = new System.Windows.Forms.Label();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_settings = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addfile = new Guna.UI2.WinForms.Guna2Button();
            this.btn_stop = new Guna.UI2.WinForms.Guna2Button();
            this.tb_volume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tb_music = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lbl_music_name = new System.Windows.Forms.Label();
            this.btn_shuffle = new Guna.UI2.WinForms.Guna2Button();
            this.btn_mute_volume = new Guna.UI2.WinForms.Guna2Button();
            this.btn_repeat = new Guna.UI2.WinForms.Guna2Button();
            this.btn_next = new Guna.UI2.WinForms.Guna2Button();
            this.btn_previous = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_timestamp = new System.Windows.Forms.Label();
            this.lbl_valueVolume = new System.Windows.Forms.Label();
            this.lbl_total_time = new System.Windows.Forms.Label();
            this.btn_play_pause = new Guna.UI2.WinForms.Guna2Button();
            this.rb_form = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.pnl_background = new Guna.UI2.WinForms.Guna2Panel();
            this.ni_notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_notify = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsm_musicplayer_text = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_status = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_name_song = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tt_listbox = new System.Windows.Forms.ToolTip(this.components);
            this.timer_controls = new System.Windows.Forms.Timer(this.components);
            this.tt_downloader = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_music_main.SuspendLayout();
            this.cms_list_musics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_big_image_music)).BeginInit();
            this.cms_pictureOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_player)).BeginInit();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_header)).BeginInit();
            this.pnl_background.SuspendLayout();
            this.cms_notify.SuspendLayout();
            this.SuspendLayout();
            // 
            // opd_addmusic
            // 
            this.opd_addmusic.FileName = "Music";
            this.opd_addmusic.Multiselect = true;
            this.opd_addmusic.Title = "Select Music";
            // 
            // blf_frm_main
            // 
            this.blf_frm_main.BorderRadius = 15;
            this.blf_frm_main.ContainerControl = this;
            this.blf_frm_main.DockForm = false;
            this.blf_frm_main.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(115)))));
            this.blf_frm_main.DockIndicatorTransparencyValue = 0.6D;
            this.blf_frm_main.ResizeForm = false;
            this.blf_frm_main.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(115)))));
            this.blf_frm_main.TransparentWhileDrag = true;
            // 
            // timer_time_muic
            // 
            this.timer_time_muic.Interval = 1000;
            this.timer_time_muic.Tick += new System.EventHandler(this.timer_time_muic_Tick);
            // 
            // pnl_music_main
            // 
            this.pnl_music_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_music_main.BackColor = System.Drawing.Color.Transparent;
            this.pnl_music_main.Controls.Add(this.pnl_formSetting);
            this.pnl_music_main.Controls.Add(this.pnl_listMusics);
            this.pnl_music_main.Controls.Add(this.lb_musics);
            this.pnl_music_main.Controls.Add(this.pb_big_image_music);
            this.pnl_music_main.Controls.Add(this.wmp_player);
            this.pnl_music_main.Controls.Add(this.pnl_header);
            this.pnl_music_main.Controls.Add(this.btn_stop);
            this.pnl_music_main.Controls.Add(this.tb_volume);
            this.pnl_music_main.Controls.Add(this.tb_music);
            this.pnl_music_main.Controls.Add(this.lbl_music_name);
            this.pnl_music_main.Controls.Add(this.btn_shuffle);
            this.pnl_music_main.Controls.Add(this.btn_mute_volume);
            this.pnl_music_main.Controls.Add(this.btn_repeat);
            this.pnl_music_main.Controls.Add(this.btn_next);
            this.pnl_music_main.Controls.Add(this.btn_previous);
            this.pnl_music_main.Controls.Add(this.lbl_timestamp);
            this.pnl_music_main.Controls.Add(this.lbl_valueVolume);
            this.pnl_music_main.Controls.Add(this.lbl_total_time);
            this.pnl_music_main.Controls.Add(this.btn_play_pause);
            this.pnl_music_main.Controls.Add(this.rb_form);
            this.pnl_music_main.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_music_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_music_main.Name = "pnl_music_main";
            this.pnl_music_main.Size = new System.Drawing.Size(1027, 566);
            this.pnl_music_main.TabIndex = 1;
            // 
            // pnl_formSetting
            // 
            this.pnl_formSetting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_formSetting.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_formSetting.Location = new System.Drawing.Point(0, 47);
            this.pnl_formSetting.Name = "pnl_formSetting";
            this.pnl_formSetting.Size = new System.Drawing.Size(1027, 522);
            this.pnl_formSetting.TabIndex = 14;
            this.pnl_formSetting.Visible = false;
            // 
            // pnl_listMusics
            // 
            this.pnl_listMusics.AllowDrop = true;
            this.pnl_listMusics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_listMusics.AutoScroll = true;
            this.pnl_listMusics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_listMusics.ContextMenuStrip = this.cms_list_musics;
            this.pnl_listMusics.Location = new System.Drawing.Point(684, 47);
            this.pnl_listMusics.Name = "pnl_listMusics";
            this.pnl_listMusics.Size = new System.Drawing.Size(343, 432);
            this.pnl_listMusics.TabIndex = 13;
            this.pnl_listMusics.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_listMusics_DragDrop);
            this.pnl_listMusics.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_listMusics_DragEnter);
            this.pnl_listMusics.MouseHover += new System.EventHandler(this.pnl_listMusics_MouseHover);
            // 
            // cms_list_musics
            // 
            this.cms_list_musics.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_list_musics.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_loadFavorites,
            this.tsm_info,
            this.ltsm_clear});
            this.cms_list_musics.Name = "guna2ContextMenuStrip1";
            this.cms_list_musics.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cms_list_musics.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cms_list_musics.RenderStyle.ColorTable = null;
            this.cms_list_musics.RenderStyle.RoundedEdges = true;
            this.cms_list_musics.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cms_list_musics.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cms_list_musics.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cms_list_musics.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cms_list_musics.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cms_list_musics.Size = new System.Drawing.Size(174, 76);
            // 
            // tsm_loadFavorites
            // 
            this.tsm_loadFavorites.Name = "tsm_loadFavorites";
            this.tsm_loadFavorites.Size = new System.Drawing.Size(173, 24);
            this.tsm_loadFavorites.Text = "Load Favorites";
            this.tsm_loadFavorites.Click += new System.EventHandler(this.tsm_loadFavorites_Click);
            // 
            // tsm_info
            // 
            this.tsm_info.Name = "tsm_info";
            this.tsm_info.Size = new System.Drawing.Size(173, 24);
            this.tsm_info.Text = "Song Info";
            this.tsm_info.Click += new System.EventHandler(this.tsm_info_Click);
            // 
            // ltsm_clear
            // 
            this.ltsm_clear.Name = "ltsm_clear";
            this.ltsm_clear.Size = new System.Drawing.Size(173, 24);
            this.ltsm_clear.Text = "ClearList";
            this.ltsm_clear.Click += new System.EventHandler(this.ltsm_clear_Click);
            // 
            // lb_musics
            // 
            this.lb_musics.AllowDrop = true;
            this.lb_musics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_musics.BackColor = System.Drawing.Color.White;
            this.lb_musics.BorderColor = System.Drawing.Color.Black;
            this.lb_musics.Depth = 0;
            this.lb_musics.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_musics.Location = new System.Drawing.Point(779, 47);
            this.lb_musics.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_musics.Name = "lb_musics";
            this.lb_musics.SelectedIndex = -1;
            this.lb_musics.SelectedItem = null;
            this.lb_musics.Size = new System.Drawing.Size(248, 377);
            this.lb_musics.TabIndex = 12;
            this.lb_musics.Visible = false;
            this.lb_musics.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.lb_musics_SelectedIndexChanged);
            this.lb_musics.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_musics_DragDrop);
            this.lb_musics.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_musics_DragEnter);
            this.lb_musics.MouseHover += new System.EventHandler(this.lb_musics_MouseHover);
            // 
            // pb_big_image_music
            // 
            this.pb_big_image_music.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_big_image_music.BackColor = System.Drawing.Color.Transparent;
            this.pb_big_image_music.BorderRadius = 10;
            this.pb_big_image_music.ContextMenuStrip = this.cms_pictureOptions;
            this.pb_big_image_music.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(62)))));
            this.pb_big_image_music.Image = global::MusicPlayer.Properties.Resources.musicListIcon;
            this.pb_big_image_music.ImageRotate = 0F;
            this.pb_big_image_music.Location = new System.Drawing.Point(161, 74);
            this.pb_big_image_music.Name = "pb_big_image_music";
            this.pb_big_image_music.Size = new System.Drawing.Size(350, 350);
            this.pb_big_image_music.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_big_image_music.TabIndex = 5;
            this.pb_big_image_music.TabStop = false;
            this.pb_big_image_music.DoubleClick += new System.EventHandler(this.pb_big_image_music_DoubleClick);
            // 
            // cms_pictureOptions
            // 
            this.cms_pictureOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_pictureOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_savePicture});
            this.cms_pictureOptions.Name = "cms_notify";
            this.cms_pictureOptions.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cms_pictureOptions.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cms_pictureOptions.RenderStyle.ColorTable = null;
            this.cms_pictureOptions.RenderStyle.RoundedEdges = true;
            this.cms_pictureOptions.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cms_pictureOptions.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cms_pictureOptions.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cms_pictureOptions.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cms_pictureOptions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cms_pictureOptions.Size = new System.Drawing.Size(159, 28);
            // 
            // tsm_savePicture
            // 
            this.tsm_savePicture.Name = "tsm_savePicture";
            this.tsm_savePicture.Size = new System.Drawing.Size(158, 24);
            this.tsm_savePicture.Text = "Save Picture";
            this.tsm_savePicture.Click += new System.EventHandler(this.tsm_savePicture_Click);
            // 
            // wmp_player
            // 
            this.wmp_player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmp_player.Enabled = true;
            this.wmp_player.Location = new System.Drawing.Point(0, 47);
            this.wmp_player.Name = "wmp_player";
            this.wmp_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_player.OcxState")));
            this.wmp_player.Size = new System.Drawing.Size(683, 377);
            this.wmp_player.TabIndex = 11;
            this.wmp_player.Visible = false;
            this.wmp_player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmp_player_PlayStateChange);
            this.wmp_player.MediaError += new AxWMPLib._WMPOCXEvents_MediaErrorEventHandler(this.wmp_player_MediaError);
            this.wmp_player.DoubleClickEvent += new AxWMPLib._WMPOCXEvents_DoubleClickEventHandler(this.wmp_player_DoubleClickEvent);
            // 
            // pnl_header
            // 
            this.pnl_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_header.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_header.Controls.Add(this.btn_autoPlay);
            this.pnl_header.Controls.Add(this.txt_search);
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Controls.Add(this.label3);
            this.pnl_header.Controls.Add(this.btn_exit);
            this.pnl_header.Controls.Add(this.label5);
            this.pnl_header.Controls.Add(this.btn_minimize);
            this.pnl_header.Controls.Add(this.lbl_status);
            this.pnl_header.Controls.Add(this.btn_about);
            this.pnl_header.Controls.Add(this.lbl_repeat);
            this.pnl_header.Controls.Add(this.pb_icon_header);
            this.pnl_header.Controls.Add(this.lbl_shuffle);
            this.pnl_header.Controls.Add(this.lbl_name_app);
            this.pnl_header.Controls.Add(this.btn_search);
            this.pnl_header.Controls.Add(this.btn_settings);
            this.pnl_header.Controls.Add(this.btn_addfile);
            this.pnl_header.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_header.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1027, 47);
            this.pnl_header.TabIndex = 10;
            this.pnl_header.DoubleClick += new System.EventHandler(this.pnl_header_DoubleClick);
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_background_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_background_MouseMove);
            this.pnl_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_background_MouseUp);
            // 
            // btn_autoPlay
            // 
            this.btn_autoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_autoPlay.Animated = true;
            this.btn_autoPlay.AutoRoundedCorners = true;
            this.btn_autoPlay.BorderColor = System.Drawing.Color.Transparent;
            this.btn_autoPlay.BorderRadius = 13;
            this.btn_autoPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_autoPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_autoPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_autoPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_autoPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_autoPlay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btn_autoPlay.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_autoPlay.ForeColor = System.Drawing.Color.White;
            this.btn_autoPlay.Image = global::MusicPlayer.Properties.Resources.musicAdd;
            this.btn_autoPlay.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btn_autoPlay.Location = new System.Drawing.Point(501, 9);
            this.btn_autoPlay.Name = "btn_autoPlay";
            this.btn_autoPlay.Size = new System.Drawing.Size(154, 29);
            this.btn_autoPlay.TabIndex = 6;
            this.btn_autoPlay.Text = "Autoplay";
            this.btn_autoPlay.Click += new System.EventHandler(this.btn_autoPlay_Click);
            // 
            // txt_search
            // 
            this.txt_search.Animated = true;
            this.txt_search.BorderRadius = 11;
            this.txt_search.BorderThickness = 2;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txt_search.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txt_search.Location = new System.Drawing.Point(433, 10);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.MaxLength = 30;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Search ";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(246, 27);
            this.txt_search.TabIndex = 7;
            this.txt_search.Visible = false;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(308, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status :";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(444, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repeat :";
            this.label3.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_exit.Animated = true;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BorderRadius = 20;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.Empty;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Image = global::MusicPlayer.Properties.Resources.exit1;
            this.btn_exit.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_exit.Location = new System.Drawing.Point(981, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(43, 44);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.headerControls_MouseLeave);
            this.btn_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FocusButtonsControl);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(572, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Shuffle :";
            this.label5.Visible = false;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_minimize.Animated = true;
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BorderRadius = 20;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minimize.FillColor = System.Drawing.Color.Empty;
            this.btn_minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Image = global::MusicPlayer.Properties.Resources.minimize;
            this.btn_minimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_minimize.Location = new System.Drawing.Point(931, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(48, 44);
            this.btn_minimize.TabIndex = 0;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseLeave += new System.EventHandler(this.headerControls_MouseLeave);
            this.btn_minimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FocusButtonsControl);
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(377, 15);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(70, 18);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "None";
            this.lbl_status.Visible = false;
            this.lbl_status.TextChanged += new System.EventHandler(this.lbl_status_TextChanged);
            // 
            // btn_about
            // 
            this.btn_about.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_about.Animated = true;
            this.btn_about.BackColor = System.Drawing.Color.Transparent;
            this.btn_about.BorderRadius = 20;
            this.btn_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_about.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_about.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_about.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_about.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_about.FillColor = System.Drawing.Color.Empty;
            this.btn_about.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Image = global::MusicPlayer.Properties.Resources.about;
            this.btn_about.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_about.Location = new System.Drawing.Point(880, 0);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(45, 46);
            this.btn_about.TabIndex = 0;
            this.btn_about.Tag = "About";
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            this.btn_about.MouseLeave += new System.EventHandler(this.headerControls_MouseLeave);
            this.btn_about.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FocusButtonsControl);
            // 
            // lbl_repeat
            // 
            this.lbl_repeat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_repeat.AutoSize = true;
            this.lbl_repeat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_repeat.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_repeat.Location = new System.Drawing.Point(519, 15);
            this.lbl_repeat.Name = "lbl_repeat";
            this.lbl_repeat.Size = new System.Drawing.Size(31, 18);
            this.lbl_repeat.TabIndex = 2;
            this.lbl_repeat.Text = "Off";
            this.lbl_repeat.Visible = false;
            // 
            // pb_icon_header
            // 
            this.pb_icon_header.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pb_icon_header.BackColor = System.Drawing.Color.Transparent;
            this.pb_icon_header.BorderRadius = 3;
            this.pb_icon_header.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(62)))));
            this.pb_icon_header.Image = global::MusicPlayer.Properties.Resources.iconShow;
            this.pb_icon_header.ImageRotate = 0F;
            this.pb_icon_header.Location = new System.Drawing.Point(12, 5);
            this.pb_icon_header.Name = "pb_icon_header";
            this.pb_icon_header.Size = new System.Drawing.Size(37, 36);
            this.pb_icon_header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icon_header.TabIndex = 5;
            this.pb_icon_header.TabStop = false;
            // 
            // lbl_shuffle
            // 
            this.lbl_shuffle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_shuffle.AutoSize = true;
            this.lbl_shuffle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_shuffle.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_shuffle.Location = new System.Drawing.Point(648, 15);
            this.lbl_shuffle.Name = "lbl_shuffle";
            this.lbl_shuffle.Size = new System.Drawing.Size(31, 18);
            this.lbl_shuffle.TabIndex = 2;
            this.lbl_shuffle.Text = "Off";
            this.lbl_shuffle.Visible = false;
            // 
            // lbl_name_app
            // 
            this.lbl_name_app.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_name_app.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name_app.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_app.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_name_app.Location = new System.Drawing.Point(55, 6);
            this.lbl_name_app.Name = "lbl_name_app";
            this.lbl_name_app.Size = new System.Drawing.Size(331, 35);
            this.lbl_name_app.TabIndex = 1;
            this.lbl_name_app.Text = "MusicPlayer";
            this.lbl_name_app.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name_app.TextChanged += new System.EventHandler(this.lbl_music_name_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Animated = true;
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BorderRadius = 20;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.Transparent;
            this.btn_search.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = global::MusicPlayer.Properties.Resources.search;
            this.btn_search.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_search.Location = new System.Drawing.Point(718, -1);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(48, 47);
            this.btn_search.TabIndex = 0;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.MouseLeave += new System.EventHandler(this.headerControls_MouseLeave);
            this.btn_search.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FocusButtonsControl);
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settings.Animated = true;
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.BorderRadius = 20;
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_settings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_settings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_settings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_settings.FillColor = System.Drawing.Color.Transparent;
            this.btn_settings.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold);
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Image = global::MusicPlayer.Properties.Resources.settings1;
            this.btn_settings.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_settings.Location = new System.Drawing.Point(772, 0);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(48, 47);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            this.btn_settings.MouseLeave += new System.EventHandler(this.headerControls_MouseLeave);
            this.btn_settings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FocusButtonsControl);
            // 
            // btn_addfile
            // 
            this.btn_addfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addfile.Animated = true;
            this.btn_addfile.BackColor = System.Drawing.Color.Transparent;
            this.btn_addfile.BorderRadius = 20;
            this.btn_addfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addfile.FillColor = System.Drawing.Color.Transparent;
            this.btn_addfile.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold);
            this.btn_addfile.ForeColor = System.Drawing.Color.White;
            this.btn_addfile.Image = global::MusicPlayer.Properties.Resources.add;
            this.btn_addfile.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_addfile.Location = new System.Drawing.Point(826, 0);
            this.btn_addfile.Name = "btn_addfile";
            this.btn_addfile.Size = new System.Drawing.Size(48, 47);
            this.btn_addfile.TabIndex = 0;
            this.btn_addfile.Click += new System.EventHandler(this.btn_addfile_Click);
            this.btn_addfile.MouseLeave += new System.EventHandler(this.headerControls_MouseLeave);
            this.btn_addfile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FocusButtonsControl);
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_stop.Animated = true;
            this.btn_stop.AnimatedGIF = true;
            this.btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_stop.BorderRadius = 5;
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_stop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_stop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_stop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_stop.FillColor = System.Drawing.Color.Empty;
            this.btn_stop.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Image = global::MusicPlayer.Properties.Resources.stop;
            this.btn_stop.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_stop.Location = new System.Drawing.Point(345, 489);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(73, 58);
            this.btn_stop.TabIndex = 0;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // tb_volume
            // 
            this.tb_volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_volume.BackColor = System.Drawing.Color.Transparent;
            this.tb_volume.Location = new System.Drawing.Point(752, 507);
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(214, 23);
            this.tb_volume.TabIndex = 4;
            this.tb_volume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tb_volume.Value = 0;
            this.tb_volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tb_volume_Scroll);
            // 
            // tb_music
            // 
            this.tb_music.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_music.BackColor = System.Drawing.Color.Transparent;
            this.tb_music.Location = new System.Drawing.Point(114, 456);
            this.tb_music.Name = "tb_music";
            this.tb_music.Size = new System.Drawing.Size(468, 23);
            this.tb_music.TabIndex = 4;
            this.tb_music.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tb_music.Value = 0;
            this.tb_music.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tb_music_Scroll);
            this.tb_music.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_music_KeyDown);
            this.tb_music.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_music_KeyPress);
            this.tb_music.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_music_KeyUp);
            this.tb_music.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_music_MouseDown);
            this.tb_music.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tb_music_MouseUp);
            // 
            // lbl_music_name
            // 
            this.lbl_music_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_music_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_music_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_music_name.Location = new System.Drawing.Point(211, 435);
            this.lbl_music_name.Name = "lbl_music_name";
            this.lbl_music_name.Size = new System.Drawing.Size(270, 18);
            this.lbl_music_name.TabIndex = 1;
            this.lbl_music_name.Text = "Musicname";
            this.lbl_music_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_music_name.TextChanged += new System.EventHandler(this.lbl_music_name_TextChanged);
            // 
            // btn_shuffle
            // 
            this.btn_shuffle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_shuffle.Animated = true;
            this.btn_shuffle.BackColor = System.Drawing.Color.Transparent;
            this.btn_shuffle.BorderRadius = 5;
            this.btn_shuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_shuffle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_shuffle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_shuffle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_shuffle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_shuffle.FillColor = System.Drawing.Color.Empty;
            this.btn_shuffle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_shuffle.ForeColor = System.Drawing.Color.White;
            this.btn_shuffle.Image = global::MusicPlayer.Properties.Resources.shuffle;
            this.btn_shuffle.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_shuffle.Location = new System.Drawing.Point(114, 490);
            this.btn_shuffle.Name = "btn_shuffle";
            this.btn_shuffle.Size = new System.Drawing.Size(62, 57);
            this.btn_shuffle.TabIndex = 0;
            this.btn_shuffle.Click += new System.EventHandler(this.btn_shuffle_Click);
            // 
            // btn_mute_volume
            // 
            this.btn_mute_volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mute_volume.Animated = true;
            this.btn_mute_volume.BackColor = System.Drawing.Color.Transparent;
            this.btn_mute_volume.BorderRadius = 5;
            this.btn_mute_volume.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_mute_volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mute_volume.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_mute_volume.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_mute_volume.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_mute_volume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_mute_volume.FillColor = System.Drawing.Color.Empty;
            this.btn_mute_volume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_mute_volume.ForeColor = System.Drawing.Color.White;
            this.btn_mute_volume.Image = global::MusicPlayer.Properties.Resources.high_volume;
            this.btn_mute_volume.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_mute_volume.Location = new System.Drawing.Point(684, 490);
            this.btn_mute_volume.Name = "btn_mute_volume";
            this.btn_mute_volume.Size = new System.Drawing.Size(62, 57);
            this.btn_mute_volume.TabIndex = 0;
            this.btn_mute_volume.Tag = "";
            this.btn_mute_volume.Click += new System.EventHandler(this.btn_mute_volume_Click);
            // 
            // btn_repeat
            // 
            this.btn_repeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_repeat.Animated = true;
            this.btn_repeat.BackColor = System.Drawing.Color.Transparent;
            this.btn_repeat.BorderRadius = 5;
            this.btn_repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_repeat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_repeat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_repeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_repeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_repeat.FillColor = System.Drawing.Color.Empty;
            this.btn_repeat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_repeat.ForeColor = System.Drawing.Color.White;
            this.btn_repeat.Image = global::MusicPlayer.Properties.Resources.repeat;
            this.btn_repeat.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_repeat.Location = new System.Drawing.Point(510, 489);
            this.btn_repeat.Name = "btn_repeat";
            this.btn_repeat.Size = new System.Drawing.Size(62, 57);
            this.btn_repeat.TabIndex = 0;
            this.btn_repeat.Click += new System.EventHandler(this.btn_repeat_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_next.Animated = true;
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.BorderRadius = 5;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_next.FillColor = System.Drawing.Color.Empty;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Image = global::MusicPlayer.Properties.Resources.next;
            this.btn_next.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_next.Location = new System.Drawing.Point(433, 489);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(62, 57);
            this.btn_next.TabIndex = 0;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_previous.Animated = true;
            this.btn_previous.BackColor = System.Drawing.Color.Transparent;
            this.btn_previous.BorderRadius = 5;
            this.btn_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_previous.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_previous.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_previous.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_previous.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_previous.FillColor = System.Drawing.Color.Empty;
            this.btn_previous.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.Image = global::MusicPlayer.Properties.Resources.previous;
            this.btn_previous.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_previous.Location = new System.Drawing.Point(191, 490);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(62, 57);
            this.btn_previous.TabIndex = 0;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // lbl_timestamp
            // 
            this.lbl_timestamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_timestamp.AutoSize = true;
            this.lbl_timestamp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_timestamp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_timestamp.Location = new System.Drawing.Point(56, 461);
            this.lbl_timestamp.Name = "lbl_timestamp";
            this.lbl_timestamp.Size = new System.Drawing.Size(52, 18);
            this.lbl_timestamp.TabIndex = 2;
            this.lbl_timestamp.Text = "00:00";
            // 
            // lbl_valueVolume
            // 
            this.lbl_valueVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_valueVolume.BackColor = System.Drawing.Color.Transparent;
            this.lbl_valueVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_valueVolume.Location = new System.Drawing.Point(972, 512);
            this.lbl_valueVolume.Name = "lbl_valueVolume";
            this.lbl_valueVolume.Size = new System.Drawing.Size(52, 18);
            this.lbl_valueVolume.TabIndex = 2;
            this.lbl_valueVolume.Text = "%0";
            // 
            // lbl_total_time
            // 
            this.lbl_total_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total_time.AutoSize = true;
            this.lbl_total_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_total_time.Location = new System.Drawing.Point(588, 461);
            this.lbl_total_time.Name = "lbl_total_time";
            this.lbl_total_time.Size = new System.Drawing.Size(52, 18);
            this.lbl_total_time.TabIndex = 2;
            this.lbl_total_time.Text = "00:00";
            // 
            // btn_play_pause
            // 
            this.btn_play_pause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_play_pause.Animated = true;
            this.btn_play_pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_play_pause.BorderRadius = 5;
            this.btn_play_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play_pause.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.btn_play_pause.FillColor = System.Drawing.Color.Empty;
            this.btn_play_pause.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_play_pause.ForeColor = System.Drawing.Color.White;
            this.btn_play_pause.Image = global::MusicPlayer.Properties.Resources.play;
            this.btn_play_pause.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_play_pause.Location = new System.Drawing.Point(268, 490);
            this.btn_play_pause.Name = "btn_play_pause";
            this.btn_play_pause.Size = new System.Drawing.Size(62, 57);
            this.btn_play_pause.TabIndex = 0;
            this.btn_play_pause.Click += new System.EventHandler(this.btn_play_pause_Click);
            // 
            // rb_form
            // 
            this.rb_form.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rb_form.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.rb_form.ForeColor = System.Drawing.Color.Black;
            this.rb_form.Location = new System.Drawing.Point(1000, 537);
            this.rb_form.Name = "rb_form";
            this.rb_form.Size = new System.Drawing.Size(27, 29);
            this.rb_form.TabIndex = 2;
            this.rb_form.TargetControl = this;
            // 
            // pnl_background
            // 
            this.pnl_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.pnl_background.Controls.Add(this.pnl_music_main);
            this.pnl_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_background.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnl_background.Location = new System.Drawing.Point(0, 0);
            this.pnl_background.Name = "pnl_background";
            this.pnl_background.Size = new System.Drawing.Size(1027, 566);
            this.pnl_background.TabIndex = 0;
            this.pnl_background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_background_MouseDown);
            this.pnl_background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_background_MouseMove);
            this.pnl_background.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_background_MouseUp);
            // 
            // ni_notify
            // 
            this.ni_notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ni_notify.BalloonTipText = "Playing Music";
            this.ni_notify.BalloonTipTitle = "MusicPlayer Minimized";
            this.ni_notify.ContextMenuStrip = this.cms_notify;
            this.ni_notify.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_notify.Icon")));
            this.ni_notify.Text = "Status MusicPlayer\r\nRight Click For See";
            this.ni_notify.Visible = true;
            this.ni_notify.DoubleClick += new System.EventHandler(this.ni_notify_DoubleClick);
            // 
            // cms_notify
            // 
            this.cms_notify.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_notify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_musicplayer_text,
            this.tsm_status,
            this.tsm_name_song,
            this.tsm_exit});
            this.cms_notify.Name = "cms_notify";
            this.cms_notify.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cms_notify.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cms_notify.RenderStyle.ColorTable = null;
            this.cms_notify.RenderStyle.RoundedEdges = true;
            this.cms_notify.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cms_notify.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cms_notify.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cms_notify.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cms_notify.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cms_notify.Size = new System.Drawing.Size(191, 108);
            // 
            // tsm_musicplayer_text
            // 
            this.tsm_musicplayer_text.Image = global::MusicPlayer.Properties.Resources.music_png_6108;
            this.tsm_musicplayer_text.Name = "tsm_musicplayer_text";
            this.tsm_musicplayer_text.Size = new System.Drawing.Size(190, 26);
            this.tsm_musicplayer_text.Text = "MusicPlayer";
            // 
            // tsm_status
            // 
            this.tsm_status.Name = "tsm_status";
            this.tsm_status.Size = new System.Drawing.Size(190, 26);
            this.tsm_status.Text = "Status : Stopped";
            // 
            // tsm_name_song
            // 
            this.tsm_name_song.Name = "tsm_name_song";
            this.tsm_name_song.Size = new System.Drawing.Size(190, 26);
            this.tsm_name_song.Text = "Song : None";
            // 
            // tsm_exit
            // 
            this.tsm_exit.Name = "tsm_exit";
            this.tsm_exit.Size = new System.Drawing.Size(190, 26);
            this.tsm_exit.Text = "Exit";
            this.tsm_exit.Click += new System.EventHandler(this.tsm_exit_Click);
            // 
            // tt_listbox
            // 
            this.tt_listbox.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_listbox.ToolTipTitle = "Count Songs";
            // 
            // timer_controls
            // 
            this.timer_controls.Enabled = true;
            this.timer_controls.Interval = 500;
            this.timer_controls.Tick += new System.EventHandler(this.timer_controls_Tick);
            // 
            // tt_downloader
            // 
            this.tt_downloader.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_downloader.ToolTipTitle = "Downloader";
            // 
            // frm_musicplayer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 566);
            this.Controls.Add(this.pnl_background);
            this.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(846, 513);
            this.Name = "frm_musicplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.SizeChanged += new System.EventHandler(this.frm_main_SizeChanged);
            this.pnl_music_main.ResumeLayout(false);
            this.pnl_music_main.PerformLayout();
            this.cms_list_musics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_big_image_music)).EndInit();
            this.cms_pictureOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmp_player)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_header)).EndInit();
            this.pnl_background.ResumeLayout(false);
            this.cms_notify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog opd_addmusic;
        private Guna.UI2.WinForms.Guna2BorderlessForm blf_frm_main;
        private System.Windows.Forms.Timer timer_time_muic;
        private Guna.UI2.WinForms.Guna2Panel pnl_background;
        private Guna.UI2.WinForms.Guna2Panel pnl_music_main;
        private Guna.UI2.WinForms.Guna2Button btn_stop;
        private Guna.UI2.WinForms.Guna2Button btn_shuffle;
        private Guna.UI2.WinForms.Guna2Button btn_repeat;
        private Guna.UI2.WinForms.Guna2Button btn_next;
        private Guna.UI2.WinForms.Guna2Button btn_previous;
        private System.Windows.Forms.Label lbl_timestamp;
        private System.Windows.Forms.Label lbl_total_time;
        private Guna.UI2.WinForms.Guna2Button btn_play_pause;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cms_list_musics;
        private System.Windows.Forms.ToolStripMenuItem ltsm_clear;
        private Guna.UI2.WinForms.Guna2PictureBox pb_icon_header;
        private Guna.UI2.WinForms.Guna2Button btn_mute_volume;
        private Guna.UI2.WinForms.Guna2PictureBox pb_big_image_music;
        private Guna.UI2.WinForms.Guna2ResizeBox rb_form;
        private System.Windows.Forms.NotifyIcon ni_notify;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cms_notify;
        private System.Windows.Forms.ToolStripMenuItem tsm_musicplayer_text;
        private System.Windows.Forms.ToolStripMenuItem tsm_name_song;
        private System.Windows.Forms.ToolStripMenuItem tsm_status;
        private System.Windows.Forms.ToolStripMenuItem tsm_exit;
        private MaterialSkin.Controls.MaterialListBox lb_musics;
        private System.Windows.Forms.ToolTip tt_listbox;
        private System.Windows.Forms.Timer timer_controls;
        private System.Windows.Forms.ToolStripMenuItem tsm_loadFavorites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_repeat;
        private System.Windows.Forms.Label lbl_shuffle;
        private System.Windows.Forms.ToolTip tt_downloader;
        public System.Windows.Forms.Panel pnl_listMusics;
        public AxWMPLib.AxWindowsMediaPlayer wmp_player;
        private Guna.UI2.WinForms.Guna2Button btn_autoPlay;
        private System.Windows.Forms.Label lbl_valueVolume;
        private Guna.UI2.WinForms.Guna2TrackBar tb_music;
        public System.Windows.Forms.Label lbl_music_name;
        public Guna.UI2.WinForms.Guna2Panel pnl_header;
        public Guna.UI2.WinForms.Guna2Button btn_addfile;
        public Guna.UI2.WinForms.Guna2Button btn_minimize;
        public Guna.UI2.WinForms.Guna2Button btn_exit;
        public Guna.UI2.WinForms.Guna2Button btn_about;
        public Guna.UI2.WinForms.Guna2Button btn_settings;
        private System.Windows.Forms.ToolStripMenuItem tsm_info;
        public System.Windows.Forms.Label lbl_name_app;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cms_pictureOptions;
        private System.Windows.Forms.ToolStripMenuItem tsm_savePicture;
        public Guna.UI2.WinForms.Guna2Panel pnl_formSetting;
        private Guna.UI2.WinForms.Guna2TrackBar tb_volume;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        public Guna.UI2.WinForms.Guna2Button btn_search;
    }
}

