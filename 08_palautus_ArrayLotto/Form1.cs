using System.Runtime.InteropServices;
using System.Data;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;

namespace _08_palautus_ArrayLotto
{
    public partial class Form1 : Form
    {
        public int[] lottorivi;
        public int[] joarvottu;
        public int[] lisanumero;
        //§§§§§§§ MAHDOLLISTAA CONSOLE.WRITELINEN WINFORMSISSA §§§§§§
        [DllImport("Kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        //§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
        public Form1()
        {
            InitializeComponent();
            AllocConsole();
        }

        private void btnArvo_Click(object sender, EventArgs e)
        {
           lottorivi = new int[7];
            Random rnd = new Random();
           joarvottu = new int[9];
            lisanumero = new int[2];

            for (int i = 0; i < 7; i++)
            {
                int arpa = rnd.Next(1, 41);

                if (Array.IndexOf(lottorivi, arpa) == -1)
                {
                    lottorivi[i] = arpa;
                    joarvottu[i] = arpa;
                   
                }
                else {  i--;  }
            } //for

            for (int x = 0; x < 2; x++)
            {
                int arpa2 = rnd.Next(1, 41);

                if (Array.IndexOf(joarvottu, arpa2) == -1)
                {
                    lisanumero[x] = arpa2;
                }
                else { x--; }
            }
            Array.Sort(lisanumero);

            lblLisa.Text = $"Lis‰numerot: {lisanumero[0]} ja {lisanumero[1]}";

                Array.Sort(lottorivi); // Sorts the array in ascending order
            string rivi = "";
            foreach (int num in lottorivi)
            {
                rivi = rivi + $"{num.ToString()}, ";
            }

            string modrivi = rivi.Remove(rivi.Length - 2);
            lblLottorivi.Text = modrivi;
        }

        private void btnTarkista_Click(object sender, EventArgs e)
        {
           
            int[] omarivi = new int[7];

            int y = 0;
            foreach (Control control in this.Controls)
            {
                bool test = false;
                if (control is TextBox textBox)
                {
                  
                    if (textBox.Text.Length > 0)
                    {
                        int numx = Convert.ToInt32(textBox.Text);
                        if ( numx < 41 && numx > 0 && Regex.IsMatch(textBox.Text, @"^[0-9]+$"))
                        {

                         
                            foreach (int num in omarivi)
                            {
                                if (num == numx)
                                {
                                    test = true;
                                    break;
                                }

                            }
                            if (test == false)
                            {
                                omarivi[y] = Convert.ToInt32(textBox.Text);
                                textBox.BackColor = Color.FromArgb(255, Color.White);
                                y++;
                            }
                            else
                            {
                                textBox.BackColor = Color.FromArgb(255, 255, 192, 230);
                                MessageBox.Show("Kaikkien numeroiden tulee olla kesken‰‰n erilaisia.");
                                
                                return;
                            }
                        }//numx < 41 && numx > 0 && Regex.IsMatch(textBox.Text, @"^[0-9]+$"))

                    }//if (textBox.Text.Length > 0 
                    else
                    {
                        MessageBox.Show("Anna vain numeroita v‰lill‰ 1-40.");
                        return;
                    }
                }
            }// foreach (Control control in this.Controls)
            List<int> matches = new();
            List<int> matches2 = new();
        
            bool elementFound = false;

            int i = 0;
            foreach (Control control in this.Controls)
            {
              
                if (control is TextBox textBox) //luetaan laatikot ja asetetaan tausta valkoiseksi
                {
                  //  Console.WriteLine("annettu: " +textBox.Text + "i= " + i);
                    int num1 =  Convert.ToInt32(textBox.Text);
                  
                    textBox.BackColor = Color.FromArgb(255, Color.White);



                    foreach (int num2 in lottorivi)
                    {
                        if (num1 == num2)
                        {
                            matches.Add(num2);
                            //  Console.WriteLine("m‰tsi!! " +num2);
                            textBox.BackColor = Color.FromArgb(255, 255, 255, 192);
                            elementFound = true;
                        }
                    }
                    foreach (int num2 in lisanumero)
                    {
                        if (num1 == num2)
                        {
                            matches2.Add(num2);
                            //  Console.WriteLine("m‰tsi!! " +num2);
                            textBox.BackColor = Color.FromArgb(255, 255, 230, 192);
                            elementFound = true;
                        }
                    }

                    i++; //jotta saadaan indeksi

                }// if (control is TextBox textBox)
            }// foreach (Control control in this.Controls)


            if (!elementFound)
            {
                 lblTulokset.Text = "Ei numeroita oikein";
            }
            else if (elementFound)
            {
                 lblTulokset.Text = $"Numeroita oikein: { matches.Count.ToString()}. Lis‰numeroita: {matches2.Count.ToString()}";
            }
          


        }
    }
}
