using System.Text.RegularExpressions;

namespace _01WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Tiina Kuustie");
        }

        private void btnUusi_Click(object sender, EventArgs e)
        {
            tbID.Text = "0";
            tbNimi.Text = "[Syötä elokuvan nimi]";
            tbKesto.Text = "0";

            DateTime dateTime = DateTime.Now;

            tbVuosi.Text = dateTime.Year.ToString();
            rtbArvio.Text = "[Kirjoita arvio tähän]";
            nudFirst.Value = 5;
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void tbKesto_MouseClick(object sender, MouseEventArgs e)
        {
            tbKesto.Text = "";
        }

        private void rtbArvio_MouseClick(object sender, MouseEventArgs e)
        {
            rtbArvio.Text = "";
        }

        private void tbNimi_MouseClick(object sender, MouseEventArgs e)
        {
            tbNimi.Text = "";
        }

        private void tbKesto_MouseLeave(object sender, EventArgs e)
        {
            if (tbKesto.Text == "")
            {
                tbKesto.Text = "0";
            }
        }

        private void rtbArvio_MouseLeave(object sender, EventArgs e)
        {
            if (rtbArvio.Text == "")
            { rtbArvio.Text = "[Kirjoita arvio tähän]"; }
        }

        private void tbNimi_MouseLeave(object sender, EventArgs e)
        {
            if (tbNimi.Text == "")
            {
                tbNimi.Text = "[Syötä elokuvan nimi]";
            }


        }


        /*

    Kun painetaan tallenna, tarkistetaan yhdessä samassa if-else rakenteessa:

    Onko tekstiä syötetty ollenkaan (eli onko kenttä tyhjä)

    Onko tekstin muoto oikea numerokentissä (kesto ja julkaisuvuosi saa sisältää vain numeroita)

    Jos tulee virhe, laitetaan MessageBox-ilmoitus ohjelmaan
*/
        private void btnTallenna_Click(object sender, EventArgs e)
        {
            string kesto = tbKesto.Text;
            string vuosi = tbVuosi.Text;
            string nimi = tbNimi.Text;

            string kestolause = "";
            string vuosilause = "";
            string nimilause = "";
            string pituus = "";
            string aika = "";

            if (nimi != "[Syötä elokuvan nimi]" && Regex.IsMatch(kesto, @"^[0-9]+$") && Regex.IsMatch(vuosi, @"^[0-9]+$") && vuosi.Length == 4)
            {
            }
            else 
            { 

                if (!Regex.IsMatch(kesto, @"^[0-9]+$") && Regex.IsMatch(vuosi, @"^[0-9]+$"))
                {
                    kestolause = "Syötä vain numeroita elokuvan kestoon.";
                    vuosilause = "\n";
                }
                 else if (!Regex.IsMatch(kesto, @"^[0-9]+$") && !Regex.IsMatch(vuosi, @"^[0-9]+$"))
                {
                    kestolause = "Syötä vain numeroita elokuvan kestoon ja ";
                     vuosilause = "julkaisuvuoteen.\n";
                }
                else if (Regex.IsMatch(kesto, @"^[0-9]+$") && !Regex.IsMatch(vuosi, @"^[0-9]+$"))
                {
                    kestolause = "\"Syötä vain numeroita ";
                    vuosilause = "elokuvan julkaisuvuoteen.\n";
                }
                if(vuosi.Length != 4)
                {
                    pituus = "Anna vuosilukuun neljä numeroa.\n";
                }
                if ((vuosi.Length == 4 && Convert.ToInt32(vuosi) < 1888) || Convert.ToInt32(vuosi) > Convert.ToInt32(DateTime.Now.Year))
                {
                    pituus = "Tarkista vuosiluku.\n";
                }


                if (Convert.ToInt32(kesto) <= 0)
                {
                    aika = "Anna elokuvan kesto minuutteina.\n";
                }
        
                if (nimi == "[Syötä elokuvan nimi]" )
                {
                    nimilause = "Anna elokuvan nimi.";
                }
                else
                {
                    nimilause = "";
                }
                MessageBox.Show(kestolause+vuosilause+pituus+aika+nimilause);
            
            }//else
        }
    }
}
