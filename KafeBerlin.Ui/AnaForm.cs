using System;
using System.Linq;
using System.Windows.Forms;
using KafeBerlin.Data;

namespace KafeBerlin.Ui
{
    public partial class AnaForm : Form
    {
        KafeVeri db = new KafeVeri();
        public AnaForm()
        {
            InitializeComponent();
            MasalariYukle();
            OrnekUrunlerYukle();
        }

        private void OrnekUrunlerYukle()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Çay", BirimFiyat = 6.00m });
            db.Urunler.Add(new Urun() { UrunAd = "Simit", BirimFiyat = 5.00m });
        }

        private void MasalariYukle()
        {
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                var lvi = new ListViewItem($"Masa {i}");
                lvi.ImageKey = "bos";
                lvi.Tag = i; // List view kimliği gibi oldu ve daha sonra kullanmak için tag'da numarasını tuttuk
                lvw_Masalar.Items.Add(lvi);
            }
        }

        private void lvw_Masalar_DoubleClick(object sender, System.EventArgs e)
        {
            var lvi = lvw_Masalar.SelectedItems[0];
            int masaNo = (int)lvi.Tag;
            var siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);
            if (siparis == null)
            {
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
                lvi.ImageKey = "dolu";
            }
            // sipariş yoksa oluşturduk varsa olanı getirdik
            var dr = new SiparisForm(db, siparis).ShowDialog();

            if (dr == DialogResult.OK)
            {
                lvi.ImageKey = "bos";
                lvi.Selected = false;
            }
        }
    }
}
