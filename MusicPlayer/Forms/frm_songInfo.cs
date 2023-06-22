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
        private MusicFileInformation _information;
        public frm_songInfo(MusicFileInformation information)
        {
            InitializeComponent();
            this._information = information;
        }

        private void frm_songInfo_Load(object sender, EventArgs e)
        {
            if (_information != null)
            {
                lbl_title.Text = _information.FileName;
                lbl_duration.Text = _information.Duration.ToString();
                lbl_audioBitrate.Text = _information.AudioBitrate.ToString(); ;
                lbl_audioChannels.Text = _information.AudioChannel.ToString();
                lbl_mediaTypes.Text = _information.MediaType;
                if (_information.Author != null)
                    lbl_author.Text = _information.Author;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
