namespace registration_system
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdmin
            // 
            this.grpAdmin.BackColor = System.Drawing.Color.Black;
            this.grpAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpAdmin.BackgroundImage")));
            this.grpAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpAdmin.Controls.Add(this.btncikis);
            this.grpAdmin.Controls.Add(this.btnGiris);
            this.grpAdmin.Controls.Add(this.txtSifre);
            this.grpAdmin.Controls.Add(this.txtAd);
            this.grpAdmin.Controls.Add(this.label2);
            this.grpAdmin.Controls.Add(this.label1);
            this.grpAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAdmin.ForeColor = System.Drawing.Color.White;
            this.grpAdmin.Location = new System.Drawing.Point(12, 12);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Size = new System.Drawing.Size(756, 332);
            this.grpAdmin.TabIndex = 1;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "Bilgilerinizi Girin";
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.AliceBlue;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.Color.Black;
            this.btncikis.Location = new System.Drawing.Point(616, 286);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(125, 40);
            this.btncikis.TabIndex = 5;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            this.btncikis.MouseLeave += new System.EventHandler(this.btncikis_MouseLeave);
            this.btncikis.MouseHover += new System.EventHandler(this.btncikis_MouseHover);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Location = new System.Drawing.Point(15, 286);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(125, 40);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            this.btnGiris.MouseLeave += new System.EventHandler(this.btnGiris_MouseLeave);
            this.btnGiris.MouseHover += new System.EventHandler(this.btnGiris_MouseHover);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(126, 112);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(224, 38);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            this.txtSifre.MouseLeave += new System.EventHandler(this.btnGiris_MouseLeave);
            this.txtSifre.MouseHover += new System.EventHandler(this.btnGiris_MouseHover);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(126, 51);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(224, 38);
            this.txtAd.TabIndex = 2;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            this.txtAd.MouseLeave += new System.EventHandler(this.btnGiris_MouseLeave);
            this.txtAd.MouseHover += new System.EventHandler(this.btnGiris_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            this.label2.MouseLeave += new System.EventHandler(this.btnGiris_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.btnGiris_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(57, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            this.label1.MouseLeave += new System.EventHandler(this.btnGiris_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.btnGiris_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 356);
            this.Controls.Add(this.grpAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAdmin.ResumeLayout(false);
            this.grpAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdmin;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncikis;
    }
}

