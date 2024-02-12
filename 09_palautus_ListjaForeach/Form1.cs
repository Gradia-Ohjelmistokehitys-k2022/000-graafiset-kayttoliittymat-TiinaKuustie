namespace _09_palautus_ListjaForeach
{
    public partial class Form1 : Form
    {
        public List<string> lista;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            lista = new List<string>();
            lblLista.Text = "Lista luotu";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lista.Add(tbSanat.Text);
            MessageBox.Show(tbSanat.Text + " lisätty.");
            fillCombo();
        }
   
        private void fillCombo()
        {
            /* 
            //TÄLLEI MÄ TEKISIN TÄN OIKEASTI ja sit Hae nappulalla tehtäis jotakin sille valitulle
            cbHae.DataSource = null;
            lista.Sort();
            cbHae.DataSource = lista;
            //  mut tehtävänannossa käskettiin tekeen foreach looppi Hae nappulaan 
            */
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lista.Sort();
            foreach (string s in lista)
            {
                cbHae.Items.Add(s);
            }
        }
    }
}
