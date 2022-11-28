using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //sql için

namespace registration_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
   
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.gonderilecekAdminAdSoyad;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                if (i == 99) timer1.Stop();
                else
                {
                    int x = label1.Location.X + 2;

                    label1.Location=new Point(x);
                }
            }
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
            btn_cikis.ForeColor = Color.Black;
        }

        private void btn_veriler_MouseHover(object sender, EventArgs e)
        {
            btn_veriler.BackColor = Color.DeepSkyBlue;
            btn_veriler.ForeColor = Color.White;
        }

        private void btn_veriler_MouseLeave(object sender, EventArgs e)
        {
            btn_veriler.BackColor = Color.AliceBlue;
            btn_veriler.ForeColor = Color.Black;
        }

        private void btn_veriler_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            Form2 frm2 = new Form2();
            frm2.Hide();
            frm4.ShowDialog();
        }

        private void btn_grsDon_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            Form1 frm1 = new Form1();
            frm2.Hide();
            frm1.ShowDialog();
        }

        private void btn_grsDon_MouseHover(object sender, EventArgs e)
        {
            btn_grsDon.BackColor = Color.IndianRed;
            btn_grsDon.ForeColor = Color.White;
        }

        private void btn_grsDon_MouseLeave(object sender, EventArgs e)
        {
            btn_grsDon.BackColor = Color.AliceBlue;
            btn_grsDon.ForeColor = Color.Black;
        }

        private void btnMetin_MouseHover(object sender, EventArgs e)
        {
            btnMetin.BackColor = Color.DeepSkyBlue;
            btnMetin.ForeColor = Color.White;
        }

        private void btnMetin_MouseLeave(object sender, EventArgs e)
        {
            btnMetin.BackColor = Color.AliceBlue;
            btnMetin.ForeColor = Color.Black;
        }

        private void btnMetin_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            Form2 frm2 = new Form2();
            frm2.Hide();
            frm5.ShowDialog();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            Form2 frm2 = new Form2();
            frm2.Hide();
            frm3.ShowDialog();
        }

        private void btnKayit_MouseHover(object sender, EventArgs e)
        {
            btnKayit.BackColor = Color.DeepSkyBlue;
            btnKayit.ForeColor = Color.White;
        }

        private void btnKayit_MouseLeave(object sender, EventArgs e)
        {
            btnKayit.BackColor = Color.AliceBlue;
            btnKayit.ForeColor = Color.Black;
        }
    }
}
