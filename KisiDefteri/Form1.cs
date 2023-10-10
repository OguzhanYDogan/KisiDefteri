using System.Text.Encodings.Web;
using System.Text.Json;

namespace KisiDefteri
{
    public partial class Form1 : Form
    {
        List<Kisi> kisiler;

        public Form1()
        {
            InitializeComponent();
            VerileriYukle();
            Listele();
        }

        private void VerileriYukle()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                kisiler = JsonSerializer.Deserialize<List<Kisi>>(json)!; // Serilize edilmi� json tekrar list hale gelir.
            }
            catch (Exception)
            {
                OrnekVerileriEkle();
            }
        }

        private void OrnekVerileriEkle()
        {
            kisiler = new List<Kisi>()
            {
                new Kisi() { Ad = "Ali", Soyad = "Y�lmaz" },
                new Kisi() { Ad = "Can", Soyad = "�zt�rk" },
                new Kisi() { Ad = "Cem", Soyad = "�ahin" },
                new Kisi() { Ad = "Ece", Soyad = "Do�an" }
            };
        }

        public void Listele()
        {
            lstKisiler.Items.Clear();
            foreach (Kisi kisi in kisiler)
                lstKisiler.Items.Add(kisi); // Ki�i class�nda TamAd tan�mlad�k. Design sayfas�nda da Displaymember olarak onu se�tik. �stersek Ad veya Soyad se�ilebilir.
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            if (ad == "" || soyad == "")
            {
                MessageBox.Show("Ad ve Soyad zorunlu!");
                return;
            }
            Kisi k = new Kisi() { Ad = ad, Soyad = soyad };
            kisiler.Add(k);
            Listele();
            lstKisiler.SelectedItem = k;
            txtAd.Clear();
            txtSoyad.Clear();
            txtAd.Focus();
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            int sid = lstKisiler.SelectedIndex;
            if (sid < 1)
                return;
            SeciliyiTasi(sid - 1);
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            int sid = lstKisiler.SelectedIndex;
            if (sid == lstKisiler.Items.Count - 1 || sid == -1)
                return;
            SeciliyiTasi(sid + 1);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sid = lstKisiler.SelectedIndex;
            if (lstKisiler.SelectedItem == null)
            {
                MessageBox.Show("Silinecek ki�iyi se�iniz.");
                return;
            }

            DialogResult result = MessageBox.Show("Emin misin?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                kisiler.RemoveAt(sid);
                Listele();
                lstKisiler.SelectedIndex = Math.Min(sid, kisiler.Count - 1);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedIndex < 0)
            {
                MessageBox.Show("D�zenlenecek ki�iyi se�iniz.");
                return;
            }
            int sid = lstKisiler.SelectedIndex;
            Kisi kisi = kisiler[sid];
            DuzenleForm frmDuzenle = new DuzenleForm(kisi);
            frmDuzenle.ShowDialog();
            Listele();
            lstKisiler.SelectedIndex = sid;
        }

        private void SeciliyiTasi(int yeniIndeks)
        {
            Kisi kisi = kisiler[lstKisiler.SelectedIndex];
            kisiler.RemoveAt(lstKisiler.SelectedIndex);
            kisiler.Insert(yeniIndeks, kisi);
            Listele();
            lstKisiler.SelectedIndex = yeniIndeks;
        }

        private void lstKisiler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                btnSil.PerformClick();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(kisiler, options);
            File.WriteAllText("veri.json", json);
        }
    }
}