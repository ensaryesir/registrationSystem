using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registration_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal static string gonderilecekAdminAdSoyad;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string admin_ad = txtAd.Text;
            string admin_sifre = txtSifre.Text;
            veritabani_sinifi islemim = new veritabani_sinifi();
            islemim.girisYap(admin_ad, admin_sifre, this);
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (sender as TextBox);
            txt.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnGiris_MouseHover(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.RoyalBlue;
            btnGiris.ForeColor = Color.White;
        }

        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.AliceBlue; 
            btnGiris.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamadan Çıkış Yaptınız.", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Application.Exit();
        }

        private void btncikis_MouseHover(object sender, EventArgs e)
        {
            btncikis.BackColor = Color.DarkRed;
            btncikis.ForeColor = Color.White;
        }

        private void btncikis_MouseLeave(object sender, EventArgs e)
        {
            btncikis.BackColor = Color.AliceBlue;
            btncikis.ForeColor = Color.Black;
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string admin_ad = txtAd.Text;
                string admin_sifre = txtSifre.Text;
                veritabani_sinifi islemim = new veritabani_sinifi();
                islemim.girisYap(admin_ad, admin_sifre, this);
            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSifre.Focus();
            }
        }
    }
}
