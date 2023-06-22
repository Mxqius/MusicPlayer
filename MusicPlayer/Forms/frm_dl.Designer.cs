
namespace MusicPlayer
{
    partial class frm_dl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dl));
            this.gbf_frm_dl = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txt_url = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear_list = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add_url = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_header = new Guna.UI2.WinForms.Guna2Panel();
            this.pb_icon_header = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_minimize = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_downloaded = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pb_downloadStatus = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.btn_downloadAll = new Guna.UI2.WinForms.Guna2Button();
            this.pic_browser = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_playOnline = new Guna.UI2.WinForms.Guna2Button();
            this.btn_download = new Guna.UI2.WinForms.Guna2Button();
            this.lb_urls = new MaterialSkin.Controls.MaterialListBox();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_browser)).BeginInit();
            this.SuspendLayout();
            // 
            // gbf_frm_dl
            // 
            this.gbf_frm_dl.BorderRadius = 5;
            this.gbf_frm_dl.ContainerControl = this;
            this.gbf_frm_dl.DockForm = false;
            this.gbf_frm_dl.DockIndicatorTransparencyValue = 0.6D;
            this.gbf_frm_dl.ResizeForm = false;
            this.gbf_frm_dl.TransparentWhileDrag = true;
            // 
            // txt_url
            // 
            this.txt_url.BorderColor = System.Drawing.Color.Coral;
            this.txt_url.BorderRadius = 15;
            this.txt_url.BorderThickness = 2;
            this.txt_url.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_url.DefaultText = "";
            this.txt_url.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_url.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_url.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_url.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_url.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_url.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_url.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(215)))), ((int)(((byte)(237)))));
            this.txt_url.Location = new System.Drawing.Point(12, 102);
            this.txt_url.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_url.Name = "txt_url";
            this.txt_url.PasswordChar = '\0';
            this.txt_url.PlaceholderText = "URL Audio";
            this.txt_url.SelectedText = "";
            this.txt_url.Size = new System.Drawing.Size(492, 36);
            this.txt_url.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(279, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status :";
            // 
            // btn_clear_list
            // 
            this.btn_clear_list.Animated = true;
            this.btn_clear_list.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear_list.BorderRadius = 15;
            this.btn_clear_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear_list.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear_list.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear_list.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear_list.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear_list.FillColor = System.Drawing.Color.Coral;
            this.btn_clear_list.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_list.ForeColor = System.Drawing.Color.White;
            this.btn_clear_list.Location = new System.Drawing.Point(16, 213);
            this.btn_clear_list.Name = "btn_clear_list";
            this.btn_clear_list.Size = new System.Drawing.Size(261, 45);
            this.btn_clear_list.TabIndex = 4;
            this.btn_clear_list.Text = "Clear List";
            this.btn_clear_list.Click += new System.EventHandler(this.btn_clear_list_Click);
            // 
            // btn_add_url
            // 
            this.btn_add_url.Animated = true;
            this.btn_add_url.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_url.BorderRadius = 15;
            this.btn_add_url.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_url.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_url.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_url.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_url.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_url.FillColor = System.Drawing.Color.Coral;
            this.btn_add_url.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_url.ForeColor = System.Drawing.Color.White;
            this.btn_add_url.Location = new System.Drawing.Point(283, 213);
            this.btn_add_url.Name = "btn_add_url";
            this.btn_add_url.Size = new System.Drawing.Size(270, 45);
            this.btn_add_url.TabIndex = 3;
            this.btn_add_url.Text = "Add Url";
            this.btn_add_url.Click += new System.EventHandler(this.btn_add_url_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_status.Location = new System.Drawing.Point(360, 287);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(54, 20);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "None";
            // 
            // btn_exit
            // 
            this.btn_exit.BorderRadius = 1;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.Red;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(798, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(41, 38);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "X";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(62)))));
            this.pnl_header.Controls.Add(this.pb_icon_header);
            this.pnl_header.Controls.Add(this.btn_minimize);
            this.pnl_header.Controls.Add(this.btn_exit);
            this.pnl_header.Controls.Add(this.label3);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(842, 46);
            this.pnl_header.TabIndex = 5;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseMove);
            this.pnl_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseUp);
            // 
            // pb_icon_header
            // 
            this.pb_icon_header.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pb_icon_header.BackColor = System.Drawing.Color.Transparent;
            this.pb_icon_header.BorderRadius = 3;
            this.pb_icon_header.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(62)))));
            this.pb_icon_header.Image = global::MusicPlayer.Properties.Resources.music_png_6108;
            this.pb_icon_header.ImageRotate = 0F;
            this.pb_icon_header.Location = new System.Drawing.Point(12, 5);
            this.pb_icon_header.Name = "pb_icon_header";
            this.pb_icon_header.Size = new System.Drawing.Size(37, 36);
            this.pb_icon_header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icon_header.TabIndex = 8;
            this.pb_icon_header.TabStop = false;
            // 
            // btn_minimize
            // 
            this.btn_minimize.BorderRadius = 1;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minimize.FillColor = System.Drawing.Color.LightGray;
            this.btn_minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(751, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(41, 38);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.Text = "__";
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Downloader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Link :";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_speed.Location = new System.Drawing.Point(103, 287);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(51, 20);
            this.lbl_speed.TabIndex = 3;
            this.lbl_speed.Text = "MB/s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(22, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Speed :";
            // 
            // lbl_downloaded
            // 
            this.lbl_downloaded.AutoSize = true;
            this.lbl_downloaded.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_downloaded.Location = new System.Drawing.Point(152, 323);
            this.lbl_downloaded.Name = "lbl_downloaded";
            this.lbl_downloaded.Size = new System.Drawing.Size(35, 20);
            this.lbl_downloaded.TabIndex = 3;
            this.lbl_downloaded.Text = "MB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(22, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Downloaded :";
            // 
            // pb_downloadStatus
            // 
            this.pb_downloadStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_downloadStatus.Location = new System.Drawing.Point(0, 373);
            this.pb_downloadStatus.Name = "pb_downloadStatus";
            this.pb_downloadStatus.Size = new System.Drawing.Size(842, 41);
            this.pb_downloadStatus.TabIndex = 6;
            this.pb_downloadStatus.Text = "guna2ProgressBar1";
            this.pb_downloadStatus.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btn_downloadAll
            // 
            this.btn_downloadAll.Animated = true;
            this.btn_downloadAll.BackColor = System.Drawing.Color.Transparent;
            this.btn_downloadAll.BorderRadius = 15;
            this.btn_downloadAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_downloadAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_downloadAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_downloadAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_downloadAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_downloadAll.FillColor = System.Drawing.Color.Coral;
            this.btn_downloadAll.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downloadAll.ForeColor = System.Drawing.Color.White;
            this.btn_downloadAll.Location = new System.Drawing.Point(283, 323);
            this.btn_downloadAll.Name = "btn_downloadAll";
            this.btn_downloadAll.Size = new System.Drawing.Size(270, 32);
            this.btn_downloadAll.TabIndex = 5;
            this.btn_downloadAll.Text = "Download All";
            this.btn_downloadAll.Click += new System.EventHandler(this.btn_downloadAll_Click);
            // 
            // pic_browser
            // 
            this.pic_browser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_browser.Image = global::MusicPlayer.Properties.Resources.folderBrowser;
            this.pic_browser.ImageRotate = 0F;
            this.pic_browser.Location = new System.Drawing.Point(510, 102);
            this.pic_browser.Name = "pic_browser";
            this.pic_browser.Size = new System.Drawing.Size(43, 36);
            this.pic_browser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_browser.TabIndex = 7;
            this.pic_browser.TabStop = false;
            this.pic_browser.Click += new System.EventHandler(this.pic_browser_Click);
            // 
            // btn_playOnline
            // 
            this.btn_playOnline.Animated = true;
            this.btn_playOnline.BackColor = System.Drawing.Color.Transparent;
            this.btn_playOnline.BorderRadius = 15;
            this.btn_playOnline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_playOnline.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_playOnline.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_playOnline.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_playOnline.DisabledState.ForeColor = System.Drawing.Color.LightGray;
            this.btn_playOnline.FillColor = System.Drawing.Color.Coral;
            this.btn_playOnline.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playOnline.ForeColor = System.Drawing.Color.White;
            this.btn_playOnline.Image = global::MusicPlayer.Properties.Resources.playOnline;
            this.btn_playOnline.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_playOnline.Location = new System.Drawing.Point(16, 162);
            this.btn_playOnline.Name = "btn_playOnline";
            this.btn_playOnline.Size = new System.Drawing.Size(261, 45);
            this.btn_playOnline.TabIndex = 2;
            this.btn_playOnline.Text = "Play Online";
            this.btn_playOnline.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_download
            // 
            this.btn_download.Animated = true;
            this.btn_download.BackColor = System.Drawing.Color.Transparent;
            this.btn_download.BorderRadius = 15;
            this.btn_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_download.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_download.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_download.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_download.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_download.FillColor = System.Drawing.Color.Coral;
            this.btn_download.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.ForeColor = System.Drawing.Color.White;
            this.btn_download.Image = global::MusicPlayer.Properties.Resources.download;
            this.btn_download.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_download.Location = new System.Drawing.Point(283, 162);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(270, 45);
            this.btn_download.TabIndex = 1;
            this.btn_download.Text = "Download";
            this.btn_download.Click += new System.EventHandler(this.btn_dl_Click);
            // 
            // lb_urls
            // 
            this.lb_urls.AllowDrop = true;
            this.lb_urls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_urls.BackColor = System.Drawing.Color.White;
            this.lb_urls.BorderColor = System.Drawing.Color.Black;
            this.lb_urls.Depth = 0;
            this.lb_urls.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_urls.Location = new System.Drawing.Point(582, 67);
            this.lb_urls.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_urls.Name = "lb_urls";
            this.lb_urls.SelectedIndex = -1;
            this.lb_urls.SelectedItem = null;
            this.lb_urls.Size = new System.Drawing.Size(248, 288);
            this.lb_urls.TabIndex = 13;
            this.lb_urls.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.lb_urls_SelectedIndexChanged);
            this.lb_urls.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_urls_DragDrop);
            this.lb_urls.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_urls_DragEnter);
            // 
            // frm_dl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(842, 414);
            this.Controls.Add(this.lb_urls);
            this.Controls.Add(this.pic_browser);
            this.Controls.Add(this.pb_downloadStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_downloaded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn_add_url);
            this.Controls.Add(this.btn_playOnline);
            this.Controls.Add(this.btn_clear_list);
            this.Controls.Add(this.btn_downloadAll);
            this.Controls.Add(this.btn_download);
            this.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_dl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloader";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon_header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_browser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm gbf_frm_dl;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_url;
        private Guna.UI2.WinForms.Guna2Button btn_add_url;
        private Guna.UI2.WinForms.Guna2Button btn_playOnline;
        private Guna.UI2.WinForms.Guna2Button btn_clear_list;
        private Guna.UI2.WinForms.Guna2Button btn_download;
        private System.Windows.Forms.Label lbl_status;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Panel pnl_header;
        private Guna.UI2.WinForms.Guna2ProgressBar pb_downloadStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_downloaded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_speed;
        private Guna.UI2.WinForms.Guna2Button btn_minimize;
        private Guna.UI2.WinForms.Guna2Button btn_downloadAll;
        private Guna.UI2.WinForms.Guna2PictureBox pic_browser;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox pb_icon_header;
        private MaterialSkin.Controls.MaterialListBox lb_urls;
    }
}