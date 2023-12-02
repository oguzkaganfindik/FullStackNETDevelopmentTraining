namespace Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label'a Týkladým");
        }

        private void btnButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buraya Bakarlar");
        }

        private void btnDeneme2_Click(object sender, EventArgs e)
        {

            string mesaj = txtMesaj.Text;
            MessageBox.Show("Girilen mesaj -> " + mesaj);
        }

        private void txtMesaj_TextChanged(object sender, EventArgs e)
        {

        }
    }
}