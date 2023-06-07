using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace MusicPlayer.Forms
{
    public partial class frm_settings : Form
    {
        // loading Thread
        private Thread loadingPreview;
        private frm_musicplayer parentForm;
        // ColorDialog for panelColor and titleColor
        private ColorDialog cd = new ColorDialog();
        // FontDialog for Change Font Musicname Label
        private FontDialog fd = new FontDialog();

        public frm_settings(frm_musicplayer parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            loadingPreview = new Thread(() =>
            {
                loadingFormPreview(2000);
            });
            loadingPreview.Start();
        }

        async Task loadingFormPreview(int miliSecounds)
        {
            await Task.Run(async () =>
            {
                await Task.Delay(miliSecounds);
                Invoke(new Action(() =>
                {
                    lbl_loading.Visible = pnl_loading.Visible = wpi_progress.Visible = false;
                    pnl_preview.Visible = true;
                }));
            });
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            parentForm.pnl_formSetting.Visible = false;
            parentForm.lbl_name_app.Text = "MusicPlayer";
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.AllowFullOpen = true;
            cd.Color = pnl_header.FillColor;
            cd.SolidColorOnly = true;
            if (cd.ShowDialog() == DialogResult.OK)
                pnl_header.FillColor = cd.Color;
        }

        private void btn_font_Click(object sender, EventArgs e)
        {
            fd.Font = lbl_music_name.Font;
            if (fd.ShowDialog() == DialogResult.OK)
                lbl_music_name.Font = fd.Font;
        }
        private void saveChanges()
        {
            parentForm.pnl_header.FillColor = pnl_header.FillColor;
            parentForm.lbl_music_name.Font = lbl_music_name.Font;
            parentForm.lbl_name_app.ForeColor = lbl_titleFormMusic.ForeColor;
            if (cb_theme.Text == "Dark")
            {
                parentForm.btn_settings.Image = Properties.Resources.settingDark;
                parentForm.btn_addfile.Image = Properties.Resources.addDark;
                parentForm.btn_exit.Image = Properties.Resources.exitDark;
                parentForm.btn_about.Image = Properties.Resources.aboutDark;
                parentForm.btn_minimize.Image = Properties.Resources.minimizeDark;
                parentForm.btn_search.Image = Properties.Resources.searchDark;
            }
            else
            {
                parentForm.btn_settings.Image = Properties.Resources.settings1;
                parentForm.btn_about.Image = Properties.Resources.about;
                parentForm.btn_exit.Image = Properties.Resources.exit1;
                parentForm.btn_addfile.Image = Properties.Resources.add;
                parentForm.btn_minimize.Image = Properties.Resources.minimize;
                parentForm.btn_search.Image = Properties.Resources.search;
            }
        }
        void LoadDataPreview()
        {
            if (!parentForm.Theme)
            {
                cb_theme.Text = "Dark";
                btn_settingP.Image = Properties.Resources.settingDark;
                btn_aboutP.Image = Properties.Resources.aboutDark;
                btn_exitP.Image = Properties.Resources.exitDark;
                btn_addP.Image = Properties.Resources.addDark;
                btn_minimizeP.Image = Properties.Resources.minimizeDark;
                btn_search.Image = Properties.Resources.searchDark;
            }
            else
            {
                cb_theme.Text = "Light";
                btn_settingP.Image = Properties.Resources.settings1;
                btn_aboutP.Image = Properties.Resources.about;
                btn_exitP.Image = Properties.Resources.exit1;
                btn_addP.Image = Properties.Resources.add;
                btn_minimizeP.Image = Properties.Resources.minimize;
                btn_search.Image = Properties.Resources.search;
            }
            lbl_titleFormMusic.ForeColor = parentForm.lbl_name_app.ForeColor;
            pnl_header.FillColor = parentForm.pnl_header.FillColor;
            lbl_music_name.Font = parentForm.lbl_music_name.Font;
        }
        private void frm_settings_Load(object sender, EventArgs e)
        {
            LoadDataPreview();
            checkUpdate();
        }

        private void checkUpdate()
        {
            if (!parentForm.UpdateExist)
            {
                btn_updateApp.Text = "Up to date!";
            }
        }

        private void btn_saveChnages_MouseMove(object sender, MouseEventArgs e)
        {
            // Custome FocusColor
            //foreach (var control in new Control[] { btn_color, btn_font, btn_updateApp, btn_saveChnages,btn_defult })
            //{
            //    if (control.Name == ((Control)sender).Name)
            //        ((Guna2Button)control).FillColor = Color.FromArgb(189, 195, 199);
            //    else
            //        ((Guna2Button)control).FillColor = Color.Transparent;
            //}
        }

        private void cb_theme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_theme.Text == "Dark")
            {
                btn_settingP.Image = Properties.Resources.settingDark;
                btn_aboutP.Image = Properties.Resources.aboutDark;
                btn_exitP.Image = Properties.Resources.exitDark;
                btn_addP.Image = Properties.Resources.addDark;
                btn_minimizeP.Image = Properties.Resources.minimizeDark;
                btn_search.Image = Properties.Resources.searchDark;
                parentForm.Theme = false;
            }
            else
            {
                btn_settingP.Image = Properties.Resources.settings1;
                btn_aboutP.Image = Properties.Resources.about;
                btn_exitP.Image = Properties.Resources.exit1;
                btn_addP.Image = Properties.Resources.add;
                btn_minimizeP.Image = Properties.Resources.minimize;
                btn_search.Image = Properties.Resources.search;
                parentForm.Theme = true;
            }
        }

        private void btn_saveChnages_MouseLeave(object sender, EventArgs e)
        {
            ((Guna2Button)sender).FillColor = Color.Transparent;
        }


        private void btn_colorText_Click(object sender, EventArgs e)
        {
            cd.AllowFullOpen = true;
            cd.Color = parentForm.lbl_name_app.ForeColor;
            cd.SolidColorOnly = true;
            if (cd.ShowDialog() == DialogResult.OK)
                lbl_titleFormMusic.ForeColor = cd.Color;
        }

        private void btn_updateApp_Click(object sender, EventArgs e)
        {
            if (parentForm.UpdateExist)
            {

                if (parentForm.updateInfo["DownloadAddress"] != string.Empty)
                {
                    UpdateFolder.Update.downloadUpdateFile(parentForm.updateInfo["DownloadAddress"], Application.StartupPath + "\\update.exe");
                    btn_updateApp.Text = "Downloading...";
                }
                else
                    MessageBox.Show("Cannot download update please try agin !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_default_Click(object sender, EventArgs e)
        {

            parentForm.pnl_header.FillColor = parentForm.defColor;
            parentForm.lbl_music_name.Font = parentForm.defFont;
            parentForm.lbl_name_app.ForeColor = Color.Black;
            //Change Icons Preview 
            btn_settingP.Image = Properties.Resources.settingDark;
            btn_aboutP.Image = Properties.Resources.aboutDark;
            btn_exitP.Image = Properties.Resources.exitDark;
            btn_addP.Image = Properties.Resources.addDark;
            btn_minimizeP.Image = Properties.Resources.minimizeDark;
            parentForm.btn_search.Image = Properties.Resources.searchDark;

            //-----
            // Change Form Icons
            parentForm.btn_settings.Image = Properties.Resources.settingDark;
            parentForm.btn_addfile.Image = Properties.Resources.addDark;
            parentForm.btn_exit.Image = Properties.Resources.exitDark;
            parentForm.btn_about.Image = Properties.Resources.aboutDark;
            parentForm.btn_minimize.Image = Properties.Resources.minimizeDark;
            parentForm.btn_search.Image = Properties.Resources.searchDark;
            //-----
            cb_theme.Text = "Dark";
            LoadDataPreview();
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            saveChanges();
        }
    }
}
