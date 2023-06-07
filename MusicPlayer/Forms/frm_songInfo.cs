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

namespace MusicPlayer.Forms
{
    public partial class frm_songInfo : Form
    {
        private string songUrl;
        public frm_songInfo(string songUrl)
        {
            InitializeComponent();
            this.songUrl = songUrl;
        }

        private void frm_songInfo_Load(object sender, EventArgs e)
        {
            if (songUrl != string.Empty)
            {
                TagLib.File tf = TagLib.File.Create(songUrl);
                lbl_title.Text = Path.GetFileName(songUrl);
                lbl_duration.Text = tf.Properties.Duration.ToString().Substring(0, 8);
                lbl_audioBitrate.Text = tf.Properties.AudioBitrate.ToString();
                lbl_audioChannels.Text = tf.Properties.AudioChannels.ToString();
                lbl_mediaTypes.Text = tf.Properties.MediaTypes.ToString();
                if (tf.Tag.FirstAlbumArtist != null)
                    lbl_author.Text = tf.Tag.FirstAlbumArtist;
                //            lbl_author.Text = tf.Properties.
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
