namespace _27__AtYarisiOyunuFormUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int at1Baslangic, at2Baslangic, at3Baslangic;
        string tahmin;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "At Yarýþý Uygulamasý";
            btnSifirla.Enabled = false;

            at1Baslangic = pcbAt1.Left;
            at2Baslangic = pcbAt2.Left;
            at3Baslangic = pcbAt3.Left;

            btnBaslat.Enabled = false; //Tahmin girilmeden oyun baþlasýn istemediðim için.
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnBaslat.Enabled = false;
        }

        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            pcbAt1.Left = pcbAt1.Left + rnd.Next(10, 25);
            pcbAt2.Left = pcbAt2.Left + rnd.Next(10, 15);
            pcbAt3.Left = pcbAt3.Left + rnd.Next(1, 35);

            string mesaj = "Birinci at önde!";
            int birincininYeri = pcbAt1.Left;

            if (pcbAt2.Left > birincininYeri)
            {
                birincininYeri = pcbAt2.Left;
                mesaj = "Ýkinci at önde";
            }

            if (pcbAt3.Left > birincininYeri)
            {
                birincininYeri = pcbAt3.Left;
                mesaj = "Ücüncü at önde";
            }

            lblDurum.Text = mesaj;

            // Her tikte bütün atlarým için tek tek bitiþ çizgisine varmýþ mý veya geçmiþ mi diye kontrol etmem gerekiyor.

            // Eðer atlardan herhangi biri yarýþý bitirdiyse timer'ýn artýk durmasý ve atlarýn pozisyon deðiþtirmemesi gerekiyor.

            // Kazanan kýrmýzý bir yazi ile ilan edilmeli ve bu noktadan sonra yarýþý sýfýrla butonu yeniden týklanabilir hale gelmeli.

            if (pcbAt1.Right >= lblFinish.Left)
            {
                lblDurum.Text = "1. At Yarýþý Kazandý !!!";
                lblDurum.ForeColor = Color.Red;
                timer1.Stop();
                btnSifirla.Enabled = true;

                if (tahmin == "Gönlüþahane")
                {
                    MessageBox.Show("DOÐRU TAHMÝN!");
                }
                else
                {
                    MessageBox.Show("KUPON YATTI!");
                }
            }

            else if (pcbAt2.Right >= lblFinish.Left)
            {
                lblDurum.Text = "2. At Yarýþý Kazandý !!!";
                lblDurum.ForeColor = Color.Red;
                timer1.Stop();
                btnSifirla.Enabled = true;

                if (tahmin == "Karasevda")
                {
                    MessageBox.Show("DOÐRU TAHMÝN!");
                }
                else
                {
                    MessageBox.Show("KUPON YATTI!");
                }

            }

            else if (pcbAt3.Right >= lblFinish.Left)
            {
                lblDurum.Text = "3. At Yarýþý Kazandý !!!";
                lblDurum.ForeColor = Color.Red;
                timer1.Stop();
                btnSifirla.Enabled = true;

                if (tahmin == "Küheylan")
                {
                    MessageBox.Show("DOÐRU TAHMÝN!");
                }
                else
                {
                    MessageBox.Show("KUPON YATTI!");
                }
            }

        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            pcbAt1.Left = at1Baslangic;
            pcbAt2.Left = at2Baslangic;
            pcbAt3.Left = at3Baslangic;

            lblDurum.Text = "-";
            lblDurum.ForeColor = Color.White;

            btnSifirla.Enabled = false;

            txtTahmin.Text = "";
            txtTahmin.Enabled = true; // yarýþ sýfýrlanýnca yeni bir tahminde bulunulabilsin.

            btnTahmin.Enabled = true;
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (txtTahmin.Text != "Gönlüþahane" && txtTahmin.Text != "Karasevda" && txtTahmin.Text != "Küheylan")
            {
                MessageBox.Show("Böyle bir at yok!");
            }
            else
            {
                txtTahmin.Enabled = false;
                btnTahmin.Enabled = false;
                //btnTahmin.Visible = false;
                //txtTahmin.Visible = false;
                tahmin = txtTahmin.Text;

                // Tahminde bulunulduðuna göre artýk yarýþý baþlat'a basýlabilsin.

                btnBaslat.Enabled = true;
            }

        }
    }
}