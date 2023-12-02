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
            MessageBox.Show("Düþmana saldýrýldý.");
        }

        void Saldir(string isim)
        {
            MessageBox.Show(isim + " düþmana saldýrdý");
        }

        void Saldir(string isim, int hasarMiktari)
        {
            MessageBox.Show(isim + " düþmana " + hasarMiktari + " hasar verdi.");

        }

        // Ayný isimde birden fazla metot tanýmlarsanýz, bu durum metodun aþýrý yüklenmesidir ----> MethodOverloading

        // Ayný isimde birden fazla metot farklý parametrelerle farklý þekillerde çalýþýyor olabilir.

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