namespace registration_system
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMetin = new System.Windows.Forms.Button();
            this.btn_grsDon = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_veriler = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btnMetin);
            this.groupBox1.Controls.Add(this.btn_grsDon);
            this.groupBox1.Controls.Add(this.btn_cikis);
            this.groupBox1.Controls.Add(this.btn_veriler);
            this.groupBox1.Controls.Add(this.btnKayit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yapmak istediğiniz işlemi seçin:";
            // 
            // btnMetin
            // 
            this.btnMetin.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMetin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetin.ForeColor = System.Drawing.Color.Black;
            this.btnMetin.Location = new System.Drawing.Point(33, 100);
            this.btnMetin.Name = "btnMetin";
            this.btnMetin.Size = new System.Drawing.Size(230, 37);
            this.btnMetin.TabIndex = 4;
            this.btnMetin.Text = "Metin Kayıt İşlemi";
            this.btnMetin.UseVisualStyleBackColor = false;
            this.btnMetin.Click += new System.EventHandler(this.btnMetin_Click);
            this.btnMetin.MouseLeave += new System.EventHandler(this.btnMetin_MouseLeave);
            this.btnMetin.MouseHover += new System.EventHandler(this.btnMetin_MouseHover);
            // 
            // btn_grsDon
            // 
            this.btn_grsDon.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_grsDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grsDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_grsDon.ForeColor = System.Drawing.Color.Black;
            this.btn_grsDon.Location = new System.Drawing.Point(6, 264);
            this.btn_grsDon.Name = "btn_grsDon";
            this.btn_grsDon.Size = new System.Drawing.Size(230, 37);
            this.btn_grsDon.TabIndex = 3;
            this.btn_grsDon.Text = "Giriş Ekranına Dön";
            this.btn_grsDon.UseVisualStyleBackColor = false;
            this.btn_grsDon.Click += new System.EventHandler(this.btn_grsDon_Click);
            this.btn_grsDon.MouseLeave += new System.EventHandler(this.btn_grsDon_MouseLeave);
            this.btn_grsDon.MouseHover += new System.EventHandler(this.btn_grsDon_MouseHover);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.Color.Black;
            this.btn_cikis.Location = new System.Drawing.Point(435, 261);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(115, 41);
            this.btn_cikis.TabIndex = 2;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            this.btn_cikis.MouseLeave += new System.EventHandler(this.btn_cikis_MouseLeave);
            this.btn_cikis.MouseHover += new System.EventHandler(this.btn_cikis_MouseHover);
            // 
            // btn_veriler
            // 
            this.btn_veriler.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_veriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_veriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_veriler.ForeColor = System.Drawing.Color.Black;
            this.btn_veriler.Location = new System.Drawing.Point(33, 143);
            this.btn_veriler.Name = "btn_veriler";
            this.btn_veriler.Size = new System.Drawing.Size(230, 37);
            this.btn_veriler.TabIndex = 1;
            this.btn_veriler.Text = "Verileri Görüntüle";
            this.btn_veriler.UseVisualStyleBackColor = false;
            this.btn_veriler.Click += new System.EventHandler(this.btn_veriler_Click);
            this.btn_veriler.MouseLeave += new System.EventHandler(this.btn_veriler_MouseLeave);
            this.btn_veriler.MouseHover += new System.EventHandler(this.btn_veriler_MouseHover);
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.AliceBlue;
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.Color.Black;
            this.btnKayit.Location = new System.Drawing.Point(33, 57);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(230, 37);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.Text = "Çalışan Kayıt İşlemi";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            this.btnKayit.MouseLeave += new System.EventHandler(this.btnKayit_MouseLeave);
            this.btnKayit.MouseHover += new System.EventHandler(this.btnKayit_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(580, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem Seçimi";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_veriler;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_grsDon;
        private System.Windows.Forms.Button btnMetin;
    }
}