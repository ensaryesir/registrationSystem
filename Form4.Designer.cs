namespace registration_system
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.secilenTablo = new System.Windows.Forms.DataGridView();
            this.tbl_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exportList = new System.Windows.Forms.CheckedListBox();
            this.exprt_exportList = new System.Windows.Forms.Button();
            this.dgv_exportList = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.secilenTablo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exportList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkıs.Location = new System.Drawing.Point(982, 660);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(105, 43);
            this.btnCıkıs.TabIndex = 9;
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
            this.btnGeri.Location = new System.Drawing.Point(871, 660);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(105, 43);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            this.btnGeri.MouseLeave += new System.EventHandler(this.btnGeri_MouseLeave);
            this.btnGeri.MouseHover += new System.EventHandler(this.btnGeri_MouseHover);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.AliceBlue;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExport.Location = new System.Drawing.Point(12, 281);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(309, 43);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Listelenen Tabloyu Export Et";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            this.btnExport.MouseLeave += new System.EventHandler(this.btnExport_MouseLeave);
            this.btnExport.MouseHover += new System.EventHandler(this.btnExport_MouseHover);
            // 
            // secilenTablo
            // 
            this.secilenTablo.AllowUserToResizeRows = false;
            this.secilenTablo.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.secilenTablo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.secilenTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secilenTablo.Location = new System.Drawing.Point(327, 12);
            this.secilenTablo.Name = "secilenTablo";
            this.secilenTablo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.secilenTablo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.secilenTablo.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.secilenTablo.Size = new System.Drawing.Size(760, 312);
            this.secilenTablo.TabIndex = 6;
            // 
            // tbl_comboBox
            // 
            this.tbl_comboBox.BackColor = System.Drawing.Color.AliceBlue;
            this.tbl_comboBox.DropDownHeight = 110;
            this.tbl_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbl_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbl_comboBox.ForeColor = System.Drawing.Color.Black;
            this.tbl_comboBox.FormattingEnabled = true;
            this.tbl_comboBox.IntegralHeight = false;
            this.tbl_comboBox.Location = new System.Drawing.Point(12, 12);
            this.tbl_comboBox.Name = "tbl_comboBox";
            this.tbl_comboBox.Size = new System.Drawing.Size(309, 33);
            this.tbl_comboBox.TabIndex = 5;
            this.tbl_comboBox.SelectedIndexChanged += new System.EventHandler(this.tbl_comboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.exportList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 312);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Etmek İstediğiniz Tabloları Seçin";
            // 
            // exportList
            // 
            this.exportList.BackColor = System.Drawing.Color.AliceBlue;
            this.exportList.CheckOnClick = true;
            this.exportList.ForeColor = System.Drawing.Color.Black;
            this.exportList.FormattingEnabled = true;
            this.exportList.Location = new System.Drawing.Point(0, 28);
            this.exportList.Name = "exportList";
            this.exportList.Size = new System.Drawing.Size(395, 292);
            this.exportList.TabIndex = 0;
            this.exportList.SelectedIndexChanged += new System.EventHandler(this.exportList_SelectedIndexChanged);
            // 
            // exprt_exportList
            // 
            this.exprt_exportList.BackColor = System.Drawing.Color.AliceBlue;
            this.exprt_exportList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exprt_exportList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exprt_exportList.Location = new System.Drawing.Point(12, 710);
            this.exprt_exportList.Name = "exprt_exportList";
            this.exprt_exportList.Size = new System.Drawing.Size(279, 43);
            this.exprt_exportList.TabIndex = 11;
            this.exprt_exportList.Text = "Seçilen Tabloları Export Et";
            this.exprt_exportList.UseVisualStyleBackColor = false;
            this.exprt_exportList.Click += new System.EventHandler(this.exprt_exportList_Click);
            this.exprt_exportList.MouseLeave += new System.EventHandler(this.exprt_exportList_MouseLeave);
            this.exprt_exportList.MouseHover += new System.EventHandler(this.exprt_exportList_MouseHover);
            // 
            // dgv_exportList
            // 
            this.dgv_exportList.AllowUserToResizeRows = false;
            this.dgv_exportList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_exportList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_exportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_exportList.Location = new System.Drawing.Point(413, 370);
            this.dgv_exportList.Name = "dgv_exportList";
            this.dgv_exportList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_exportList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_exportList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_exportList.Size = new System.Drawing.Size(674, 284);
            this.dgv_exportList.TabIndex = 12;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.AliceBlue;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add.Location = new System.Drawing.Point(12, 661);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(279, 43);
            this.add.TabIndex = 13;
            this.add.Text = "Seçilen Tabloları Listele";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            this.add.MouseLeave += new System.EventHandler(this.add_MouseLeave);
            this.add.MouseHover += new System.EventHandler(this.add_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(426, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Export işleminden önce tabloları listelemeniz gerekmektedir!\r\n";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 760);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dgv_exportList);
            this.Controls.Add(this.exprt_exportList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.secilenTablo);
            this.Controls.Add(this.tbl_comboBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem Yapmak İstediğiniz Tabloyu Seçiniz";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secilenTablo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exportList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView secilenTablo;
        private System.Windows.Forms.ComboBox tbl_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox exportList;
        private System.Windows.Forms.Button exprt_exportList;
        private System.Windows.Forms.DataGridView dgv_exportList;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
    }
}