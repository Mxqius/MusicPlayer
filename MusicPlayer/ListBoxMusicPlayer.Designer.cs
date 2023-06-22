namespace MusicPlayer
{
    partial class ListBoxMusicPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nameMusic = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.pic_favorite = new System.Windows.Forms.PictureBox();
            this.pic_deleteMusic = new System.Windows.Forms.PictureBox();
            this.pic_ImageMusic = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_favorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_deleteMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImageMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nameMusic
            // 
            this.lbl_nameMusic.Location = new System.Drawing.Point(109, 25);
            this.lbl_nameMusic.Name = "lbl_nameMusic";
            this.lbl_nameMusic.Size = new System.Drawing.Size(179, 23);
            this.lbl_nameMusic.TabIndex = 1;
            this.lbl_nameMusic.Text = "Name";
            this.lbl_nameMusic.Click += new System.EventHandler(this.PlayWithControls);
            this.lbl_nameMusic.MouseLeave += new System.EventHandler(this.ListBoxMusicPlayer_MouseLeave);
            this.lbl_nameMusic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListBoxMusicPlayer_MouseMove);
            // 
            // lbl_duration
            // 
            this.lbl_duration.Location = new System.Drawing.Point(109, 59);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(75, 16);
            this.lbl_duration.TabIndex = 1;
            this.lbl_duration.Text = "Duration";
            this.lbl_duration.Click += new System.EventHandler(this.PlayWithControls);
            this.lbl_duration.MouseLeave += new System.EventHandler(this.ListBoxMusicPlayer_MouseLeave);
            this.lbl_duration.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListBoxMusicPlayer_MouseMove);
            // 
            // pic_favorite
            // 
            this.pic_favorite.Image = global::MusicPlayer.Properties.Resources.favoriteUnSelected;
            this.pic_favorite.Location = new System.Drawing.Point(252, 50);
            this.pic_favorite.Name = "pic_favorite";
            this.pic_favorite.Size = new System.Drawing.Size(25, 26);
            this.pic_favorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_favorite.TabIndex = 2;
            this.pic_favorite.TabStop = false;
            this.pic_favorite.Click += new System.EventHandler(this.pic_favorite_Click);
            this.pic_favorite.MouseLeave += new System.EventHandler(this.ListBoxMusicPlayer_MouseLeave);
            this.pic_favorite.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListBoxMusicPlayer_MouseMove);
            // 
            // pic_deleteMusic
            // 
            this.pic_deleteMusic.Image = global::MusicPlayer.Properties.Resources.deleteMusic;
            this.pic_deleteMusic.Location = new System.Drawing.Point(219, 51);
            this.pic_deleteMusic.Name = "pic_deleteMusic";
            this.pic_deleteMusic.Size = new System.Drawing.Size(25, 26);
            this.pic_deleteMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_deleteMusic.TabIndex = 2;
            this.pic_deleteMusic.TabStop = false;
            this.pic_deleteMusic.Click += new System.EventHandler(this.pic_deleteMusic_Click);
            this.pic_deleteMusic.MouseLeave += new System.EventHandler(this.ListBoxMusicPlayer_MouseLeave);
            this.pic_deleteMusic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListBoxMusicPlayer_MouseMove);
            // 
            // pic_ImageMusic
            // 
            this.pic_ImageMusic.BackColor = System.Drawing.Color.Transparent;
            this.pic_ImageMusic.BorderRadius = 15;
            this.pic_ImageMusic.ImageRotate = 0F;
            this.pic_ImageMusic.Location = new System.Drawing.Point(8, 10);
            this.pic_ImageMusic.Name = "pic_ImageMusic";
            this.pic_ImageMusic.Size = new System.Drawing.Size(82, 77);
            this.pic_ImageMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ImageMusic.TabIndex = 0;
            this.pic_ImageMusic.TabStop = false;
            this.pic_ImageMusic.Click += new System.EventHandler(this.PlayWithControls);
            this.pic_ImageMusic.MouseLeave += new System.EventHandler(this.ListBoxMusicPlayer_MouseLeave);
            this.pic_ImageMusic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListBoxMusicPlayer_MouseMove);
            // 
            // ListBoxMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pic_favorite);
            this.Controls.Add(this.pic_deleteMusic);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.lbl_nameMusic);
            this.Controls.Add(this.pic_ImageMusic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ListBoxMusicPlayer";
            this.Size = new System.Drawing.Size(308, 94);
            this.MouseLeave += new System.EventHandler(this.ListBoxMusicPlayer_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListBoxMusicPlayer_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic_favorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_deleteMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImageMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox pic_ImageMusic;
        public System.Windows.Forms.Label lbl_nameMusic;
        public System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.PictureBox pic_deleteMusic;
        public System.Windows.Forms.PictureBox pic_favorite;
    }
}
