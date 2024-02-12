using System.Text.RegularExpressions;

namespace _07_palautus_Array
{
    public partial class Form1 : Form
    {
        public int[] numerot;
        public int muistipaikkoja = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTaulukko_Click(object sender, EventArgs e)
        {
            int annettu = Convert.ToInt32(tbKoko.Text);
            numerot = new int[annettu];
            muistipaikkoja = annettu;
            lblMuistipaikat.Text = muistipaikkoja.ToString();
        }

        private void btnTalleta_Click(object sender, EventArgs e)
        {
           
            try
            {
                int numero = Convert.ToInt32(tbNumero.Text);
                int indeksi = Convert.ToInt32(tbIndeksi.Text);
                if (muistipaikkoja > 0)
                {
                    if (Regex.IsMatch(tbNumero.Text, @"^-?[0-9]+$") && Regex.IsMatch(tbIndeksi.Text, @"^[0-9]+$"))
                    {


                        numerot[indeksi] = numero;
                        muistipaikkoja = 0;
                        foreach (int element in numerot)
                        {
                            if (element == 0)
                            {
                                muistipaikkoja++;
                            }
                        }
                        lblMuistipaikat.Text = muistipaikkoja.ToString();
                    }
                    else
                    {
                        if (indeksi < 0)
                        {
                            MessageBox.Show("Indeksi ei voi olla negatiivinen.");
                        }
                        else
                        {
                            MessageBox.Show("Syötä puuttuva numero.");
                        }

                    }
                }//muistipaikkoja
                else
                {
                    MessageBox.Show("Anna ensin muistipaikkojen määrä");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHae_Click(object sender, EventArgs e)
        {
            try
            {
                int indeksi = Convert.ToInt32(tbHaku.Text);
                lblResult.Text = numerot[indeksi].ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
