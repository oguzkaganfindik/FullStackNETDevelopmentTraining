using _085__KurtAdamIstilasi.Models;

namespace _085__KurtAdamIstilasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Kurt Adam Oyunu";
            lblHealth.BackColor = Color.Green;
        }

        Hero hero;  // SE� butonu i�erisinde olu�turulup SALDIR butonunda metodu kullan�laca��ndan global olarak tan�mland�.

        private void btnChoose_Click(object sender, EventArgs e)
        {
            hero = new Hero()
            {
                NickName = txtNickName.Text,
                Race = cmbRace.SelectedItem.ToString(),
                Branch = cmbBranch.SelectedItem.ToString()
            };
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            hero.Attack(); // ilgili kahramana bir hasar miktar� (damage) hesapland�.

            lblHealth.Width = lblHealth.Width - hero.Damage;

            if(lblHealth.Width > 90)
            {
                lblHealth.BackColor = Color.DarkOrange;
            }
            else if (lblHealth.Width > 70)
            {
                lblHealth.BackColor = Color.OrangeRed;
            }
            else if(lblHealth.Width > 40)
            {
                lblHealth.BackColor = Color.Red;
            }
            else if (lblHealth.Width > 10)
            {
                lblHealth.BackColor = Color.DarkRed;
            }


            if (lblHealth.Width == 0)
                MessageBox.Show("Ya�as�n kurt adamdan kurtulduk.");
        }
    }
}
