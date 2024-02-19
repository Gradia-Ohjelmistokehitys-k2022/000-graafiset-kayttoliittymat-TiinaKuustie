using Microsoft.VisualBasic.Devices;
using System.Media;
using _15_Palautus_Lopputyo_MineSweeper.Model;
using _15_Palautus_Lopputyo_MineSweeper.View;

using System.Drawing;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Collections;
using System.Resources;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace _15_Palautus_Lopputyo_MineSweeper
{
    public partial class Valinta : Form
    {
        //¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤ ESTÄÄ FORMIN LIIKUTTELUN
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
        //¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤
        //------------------------------ IMAGES ------------------------

        public ImageList imageList { get; set; }
        public int BoxFreezerIndex { get; set; }
        public int IceIndex { get; set; }
        public int MissedIndex { get; set; }
        public int NakkiBottomIndex { get; set; }
        public int NakkiLeftIndex { get; set; }
        public int NakkiLeftDownIndex { get; set; }
        public int NakkiLeftUpIndex { get; set; }
        public int NakkiMiddleIndex { get; set; }
        public int NakkiMiddleSIndex { get; set; }
        public int NakkiRightIndex { get; set; }
        public int NakkiRightDownIndex { get; set; }
        public int NakkiRightUpIndex { get; set; }
        public int NakkiSingleIndex { get; set; }
        public int NakkiTopIndex { get; set; }
        public int splatIndex { get; set; }
        public int SplatXIndex { get; set; }
        public int WhiteIndex { get; set; }
        public int XIndex { get; set; }
        public int FlyingSausageIndex { get; set; }

        internal int direction { get; set; }
        public bool Continuous { get; set; } //single game or not?


        public FlyingSausage FS { get; set; }
        public int HighScore { get; set; }
        public float speed { get; set; } //flying sausage speed
        public int gamesPlayed { get; set; }    //in continuous mode
        LinkLabel linkLabel { get; set; }
        public Valinta()
        {
            InitializeComponent();

            //¤¤¤¤MUUTTAA FORMIN PAIKKAA RUUDULLA
            //  this.StartPosition = FormStartPosition.Manual;  
            this.StartPosition = FormStartPosition.CenterScreen;
            //  this.Location = new Point(500, 180); // sideways, up down


            Continuous = false;

            lblDifficulty.BackColor = Color.FromArgb(0, Color.White);
            rbContinuous.BackColor = Color.FromArgb(0, Color.White);
            rbSingle.BackColor = Color.FromArgb(0, Color.White);




            //------------------------------------  Image bank --------------------------
            imageList = new ImageList();

            ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true);

            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceName = (string)entry.Key;

                if (entry.Value is Image image) { imageList.Images.Add(resourceName, image); }//lisätään resourcen kuvat listaan
            }//add to list

            for (int i = 0; i < imageList.Images.Count; i++)
            {
                // if (imageList.Images.Keys[i] == "BoxFreezer2") { BoxFreezerIndex = i; }
                if (imageList.Images.Keys[i] == "Ice") { IceIndex = i; }
                if (imageList.Images.Keys[i] == "Missed") { MissedIndex = i; }
                if (imageList.Images.Keys[i] == "NakkiBottom") { NakkiBottomIndex = i; }
                if (imageList.Images.Keys[i] == "NakkiLeft") { NakkiLeftIndex = i; }
                if (imageList.Images.Keys[i] == "NakkiLeftDown") { NakkiLeftDownIndex = i; }
                if (imageList.Images.Keys[i] == "NakkiLeftUp") { NakkiLeftUpIndex = i; }
                if (imageList.Images.Keys[i] == "NakkiMiddle") { NakkiMiddleIndex = i; }
                if (imageList.Images.Keys[i] == "NakkiMiddleS") { NakkiMiddleSIndex = i; }
                if (imageList.Images.Keys[i] == "NakkiRight") { NakkiRightIndex = i; }
                if (imageList.Images.Keys[i] == "NakkiRightDown") { NakkiRightDownIndex = i; }
                if (imageList.Images.Keys[i] == "NakkiRightUp") { NakkiRightUpIndex = i; }
                if (imageList.Images.Keys[i] == "NakkiSingle") { NakkiSingleIndex = i; }
                if (imageList.Images.Keys[i] == "NakkiTop") { NakkiTopIndex = i; }
                if (imageList.Images.Keys[i] == "splat") { splatIndex = i; }
                if (imageList.Images.Keys[i] == "SplatX") { SplatXIndex = i; }
                if (imageList.Images.Keys[i] == "White") { WhiteIndex = i; }
                if (imageList.Images.Keys[i] == "FlyingSausageFlap24") { FlyingSausageIndex = i; }

                imageList.TransparentColor = Color.White;

            }
            //----------------------------------------------------------------------------------


        }
        public void SpeedUp()
        {
            speed =  speed + 1.0f;
        }

        private void btnEasy_Click(object sender, EventArgs e) //9x9
        {

            speed = 2;
            Random rand = new Random();
            int rndinterval = rand.Next(20000);//120 000
            InitializeTimer(15000 + rndinterval);
            int row = 9;
            int col = 9;
            int nakkeja = 10;
            int points = 50;
            int size = Math.Min(30, 1000 / Math.Max(row, col));


            Pelilauta lauta = new Pelilauta(row, col, nakkeja, size + 20, points, "S"); //vähän isommat nappulat, jotta ohje näkyy

            int newX = this.Location.X + this.Width;
            int newY = this.Location.Y;

            FS = new FlyingSausage();
            lauta.Location = new Point(newX, newY);
            lauta.Show();


        }

        private void btnMid_Click(object sender, EventArgs e) //16x16
        {
            speed = 2;
            Random rand = new Random();
            int rndinterval = rand.Next(50000);
            InitializeTimer(15000 + rndinterval);
            int row = 16;
            int col = 16;
            int nakkeja = 40;
            int points = 12;
            int size = Math.Min(30, 1000 / Math.Max(row, col));


            Pelilauta lauta = new Pelilauta(row, col, nakkeja, size + 10, points, "M");

            int newX = this.Location.X + this.Width;
            int newY = this.Location.Y;

            lauta.Location = new Point(newX, newY);

            FS = new FlyingSausage();
            //  lauta.Capture = true;
            lauta.Show();


        }

        private void btnHard_Click(object sender, EventArgs e)//30x16
        {
            speed = 3;
            Random rand = new Random();
            int rndinterval = rand.Next(60000);
            InitializeTimer(15000 + rndinterval); //Ainakin 15 sek väliä
            int row = 30;
            int col = 30;
            int nakkeja = 99;
            int points = 4;
            int size = Math.Min(30, 1000 / Math.Max(row, col));


            Pelilauta lauta = new Pelilauta(row, col, nakkeja, size + 10, points, "B");
            int newX = this.Location.X + this.Width;
            int newY = this.Location.Y;

            FS = new FlyingSausage();
            lauta.Location = new Point(newX, newY);
            lauta.Show();

        }

        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {
            Continuous = false;
        }

        private void rbContinuous_CheckedChanged(object sender, EventArgs e)
        {
            Continuous = true;
        }
        public void InitializeTimer(int interval)
        {
            // 1 second = 1000
            if (interval > 0)
            {
                SendSausage.Interval = interval;

            }
            SendSausage.Tick += new EventHandler(timer1_Tick);
            // Enable timer.  
            SendSausage.Enabled = true;
            /*
            Button1.Text = "Stop";
            Button1.Click += new EventHandler(Button1_Click);
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            FS.Fly(); //flying sausage
            Random rand = new Random();
            int rndinterval = rand.Next(30000); //2 minutes = 120000
            InitializeTimer(rndinterval + 15000);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
