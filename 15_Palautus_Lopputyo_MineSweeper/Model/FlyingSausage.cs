using _15_Palautus_Lopputyo_MineSweeper.Model;
using _15_Palautus_Lopputyo_MineSweeper.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Palautus_Lopputyo_MineSweeper.Model
{
    public class FlyingSausage
    {
        Valinta valinta;
        Pelilauta PL;
        Screenshot SH;
        Flapping F;

        internal int check = 0;
        internal float locx = 0f;
        internal float locy = 0f;

        internal float speed = 3.0f;
        internal int rounds = 0;

        bool focused = false;
        bool stop = true;
        bool end = false;

        public int sausageamount = 3;
      
        public FlyingSausage() 
        {
            valinta = System.Windows.Forms.Application.OpenForms.OfType<Valinta>().FirstOrDefault();
            PL = System.Windows.Forms.Application.OpenForms.OfType<Pelilauta>().FirstOrDefault();
            SH = new Screenshot();
            // F = System.Windows.Forms.Application.OpenForms.OfType<Flapping>().FirstOrDefault();
            if (valinta != null)
            {
                speed = valinta.speed;
            }

            Random rand = new Random();
            sausageamount = 3 + rand.Next(0,2); // max viisi

           valinta.direction = 0;
      }


        private void FlapWings(object sender, EventArgs e)
        {
          //  Console.WriteLine("flapping timer");
            F.FlapWings();
        }

     
        private void timer2_Tick(object sender, EventArgs e)
      {
            if(end) {  PL.sausage.SendToBack(); valinta.SendSausage.Enabled = false; valinta.DirectionAndScreenshot.Enabled = false; PL.FlappingTimer.Enabled = false; return; }
          rounds++;
          


              if (rounds >= 100)
          {
              PL.FlappingTimer.Enabled = false;
              Random r = new Random();
              locx = r.Next(PL.Cpanel.Width - PL.sausage.Width);
              locy = r.Next(PL.Cpanel.Height - PL.sausage.Height);
              rounds = 0;
              valinta.DirectionAndScreenshot.Enabled = false;

              Random ur = new Random();
                valinta.direction = ur.Next(-1,4);// 0-3

                if (PL.BGsize == "S") { PL.BackgroundImage = Properties.Resources.PohjaIceSmall; }
                else if (PL.BGsize == "M") { PL.BackgroundImage = Properties.Resources.PohjaIceMed; }
                else if (PL.BGsize == "B") { PL.BackgroundImage = Properties.Resources.PohjaIceBig; }

                //   Console.WriteLine("Direction " + direction);

                PL.sausage.SendToBack();
              stop = true;

          }
          else
          {
              if (valinta.direction == 0) // alaviistoon ylävasemmalta oikealle alas
              {

                  locx = PL.sausage.Location.X + speed;
                  locy = PL.sausage.Location.Y + speed;
                  PL.sausage.Location = new Point(Convert.ToInt32(locx) % PL.Cpanel.Width, Convert.ToInt32(locy) % PL.Cpanel.Height);
              }
              else if (valinta.direction == 1) // alaviistoon ylä oikealta vasemmalle alas
              {
                  locx = PL.sausage.Location.X - speed;
                  locy = PL.sausage.Location.Y + speed;
                  PL.sausage.Location = new Point(Convert.ToInt32(locx) % PL.Cpanel.Width, Convert.ToInt32(locy) % PL.Cpanel.Height);

              }
              else if (valinta.direction == 2)//ylviistoon alavasemmalta oikealle ylös
              {
                  locx = PL.sausage.Location.X + speed;
                  locy = PL.sausage.Location.Y - speed;
                  PL.sausage.Location = new Point(Convert.ToInt32(locx) % PL.Cpanel.Width, Convert.ToInt32(locy) % PL.Cpanel.Height);

              }
              else if (valinta.direction == 3) //yläviistoon alaoikealta vasemmalle ylös
              {
                  locx = PL.sausage.Location.X - speed;
                  locy = PL.sausage.Location.Y - speed;

                  PL.sausage.Location = new Point(Convert.ToInt32(locx) % PL.Cpanel.Width, Convert.ToInt32(locy) % PL.Cpanel.Height);
              }

               // Console.WriteLine("Direction " + valinta.direction + " loc " + locx + "," + locy);
            }

      }

     
      
        public void Fly()
      {
            PL = System.Windows.Forms.Application.OpenForms.OfType<Pelilauta>().FirstOrDefault();

            if (PL == null) { PL.sausage.SendToBack(); valinta.SendSausage.Enabled = false; valinta.DirectionAndScreenshot.Enabled = false; PL.FlappingTimer.Enabled = false; return; }
         if(PL != null)
            { PL.sausage.BringToFront();//SendToBack();

                if (stop == true)
                {
                    //  Console.WriteLine("Makkara");
                    speed = valinta.speed;

                    SH.TakeScreenshot(PL);
                    F = new Flapping();
                    stop = false;
                    Random r = new Random();
                    locx = r.Next(PL.Cpanel.Width - PL.sausage.Width);
                    locy = r.Next(PL.Cpanel.Height - PL.sausage.Height);
                    PL.sausage.Location = new Point(Convert.ToInt32(locx), Convert.ToInt32(locy));

                    PL.sausage.Enabled = true;



                    valinta.DirectionAndScreenshot.Interval = 100; //half a second    // 1 second = 1000
                    valinta.DirectionAndScreenshot.Tick += new EventHandler(timer2_Tick);

                    // Enable timer.  
                    valinta.DirectionAndScreenshot.Enabled = true;
                    PL.FlappingTimer.Interval = 250; // 500 half a second    // 1 second = 1000
                    PL.FlappingTimer.Tick += new EventHandler(FlapWings);

                    // Enable timer.  
                    PL.FlappingTimer.Enabled = true;

                    Random ur = new Random();
                    valinta.direction = ur.Next(-1, 4);// 0-3


                    sausageamount--; // vain kolme - viisi lentävää makkaraa per kenttä
                    if (sausageamount <= -1) { PL.sausage.SendToBack(); end = true; }
                }//PL null

          }

      }
  }
}
