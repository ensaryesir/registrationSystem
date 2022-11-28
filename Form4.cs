using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.Reflection.Emit;

namespace registration_system
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        private void Form4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data source=.;initial catalog=calisanlarDB;integrated Security=True");
            con.Open();
            DataTable dt = con.GetSchema("Tables");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tbl_comboBox.Items.Add(dt.Rows[i]["TABLE_NAME"]);
                exportList.Items.Add(dt.Rows[i]["TABLE_NAME"]);
            }
            con.Close();
        }

        private void tbl_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablo = tbl_comboBox.Text;
            string sorgu = "SELECT *FROM " + tablo;
            da = new SqlDataAdapter(sorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, tablo);
            secilenTablo.DataSource = ds.Tables[tablo];
            con.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string tablo = tbl_comboBox.Text;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        tw.WriteLine("IF EXISTS (SELECT *FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = " + "'" + tablo + "'" + ")" + "\n");
                        for (int i = 0; i < secilenTablo.Rows.Count - 1; i++) 
                        {
                            tw.Write("INSERT INTO " + tablo + " VALUES " + " (\t");
                            for (int j = 1; j < secilenTablo.Columns.Count; j++) 
                            {
                                tw.Write("'" + secilenTablo.Rows[i].Cells[j].Value.ToString() + "'" + "," + "\t\t");
                            }
                            tw.Write("\t)");
                            tw.WriteLine("");
                        }
                        tw.WriteLine("\nELSE\n");
                        tw.Write("CREATE TABLE " + tablo + "(\n");
                        for (int i = 0; i < secilenTablo.Columns.Count; i++)
                        {
                            string clmns = secilenTablo.Columns[i].Name;

                            tw.Write(clmns + " nvarchar(50) not null" + ",");
                            if (clmns == secilenTablo.Columns.Count.ToString()) 
                            {
                                break;
                            }
                        }
                        tw.Write(" \n);\n");
                        tw.Close();
                        MessageBox.Show("Export işlemi tamamlandı.", "Bilgilendirme!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamadan Çıkış Yaptınız.", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
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

        private void btnExport_MouseHover(object sender, EventArgs e)
        {
            btnExport.BackColor = Color.DeepSkyBlue;
            btnExport.ForeColor = Color.White;
        }

        private void btnExport_MouseLeave(object sender, EventArgs e)
        {
            btnExport.BackColor = Color.AliceBlue;
            btnExport.ForeColor = Color.Black;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
            this.Show();
        }

        private void btnGeri_MouseHover(object sender, EventArgs e)
        {
            btnGeri.BackColor = Color.IndianRed;
            btnGeri.ForeColor = Color.White;
        }

        private void btnGeri_MouseLeave(object sender, EventArgs e)
        {
            btnGeri.BackColor = Color.AliceBlue;
            btnGeri.ForeColor = Color.Black;
        }

        private void exportList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tablo = exportList.Text;
                string sorgu = "SELECT *FROM " + tablo;
                da = new SqlDataAdapter(sorgu, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, tablo);
                con.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Alınan Hata: " + hata);
            }
        }

        private void exprt_exportList_Click(object sender, EventArgs e)
        {
            

            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        if (exportList.CheckedItems.Count != 0) // Determine if there are any items checked.
                        {
                            string s = ""; // If so, loop through all checked items and print results.
                            for (int i = 0; i < exportList.CheckedItems.Count; i++)
                            {
                                s = s + "IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = " + "'" + exportList.CheckedItems[i].ToString() + "'" + " )" + "\n";
                            }
                            tw.WriteLine(s);
                            for (int a = 0; a < dgv_exportList.Rows.Count - 1; a++)
                            {
                                for (int i = 0; i < exportList.CheckedItems.Count; i++)
                                {
                                    tw.Write("INSERT INTO " + exportList.CheckedItems[i].ToString() + " VALUES" + " (" + "\t");
                                }
                                    for (int b = 1; b < dgv_exportList.Columns.Count; b++)
                                {
                                    tw.Write("'" + dgv_exportList.Rows[a].Cells[b].Value.ToString() + "'" + "," + "\t\t");
                                }
                                tw.Write("\t)");
                                tw.WriteLine("");
                            }
                            tw.Write("\nELSE\n\n");
                            for (int i = 0; i < exportList.CheckedItems.Count; i++)
                            {
                                tw.Write("CREATE TABLE " + exportList.CheckedItems[i] + "(\n");
                            }
                            for (int i = 0; i < dgv_exportList.Columns.Count; i++)
                            {
                                string clmns = dgv_exportList.Columns[i].Name;

                                tw.Write(clmns + " nvarchar(50) not null" + ",");
                                if (clmns == dgv_exportList.Columns.Count.ToString())
                                {
                                    break;
                                }
                            }
                            tw.Write(" \n);\n");
                        }
                        tw.Close();
                        MessageBox.Show("Export işlemi tamamlandı.", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void exprt_exportList_MouseHover(object sender, EventArgs e)
        {
            exprt_exportList.BackColor = Color.DeepSkyBlue; 
            exprt_exportList.ForeColor = Color.White;
        }

        private void exprt_exportList_MouseLeave(object sender, EventArgs e)
        {
            exprt_exportList.BackColor = Color.AliceBlue; 
            exprt_exportList.ForeColor = Color.Black;
        }

        private void add_Click(object sender, EventArgs e) //hatalı
        {
            if (exportList.CheckedItems.Count != 0)
            {
                string s = "";
                for (int i = 0; i <= exportList.CheckedItems.Count - 1; i++)
                {
                    s += "'" + exportList.CheckedItems[i].ToString() + "',";
                }

                con.Open();
                string query = "SELECT *FROM " + exportList.CheckedItems[0].ToString();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_exportList.DataSource = dt;
                con.Close();
            }
        }

        private void add_MouseHover(object sender, EventArgs e)
        {
            add.BackColor = Color.RoyalBlue;
            add.ForeColor = Color.White;
        }

        private void add_MouseLeave(object sender, EventArgs e)
        {
            add.BackColor = Color.AliceBlue;
            add.ForeColor = Color.Black;
        }

    }
}