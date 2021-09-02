
namespace MusicPlayer
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pnl_background = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_musics = new System.Windows.Forms.ListBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_play_url = new Guna.UI2.WinForms.Guna2Button();
            this.btn_download = new Guna.UI2.WinForms.Guna2Button();
            this.txt_url_music = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_volume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lbl_shuffle = new System.Windows.Forms.Label();
            this.lbl_repeat = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_options = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_play = new Guna.UI2.WinForms.Guna2Button();
            this.btn_stop = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_music_main = new Guna.UI2.WinForms.Guna2Panel();
            this.tb_music = new Guna.UI2.WinForms.Guna2TrackBar();
            this.pb_image_music = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_music_name = new System.Windows.Forms.Label();
            this.btn_shuffle = new Guna.UI2.WinForms.Guna2Button();
            this.btn_repeat = new Guna.UI2.WinForms.Guna2Button();
            this.btn_next = new Guna.UI2.WinForms.Guna2Button();
            this.btn_previous = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addfile = new Guna.UI2.WinForms.Guna2Button();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_play_pause = new Guna.UI2.WinForms.Guna2Button();
            this.opd_addmusic = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer_repeat = new System.Windows.Forms.Timer(this.components);
            this.pnl_background.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnl_options.SuspendLayout();
            this.pnl_music_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image_music)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_background
            // 
            this.pnl_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.pnl_background.Controls.Add(this.lb_musics);
            this.pnl_background.Controls.Add(this.guna2Panel1);
            this.pnl_background.Controls.Add(this.tb_volume);
            this.pnl_background.Controls.Add(this.lbl_shuffle);
            this.pnl_background.Controls.Add(this.lbl_repeat);
            this.pnl_background.Controls.Add(this.lbl_status);
            this.pnl_background.Controls.Add(this.label5);
            this.pnl_background.Controls.Add(this.label3);
            this.pnl_background.Controls.Add(this.label2);
            this.pnl_background.Controls.Add(this.label1);
            this.pnl_background.Controls.Add(this.pnl_options);
            this.pnl_background.Controls.Add(this.pnl_music_main);
            this.pnl_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_background.Location = new System.Drawing.Point(0, 0);
            this.pnl_background.Name = "pnl_background";
            this.pnl_background.ShadowDecoration.Parent = this.pnl_background;
            this.pnl_background.Size = new System.Drawing.Size(826, 437);
            this.pnl_background.TabIndex = 0;
            // 
            // lb_musics
            // 
            this.lb_musics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(124)))), ((int)(((byte)(115)))));
            this.lb_musics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_musics.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_musics.FormattingEnabled = true;
            this.lb_musics.HorizontalScrollbar = true;
            this.lb_musics.ItemHeight = 18;
            this.lb_musics.Location = new System.Drawing.Point(412, 116);
            this.lb_musics.Name = "lb_musics";
            this.lb_musics.Size = new System.Drawing.Size(402, 162);
            this.lb_musics.TabIndex = 6;
            this.lb_musics.SelectedIndexChanged += new System.EventHandler(this.lb_musics_SelectedIndexChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.btn_clear);
            this.guna2Panel1.Controls.Add(this.btn_play_url);
            this.guna2Panel1.Controls.Add(this.btn_download);
            this.guna2Panel1.Controls.Add(this.txt_url_music);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.guna2Panel1.Location = new System.Drawing.Point(412, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(402, 95);
            this.guna2Panel1.TabIndex = 7;
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.AnimatedGIF = true;
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BorderColor = System.Drawing.Color.Transparent;
            this.btn_clear.BorderRadius = 16;
            this.btn_clear.CheckedState.Parent = this.btn_clear;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.CustomImages.Parent = this.btn_clear;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.DisabledState.Parent = this.btn_clear;
            this.btn_clear.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_clear.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.Parent = this.btn_clear;
            this.btn_clear.Location = new System.Drawing.Point(245, 56);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(114, 36);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "Clear List";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_play_url
            // 
            this.btn_play_url.Animated = true;
            this.btn_play_url.AnimatedGIF = true;
            this.btn_play_url.BackColor = System.Drawing.Color.Transparent;
            this.btn_play_url.BorderColor = System.Drawing.Color.Transparent;
            this.btn_play_url.BorderRadius = 16;
            this.btn_play_url.CheckedState.Parent = this.btn_play_url;
            this.btn_play_url.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play_url.CustomImages.Parent = this.btn_play_url;
            this.btn_play_url.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_play_url.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_play_url.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_play_url.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_play_url.DisabledState.Parent = this.btn_play_url;
            this.btn_play_url.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_play_url.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play_url.ForeColor = System.Drawing.Color.White;
            this.btn_play_url.HoverState.Parent = this.btn_play_url;
            this.btn_play_url.Location = new System.Drawing.Point(125, 56);
            this.btn_play_url.Name = "btn_play_url";
            this.btn_play_url.ShadowDecoration.Parent = this.btn_play_url;
            this.btn_play_url.Size = new System.Drawing.Size(114, 36);
            this.btn_play_url.TabIndex = 0;
            this.btn_play_url.Text = "Play Now";
            this.btn_play_url.Click += new System.EventHandler(this.btn_play_url_Click);
            // 
            // btn_download
            // 
            this.btn_download.Animated = true;
            this.btn_download.AnimatedGIF = true;
            this.btn_download.BackColor = System.Drawing.Color.Transparent;
            this.btn_download.BorderColor = System.Drawing.Color.Transparent;
            this.btn_download.BorderRadius = 16;
            this.btn_download.CheckedState.Parent = this.btn_download;
            this.btn_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_download.CustomImages.Parent = this.btn_download;
            this.btn_download.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_download.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_download.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_download.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_download.DisabledState.Parent = this.btn_download;
            this.btn_download.Enabled = false;
            this.btn_download.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_download.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.ForeColor = System.Drawing.Color.White;
            this.btn_download.HoverState.Parent = this.btn_download;
            this.btn_download.Location = new System.Drawing.Point(5, 56);
            this.btn_download.Name = "btn_download";
            this.btn_download.ShadowDecoration.Parent = this.btn_download;
            this.btn_download.Size = new System.Drawing.Size(114, 36);
            this.btn_download.TabIndex = 0;
            this.btn_download.Text = "Download";
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // txt_url_music
            // 
            this.txt_url_music.BackColor = System.Drawing.Color.Transparent;
            this.txt_url_music.BorderRadius = 15;
            this.txt_url_music.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_url_music.DefaultText = "";
            this.txt_url_music.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_url_music.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_url_music.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_url_music.DisabledState.Parent = this.txt_url_music;
            this.txt_url_music.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_url_music.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_url_music.FocusedState.Parent = this.txt_url_music;
            this.txt_url_music.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_url_music.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_url_music.HoverState.Parent = this.txt_url_music;
            this.txt_url_music.Location = new System.Drawing.Point(5, 14);
            this.txt_url_music.Name = "txt_url_music";
            this.txt_url_music.PasswordChar = '\0';
            this.txt_url_music.PlaceholderText = "URL Audio";
            this.txt_url_music.SelectedText = "";
            this.txt_url_music.ShadowDecoration.Parent = this.txt_url_music;
            this.txt_url_music.Size = new System.Drawing.Size(389, 36);
            this.txt_url_music.TabIndex = 5;
            // 
            // tb_volume
            // 
            this.tb_volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tb_volume.HoverState.Parent = this.tb_volume;
            this.tb_volume.Location = new System.Drawing.Point(515, 348);
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(281, 23);
            this.tb_volume.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.tb_volume.TabIndex = 4;
            this.tb_volume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tb_volume.Value = 10;
            this.tb_volume.ValueChanged += new System.EventHandler(this.tb_volume_ValueChanged);
            // 
            // lbl_shuffle
            // 
            this.lbl_shuffle.AutoSize = true;
            this.lbl_shuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbl_shuffle.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_shuffle.Location = new System.Drawing.Point(768, 397);
            this.lbl_shuffle.Name = "lbl_shuffle";
            this.lbl_shuffle.Size = new System.Drawing.Size(31, 18);
            this.lbl_shuffle.TabIndex = 2;
            this.lbl_shuffle.Text = "Off";
            // 
            // lbl_repeat
            // 
            this.lbl_repeat.AutoSize = true;
            this.lbl_repeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbl_repeat.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_repeat.Location = new System.Drawing.Point(644, 397);
            this.lbl_repeat.Name = "lbl_repeat";
            this.lbl_repeat.Size = new System.Drawing.Size(31, 18);
            this.lbl_repeat.TabIndex = 2;
            this.lbl_repeat.Text = "Off";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(504, 397);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(47, 18);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(694, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Shuffle :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(571, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repeat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(437, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Volume :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(437, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status :";
            // 
            // pnl_options
            // 
            this.pnl_options.BackColor = System.Drawing.Color.Transparent;
            this.pnl_options.BorderRadius = 10;
            this.pnl_options.Controls.Add(this.btn_play);
            this.pnl_options.Controls.Add(this.btn_stop);
            this.pnl_options.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnl_options.Location = new System.Drawing.Point(412, 287);
            this.pnl_options.Name = "pnl_options";
            this.pnl_options.ShadowDecoration.Parent = this.pnl_options;
            this.pnl_options.Size = new System.Drawing.Size(402, 138);
            this.pnl_options.TabIndex = 1;
            // 
            // btn_play
            // 
            this.btn_play.Animated = true;
            this.btn_play.AnimatedGIF = true;
            this.btn_play.BorderRadius = 20;
            this.btn_play.CheckedState.Parent = this.btn_play;
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.CustomImages.Parent = this.btn_play;
            this.btn_play.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_play.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_play.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_play.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_play.DisabledState.Parent = this.btn_play;
            this.btn_play.FillColor = System.Drawing.Color.Coral;
            this.btn_play.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.HoverState.Parent = this.btn_play;
            this.btn_play.Location = new System.Drawing.Point(28, 10);
            this.btn_play.Name = "btn_play";
            this.btn_play.ShadowDecoration.Parent = this.btn_play;
            this.btn_play.Size = new System.Drawing.Size(175, 39);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "PLAY";
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Animated = true;
            this.btn_stop.AnimatedGIF = true;
            this.btn_stop.BorderRadius = 20;
            this.btn_stop.CheckedState.Parent = this.btn_stop;
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.CustomImages.Parent = this.btn_stop;
            this.btn_stop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_stop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_stop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_stop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_stop.DisabledState.Parent = this.btn_stop;
            this.btn_stop.FillColor = System.Drawing.Color.Coral;
            this.btn_stop.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.HoverState.Parent = this.btn_stop;
            this.btn_stop.Location = new System.Drawing.Point(212, 10);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.ShadowDecoration.Parent = this.btn_stop;
            this.btn_stop.Size = new System.Drawing.Size(175, 39);
            this.btn_stop.TabIndex = 0;
            this.btn_stop.Text = "STOP";
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // pnl_music_main
            // 
            this.pnl_music_main.BackColor = System.Drawing.Color.Transparent;
            this.pnl_music_main.BorderRadius = 10;
            this.pnl_music_main.Controls.Add(this.tb_music);
            this.pnl_music_main.Controls.Add(this.pb_image_music);
            this.pnl_music_main.Controls.Add(this.lbl_description);
            this.pnl_music_main.Controls.Add(this.lbl_music_name);
            this.pnl_music_main.Controls.Add(this.btn_shuffle);
            this.pnl_music_main.Controls.Add(this.btn_repeat);
            this.pnl_music_main.Controls.Add(this.btn_next);
            this.pnl_music_main.Controls.Add(this.btn_previous);
            this.pnl_music_main.Controls.Add(this.btn_addfile);
            this.pnl_music_main.Controls.Add(this.btn_exit);
            this.pnl_music_main.Controls.Add(this.btn_play_pause);
            this.pnl_music_main.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnl_music_main.Location = new System.Drawing.Point(12, 12);
            this.pnl_music_main.Name = "pnl_music_main";
            this.pnl_music_main.ShadowDecoration.Parent = this.pnl_music_main;
            this.pnl_music_main.Size = new System.Drawing.Size(387, 413);
            this.pnl_music_main.TabIndex = 1;
            // 
            // tb_music
            // 
            this.tb_music.HoverState.Parent = this.tb_music;
            this.tb_music.Location = new System.Drawing.Point(0, 285);
            this.tb_music.Name = "tb_music";
            this.tb_music.Size = new System.Drawing.Size(384, 23);
            this.tb_music.TabIndex = 4;
            this.tb_music.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tb_music.Value = 0;
            // 
            // pb_image_music
            // 
            this.pb_image_music.FillColor = System.Drawing.Color.Transparent;
            this.pb_image_music.Image = ((System.Drawing.Image)(resources.GetObject("pb_image_music.Image")));
            this.pb_image_music.ImageRotate = 0F;
            this.pb_image_music.Location = new System.Drawing.Point(96, 74);
            this.pb_image_music.Name = "pb_image_music";
            this.pb_image_music.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pb_image_music.ShadowDecoration.Parent = this.pb_image_music;
            this.pb_image_music.Size = new System.Drawing.Size(189, 183);
            this.pb_image_music.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image_music.TabIndex = 2;
            this.pb_image_music.TabStop = false;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_description.Location = new System.Drawing.Point(147, 45);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(91, 18);
            this.lbl_description.TabIndex = 1;
            this.lbl_description.Text = "Description";
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_music_name
            // 
            this.lbl_music_name.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_music_name.Location = new System.Drawing.Point(59, 14);
            this.lbl_music_name.Name = "lbl_music_name";
            this.lbl_music_name.Size = new System.Drawing.Size(270, 18);
            this.lbl_music_name.TabIndex = 1;
            this.lbl_music_name.Text = "Musicname";
            this.lbl_music_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_shuffle
            // 
            this.btn_shuffle.Animated = true;
            this.btn_shuffle.CheckedState.Parent = this.btn_shuffle;
            this.btn_shuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_shuffle.CustomImages.Parent = this.btn_shuffle;
            this.btn_shuffle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_shuffle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_shuffle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_shuffle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_shuffle.DisabledState.Parent = this.btn_shuffle;
            this.btn_shuffle.FillColor = System.Drawing.Color.Empty;
            this.btn_shuffle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_shuffle.ForeColor = System.Drawing.Color.White;
            this.btn_shuffle.HoverState.Parent = this.btn_shuffle;
            this.btn_shuffle.Image = ((System.Drawing.Image)(resources.GetObject("btn_shuffle.Image")));
            this.btn_shuffle.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_shuffle.Location = new System.Drawing.Point(4, 336);
            this.btn_shuffle.Name = "btn_shuffle";
            this.btn_shuffle.ShadowDecoration.Parent = this.btn_shuffle;
            this.btn_shuffle.Size = new System.Drawing.Size(62, 57);
            this.btn_shuffle.TabIndex = 0;
            this.btn_shuffle.Click += new System.EventHandler(this.btn_shuffle_Click);
            // 
            // btn_repeat
            // 
            this.btn_repeat.Animated = true;
            this.btn_repeat.CheckedState.Parent = this.btn_repeat;
            this.btn_repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_repeat.CustomImages.Parent = this.btn_repeat;
            this.btn_repeat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_repeat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_repeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_repeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_repeat.DisabledState.Parent = this.btn_repeat;
            this.btn_repeat.FillColor = System.Drawing.Color.Empty;
            this.btn_repeat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_repeat.ForeColor = System.Drawing.Color.White;
            this.btn_repeat.HoverState.Parent = this.btn_repeat;
            this.btn_repeat.Image = ((System.Drawing.Image)(resources.GetObject("btn_repeat.Image")));
            this.btn_repeat.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_repeat.Location = new System.Drawing.Point(320, 336);
            this.btn_repeat.Name = "btn_repeat";
            this.btn_repeat.ShadowDecoration.Parent = this.btn_repeat;
            this.btn_repeat.Size = new System.Drawing.Size(62, 57);
            this.btn_repeat.TabIndex = 0;
            this.btn_repeat.Click += new System.EventHandler(this.btn_repeat_Click);
            // 
            // btn_next
            // 
            this.btn_next.Animated = true;
            this.btn_next.CheckedState.Parent = this.btn_next;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.CustomImages.Parent = this.btn_next;
            this.btn_next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_next.DisabledState.Parent = this.btn_next;
            this.btn_next.FillColor = System.Drawing.Color.Empty;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.HoverState.Parent = this.btn_next;
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_next.Location = new System.Drawing.Point(252, 336);
            this.btn_next.Name = "btn_next";
            this.btn_next.ShadowDecoration.Parent = this.btn_next;
            this.btn_next.Size = new System.Drawing.Size(62, 57);
            this.btn_next.TabIndex = 0;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Animated = true;
            this.btn_previous.CheckedState.Parent = this.btn_previous;
            this.btn_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_previous.CustomImages.Parent = this.btn_previous;
            this.btn_previous.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_previous.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_previous.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_previous.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_previous.DisabledState.Parent = this.btn_previous;
            this.btn_previous.FillColor = System.Drawing.Color.Empty;
            this.btn_previous.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.HoverState.Parent = this.btn_previous;
            this.btn_previous.Image = ((System.Drawing.Image)(resources.GetObject("btn_previous.Image")));
            this.btn_previous.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_previous.Location = new System.Drawing.Point(71, 336);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.ShadowDecoration.Parent = this.btn_previous;
            this.btn_previous.Size = new System.Drawing.Size(62, 57);
            this.btn_previous.TabIndex = 0;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_addfile
            // 
            this.btn_addfile.Animated = true;
            this.btn_addfile.CheckedState.Parent = this.btn_addfile;
            this.btn_addfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addfile.CustomImages.Parent = this.btn_addfile;
            this.btn_addfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addfile.DisabledState.Parent = this.btn_addfile;
            this.btn_addfile.FillColor = System.Drawing.Color.Empty;
            this.btn_addfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addfile.ForeColor = System.Drawing.Color.White;
            this.btn_addfile.HoverState.Parent = this.btn_addfile;
            this.btn_addfile.Image = ((System.Drawing.Image)(resources.GetObject("btn_addfile.Image")));
            this.btn_addfile.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_addfile.Location = new System.Drawing.Point(6, 6);
            this.btn_addfile.Name = "btn_addfile";
            this.btn_addfile.ShadowDecoration.Parent = this.btn_addfile;
            this.btn_addfile.Size = new System.Drawing.Size(31, 34);
            this.btn_addfile.TabIndex = 0;
            this.btn_addfile.Click += new System.EventHandler(this.btn_addfile_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Animated = true;
            this.btn_exit.CheckedState.Parent = this.btn_exit;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.CustomImages.Parent = this.btn_exit;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.DisabledState.Parent = this.btn_exit;
            this.btn_exit.FillColor = System.Drawing.Color.Empty;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.HoverState.Parent = this.btn_exit;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_exit.Location = new System.Drawing.Point(353, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Parent = this.btn_exit;
            this.btn_exit.Size = new System.Drawing.Size(31, 34);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_play_pause
            // 
            this.btn_play_pause.Animated = true;
            this.btn_play_pause.CheckedState.Parent = this.btn_play_pause;
            this.btn_play_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play_pause.CustomImages.Parent = this.btn_play_pause;
            this.btn_play_pause.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_play_pause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_play_pause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_play_pause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_play_pause.DisabledState.Parent = this.btn_play_pause;
            this.btn_play_pause.FillColor = System.Drawing.Color.Empty;
            this.btn_play_pause.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_play_pause.ForeColor = System.Drawing.Color.White;
            this.btn_play_pause.HoverState.Parent = this.btn_play_pause;
            this.btn_play_pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_play_pause.Image")));
            this.btn_play_pause.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_play_pause.Location = new System.Drawing.Point(162, 336);
            this.btn_play_pause.Name = "btn_play_pause";
            this.btn_play_pause.ShadowDecoration.Parent = this.btn_play_pause;
            this.btn_play_pause.Size = new System.Drawing.Size(62, 57);
            this.btn_play_pause.TabIndex = 0;
            this.btn_play_pause.Click += new System.EventHandler(this.btn_play_pause_Click);
            // 
            // opd_addmusic
            // 
            this.opd_addmusic.FileName = "Music";
            this.opd_addmusic.Multiselect = true;
            this.opd_addmusic.Title = "Select Music";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer_repeat
            // 
            this.timer_repeat.Interval = 1000;
            this.timer_repeat.Tick += new System.EventHandler(this.timer_repeat_Tick);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 437);
            this.Controls.Add(this.pnl_background);
            this.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.pnl_background.ResumeLayout(false);
            this.pnl_background.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.pnl_options.ResumeLayout(false);
            this.pnl_music_main.ResumeLayout(false);
            this.pnl_music_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image_music)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_background;
        private Guna.UI2.WinForms.Guna2Panel pnl_music_main;
        private Guna.UI2.WinForms.Guna2Button btn_play_pause;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_addfile;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_music_name;
        private Guna.UI2.WinForms.Guna2Button btn_next;
        private Guna.UI2.WinForms.Guna2Button btn_previous;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pb_image_music;
        private Guna.UI2.WinForms.Guna2Button btn_shuffle;
        private Guna.UI2.WinForms.Guna2Button btn_repeat;
        private System.Windows.Forms.OpenFileDialog opd_addmusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_shuffle;
        private System.Windows.Forms.Label lbl_repeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TrackBar tb_music;
        private Guna.UI2.WinForms.Guna2TrackBar tb_volume;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel pnl_options;
        private Guna.UI2.WinForms.Guna2Button btn_play;
        private Guna.UI2.WinForms.Guna2Button btn_stop;
        private Guna.UI2.WinForms.Guna2TextBox txt_url_music;
        private Guna.UI2.WinForms.Guna2Button btn_download;
        private Guna.UI2.WinForms.Guna2Button btn_play_url;
        private System.Windows.Forms.ListBox lb_musics;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer_repeat;
    }
}

