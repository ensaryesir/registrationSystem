namespace registration_system
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.rchMetin = new System.Windows.Forms.RichTextBox();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchMetin
            // 
            this.rchMetin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchMetin.Location = new System.Drawing.Point(12, 12);
            this.rchMetin.Name = "rchMetin";
            this.rchMetin.Size = new System.Drawing.Size(706, 334);
            this.rchMetin.TabIndex = 0;
            this.rchMetin.Text = "";
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkıs.Location = new System.Drawing.Point(613, 352);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(105, 43);
            this.btnCıkıs.TabIndex = 11;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            this.btnCıkıs.MouseLeave += new System.EventHandler(this.btnCıkıs_MouseLeave);
            this.btnCıkıs.MouseHover += new System.EventHandler(this.btnCıkıs_MouseHover);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(502, 352);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(105, 43);
            this.btnGeri.TabIndex = 10;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            this.btnGeri.MouseLeave += new System.EventHandler(this.btnGeri_MouseLeave);
            this.btnGeri.MouseHover += new System.EventHandler(this.btnGeri_MouseHover);
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.AliceBlue;
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(12, 352);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(105, 43);
            this.btnKayit.TabIndex = 12;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            this.btnKayit.MouseLeave += new System.EventHandler(this.btnKayit_MouseLeave);
            this.btnKayit.MouseHover += new System.EventHandler(this.btnKayit_MouseHover);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(730, 407);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.rchMetin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metin Kayıt Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchMetin;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnKayit;
    }
}