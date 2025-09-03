namespace DsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cantor ExibirCantor = new Cantor();
            this.Hide();
            ExibirCantor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Album ExibirAlbum = new Album();
            this.Hide();
            ExibirAlbum.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musicas ExibirMusica = new musicas();
            this.Hide();
            ExibirMusica.ShowDialog();
        }
    }
}
