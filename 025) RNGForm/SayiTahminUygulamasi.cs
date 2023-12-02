namespace _25__RNGForm
{
    public partial class SayiTahminUygulamasi : Form
    {
        int rastgele; //Global değişken (her local'de tanınsın)
        int canHakki;
        int tahminSayisi;
        public SayiTahminUygulamasi()
        {
            InitializeComponent();
        }

        private void SayiTahminUygulamasi_Load(object sender, EventArgs e)
        {
            // Form_Load -> Form yüklenirken 1 seferlik tetiklenen kodlar.
            Random rnd = new Random();
            rastgele = rnd.Next(1, 11);
            //lblRastgele.Text = rastgele.ToString();
            //test aşamasında veriyi görmek için
            canHakki = 3;
            tahminSayisi = 0;

            lblCanHakki.Text = canHakki.ToString();
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(txtTahmin.Text);
            // local değişken, yalnızca bu scope'ta tanınır.
            tahminSayisi++;

            if (tahmin == rastgele)
            {
                MessageBox.Show("Doğru Tahmin ----" + tahminSayisi + ". tahminde bildiniz.");
                btnTahminEt.Enabled = false;
            }
            else
            {
                canHakki--;
                lblCanHakki.Text = canHakki.ToString();
                if (canHakki == 0)
                {
                    btnTahminEt.Enabled = false;
                    MessageBox.Show("Başka can hakkınız kalmadığı için oyunu kaybettiniz.");
                }
                else
                {
                    if (tahmin > rastgele)
                    {
                        MessageBox.Show("Daha küçük bir sayı giriniz.");
                    }
                    else
                    {
                        MessageBox.Show("Daha büyük bir sayı deneyiniz.");
                    }
                }
            }
        }

        private void btnYenidenBasla_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
