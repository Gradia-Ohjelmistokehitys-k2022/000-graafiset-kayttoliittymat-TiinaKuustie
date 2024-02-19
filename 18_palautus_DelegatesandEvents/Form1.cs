using _18_palautus_DelegatesandEvents.Model;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace _18_palautus_DelegatesandEvents
{
    public partial class Form1 : Form
    {
     

    delegate void PrintDelegate(string text);
    //%%%%%% MAHDOLLISTAA CONSOLE.WRITELINEN WINFORMSISSA %%%%
    [DllImport("Kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        Queue<Tilaukset> Ilmojono;
        Tuotteet tuotteet;
        DateTime viimeinennvikanoutoPVM;
        Tilaukset tilaukset;
        PrintDelegate print = (string text) => { MessageBox.Show(text); };

        public static List<Tuotteet>? tuotelista { get; set; }
        public Form1()
        {
            InitializeComponent();
     

            AllocConsole();
            tuotteet = new Tuotteet();
            tilaukset = new Tilaukset();
            tuotelista = new List<Tuotteet>();
            tilaukset.initialize();
            luoTuotteet();

        }

     
        private void InitializeTimer(int interval)
        {
            // 1 second = 1000
            if (interval > 0)
            {
                timer1.Interval = interval;

            }
            timer1.Tick += new EventHandler(AIKAILMOITUS);
        
            timer1.Enabled = true;
           
        }

   

private void luoTuotteet()
        {
            int amount = 24; //monta tuotetta luodaan
            List<string> names = new List<string> { "Kuulalaakeri", "Kupariputki", "Ter‰sputki", "Ter‰slevy", "Kuparilevy", "Lattarauta", "Hitsauspuikko", "Akseli", "Ratas" };


            for (int i = 0; i < amount-1; i++)
            {

              
                Random random = new Random();
                int randomIndex = random.Next(0, names.Count);

                string nimi = names[randomIndex];
                Console.WriteLine(nimi);

               Tuotteet to = tuotteet.GenerateProducts(nimi);
                tuotelista.Add(to);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //lue viivakoodi
        {

            Random random = new Random();
            int randomIndex = random.Next(0, tuotelista.Count);
          //  Console.WriteLine("arvonta " + randomIndex + " tuotelista " + tuotelista.Count);
            Tuotteet arvottu = tuotelista[randomIndex];


            lblKoodi.Text = arvottu.Id.ToString();

           // Console.WriteLine("arvottu on " +arvottu.Name.ToString());

            rtbInfo.Text = $"{arvottu.Name}\n{arvottu.Paino}kg\n{arvottu.Price}Ä";
        }

        private void dtpPVM_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            Tuotteet tuote = new Tuotteet();
            DateTime time = dtpPVM.Value;
            
            string asiakas = tbNimi.Text;
            string hyllypaikka = tbHylly.Text;

            foreach(Tuotteet tavara in tuotelista) 
            {
                if(tavara.Id == lblKoodi.Text)
                {
                    tuote = tavara;
                }
            }


           print($"Tilaus: {tuote.Name} asiakkaalle {asiakas} tehty");
            tilaukset.UusiHyllytys(tuote,time,asiakas, hyllypaikka); //Tuotteet tuote, DateTime lastdate

            InitializeTimer(86400000); // 1000 == sekunti // AIKAILMOITUS on timer click 86400 sekuntia vuorokaudessa
        }

        private void AIKAILMOITUS(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            Ilmojono = new Queue<Tilaukset>(); //t‰‰ on ny kokeilun vuoksi queue

            foreach (Tilaukset tilaus in Tilaukset.tilauslista)
            {
               

                if (dt.DayOfYear == tilaus.LastPickup.DayOfYear -1 && !Ilmojono.Contains(tilaus))
                {
                    Ilmojono.Enqueue(tilaus);
                  
                }
            }

            //foreach (Tilaukset tilaus in Ilmojono)    //ei voinukka dequeue foreach loopin sis‰lt‰
            for (int i = 0; i < Ilmojono.Count; i++) 
           {
                Tilaukset tilaus = Ilmojono.Dequeue();
                string ilmo = $"Viimeinen muistutus:\n\nTilaamanne tuote tilausnumerolla {tilaus.Tilausnumero} on saapunut noudettavaksi. \nViimeinen noutop‰iv‰ huomenna {tilaus.LastPickup.Date}";
                Hakuilmoitus uusi = new Hakuilmoitus(ilmo);

                uusi.Show();
             
            }

         
            //vois tehd‰ sillei et ajaa jonkin tarkistuksen ja sit vasta dequeueaa


        }
    }
}
