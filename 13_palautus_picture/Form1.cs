using System.Drawing;

namespace _13_palautus_picture
{
    public partial class Form1 : Form
    {
        private Image image;
        private Bitmap myBitmap;


        Point piste = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;  //est‰‰ kuvan vilkkumisen

            image = Image.FromFile("D:\\Koulu\\Databases\\Soveltaminen\\1-TiinaKuustie\\Graafiset\\13_palautus_picture\\Kuvat\\HessuHopo.png");
            myBitmap = new Bitmap(image);

           // e.Graphics.DrawImage(myBitmap, 0, 0, myBitmap.Width, myBitmap.Height);
                     
            Color backColor = myBitmap.GetPixel(1, 1);    // Get the color of a background pixel.
                    
            myBitmap.MakeTransparent(backColor);    // Make backColor transparent for myBitmap.


            this.MouseClick += MainForm_MouseDown;
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
     
     
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            // Create a Bitmap object from an image file.
          

            // Draw myBitmap to the screen.
           

            // Draw the transparent bitmap to the screen.
            e.Graphics.DrawImage(myBitmap, piste);


          //  Graphics g = e.Graphics;
         
           // g.DrawImage(image,piste);
        }
    }
}
