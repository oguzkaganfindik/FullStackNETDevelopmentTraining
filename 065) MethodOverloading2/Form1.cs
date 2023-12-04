namespace _065__MethodOverloading2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void SelamVer()
        {
            MessageBox.Show("Merhaba");
        }

        void SelamVer(string ad, string soyad)
        {
            MessageBox.Show("Merhaba " + ad + " " + soyad);
        }

        void SelamVer(string ad, string soyad, int tekrarSayisi)
        {
            for (int i = 0; i < tekrarSayisi; i++)
            {
                MessageBox.Show("Merhaba " + ad + " " + soyad);
            }
        }

        private void btnSelamVer1_Click(object sender, EventArgs e)
        {
            SelamVer();
        }

        private void btnSelamVer2_Click(object sender, EventArgs e)
        {
            string ad = txtAd1.Text;
            string soyad = txtSoyad1.Text;

            SelamVer(ad, soyad);
        }

        private void btnSelamVer3_Click(object sender, EventArgs e)
        {
            string ad = txtAd2.Text;
            string soyad = txtSoyad2.Text;
            int tekrarSayisi = Convert.ToInt32(txtTekrar2.Text);

            SelamVer(ad, soyad, tekrarSayisi);
        }
    }
}