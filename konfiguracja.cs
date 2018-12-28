using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace LKLogArchiver
{
    public partial class konfiguracja : Form
    {
        public konfiguracja()
        {
            InitializeComponent();
        }

        private void bt_przegladaj_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        {
            textPathSource.Text = folderBrowserDialog1.SelectedPath;
        }

        }

        private void konfiguracja_Load(object sender, EventArgs e)
        {
            textPathSource.Text = Properties.Settings.Default.path_log;
            textPathCel.Text = Properties.Settings.Default.path_destination;
            textPlikLoga.Text = Properties.Settings.Default.log_file;
            textMaska.Text = Properties.Settings.Default.maska_nazwy;
            textKey.Text = Properties.Settings.Default.key;
            checkKasuj.Checked = Properties.Settings.Default.delete_old;
            checkSzyfruj.Checked = Properties.Settings.Default.szyfruj;
            checkZastap.Checked = Properties.Settings.Default.zastap;
            textserwer_ftp.Text = Properties.Settings.Default.ftp_serwer;
            textHasloFTP.Text = Properties.Settings.Default.ftp_haslo;
            textFTPKatsalog.Text = Properties.Settings.Default.ftp_katalog;
            textUserFTP.Text = Properties.Settings.Default.ftp_login;
            checkSendFTP.Checked = Properties.Settings.Default.send_ftp;
            checkUsuwajFTP.Checked = Properties.Settings.Default.ftp_usun_stare;
            checkSuma.Checked = Properties.Settings.Default.ftp_suma;
        }

        private void bt_zapisz_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.path_log = textPathSource.Text;
            Properties.Settings.Default.path_destination = textPathCel.Text;
            Properties.Settings.Default.log_file = textPlikLoga.Text;
            Properties.Settings.Default.maska_nazwy = textMaska.Text;
            Properties.Settings.Default.key = textKey.Text;
            Properties.Settings.Default.delete_old = checkKasuj.Checked;
            Properties.Settings.Default.szyfruj = checkSzyfruj.Checked;
            Properties.Settings.Default.zastap = checkZastap.Checked;
            Properties.Settings.Default.ftp_serwer = textserwer_ftp.Text.Trim();
            Properties.Settings.Default.ftp_haslo = textHasloFTP.Text;
            Properties.Settings.Default.ftp_katalog = textFTPKatsalog.Text.Trim();
            Properties.Settings.Default.ftp_login = textUserFTP.Text.Trim();
            Properties.Settings.Default.send_ftp = checkSendFTP.Checked;
            Properties.Settings.Default.ftp_usun_stare = checkUsuwajFTP.Checked;
            Properties.Settings.Default.ftp_suma = checkSuma.Checked;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void bt_path_cel_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
              textPathCel.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void bt_plik_loga_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textPlikLoga.Text = Path.GetExtension(openFileDialog1.FileName);
            }
        }


    }
}
