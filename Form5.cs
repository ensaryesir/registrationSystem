using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace registration_system
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data source=.;initial catalog=calisanlarDB;integrated Security=True");

        private void btnGeri_MouseHover(object sender, EventArgs e)
        {
            btnGeri.BackColor = Color.IndianRed;
            btnGeri.ForeColor=Color.White;
        }

        private void btnGeri_MouseLeave(object sender, EventArgs e)
        {
            btnGeri.BackColor = Color.AliceBlue;
            btnGeri.ForeColor=Color.Black;
        }

        private void btnCıkıs_MouseHover(object sender, EventArgs e)
        {
            btnCıkıs.BackColor = Color.DarkRed;
            btnCıkıs.ForeColor = Color.White;
        }

        private void btnCıkıs_MouseLeave(object sender, EventArgs e)
        {
            btnCıkıs.BackColor = Color.AliceBlue;
            btnCıkıs.ForeColor = Color.Black;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
            this.Show();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamadan Çıkış Yaptınız.", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btnKayit_MouseHover(object sender, EventArgs e)
        {
            btnKayit.BackColor = Color.DeepSkyBlue;
            btnKayit.ForeColor = Color.White;
        }

        private void btnKayit_MouseLeave(object sender, EventArgs e)
        {
            btnKayit.BackColor = Color.AliceBlue;
            btnKayit.ForeColor= Color.Black;

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                string kayit = "insert into metinTB (metin) values (@metin)";
                SqlCommand cmd = new SqlCommand(kayit, con);
                con.Open();
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@metin", rchMetin.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kayıt işlemi başarı ile gerçekleştirildi.","Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu: " + hata.Message);
            }
            
        }
    }
}
