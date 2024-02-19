using _15_Palautus_Lopputyo_MineSweeper.Model;
using _15_Palautus_Lopputyo_MineSweeper.View;
using System.Collections;
using System.Resources;
using System.Runtime.InteropServices;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using _15_Palautus_Lopputyo_MineSweeper;
using System.Xml.Serialization;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _15_Palautus_Lopputyo_MineSweeper.View
{

    public partial class Pelilauta : Form
    {
        //¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤

        //%%%%%% MAHDOLLISTAA CONSOLE.WRITELINEN WINFORMSISSA %%%%
        [DllImport("Kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        //++++++++++++++++ ESTÄÄ FORMIN LIIKUTTELUN +++++++++++++++++++++++++++
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        // Constants for window messages
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        // Override the WndProc method to intercept window messages
        protected override void WndProc(ref Message m)
        {
            // Check if the message is WM_NCLBUTTONDOWN and the cursor is on the title bar
            if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HTCAPTION)
            {
                // Do nothing to prevent the form from being moved
                return;
            }

            // If the message is not WM_NCLBUTTONDOWN or the cursor is not on the title bar, process the message as usual
            base.WndProc(ref m);
        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤

        //  ----------------------------  GLOBALS  -----------------------------

        private Ruutu ruutu;
        private Button[][] buttons; //jagged array (array of arrays)

        public Label ScoreLabel => lblScore;
        public Label Highscore => lblHighscore;

        public int nakkeja = 0;
        public HashSet<string> FoundSausages { get; set; }
        public HashSet <string> openButtons { get; set; }
        private int points { get; set; } //changes according to the difficulty
        private int Row = 0;
        private int Col = 0;
        private int size = 0;
        private int ruutuja = 0;

        private bool opn = false; //how many buttons clicked?

        ScoreManager scoreManager;
        FlyingSausage FS {  get; set; } 
  
        Valinta valinta;
        public Panel parentPanel;
        public Panel Cpanel;
        public PictureBox sausage {  get; set; }
        public string BGsize { get; set; }
    
        //------------------------------ IMAGES ------------------------
        ImageList imageList;
        private Bitmap myBitmap;
        private System.Drawing.Image image;
        int BoxFreezerIndex = 0;
        int IceIndex = 0;
        int MissedIndex = 0;
        int NakkiBottomIndex = 0;
        int NakkiLeftIndex = 0;
        int NakkiLeftDownIndex = 0;
        int NakkiLeftUpIndex = 0;
        int NakkiMiddleIndex = 0;
        int NakkiMiddleSIndex = 0;
        int NakkiRightIndex = 0;
        int NakkiRightDownIndex = 0;
        int NakkiRightUpIndex = 0;
        int NakkiSingleIndex = 0;
        int NakkiTopIndex = 0;
        int splatIndex = 0;
        int SplatXIndex = 0;
        int WhiteIndex = 0;
        int FlyingSausageIndex = 0;

        //------------------------------ SOUNDS ---------------------
        PSound audio;
        public string frozen = "chord";
        public string known = "chord";
        public string aloitus = "chimes";
        public string fanfare = "tada";
        public string ring = "ringout";
        public string ring06 = "Ring06";




        //###########################################   GAME   ############################################################
        public Pelilauta(int row, int col, int nakit, int size, int points, string BG) // PÄÄKONSTRUKTORI
        {
            InitializeComponent();
         //  AllocConsole();

       

            this.nakkeja = nakit;
            this.points = points;
            this.Row = row;
            this.Col = col;
            this.size = size;

            ruutuja = Row * Col;

            //¤¤¤¤MUUTTAA FORMIN PAIKKAA RUUDULLA
            this.StartPosition = FormStartPosition.CenterScreen;
            // this.StartPosition = FormStartPosition.Manual;   
            // this.Location = new Point(0, -0); // sideways, up down 
            //¤¤¤¤

            this.DoubleBuffered = true;


            FoundSausages = new HashSet<string>();
            audio = new PSound();
            audio.playSimpleSound(aloitus);
            ruutu = new Ruutu(row, col, nakkeja);
            this.ClientSize = new Size((col * size) + 150, (row * size) + 120); //formi vähän isompi
          



            parentPanel = new Panel();
            parentPanel.BackColor = Color.Transparent;
            parentPanel.BorderStyle = BorderStyle.FixedSingle; //rajat
            parentPanel.Size = new Size((col * size), (row * size));//emopaneeli laskennallisesti nappuloiden kokoinen
            parentPanel.Location = new Point(50, 50);
            this.Controls.Add(parentPanel);

          



            //------------------------------------  Image bank --------------------------

            valinta = System.Windows.Forms.Application.OpenForms.OfType<Valinta>().FirstOrDefault();

            imageList = valinta.imageList;
            imageList.ImageSize = new Size(size, size);

            BoxFreezerIndex = valinta.BoxFreezerIndex;
            IceIndex = valinta.IceIndex;
            MissedIndex = valinta.MissedIndex;
            NakkiBottomIndex = valinta.NakkiBottomIndex;
            NakkiLeftIndex = valinta.NakkiLeftIndex;
            NakkiLeftDownIndex = valinta.NakkiLeftDownIndex;
            NakkiLeftUpIndex = valinta.NakkiLeftUpIndex;
            NakkiMiddleIndex = valinta.NakkiMiddleIndex;
            NakkiMiddleSIndex = valinta.NakkiMiddleSIndex;
            NakkiRightIndex = valinta.NakkiRightIndex;
            NakkiRightDownIndex = valinta.NakkiRightDownIndex;
            NakkiRightUpIndex = valinta.NakkiRightUpIndex;
            NakkiSingleIndex = valinta.NakkiSingleIndex;
            NakkiTopIndex = valinta.NakkiTopIndex;
            splatIndex = valinta.splatIndex;
            SplatXIndex = valinta.SplatXIndex;
            WhiteIndex = valinta.WhiteIndex;
            FlyingSausageIndex = valinta.FlyingSausageIndex;



            //----------------------------------------------------------------------------------

            Cpanel = new Panel();
            Cpanel.Dock = DockStyle.Fill; //lapsipaneli fillaa
            Cpanel.BackColor = Color.Transparent;
          //  Cpanel.BackgroundImage = imageList.Images[IceIndex];
           // Cpanel.BackgroundImageLayout = ImageLayout.Tile;
            parentPanel.Controls.Add(Cpanel);


            CreateButtons();

            /*
            Panel CCpanel = new Panel();
           CCpanel.Dock = DockStyle.Fill; //lapsipaneli fillaa
            CCpanel.BackColor = Color.Transparent;
           Cpanel.Controls.Add(CCpanel);

            CCpanel.BringToFront();
            */

            sausage = new PictureBox();
            sausage.Text = "";
            sausage.Name = "";
            sausage.Width = 100;
            sausage.Height = 100;
            sausage.Visible = true;
         //   sausage.FlatStyle = FlatStyle.Flat;
          
          
            sausage.MouseUp += new MouseEventHandler(sausage_Click);

            //TÄÄ TOIMII KYLLÄ, mut jostain syystä se näyttää alimman panelin/formin pohjan, eikä nappuloita
            //ks: https://bytes.com/topic/c-sharp/answers/707265-transparent-graphic-background

            Bitmap image = Properties.Resources.FlyingSausageFlap241 as Bitmap;
            Color backColor = image.GetPixel(0, 0); 
            image.MakeTransparent(backColor);
            sausage.Image = image;



            sausage.Parent =Cpanel;
            Cpanel.Controls.Add(sausage);

            this.AutoSize = true;

            scoreManager = new ScoreManager();
           

       


            lblHighscore.Text = "Highest score: " + valinta.HighScore.ToString();
            lblOhjeet.Text = "LMB: Smashsplode RMB: Pick carefully, but do not freeze your fingers!";
            lblScore.Text = $"Score: 0\nGotten: 0\nSmashed: 0\nRemaining: {nakit}\nFingers: 10/10";


            if(BG == "S") { this.BackgroundImage = Properties.Resources.PohjaIceSmall; BGsize = "S"; }
            else if (BG == "M") { this.BackgroundImage = Properties.Resources.PohjaIceMed; BGsize = "M"; }
            else if (BG == "B") { this.BackgroundImage = Properties.Resources.PohjaIceBig; BGsize = "B"; }




            valinta.SpeedUp(); //jokainen uusi lauta nopeutuu

            lblRounds.Text = "Round: " + (valinta.gamesPlayed + 1).ToString();
            valinta.gamesPlayed += 1;

        }//start

      

            public void CreateButtons()
        {
            opn = false;

            openButtons = new HashSet<string> ();

            //clearing old buttons
            foreach (Control control in Cpanel.Controls)
            {
                if (control is Button button)
                {
                    Cpanel.Controls.Remove(button);
                    button.Dispose();
                }
            }
      
            Cpanel.Controls.Clear();




            buttons = new Button[Row][];
            for (int i = 0; i < Row; i++)
            {
                buttons[i] = new Button[Col];

            }// for(int i=0; i < row; i++)

            foreach (int i in Enumerable.Range(0, Row))
            {

                foreach (int j in Enumerable.Range(0, Col))
                {
                    buttons[i][j] = new Button();
                    buttons[i][j].Text = "";
                    buttons[i][j].BackColor = Color.White;
                    buttons[i][j].Name = i + "," + j;
                    buttons[i][j].Size = new Size(size + 2, size + 2); //ruudun koko
                    buttons[i][j].Location = new Point(size * j, size * i);
                    buttons[i][j].UseVisualStyleBackColor = false;
                    buttons[i][j].MouseUp += new MouseEventHandler(Button_Click);
                    buttons[i][j].ImageList = valinta.imageList; // Set the ImageList
                    buttons[i][j].ImageIndex = 0; // Set the index of the image in the ImageList
                    buttons[i][j].Image = valinta.imageList.Images[IceIndex];

                    //   buttons[i][j].BackgroundImageLayout = ImageLayout.Stretch;

                    Cpanel.Controls.Add(buttons[i][j]);

                }//foreach (int j in Enumerable.Range(0,col))
            }// foreach (int i in Enumerable.Range(0, row))


          


        }
        private void sausage_Click(object sender, MouseEventArgs e)
        {

            //Console.WriteLine("Caught flying sausage");
            scoreManager.changeScore(5, "FS", nakkeja);
            sausage.SendToBack();
            audio.playSimpleSound(ring06);
            sausage.Enabled = false;
        }
      


        private void Button_Click(object sender, MouseEventArgs e)
        {

            Button b = (Button)sender;
            int pilkunIndex = b.Name.IndexOf(","); //Buttonin nimeen on tallennettu koordinaatit
            int click_x = Int16.Parse(b.Name.Substring(0, pilkunIndex));
            int click_y = Int16.Parse(b.Name.Substring(pilkunIndex + 1));
           this.Focus();
            switch (e.Button)
            {
                case MouseButtons.Left: //klikattiinko LMB?
                    {
                        openButtons.Add($"{click_x},{click_y}");
                        if (openButtons.Count == ruutuja) { opn = true;   scoreManager.changeScore(0, "o", nakkeja); }



                        // audio.playSimpleSound("chimes");
                        if (!this.ruutu.Started)
                            this.ruutu.Initialize(click_x, click_y);

                        int n = this.ruutu.LaskeNakit(click_x, click_y);

                        if (this.ruutu.OnkoNakki(click_x, click_y))
                        {
                            osuitNakkiin(b, click_x, click_y, "m");

                            break;
                        }
                        if (this.ruutu.Discovered.Contains(click_x * buttons[0].Length + click_y)) break;


                        foreach (int k in this.ruutu.GetSafeIsland(click_x, click_y))
                        {
                            int i = k / buttons[0].Length;
                            int j = k % buttons[0].Length;

                            buttons[i][j].BackColor = Color.LightGray;
                            buttons[i][j].Image = imageList.Images[WhiteIndex];

                            int m = this.ruutu.LaskeNakit(i, j);

                            if (m > 0)
                            {
                                buttons[i][j].Text = m + "";
                                buttons[i][j].BackColor = Color.LightBlue;
                            }
                            else { buttons[i][j].Enabled = false; }

                        }//   foreach (int k in this.ruutu.GetSafeIsland(click_x,click_y))

                        break;
                    }

                case MouseButtons.Right: //klikattiinko RMB?
                    {
                        openButtons.Add($"{click_x},{click_y}");
                        if (openButtons.Count == ruutuja) { opn = true;  scoreManager.changeScore(0, "o", nakkeja); }
                        if (!this.ruutu.Started)
                            this.ruutu.Initialize(click_x, click_y);
                        if (this.ruutu.Discovered.Contains(click_x * buttons[0].Length + click_y)) break;

                        int n = this.ruutu.LaskeNakit(click_x, click_y);

                        if (this.ruutu.OnkoNakki(click_x, click_y))
                        {
                            osuitNakkiin(b, click_x, click_y, "g");

                            break;
                        }
                        else
                        {
                            audio.playSimpleSound(frozen);
                            b.Image = imageList.Images[MissedIndex];
                            MessageBox.Show("Whoops Ice-Burn!");

                            scoreManager.changeScore(-1, "f", nakkeja);
                            break;
                        }


                        break;
                    }


            }//switch

        }
  
        private void PiirraNakki(Button b, int click_x, int click_y) // X = up/down   y = left/right
        {
            bool r = this.ruutu.OnkoNakki(click_x, click_y + 1); //seuraava kolumni okealla = +1
            bool d = this.ruutu.OnkoNakki(click_x + 1, click_y);
            bool u = this.ruutu.OnkoNakki(click_x - 1, click_y); //aiempi rivi = -1
            bool l = this.ruutu.OnkoNakki(click_x, click_y - 1); //edellinen kolumni vas = -1

            // Console.WriteLine("x "+click_x +" y " + click_y);
            //angled
            if (r == true && d == true)
            {
                b.Image = imageList.Images[NakkiRightDownIndex];
            }
            if (r == true && u == true)
            {
                b.Image = imageList.Images[NakkiRightUpIndex];
            }
            if (l == true && d == true)
            {
                b.Image = imageList.Images[NakkiLeftDownIndex];
            }
            if (l == true && u == true)
            {
                b.Image = imageList.Images[NakkiLeftUpIndex];
            }

            //vertical
            else if (u == false && d == true)
            {
                b.Image = imageList.Images[NakkiTopIndex];
            }
            else if (u == true && d == false)
            {
                b.Image = imageList.Images[NakkiBottomIndex];
            }
            else if (u == true && d == true)
            {
                b.Image = imageList.Images[NakkiMiddleIndex];
            }

            //horizontal

            else if (r == false && l == true)
            {
                b.Image = imageList.Images[NakkiRightIndex];
            }
            else if (r == true && l == false)
            {
                b.Image = imageList.Images[NakkiLeftIndex];
            }
            else if (r == true && l == true)
            {
                b.Image = imageList.Images[NakkiMiddleSIndex];
            }
            else
            {
                b.Image = imageList.Images[NakkiSingleIndex];
            }
        }
        private void osuitNakkiin(Button b, int click_x, int click_y, string data)
        {
            // b.BackColor = Color.Red;
            // MessageBox.Show("Osuit nakkiin!");


            if (FoundSausages.Contains(b.Name))  //skip already clicked buttons
            {
               audio.playSimpleSound(known);
            }
            else if (!FoundSausages.Contains(b.Name))
            {
                if (data.ToUpper() == "M")
                {
                    audio.playSimpleSound(ring);
                    //   b.Image = Properties.Resources.SplatX;
                    b.Image = imageList.Images[SplatXIndex];
                    scoreManager.changeScore(-points, "m", nakkeja); //Valintaa ei resetoida ni highscoren pitäs nyt säilyä
                    FoundSausages.Add(b.Name);
                    //  b.Enabled = false; //tää greyouttaa nappulan

                }
                else if (data.ToUpper() == "G")
                {
                    audio.playSimpleSound(fanfare);
                    PiirraNakki(b, click_x, click_y);
                    scoreManager.changeScore(points, "g", nakkeja);

                    FoundSausages.Add(b.Name);
                    // b.Enabled = false;  //tää greyouttaa nappulan

                }
            }//does not contain

        }//osuit
       
        public void ReNakit(int nakkeja)
        {
            this.nakkeja = nakkeja;
        }
        
        public bool allOpen()
        {
         if(openButtons.Count == nakkeja) { opn = true; }

            return opn;
        }
     
        public void GameOver(string m)
        {
            valinta.SendSausage.Enabled = false;
            valinta.DirectionAndScreenshot.Enabled = false;
            this.FlappingTimer.Enabled = false;   
            string message = "";
            string caption = "";
            if (!valinta.Continuous)
            {
               
                if (m == "frozen")
                {
                    message = "Oh noo noo, all your fingers are frozen! Try again after warming up!";
                    caption = "Game Over";
                }

                else if (m == "less") //than half gotten
                {
                    message = "Oh noo noo, you didn't get enough sausages! Try again with better luck!";
                    caption = "Game Over";

                }

                else if (m == "win") //win
                {
                    message = "HURRAY! You found all sausages!!!";
                    caption = "You won";
                }

                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.RetryCancel);

                if (result == DialogResult.Retry)
                {
                    this.Close();
                }
               else
               {
                 System.Windows.Forms.Application.Exit();
                }
            }//if (!valinta.Continuous)
            else
            {
                if(m == "frozen" || m == "less")
                {
                    if (m == "frozen")
                    {
                        message = "Oh noo noo, all your fingers are frozen! Try again after warming up!";
                        caption = "Game Over";
                    }

                    else if (m == "less") //than half gotten
                    {
                        message = "Oh noo noo, you didn't get enough sausages! Try again with better luck!";
                        caption = "Game Over";

                    }
                    DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.RetryCancel);

                    if (result == DialogResult.Retry)
                    {
                        this.Close();
                    }
                    else
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }//(m == "frozen" || m == "less")

                else
                {
                   
                    message = "Continue?";
                    caption = "You won!";
                    DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        this.Close();

                        // Create a new instance of the form and show it
                       Pelilauta newForm = new Pelilauta(Row,Col, nakkeja, size, points,BGsize); //(int row, int col, int nakit, int size, int points)
                        newForm.Show();

                        Random rand = new Random();
                       FS.sausageamount = 3 + rand.Next(0, 2);
                   
                        valinta.SendSausage.Enabled = true;
                        valinta.DirectionAndScreenshot.Enabled = true;
                        
                        Random rand2 = new Random();
                        int rndinterval = rand2.Next(30000);
                        valinta.InitializeTimer(15000 + rndinterval); // sendsausage
                    }
                    else
                    {
                        System.Windows.Forms.Application.Exit();
                    }


                }
              
            }
        }

     
    }
}
