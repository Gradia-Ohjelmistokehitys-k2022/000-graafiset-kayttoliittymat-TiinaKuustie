namespace _11_palautus_PaintandMouse
{
    public partial class Form1 : Form
    {

        Point piste = new Point(0, 0);
        // Talletetaan grafiikkaobjekti. Grafiikkaobjekti tarvitaan  grafikan piirtämiseksi näytölle. 
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.MouseDown += MainForm_MouseDown;
            this.MouseUp += Form1_MouseUp;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Left)
            {


                piste = e.Location;


                Invalidate();

            }

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {


                piste = e.Location;


                Invalidate();

            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)

        {

            Graphics Graf = e.Graphics;

            // - Pää 

            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);

            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            // - Selkä 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41,

            piste.X + 21, piste.Y + 131);

            // - Kädet 

            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60,

            piste.X + 70, piste.Y + 60);

            // - Jalat 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X - 30, piste.Y + 181);

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X + 70, piste.Y + 181);



            // Kutsutaan DrawCoordinates()-metodia. 

            DrawCordinates(Graf);

        }

        // DrawCoordinates() -metodi PIIRTÄÄ pisteen koordinaatit lomakkeelle.  



        private void DrawCordinates(Graphics Graf)

        {

            // Piirretään piirtokoordinaattien arvot näytölle. 

            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",

                            new Font("Arial", 14, System.Drawing.FontStyle.Regular),

                            new SolidBrush(Color.Black), 8, 30);

        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            /*
            piste = new Point(Convert.ToInt32(tbX.Text), Convert.ToInt32(tbY.Text));
            Invalidate();
            */
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          //  MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyCode.ToString().ToLower() == "w")
            {
                    piste = new Point(piste.X ,piste.Y -1);
                Invalidate();
            }
            if (e.KeyCode.ToString().ToLower() == "s")
            {
                piste = new Point(piste.X, piste.Y + 1);
                Invalidate();
            }
            if (e.KeyCode.ToString().ToLower() == "a")
            {
                piste = new Point(piste.X-1, piste.Y);
                Invalidate();
            }
            if (e.KeyCode.ToString().ToLower() == "d")
            {
                piste = new Point(piste.X+1, piste.Y);
                Invalidate();
            }




            /* if (e.KeyCode == Keys.Up)
             if (e.KeyCode == Keys.Down) 
            */

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Invalidate();
        }
    }

}
