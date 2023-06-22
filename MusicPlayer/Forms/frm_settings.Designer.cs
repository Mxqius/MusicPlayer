namespace MusicPlayer.Forms
{
    partial class frm_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_settings));
            this.pnl_parent = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_loading = new Guna.UI2.WinForms.Guna2Panel();
            this.wpi_progress = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.pnl_preview = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_header = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_exitP = new Guna.UI2.WinForms.Guna2Button();
            this.btn_minimizeP = new Guna.UI2.WinForms.Guna2Button();
            this.btn_aboutP = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addP = new Guna.UI2.WinForms.Guna2Button();
            this.btn_settingP = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_titleFormMusic = new System.Windows.Forms.Label();
            this.lbl_beta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_tools = new Guna.UI2.WinForms.Guna2Panel();
            this.cb_theme = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_default = new Guna.UI2.WinForms.Guna2Button();
            this.btn_saveChanges = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updateApp = new Guna.UI2.WinForms.Guna2Button();
            this.btn_font = new Guna.UI2.WinForms.Guna2Button();
            this.btn_colorText = new Guna.UI2.WinForms.Guna2Button();
            this.btn_color = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.bf_form = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_stop = new Guna.UI2.WinForms.Guna2Button();
            this.tb_music = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lbl_music_name = new System.Windows.Forms.Label();
            this.btn_shuffle = new Guna.UI2.WinForms.Guna2Button();
            this.btn_repeat = new Guna.UI2.WinForms.Guna2Button();
            this.btn_next = new Guna.UI2.WinForms.Guna2Button();
            this.btn_previous = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_timestamp = new System.Windows.Forms.Label();
            this.lbl_total_time = new System.Windows.Forms.Label();
            this.btn_play_pause = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_parent.SuspendLayout();
            this.pnl_loading.SuspendLayout();
            this.pnl_preview.SuspendLayout();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnl_tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_parent
            // 
            this.pnl_parent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_parent.Controls.Add(this.pnl_loading);
            this.pnl_parent.Controls.Add(this.pnl_preview);
            this.pnl_parent.Controls.Add(this.lbl_beta);
            this.pnl_parent.Controls.Add(this.label2);
            this.pnl_parent.Controls.Add(this.pnl_tools);
            this.pnl_parent.Controls.Add(this.btn_exit);
            this.pnl_parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_parent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnl_parent.Location = new System.Drawing.Point(0, 0);
            this.pnl_parent.Name = "pnl_parent";
            this.pnl_parent.Size = new System.Drawing.Size(1027, 522);
            this.pnl_parent.TabIndex = 0;
            // 
            // pnl_loading
            // 
            this.pnl_loading.Controls.Add(this.wpi_progress);
            this.pnl_loading.Controls.Add(this.lbl_loading);
            this.pnl_loading.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnl_loading.Location = new System.Drawing.Point(204, 109);
            this.pnl_loading.Name = "pnl_loading";
            this.pnl_loading.Size = new System.Drawing.Size(811, 387);
            this.pnl_loading.TabIndex = 7;
            // 
            // wpi_progress
            // 
            this.wpi_progress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wpi_progress.AutoStart = true;
            this.wpi_progress.BackColor = System.Drawing.Color.Transparent;
            this.wpi_progress.Location = new System.Drawing.Point(357, 133);
            this.wpi_progress.Name = "wpi_progress";
            this.wpi_progress.NumberOfCircles = 9;
            this.wpi_progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.wpi_progress.Size = new System.Drawing.Size(90, 90);
            this.wpi_progress.TabIndex = 1;
            // 
            // lbl_loading
            // 
            this.lbl_loading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_loading.AutoSize = true;
            this.lbl_loading.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loading.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_loading.Location = new System.Drawing.Point(360, 242);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(100, 25);
            this.lbl_loading.TabIndex = 1;
            this.lbl_loading.Text = "Loading....";
            // 
            // pnl_preview
            // 
            this.pnl_preview.AutoSize = true;
            this.pnl_preview.Controls.Add(this.btn_stop);
            this.pnl_preview.Controls.Add(this.tb_music);
            this.pnl_preview.Controls.Add(this.lbl_music_name);
            this.pnl_preview.Controls.Add(this.btn_shuffle);
            this.pnl_preview.Controls.Add(this.btn_repeat);
            this.pnl_preview.Controls.Add(this.btn_next);
            this.pnl_preview.Controls.Add(this.btn_previous);
            this.pnl_preview.Controls.Add(this.lbl_timestamp);
            this.pnl_preview.Controls.Add(this.lbl_total_time);
            this.pnl_preview.Controls.Add(this.btn_play_pause);
            this.pnl_preview.Controls.Add(this.pnl_header);
            this.pnl_preview.Location = new System.Drawing.Point(223, 109);
            this.pnl_preview.Name = "pnl_preview";
            this.pnl_preview.Size = new System.Drawing.Size(779, 375);
            this.pnl_preview.TabIndex = 5;
            this.pnl_preview.Visible = false;
            // 
            // pnl_header
            // 
            this.pnl_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_header.Controls.Add(this.btn_search);
            this.pnl_header.Controls.Add(this.btn_exitP);
            this.pnl_header.Controls.Add(this.btn_minimizeP);
            this.pnl_header.Controls.Add(this.btn_aboutP);
            this.pnl_header.Controls.Add(this.btn_addP);
            this.pnl_header.Controls.Add(this.btn_settingP);
            this.pnl_header.Controls.Add(this.guna2PictureBox1);
            this.pnl_header.Controls.Add(this.lbl_titleFormMusic);
            this.pnl_header.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(62)))));
            this.pnl_header.Location = new System.Drawing.Point(1, 3);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(775, 67);
            this.pnl_header.TabIndex = 12;
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
            this.btn_search.Location = new System.Drawing.Point(444, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(48, 47);
            this.btn_search.TabIndex = 20;
            // 
            // btn_exitP
            // 
            this.btn_exitP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_exitP.Animated = true;
            this.btn_exitP.BackColor = System.Drawing.Color.Transparent;
            this.btn_exitP.BorderRadius = 20;
            this.btn_exitP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exitP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exitP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exitP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exitP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exitP.FillColor = System.Drawing.Color.Empty;
            this.btn_exitP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exitP.ForeColor = System.Drawing.Color.White;
            this.btn_exitP.Image = global::MusicPlayer.Properties.Resources.exit1;
            this.btn_exitP.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_exitP.Location = new System.Drawing.Point(723, 12);
            this.btn_exitP.Name = "btn_exitP";
            this.btn_exitP.Size = new System.Drawing.Size(43, 44);
            this.btn_exitP.TabIndex = 6;
            // 
            // btn_minimizeP
            // 
            this.btn_minimizeP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_minimizeP.Animated = true;
            this.btn_minimizeP.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizeP.BorderRadius = 20;
            this.btn_minimizeP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizeP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimizeP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimizeP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minimizeP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minimizeP.FillColor = System.Drawing.Color.Empty;
            this.btn_minimizeP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_minimizeP.ForeColor = System.Drawing.Color.White;
            this.btn_minimizeP.Image = global::MusicPlayer.Properties.Resources.minimize;
            this.btn_minimizeP.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_minimizeP.Location = new System.Drawing.Point(666, 12);
            this.btn_minimizeP.Name = "btn_minimizeP";
            this.btn_minimizeP.Size = new System.Drawing.Size(48, 44);
            this.btn_minimizeP.TabIndex = 7;
            // 
            // btn_aboutP
            // 
            this.btn_aboutP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_aboutP.Animated = true;
            this.btn_aboutP.BackColor = System.Drawing.Color.Transparent;
            this.btn_aboutP.BorderRadius = 20;
            this.btn_aboutP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aboutP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_aboutP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_aboutP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_aboutP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_aboutP.FillColor = System.Drawing.Color.Empty;
            this.btn_aboutP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_aboutP.ForeColor = System.Drawing.Color.White;
            this.btn_aboutP.Image = global::MusicPlayer.Properties.Resources.about;
            this.btn_aboutP.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_aboutP.Location = new System.Drawing.Point(612, 11);
            this.btn_aboutP.Name = "btn_aboutP";
            this.btn_aboutP.Size = new System.Drawing.Size(45, 46);
            this.btn_aboutP.TabIndex = 8;
            this.btn_aboutP.Tag = "About";
            // 
            // btn_addP
            // 
            this.btn_addP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addP.Animated = true;
            this.btn_addP.BackColor = System.Drawing.Color.Transparent;
            this.btn_addP.BorderRadius = 20;
            this.btn_addP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addP.FillColor = System.Drawing.Color.Transparent;
            this.btn_addP.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold);
            this.btn_addP.ForeColor = System.Drawing.Color.White;
            this.btn_addP.Image = ((System.Drawing.Image)(resources.GetObject("btn_addP.Image")));
            this.btn_addP.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_addP.Location = new System.Drawing.Point(555, 11);
            this.btn_addP.Name = "btn_addP";
            this.btn_addP.Size = new System.Drawing.Size(48, 47);
            this.btn_addP.TabIndex = 9;
            // 
            // btn_settingP
            // 
            this.btn_settingP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settingP.Animated = true;
            this.btn_settingP.BackColor = System.Drawing.Color.Transparent;
            this.btn_settingP.BorderRadius = 20;
            this.btn_settingP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settingP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_settingP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_settingP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_settingP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_settingP.FillColor = System.Drawing.Color.Transparent;
            this.btn_settingP.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold);
            this.btn_settingP.ForeColor = System.Drawing.Color.White;
            this.btn_settingP.Image = global::MusicPlayer.Properties.Resources.settingDark;
            this.btn_settingP.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_settingP.Location = new System.Drawing.Point(498, 11);
            this.btn_settingP.Name = "btn_settingP";
            this.btn_settingP.Size = new System.Drawing.Size(48, 47);
            this.btn_settingP.TabIndex = 10;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 3;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(62)))));
            this.guna2PictureBox1.Image = global::MusicPlayer.Properties.Resources.music_png_6108;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 15);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(37, 36);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbl_titleFormMusic
            // 
            this.lbl_titleFormMusic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_titleFormMusic.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titleFormMusic.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleFormMusic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titleFormMusic.Location = new System.Drawing.Point(55, 16);
            this.lbl_titleFormMusic.Name = "lbl_titleFormMusic";
            this.lbl_titleFormMusic.Size = new System.Drawing.Size(122, 35);
            this.lbl_titleFormMusic.TabIndex = 1;
            this.lbl_titleFormMusic.Text = "MusicPlayer";
            this.lbl_titleFormMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_beta
            // 
            this.lbl_beta.AutoSize = true;
            this.lbl_beta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_beta.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_beta.ForeColor = System.Drawing.Color.Black;
            this.lbl_beta.Location = new System.Drawing.Point(935, 496);
            this.lbl_beta.Name = "lbl_beta";
            this.lbl_beta.Size = new System.Drawing.Size(80, 17);
            this.lbl_beta.TabIndex = 1;
            this.lbl_beta.Text = "Beta Version";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(218, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preview Settings";
            // 
            // pnl_tools
            // 
            this.pnl_tools.Controls.Add(this.cb_theme);
            this.pnl_tools.Controls.Add(this.btn_default);
            this.pnl_tools.Controls.Add(this.btn_saveChanges);
            this.pnl_tools.Controls.Add(this.btn_updateApp);
            this.pnl_tools.Controls.Add(this.btn_font);
            this.pnl_tools.Controls.Add(this.btn_colorText);
            this.pnl_tools.Controls.Add(this.btn_color);
            this.pnl_tools.Controls.Add(this.label4);
            this.pnl_tools.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnl_tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_tools.Name = "pnl_tools";
            this.pnl_tools.Size = new System.Drawing.Size(198, 522);
            this.pnl_tools.TabIndex = 4;
            // 
            // cb_theme
            // 
            this.cb_theme.BackColor = System.Drawing.Color.Transparent;
            this.cb_theme.BorderRadius = 3;
            this.cb_theme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_theme.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_theme.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_theme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_theme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_theme.ItemHeight = 30;
            this.cb_theme.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.cb_theme.Location = new System.Drawing.Point(7, 382);
            this.cb_theme.Name = "cb_theme";
            this.cb_theme.Size = new System.Drawing.Size(182, 36);
            this.cb_theme.StartIndex = 1;
            this.cb_theme.TabIndex = 5;
            this.cb_theme.SelectedIndexChanged += new System.EventHandler(this.cb_theme_SelectedIndexChanged);
            this.cb_theme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_theme_KeyPress);
            // 
            // btn_default
            // 
            this.btn_default.BackColor = System.Drawing.Color.Transparent;
            this.btn_default.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_default.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_default.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_default.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_default.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_default.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_default.FillColor = System.Drawing.Color.Transparent;
            this.btn_default.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_default.ForeColor = System.Drawing.Color.White;
            this.btn_default.Location = new System.Drawing.Point(0, 260);
            this.btn_default.Name = "btn_default";
            this.btn_default.Size = new System.Drawing.Size(198, 59);
            this.btn_default.TabIndex = 3;
            this.btn_default.Text = "Default";
            this.btn_default.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_default.TextOffset = new System.Drawing.Point(20, 0);
            this.btn_default.Click += new System.EventHandler(this.btn_default_Click);
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveChanges.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_saveChanges.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_saveChanges.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_saveChanges.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_saveChanges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_saveChanges.FillColor = System.Drawing.Color.Transparent;
            this.btn_saveChanges.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold);
            this.btn_saveChanges.ForeColor = System.Drawing.Color.White;
            this.btn_saveChanges.Location = new System.Drawing.Point(0, 195);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(198, 66);
            this.btn_saveChanges.TabIndex = 3;
            this.btn_saveChanges.Text = "Save";
            this.btn_saveChanges.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_saveChanges.TextOffset = new System.Drawing.Point(20, 0);
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // btn_updateApp
            // 
            this.btn_updateApp.Animated = true;
            this.btn_updateApp.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateApp.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_updateApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_updateApp.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_updateApp.FillColor = System.Drawing.Color.Transparent;
            this.btn_updateApp.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold);
            this.btn_updateApp.ForeColor = System.Drawing.Color.White;
            this.btn_updateApp.Image = global::MusicPlayer.Properties.Resources.update1;
            this.btn_updateApp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_updateApp.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_updateApp.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_updateApp.Location = new System.Drawing.Point(0, 463);
            this.btn_updateApp.Name = "btn_updateApp";
            this.btn_updateApp.Size = new System.Drawing.Size(198, 59);
            this.btn_updateApp.TabIndex = 3;
            this.btn_updateApp.Text = "Check Updates";
            this.btn_updateApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_updateApp.TextOffset = new System.Drawing.Point(15, 0);
            this.btn_updateApp.Click += new System.EventHandler(this.btn_updateApp_Click);
            // 
            // btn_font
            // 
            this.btn_font.BackColor = System.Drawing.Color.Transparent;
            this.btn_font.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_font.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_font.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_font.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_font.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_font.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_font.FillColor = System.Drawing.Color.Transparent;
            this.btn_font.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_font.ForeColor = System.Drawing.Color.White;
            this.btn_font.Location = new System.Drawing.Point(0, 130);
            this.btn_font.Name = "btn_font";
            this.btn_font.Size = new System.Drawing.Size(198, 59);
            this.btn_font.TabIndex = 3;
            this.btn_font.Text = "Font";
            this.btn_font.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_font.TextOffset = new System.Drawing.Point(20, 0);
            this.btn_font.Click += new System.EventHandler(this.btn_font_Click);
            // 
            // btn_colorText
            // 
            this.btn_colorText.BackColor = System.Drawing.Color.Transparent;
            this.btn_colorText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_colorText.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_colorText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_colorText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_colorText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_colorText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_colorText.FillColor = System.Drawing.Color.Transparent;
            this.btn_colorText.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold);
            this.btn_colorText.ForeColor = System.Drawing.Color.White;
            this.btn_colorText.Location = new System.Drawing.Point(0, 65);
            this.btn_colorText.Name = "btn_colorText";
            this.btn_colorText.Size = new System.Drawing.Size(198, 59);
            this.btn_colorText.TabIndex = 3;
            this.btn_colorText.Text = "Color Text";
            this.btn_colorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_colorText.TextOffset = new System.Drawing.Point(20, 0);
            this.btn_colorText.Click += new System.EventHandler(this.btn_colorText_Click);
            this.btn_colorText.MouseLeave += new System.EventHandler(this.btn_saveChnages_MouseLeave);
            this.btn_colorText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_saveChnages_MouseMove);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.Transparent;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_color.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_color.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_color.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_color.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_color.FillColor = System.Drawing.Color.Transparent;
            this.btn_color.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold);
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Location = new System.Drawing.Point(0, 0);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(198, 59);
            this.btn_color.TabIndex = 3;
            this.btn_color.Text = "Color Panel";
            this.btn_color.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_color.TextOffset = new System.Drawing.Point(20, 0);
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            this.btn_color.MouseLeave += new System.EventHandler(this.btn_saveChnages_MouseLeave);
            this.btn_color.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_saveChnages_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Icon Theme :";
            // 
            // btn_exit
            // 
            this.btn_exit.Animated = true;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BorderRadius = 20;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.Transparent;
            this.btn_exit.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_exit.Location = new System.Drawing.Point(892, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(123, 39);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Back";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // bf_form
            // 
            this.bf_form.AnimateWindow = true;
            this.bf_form.BorderRadius = 3;
            this.bf_form.ContainerControl = this;
            this.bf_form.DockForm = false;
            this.bf_form.DockIndicatorTransparencyValue = 0.6D;
            this.bf_form.HasFormShadow = false;
            this.bf_form.ResizeForm = false;
            this.bf_form.TransparentWhileDrag = true;
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
            this.btn_stop.Image = global::MusicPlayer.Properties.Resources.stopIcon;
            this.btn_stop.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_stop.Location = new System.Drawing.Point(389, 246);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(73, 58);
            this.btn_stop.TabIndex = 13;
            // 
            // tb_music
            // 
            this.tb_music.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_music.BackColor = System.Drawing.Color.Transparent;
            this.tb_music.Location = new System.Drawing.Point(158, 213);
            this.tb_music.Name = "tb_music";
            this.tb_music.Size = new System.Drawing.Size(468, 23);
            this.tb_music.TabIndex = 22;
            this.tb_music.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tb_music.Value = 0;
            // 
            // lbl_music_name
            // 
            this.lbl_music_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_music_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_music_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_music_name.Location = new System.Drawing.Point(255, 192);
            this.lbl_music_name.Name = "lbl_music_name";
            this.lbl_music_name.Size = new System.Drawing.Size(270, 18);
            this.lbl_music_name.TabIndex = 19;
            this.lbl_music_name.Text = "Musicname";
            this.lbl_music_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_shuffle.Location = new System.Drawing.Point(158, 247);
            this.btn_shuffle.Name = "btn_shuffle";
            this.btn_shuffle.Size = new System.Drawing.Size(62, 57);
            this.btn_shuffle.TabIndex = 14;
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
            this.btn_repeat.Location = new System.Drawing.Point(554, 246);
            this.btn_repeat.Name = "btn_repeat";
            this.btn_repeat.Size = new System.Drawing.Size(62, 57);
            this.btn_repeat.TabIndex = 15;
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
            this.btn_next.Location = new System.Drawing.Point(477, 246);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(62, 57);
            this.btn_next.TabIndex = 16;
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
            this.btn_previous.Location = new System.Drawing.Point(235, 247);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(62, 57);
            this.btn_previous.TabIndex = 17;
            // 
            // lbl_timestamp
            // 
            this.lbl_timestamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_timestamp.AutoSize = true;
            this.lbl_timestamp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_timestamp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_timestamp.Location = new System.Drawing.Point(100, 218);
            this.lbl_timestamp.Name = "lbl_timestamp";
            this.lbl_timestamp.Size = new System.Drawing.Size(52, 18);
            this.lbl_timestamp.TabIndex = 20;
            this.lbl_timestamp.Text = "00:00";
            // 
            // lbl_total_time
            // 
            this.lbl_total_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total_time.AutoSize = true;
            this.lbl_total_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_total_time.Location = new System.Drawing.Point(632, 218);
            this.lbl_total_time.Name = "lbl_total_time";
            this.lbl_total_time.Size = new System.Drawing.Size(52, 18);
            this.lbl_total_time.TabIndex = 21;
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
            this.btn_play_pause.Image = global::MusicPlayer.Properties.Resources.playIcon;
            this.btn_play_pause.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_play_pause.Location = new System.Drawing.Point(312, 247);
            this.btn_play_pause.Name = "btn_play_pause";
            this.btn_play_pause.Size = new System.Drawing.Size(62, 57);
            this.btn_play_pause.TabIndex = 18;
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 522);
            this.Controls.Add(this.pnl_parent);
            this.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frm_settings_Load);
            this.pnl_parent.ResumeLayout(false);
            this.pnl_parent.PerformLayout();
            this.pnl_loading.ResumeLayout(false);
            this.pnl_loading.PerformLayout();
            this.pnl_preview.ResumeLayout(false);
            this.pnl_preview.PerformLayout();
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnl_tools.ResumeLayout(false);
            this.pnl_tools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_parent;
        private System.Windows.Forms.Label lbl_beta;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2BorderlessForm bf_form;
        private Guna.UI2.WinForms.Guna2Button btn_color;
        private Guna.UI2.WinForms.Guna2Panel pnl_tools;
        private Guna.UI2.WinForms.Guna2Button btn_saveChanges;
        private Guna.UI2.WinForms.Guna2Button btn_updateApp;
        private Guna.UI2.WinForms.Guna2Button btn_font;
        private Guna.UI2.WinForms.Guna2Panel pnl_preview;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel pnl_header;
        private Guna.UI2.WinForms.Guna2Button btn_exitP;
        private Guna.UI2.WinForms.Guna2Button btn_minimizeP;
        private Guna.UI2.WinForms.Guna2Button btn_aboutP;
        private Guna.UI2.WinForms.Guna2Button btn_addP;
        private Guna.UI2.WinForms.Guna2Button btn_settingP;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lbl_titleFormMusic;
        private Guna.UI2.WinForms.Guna2Panel pnl_loading;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator wpi_progress;
        private System.Windows.Forms.Label lbl_loading;
        private Guna.UI2.WinForms.Guna2ComboBox cb_theme;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_default;
        private Guna.UI2.WinForms.Guna2Button btn_colorText;
        public Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2Button btn_stop;
        private Guna.UI2.WinForms.Guna2TrackBar tb_music;
        public System.Windows.Forms.Label lbl_music_name;
        private Guna.UI2.WinForms.Guna2Button btn_shuffle;
        private Guna.UI2.WinForms.Guna2Button btn_repeat;
        private Guna.UI2.WinForms.Guna2Button btn_next;
        private Guna.UI2.WinForms.Guna2Button btn_previous;
        private System.Windows.Forms.Label lbl_timestamp;
        private System.Windows.Forms.Label lbl_total_time;
        private Guna.UI2.WinForms.Guna2Button btn_play_pause;
    }
}