namespace _05_palautus_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblLuvut.Text = "0";
        }

        private void tbSyote_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* int end = Convert.ToInt32(tbSyote.Text);

             for(int i = 0; i < end; i++)
             {
                 lblLuvut.Text = i.ToString();

             }*/

            Thread OmaSaie;


            // Luodaan toissijainen säie ja käynnistetään se Start()-metodilla. 

            OmaSaie = new Thread(new ThreadStart(this.SaieProceduuri));

            OmaSaie.Start();


        }


        private void SaieProceduuri()

        {

            // Muutetaan tekstinä oleva numero kokonaisluvuksi. 

            Int32 Kierrokset = Convert.ToInt32(tbSyote.Text);



            for (Int32 i = 0; i < Kierrokset; i++)

            {

                string uusiNumero = (i + 1).ToString();

                this.AsetaTeksti(uusiNumero);



                // Viive 

                Thread.Sleep(10);

            }

        }




        delegate void StringArgReturningVoidDelegate(string texti);


        private void AsetaTeksti(string texti)

        {

            // InvokeRequired required compares the thread ID of the   

            // calling thread to the thread ID of the creating thread.   

            // If these threads are different, it returns true.   


            if (this.lblLuvut.InvokeRequired)

            {   //Herätetään alkuperäinen säie 

                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(AsetaTeksti);

                this.Invoke(d, new object[] { texti });

            }

            else

            {   //Jos on alkupeäinen säie laitetaan se ´muuttamaan teksti 

                this.lblLuvut.Text = texti;

            }

        }
    }
}
