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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nud_BirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.dgv_Urunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.UrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Iptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Urunler)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_BirimFiyat
            // 
            this.nud_BirimFiyat.DecimalPlaces = 2;
            this.nud_BirimFiyat.Location = new System.Drawing.Point(379, 44);
            this.nud_BirimFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_BirimFiyat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_BirimFiyat.Name = "nud_BirimFiyat";
            this.nud_BirimFiyat.Size = new System.Drawing.Size(141, 24);
            this.nud_BirimFiyat.TabIndex = 1;
            this.nud_BirimFiyat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(649, 38);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(101, 33);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // dgv_Urunler
            // 
            this.dgv_Urunler.AllowUserToAddRows = false;
            this.dgv_Urunler.AllowUserToResizeColumns = false;
            this.dgv_Urunler.AllowUserToResizeRows = false;
            this.dgv_Urunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Urunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunAd,
            this.BirimFiyat});
            this.dgv_Urunler.Location = new System.Drawing.Point(0, 82);
            this.dgv_Urunler.MultiSelect = false;
            this.dgv_Urunler.Name = "dgv_Urunler";
            this.dgv_Urunler.ReadOnly = true;
            this.dgv_Urunler.RowHeadersVisible = false;
            this.dgv_Urunler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Urunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Urunler.Size = new System.Drawing.Size(762, 437);
            this.dgv_Urunler.TabIndex = 3;
            this.dgv_Urunler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Urunler_CellDoubleClick);
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
            this.label2.Location = new System.Drawing.Point(376, 9);
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
            // UrunAd
            // 
            this.UrunAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAd.DataPropertyName = "UrunAd";
            this.UrunAd.HeaderText = "Ürün Adı";
            this.UrunAd.Name = "UrunAd";
            this.UrunAd.ReadOnly = true;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BirimFiyat.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle10.Format = "c2";
            this.BirimFiyat.DefaultCellStyle = dataGridViewCellStyle10;
            this.BirimFiyat.HeaderText = "Birim Fiyatı";
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.ReadOnly = true;
            // 
            // btn_Iptal
            // 
            this.btn_Iptal.Location = new System.Drawing.Point(537, 38);
            this.btn_Iptal.Name = "btn_Iptal";
            this.btn_Iptal.Size = new System.Drawing.Size(101, 33);
            this.btn_Iptal.TabIndex = 7;
            this.btn_Iptal.Text = "İPTAL";
            this.btn_Iptal.UseVisualStyleBackColor = true;
            this.btn_Iptal.Visible = false;
            this.btn_Iptal.Click += new System.EventHandler(this.btn_Iptal_Click);
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 519);
            this.Controls.Add(this.btn_Iptal);
            this.Controls.Add(this.txt_UrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Urunler);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.nud_BirimFiyat);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UrunlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.Button btn_Iptal;
    }
}