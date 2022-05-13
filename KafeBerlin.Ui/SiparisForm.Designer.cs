namespace KafeBerlin.Ui
{
    partial class SiparisForm
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
            this.cmb_Urun = new System.Windows.Forms.ComboBox();
            this.nud_Adet = new System.Windows.Forms.NumericUpDown();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_MasaNo = new System.Windows.Forms.ComboBox();
            this.btn_Tasi = new System.Windows.Forms.Button();
            this.dgv_Detaylar = new System.Windows.Forms.DataGridView();
            this.lbl_MasaNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_OdemeTutar = new System.Windows.Forms.Label();
            this.btn_SiparisIptal = new System.Windows.Forms.Button();
            this.btn_OdemeAl = new System.Windows.Forms.Button();
            this.btn_AnasayfaDon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detaylar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Urun
            // 
            this.cmb_Urun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Urun.FormattingEnabled = true;
            this.cmb_Urun.Location = new System.Drawing.Point(12, 32);
            this.cmb_Urun.Name = "cmb_Urun";
            this.cmb_Urun.Size = new System.Drawing.Size(156, 23);
            this.cmb_Urun.TabIndex = 0;
            // 
            // nud_Adet
            // 
            this.nud_Adet.Location = new System.Drawing.Point(194, 30);
            this.nud_Adet.Name = "nud_Adet";
            this.nud_Adet.Size = new System.Drawing.Size(120, 24);
            this.nud_Adet.TabIndex = 1;
            this.nud_Adet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_Adet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(335, 26);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(141, 33);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adet";
            // 
            // cmb_MasaNo
            // 
            this.cmb_MasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_MasaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MasaNo.FormattingEnabled = true;
            this.cmb_MasaNo.Location = new System.Drawing.Point(506, 32);
            this.cmb_MasaNo.Name = "cmb_MasaNo";
            this.cmb_MasaNo.Size = new System.Drawing.Size(116, 23);
            this.cmb_MasaNo.TabIndex = 5;
            // 
            // btn_Tasi
            // 
            this.btn_Tasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tasi.Location = new System.Drawing.Point(643, 26);
            this.btn_Tasi.Name = "btn_Tasi";
            this.btn_Tasi.Size = new System.Drawing.Size(107, 33);
            this.btn_Tasi.TabIndex = 6;
            this.btn_Tasi.Text = "Taşı";
            this.btn_Tasi.UseVisualStyleBackColor = true;
            // 
            // dgv_Detaylar
            // 
            this.dgv_Detaylar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Detaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detaylar.Location = new System.Drawing.Point(12, 71);
            this.dgv_Detaylar.Name = "dgv_Detaylar";
            this.dgv_Detaylar.Size = new System.Drawing.Size(464, 436);
            this.dgv_Detaylar.TabIndex = 7;
            // 
            // lbl_MasaNo
            // 
            this.lbl_MasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MasaNo.BackColor = System.Drawing.Color.Salmon;
            this.lbl_MasaNo.Font = new System.Drawing.Font("Calibri", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_MasaNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_MasaNo.Location = new System.Drawing.Point(506, 71);
            this.lbl_MasaNo.Name = "lbl_MasaNo";
            this.lbl_MasaNo.Size = new System.Drawing.Size(244, 201);
            this.lbl_MasaNo.TabIndex = 8;
            this.lbl_MasaNo.Text = "00";
            this.lbl_MasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ödeme Tutarı :";
            // 
            // lbl_OdemeTutar
            // 
            this.lbl_OdemeTutar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_OdemeTutar.Location = new System.Drawing.Point(603, 314);
            this.lbl_OdemeTutar.Name = "lbl_OdemeTutar";
            this.lbl_OdemeTutar.Size = new System.Drawing.Size(147, 17);
            this.lbl_OdemeTutar.TabIndex = 10;
            this.lbl_OdemeTutar.Text = "0.0 ₺";
            this.lbl_OdemeTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_SiparisIptal
            // 
            this.btn_SiparisIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SiparisIptal.BackColor = System.Drawing.Color.DarkRed;
            this.btn_SiparisIptal.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_SiparisIptal.Location = new System.Drawing.Point(506, 385);
            this.btn_SiparisIptal.Name = "btn_SiparisIptal";
            this.btn_SiparisIptal.Size = new System.Drawing.Size(107, 58);
            this.btn_SiparisIptal.TabIndex = 11;
            this.btn_SiparisIptal.Text = "SİPARİŞ İPTAL";
            this.btn_SiparisIptal.UseVisualStyleBackColor = false;
            // 
            // btn_OdemeAl
            // 
            this.btn_OdemeAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OdemeAl.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_OdemeAl.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_OdemeAl.Location = new System.Drawing.Point(643, 385);
            this.btn_OdemeAl.Name = "btn_OdemeAl";
            this.btn_OdemeAl.Size = new System.Drawing.Size(107, 58);
            this.btn_OdemeAl.TabIndex = 12;
            this.btn_OdemeAl.Text = "ÖDEME AL";
            this.btn_OdemeAl.UseVisualStyleBackColor = false;
            // 
            // btn_AnasayfaDon
            // 
            this.btn_AnasayfaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AnasayfaDon.BackColor = System.Drawing.Color.Gold;
            this.btn_AnasayfaDon.ForeColor = System.Drawing.Color.Black;
            this.btn_AnasayfaDon.Location = new System.Drawing.Point(506, 449);
            this.btn_AnasayfaDon.Name = "btn_AnasayfaDon";
            this.btn_AnasayfaDon.Size = new System.Drawing.Size(244, 58);
            this.btn_AnasayfaDon.TabIndex = 13;
            this.btn_AnasayfaDon.Text = "ANASAYFAYA DÖN";
            this.btn_AnasayfaDon.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Masa No";
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 519);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_AnasayfaDon);
            this.Controls.Add(this.btn_OdemeAl);
            this.Controls.Add(this.btn_SiparisIptal);
            this.Controls.Add(this.lbl_OdemeTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_MasaNo);
            this.Controls.Add(this.dgv_Detaylar);
            this.Controls.Add(this.btn_Tasi);
            this.Controls.Add(this.cmb_MasaNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.nud_Adet);
            this.Controls.Add(this.cmb_Urun);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SiparisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detaylar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Urun;
        private System.Windows.Forms.NumericUpDown nud_Adet;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_MasaNo;
        private System.Windows.Forms.Button btn_Tasi;
        private System.Windows.Forms.DataGridView dgv_Detaylar;
        private System.Windows.Forms.Label lbl_MasaNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_OdemeTutar;
        private System.Windows.Forms.Button btn_SiparisIptal;
        private System.Windows.Forms.Button btn_OdemeAl;
        private System.Windows.Forms.Button btn_AnasayfaDon;
        private System.Windows.Forms.Label label6;
    }
}