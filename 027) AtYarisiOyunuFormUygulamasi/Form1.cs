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
            this.Text = "At Yar��� Uygulamas�";
            btnSifirla.Enabled = false;

            at1Baslangic = pcbAt1.Left;
            at2Baslangic = pcbAt2.Left;
            at3Baslangic = pcbAt3.Left;

            btnBaslat.Enabled = false; //Tahmin girilmeden oyun ba�las�n istemedi�im i�in.
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

            string mesaj = "Birinci at �nde!";
            int birincininYeri = pcbAt1.Left;

            if (pcbAt2.Left > birincininYeri)
            {
                birincininYeri = pcbAt2.Left;
                mesaj = "�kinci at �nde";
            }

            if (pcbAt3.Left > birincininYeri)
            {
                birincininYeri = pcbAt3.Left;
                mesaj = "�c�nc� at �nde";
            }

            lblDurum.Text = mesaj;

            // Her tikte b�t�n atlar�m i�in tek tek biti� �izgisine varm�� m� veya ge�mi� mi diye kontrol etmem gerekiyor.

            // E�er atlardan herhangi biri yar��� bitirdiyse timer'�n art�k durmas� ve atlar�n pozisyon de�i�tirmemesi gerekiyor.

            // Kazanan k�rm�z� bir yazi ile ilan edilmeli ve bu noktadan sonra yar��� s�f�rla butonu yeniden t�klanabilir hale gelmeli.

            if (pcbAt1.Right >= lblFinish.Left)
            {
                lblDurum.Text = "1. At Yar��� Kazand� !!!";
                lblDurum.ForeColor = Color.Red;
                timer1.Stop();
                btnSifirla.Enabled = true;

                if (tahmin == "G�nl��ahane")
                {
                    MessageBox.Show("DO�RU TAHM�N!");
                }
                else
                {
                    MessageBox.Show("KUPON YATTI!");
                }
            }

            else if (pcbAt2.Right >= lblFinish.Left)
            {
                lblDurum.Text = "2. At Yar��� Kazand� !!!";
                lblDurum.ForeColor = Color.Red;
                timer1.Stop();
                btnSifirla.Enabled = true;

                if (tahmin == "Karasevda")
                {
                    MessageBox.Show("DO�RU TAHM�N!");
                }
                else
                {
                    MessageBox.Show("KUPON YATTI!");
                }

            }

            else if (pcbAt3.Right >= lblFinish.Left)
            {
                lblDurum.Text = "3. At Yar��� Kazand� !!!";
                lblDurum.ForeColor = Color.Red;
                timer1.Stop();
                btnSifirla.Enabled = true;

                if (tahmin == "K�heylan")
                {
                    MessageBox.Show("DO�RU TAHM�N!");
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
            txtTahmin.Enabled = true; // yar�� s�f�rlan�nca yeni bir tahminde bulunulabilsin.

            btnTahmin.Enabled = true;
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (txtTahmin.Text != "G�nl��ahane" && txtTahmin.Text != "Karasevda" && txtTahmin.Text != "K�heylan")
            {
                MessageBox.Show("B�yle bir at yok!");
            }
            else
            {
                txtTahmin.Enabled = false;
                btnTahmin.Enabled = false;
                //btnTahmin.Visible = false;
                //txtTahmin.Visible = false;
                tahmin = txtTahmin.Text;

                // Tahminde bulunuldu�una g�re art�k yar��� ba�lat'a bas�labilsin.

                btnBaslat.Enabled = true;
            }

        }
    }
}