namespace _064__MethodOverloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Saldir()
        {
            MessageBox.Show("D��mana sald�r�ld�.");
        }

        void Saldir(string isim)
        {
            MessageBox.Show(isim + " d��mana sald�rd�");
        }

        void Saldir(string isim, int hasarMiktari)
        {
            MessageBox.Show(isim + " d��mana " + hasarMiktari + " hasar verdi.");

        }

        // Ayn� isimde birden fazla metot tan�mlarsan�z, bu durum metodun a��r� y�klenmesidir ----> MethodOverloading

        // Ayn� isimde birden fazla metot farkl� parametrelerle farkl� �ekillerde �al���yor olabilir.

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            Saldir();
        }

        private void btnOkAt_Click(object sender, EventArgs e)
        {
            Saldir("Legolas");
        }

        private void btnBuyuYap_Click(object sender, EventArgs e)
        {
            Saldir("Gandalf", 80);
        }

    }
}