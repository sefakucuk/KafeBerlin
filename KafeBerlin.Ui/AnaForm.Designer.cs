namespace KafeBerlin.Ui
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_Urunler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_GecmisSiparisler = new System.Windows.Forms.ToolStripMenuItem();
            this.lvw_Masalar = new System.Windows.Forms.ListView();
            this.iml_Buyuk = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Urunler,
            this.tsmi_GecmisSiparisler});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_Urunler
            // 
            this.tsmi_Urunler.Name = "tsmi_Urunler";
            this.tsmi_Urunler.Size = new System.Drawing.Size(68, 22);
            this.tsmi_Urunler.Text = "Ürünler";
            // 
            // tsmi_GecmisSiparisler
            // 
            this.tsmi_GecmisSiparisler.Name = "tsmi_GecmisSiparisler";
            this.tsmi_GecmisSiparisler.Size = new System.Drawing.Size(127, 22);
            this.tsmi_GecmisSiparisler.Text = "Geçmiş Siparişler";
            // 
            // lvw_Masalar
            // 
            this.lvw_Masalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw_Masalar.HideSelection = false;
            this.lvw_Masalar.LargeImageList = this.iml_Buyuk;
            this.lvw_Masalar.Location = new System.Drawing.Point(0, 26);
            this.lvw_Masalar.Name = "lvw_Masalar";
            this.lvw_Masalar.Size = new System.Drawing.Size(653, 424);
            this.lvw_Masalar.TabIndex = 1;
            this.lvw_Masalar.UseCompatibleStateImageBehavior = false;
            this.lvw_Masalar.DoubleClick += new System.EventHandler(this.lvw_Masalar_DoubleClick);
            // 
            // iml_Buyuk
            // 
            this.iml_Buyuk.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iml_Buyuk.ImageStream")));
            this.iml_Buyuk.TransparentColor = System.Drawing.Color.Transparent;
            this.iml_Buyuk.Images.SetKeyName(0, "bos");
            this.iml_Buyuk.Images.SetKeyName(1, "dolu");
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.lvw_Masalar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kafe Berlin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Urunler;
        private System.Windows.Forms.ToolStripMenuItem tsmi_GecmisSiparisler;
        private System.Windows.Forms.ListView lvw_Masalar;
        private System.Windows.Forms.ImageList iml_Buyuk;
    }
}

