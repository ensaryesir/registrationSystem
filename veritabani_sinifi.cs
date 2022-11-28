using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //veritabanını kullanabilmek için
using System.Windows.Forms; //win form bileşenlerini kullanabilmek için
using System.Drawing; //color kullanabilmek için

namespace registration_system
{
    internal class veritabani_sinifi
    {
        SqlConnection connection = new SqlConnection(@"Data source=.;initial catalog=adminDB;integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;

        public void girisYap(string ad,string sifre,Form frm1)
        {
            try
            {
                command = new SqlCommand("Select * From adminTB where admin_ad='" + ad + "' and admin_sifre='" + sifre + "'", connection);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Giriş Yaptınız", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1.gonderilecekAdminAdSoyad = reader["admin_adSoyad"].ToString();
                    Form2 frm2 = new Form2();
                    frm1.Hide(); //form1 i saklıyoz
                    frm2.ShowDialog(); //show dediğimde arkada gözüken formda işlem yapabiliriz. showdialog olunca yapamayız
                    Application.Exit();
                }
                else
                {
                    frm1.BackColor = Color.Red;
                    MessageBox.Show("Bilgilerinizi yanlış girdiniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frm1.BackColor = Color.Black;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Alınan Hata: " + hata.Message);
            }
            connection.Close();
            command.Dispose();
        }
    }
}
