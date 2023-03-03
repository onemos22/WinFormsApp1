namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public string CodFisc = "";

        public string Nome;

        public string Cognome;

        public string[] Comuni = File.ReadAllLines(@"C:\Users\luca.serrapica\Downloads\ElencoComuni.csv");

        public string[] Mesi = { "gennaio", "febbraio", "marzo", "aprile", "maggio", "giugno", "luglio", "agosto", "settembre", "ottobre", "novembre", "dicembre" };

        public string Sesso;
        public Form1()
        {
            InitializeComponent();

           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbt_m_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}