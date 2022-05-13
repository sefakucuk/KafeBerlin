namespace KafeBerlin.Ui
{
    partial class UrunlerForm
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
            this.nud_BirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.dgv_Urunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Urunler)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_BirimFiyat
            // 
            this.nud_BirimFiyat.Location = new System.Drawing.Point(395, 44);
            this.nud_BirimFiyat.Name = "nud_BirimFiyat";
            this.nud_BirimFiyat.Size = new System.Drawing.Size(141, 24);
            this.nud_BirimFiyat.TabIndex = 1;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(571, 38);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(179, 33);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            // 
            // dgv_Urunler
            // 
            this.dgv_Urunler.AllowUserToAddRows = false;
            this.dgv_Urunler.AllowUserToDeleteRows = false;
            this.dgv_Urunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Urunler.Location = new System.Drawing.Point(0, 82);
            this.dgv_Urunler.Name = "dgv_Urunler";
            this.dgv_Urunler.ReadOnly = true;
            this.dgv_Urunler.Size = new System.Drawing.Size(762, 437);
            this.dgv_Urunler.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Birim Fiyatı (₺)";
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Location = new System.Drawing.Point(12, 44);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(334, 24);
            this.txt_UrunAdi.TabIndex = 6;
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 519);
            this.Controls.Add(this.txt_UrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Urunler);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.nud_BirimFiyat);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UrunlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)(this.nud_BirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Urunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nud_BirimFiyat;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.DataGridView dgv_Urunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UrunAdi;
    }
}