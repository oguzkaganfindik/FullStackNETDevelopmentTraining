namespace Forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            float sayi1 = Convert.ToSingle(txtSayi1.Text);
            float sayi2 = Convert.ToSingle(txtSayi2.Text);

            float toplam = sayi1 + sayi2;

            lblSonuc.Text = toplam.ToString();
            //lblSonuc.Text = Convert.ToString(toplam);
            //ToString() ve Convert.ToString(..) ayný iþi yapar
            //fakat ToString() o kadar popüler ki biz hep onu kullanýrýz.
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            float sayi1 = Convert.ToSingle(txtSayi1.Text);
            float sayi2 = Convert.ToSingle(txtSayi2.Text);

            float fark = sayi1 - sayi2;

            lblSonuc.Text = fark.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            float sayi1 = Convert.ToSingle(txtSayi1.Text);
            float sayi2 = Convert.ToSingle(txtSayi2.Text);

            float bolum = sayi1 / sayi2;

            lblSonuc.Text = bolum.ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            float sayi1 = Convert.ToSingle(txtSayi1.Text);
            float sayi2 = Convert.ToSingle(txtSayi2.Text);

            float carpim = sayi1 * sayi2;

            lblSonuc.Text = carpim.ToString();

            lblSonuc.ForeColor = Color.Red;
        }
    }
}