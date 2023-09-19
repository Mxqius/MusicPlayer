using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class ListBoxMusicPlayer : UserControl
    {
        private frm_musicplayer formMusicPlayer;
        public ListBoxMusicPlayer(frm_musicplayer form, int indexFiles, string addressMusic, string nameMusic, string duration, Image pictureMusic, EventHandler targetClick, EventHandler targetMouseHover)
        {
            InitializeComponent();
            formMusicPlayer = form;
            IndexMusic = indexFiles;
            SetName = nameMusic;
            SetDuration = duration;
            SetPicture = pictureMusic;
            MusicAddress = addressMusic;
            lbl_duration.Click += targetClick;
            pic_ImageMusic.Click += targetClick;
            lbl_nameMusic.Click += targetClick;
            this.Click += targetClick;
            this.MouseHover += targetMouseHover;
            lbl_duration.MouseHover += targetMouseHover;
            lbl_nameMusic.MouseHover += targetMouseHover;
            pic_ImageMusic.MouseHover += targetMouseHover;
            //btn_play.Click += new EventHandler(target);
        }

        private int indexMusic;
        private string musicAddress;


        public string MusicAddress
        {
            get { return musicAddress; }
            set { musicAddress = value; }
        }
        public int IndexMusic
        {
            get { return indexMusic; }
            set { indexMusic = value; }
        }

        public Image SetPicture
        {
            get { return pic_ImageMusic.Image; }
            set { pic_ImageMusic.Image = value; }
        }

        public string SetName
        {
            get { return lbl_nameMusic.Text; }
            set { lbl_nameMusic.Text = value; }
        }

        public string SetDuration
        {
            get { return lbl_duration.Text; }
            set { lbl_duration.Text = value; }
        }

        private void ListBoxMusicPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMusicPlayer.wmp_player.URL != null && formMusicPlayer.wmp_player.URL != MusicAddress)
            {
                BackColor = Color.FromArgb(228, 228, 228);
                formMusicPlayer.songInfoURLPassed = this.MusicAddress;
            }
        }

        private void ListBoxMusicPlayer_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (formMusicPlayer.wmp_player.URL != null && formMusicPlayer.wmp_player.URL != MusicAddress)
                    BackColor = Color.WhiteSmoke;
            }
            catch { return; }
        }

        private void pic_deleteMusic_Click(object sender, EventArgs e)
        {
            formMusicPlayer.fileInformations.Remove(formMusicPlayer.fileInformations.Find(m => m.Path == this.MusicAddress));
            formMusicPlayer.pnl_listMusics.Controls.Remove(this);
            formMusicPlayer.ControlsPanelMusicList.Remove(this);
        }

        private void PlayWithControls(object sender, EventArgs e)
        {
            formMusicPlayer.indexPlayerMusic = IndexMusic;
            formMusicPlayer.PlayFile(MusicAddress);
            formMusicPlayer.SetFocusedRight();
            BackColor = Color.FromArgb(221, 221, 221);
        }

        private void pic_favorite_MouseMove(object sender, MouseEventArgs e)
        {
            //if (!formMusicPlayer.checkFavorite(MusicAddress))
            //    pic_favorite.Image = Properties.Resources.favoriteSelected;
        }


        private void pic_favorite_MouseLeave(object sender, EventArgs e)
        {
            //if (!formMusicPlayer.checkFavorite(MusicAddress))
            //    pic_favorite.Image = Properties.Resources.favoriteUnSelected;
        }
        private void pic_favorite_Click(object sender, EventArgs e)
        {
            if (!formMusicPlayer.checkFavorite(MusicAddress))
            {
                pic_favorite.Image = Properties.Resources.favoriteSelected;
                formMusicPlayer.AddFavoriteSong(MusicAddress);
            }
            else
            {
                pic_favorite.Image = Properties.Resources.favoriteUnSelected;
                formMusicPlayer.deleteFavorite(MusicAddress);
            }
        }
    }
}
