using KafeBerlin.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeBerlin.Ui
{
    public partial class UrunlerForm : Form
    {
        private readonly KafeVeri _db;
        BindingList<Urun> _blUrunler;
        Urun _duzenlenen;
        public UrunlerForm(KafeVeri db)
        {
            _db = db;
            InitializeComponent();
            dgv_Urunler.AutoGenerateColumns = false;
            _blUrunler = new BindingList<Urun>(_db.Urunler);
            dgv_Urunler.DataSource = _blUrunler;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            string ad = txt_UrunAdi.Text.Trim();

            if (ad == " ")
            {
                MessageBox.Show("Lütfen Ürün Adı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_duzenlenen == null)
            {
                _blUrunler.Add(new Urun()
                {
                    UrunAd = ad,
                    BirimFiyat = nud_BirimFiyat.Value
                });
            }
            else
            {
                _duzenlenen.UrunAd = ad;
                _duzenlenen.BirimFiyat = nud_BirimFiyat.Value;
            }

            Sifirla();
        }

        private void dgv_Urunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var satir = dgv_Urunler.Rows[e.RowIndex];
            _duzenlenen = (Urun)satir.DataBoundItem;

            btn_Ekle.Text = "KAYDET";
            txt_UrunAdi.Text = _duzenlenen.UrunAd;
            nud_BirimFiyat.Value = _duzenlenen.BirimFiyat;
            dgv_Urunler.Enabled = false;

            btn_Iptal.Visible = true;
        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            Sifirla();

        }

        private void Sifirla()
        {
            _duzenlenen = null;
            btn_Ekle.Text = "EKLE";
            txt_UrunAdi.Clear();
            nud_BirimFiyat.Value = 1;
            dgv_Urunler.Enabled = true;
            btn_Iptal.Visible = false;
        }
    }
}
