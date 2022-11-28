using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //sql kullanımı için

namespace registration_system
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data source=.;initial catalog=calisanlarDB;integrated Security=True");

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (connection.State == ConnectionState.Closed) 
                {
                    string kayit = "insert into calisan_tablosu(tc_no,ad,soyad,telefon,adres) values (@tc_no,@ad,@soyad,@telefon,@adres)";
                    
                    SqlCommand command = new SqlCommand(kayit, connection);
                    connection.Open();
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@tc_no", txt_kimlik.Text);
                    command.Parameters.AddWithValue("@ad", txt_ad.Text);
                    command.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                    command.Parameters.AddWithValue("@telefon", txt_tel.Text);
                    command.Parameters.AddWithValue("@adres", txt_adres.Text);

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Kayıt işlemi başarı ile gerçekleştirildi.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu: " + hata.Message);
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kimlik.Clear();
            txt_ad.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_tel.Clear();
            txt_adres.Clear();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
            this.Show();
        }

        private void btn_geri_MouseHover(object sender, EventArgs e)
        {
            btn_geri.BackColor = Color.IndianRed;
            btn_geri.ForeColor = Color.White;
        }

        private void btn_geri_MouseLeave(object sender, EventArgs e)
        {
            btn_geri.BackColor = Color.AliceBlue;
            btn_geri.ForeColor = Color.Black;
        }

        private void btn_temizle_MouseHover(object sender, EventArgs e)
        {
            btn_temizle.BackColor = Color.PaleVioletRed;
            btn_temizle.ForeColor = Color.White;
        }

        private void btn_temizle_MouseLeave(object sender, EventArgs e)
        {
            btn_temizle.BackColor = Color.AliceBlue;
            btn_temizle.ForeColor = Color.Black;
        }

        private void btn_kaydet_MouseHover(object sender, EventArgs e)
        {
            btn_kaydet.BackColor = Color.DeepSkyBlue;
            btn_kaydet.ForeColor = Color.White;
        }

        private void btn_kaydet_MouseLeave(object sender, EventArgs e)
        {
            btn_kaydet.BackColor = Color.AliceBlue;
            btn_kaydet.ForeColor = Color.Black;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamadan Çıkış Yaptınız.", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Application.Exit();
        }

        private void btn_cikis_MouseHover(object sender, EventArgs e)
        {
            btn_cikis.BackColor = Color.DarkRed;
            btn_cikis.ForeColor = Color.White;
        }

        private void btn_cikis_MouseLeave(object sender, EventArgs e)
        {
            btn_cikis.BackColor = Color.AliceBlue;
            btn_cikis.ForeColor= Color.Black;
        }
    }
}
