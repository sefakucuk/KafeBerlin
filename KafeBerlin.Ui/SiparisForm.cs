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
    public partial class SiparisForm : Form
    {
        private readonly KafeVeri _db;
        private readonly Siparis _siparis;
        BindingList<SiparisDetay> _blSiparisDetaylar;

        public SiparisForm(KafeVeri db, Siparis siparis)
        {
            _db = db;
            _siparis = siparis;
            InitializeComponent();
            dgv_Detaylar.AutoGenerateColumns = false;
            MasaNoGuncelle();
            OdemeTutariGuncelle();
            UrunleriListele();
            DetaylariListele();
        }

        private void DetaylariListele()
        {
            _blSiparisDetaylar = new BindingList<SiparisDetay>(_siparis.SiparisDetaylar);
            _blSiparisDetaylar.ListChanged += _blSiparisDetaylar_ListChanged;
            dgv_Detaylar.DataSource = _blSiparisDetaylar;
            //dgv_Detaylar.Columns[0].HeaderText = "Ürün"; // Elle manuel değişiklik
        }


        private void _blSiparisDetaylar_ListChanged(object sender, ListChangedEventArgs e)
        {
            OdemeTutariGuncelle();
        }

        private void OdemeTutariGuncelle()
        {
            lbl_OdemeTutar.Text = _siparis.ToplamTutarTL;
        }

        private void UrunleriListele()
        {
            cmb_Urun.DataSource = _db.Urunler;
        }

        private void MasaNoGuncelle()
        {
            Text = $"Masa {_siparis.MasaNo}";
            lbl_MasaNo.Text = _siparis.MasaNo.ToString("00");
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (cmb_Urun.SelectedItem == null)
            {
                MessageBox.Show("Önce bir ürün seçiniz!");
                return;
            }

            Urun urun = (Urun)cmb_Urun.SelectedItem;
            _blSiparisDetaylar.Add(new SiparisDetay()
            {
                Adet = (int)nud_Adet.Value,
                UrunAd = urun.UrunAd,
                BirimFiyat = urun.BirimFiyat
            });
            nud_Adet.Value = 1;
        }

        private void btn_AnasayfaDon_Click(object sender, EventArgs e)
        {
            Close();
            // DialogResult = DialogResult.Cancel; Bu şekilde de formu kapatabiliriz...
        }

        private void btn_SiparisIptal_Click(object sender, EventArgs e)
        {
            SiparisKapat(0, SiparisDurum.Iptal);
        }

        private void btn_OdemeAl_Click(object sender, EventArgs e)
        {
            SiparisKapat(_siparis.ToplamTutar(), SiparisDurum.Odendi);
        }

        private void SiparisKapat(decimal odenenTutar, SiparisDurum durum)
        {
            string eylem = durum == SiparisDurum.Iptal ? "iptal edilecektir" : "kapatılacaktır";
            string baslik = durum == SiparisDurum.Iptal ? "İptal" : "Kapatma";

            DialogResult dr = MessageBox.Show($"{_siparis.MasaNo} nolu masanın siparişi {eylem}. Emin misiniz ?", $"Sipariş {baslik} Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                _siparis.OdenenTutar = odenenTutar;
                _siparis.Durum = durum;
                _db.AktifSiparisler.Remove(_siparis);
                _db.GecmisSiparisler.Add(_siparis);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
