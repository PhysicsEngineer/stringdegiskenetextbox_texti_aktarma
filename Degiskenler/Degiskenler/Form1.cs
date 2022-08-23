namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad, meslek;
            adsoyad = "Cem Tuðanlý";
            meslek = "Öðretmen";
            label1.Text = adsoyad;
            label2.Text = meslek;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sehir;
            sehir = textBox1.Text;
            label3.Text = sehir;
            MessageBox.Show("Yaptýnýz");
        }
    }
}