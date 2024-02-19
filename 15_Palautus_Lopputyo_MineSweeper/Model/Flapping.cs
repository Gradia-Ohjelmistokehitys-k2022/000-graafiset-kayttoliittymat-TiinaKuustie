using _15_Palautus_Lopputyo_MineSweeper.Model;
using _15_Palautus_Lopputyo_MineSweeper.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Palautus_Lopputyo_MineSweeper.Model
{
    public class Flapping
    {
        internal int check = 0;
        internal int direction = 0;
        FlyingSausage FS;
        Pelilauta PL;
        Valinta valinta;


        Bitmap image1;
        Bitmap image2;
        Bitmap image3;
        Bitmap FlipXimage1;
        Bitmap FlipXimage2;
        Bitmap FlipXimage3;
        /*
        Bitmap FlipYimage1;
        Bitmap FlipYimage2;
        Bitmap FlipYimage3;
        Bitmap FlipXYimage1;
        Bitmap FlipXYimage2;
        Bitmap FlipXYimage3;
        */


        public Flapping() 
        {

         
            PL = System.Windows.Forms.Application.OpenForms.OfType<Pelilauta>().FirstOrDefault();
            FS =  System.Windows.Forms.Application.OpenForms.OfType<FlyingSausage>().FirstOrDefault();
            valinta = System.Windows.Forms.Application.OpenForms.OfType<Valinta>().FirstOrDefault();

            image1 = Properties.Resources.FlyingSausageFlap11 as Bitmap;
            Color backColor1 = image1.GetPixel(0, 0);
            image1.MakeTransparent(backColor1);


            Bitmap flipimage1 = Properties.Resources.FlyingSausageFlap11 as Bitmap;
            flipimage1.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Color flipbackColor1 = flipimage1.GetPixel(0, 0);
            flipimage1.MakeTransparent(flipbackColor1);
            FlipXimage1 = flipimage1;


            /*
                      Bitmap flipimageY1 = Properties.Resources.FlyingSausageFlap11 as Bitmap;
                      flipimageY1.RotateFlip(RotateFlipType.RotateNoneFlipY);
                      Color flipbackColorY1 = flipimageY1.GetPixel(0, 0);
                      flipimageY1.MakeTransparent(flipbackColorY1);
                      FlipYimage1 = flipimageY1;
            */

            /*
                      Bitmap flipimageXY1 = Properties.Resources.FlyingSausageFlap11 as Bitmap;
                      flipimageXY1.RotateFlip(RotateFlipType.RotateNoneFlipXY);
                      Color flipbackColorXY1 = flipimageXY1.GetPixel(0, 0);
                      flipimageXY1.MakeTransparent(flipbackColorXY1);
                      FlipXYimage1 = flipimageXY1;
            */


            //___________________________________ 2 _____________________________________
            image2 = Properties.Resources.FlyingSausageFlap241 as Bitmap;
            Color backColor2 = image2.GetPixel(0, 0);
            image2.MakeTransparent(backColor2);

            Bitmap flipimage2 = Properties.Resources.FlyingSausageFlap241 as Bitmap;
            flipimage2.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Color flipbackColor2 = flipimage2.GetPixel(0, 0);
            flipimage2.MakeTransparent(flipbackColor2);
            FlipXimage2 = flipimage2;
            /*
                    Bitmap flipimageY2 = Properties.Resources.FlyingSausageFlap241 as Bitmap;
                    flipimageY2.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    Color flipbackColorY2 = flipimageY2.GetPixel(0, 0);
                    flipimageY2.MakeTransparent(flipbackColorY2);
                    FlipYimage2 = flipimageY2;
            */

            /*
                      Bitmap flipimageXY2 = Properties.Resources.FlyingSausageFlap241 as Bitmap;
                      flipimageXY2.RotateFlip(RotateFlipType.RotateNoneFlipXY);
                      Color flipbackColorXY2 = flipimageXY2.GetPixel(0, 0);
                      flipimageXY2.MakeTransparent(flipbackColorXY2);
                      FlipXYimage2 = flipimageXY2;
              */
            //___________________________________ 3 _________________________________________

            image3 = Properties.Resources.FlyingSausageFlap31 as Bitmap;
            Color backColor3 = image3.GetPixel(0, 0);
            image3.MakeTransparent(backColor3);


            Bitmap flipimage3 = Properties.Resources.FlyingSausageFlap31 as Bitmap;
            flipimage3.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Color flipbackColor3 = flipimage3.GetPixel(0, 0);
            flipimage3.MakeTransparent(flipbackColor3);
            FlipXimage3 = flipimage3;
            /*
                    Bitmap flipimageY3 = Properties.Resources.FlyingSausageFlap31 as Bitmap;
                    flipimageY3.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    Color flipbackColorY3 = flipimageY3.GetPixel(0, 0);
                    flipimageY3.MakeTransparent(flipbackColorY3);
                    FlipYimage3 = flipimageY3;

                    Bitmap flipimageXY3 = Properties.Resources.FlyingSausageFlap31 as Bitmap;
                    flipimageXY3.RotateFlip(RotateFlipType.RotateNoneFlipXY);
                    Color flipbackColorXY3 = flipimageXY2.GetPixel(0, 0);
                    flipimageXY3.MakeTransparent(flipbackColorXY3);
                    FlipXYimage3 = flipimageXY3;
            */

        }

        public void FlapWings()
        {
           // Console.WriteLine("flapping");
            direction = valinta.direction;

            if (direction == 0)// alaviistoon ylävasemmalta oikealle alas
            {

                if (check == 0)
                {
                    PL.sausage.Image = FlipXimage1;
                    check = 1;
                    return;
                }
                if (check == 1)
                {
                    PL.sausage.Image = FlipXimage2;
                    check = 2;
                    return;
                }
                if (check == 2)
                {
                    PL.sausage.Image = FlipXimage3;
                    check = 3;
                    return;
                }
                if (check == 3)
                {
                    PL.sausage.Image = FlipXimage2;
                    check = 0;
                    return;
                }
            } //(direction == 0)
            else if (direction == 1)// alaviistoon ylä oikealta vasemmalle alas
            {

                if (check == 0)
                {
                    PL.sausage.Image = image1;
                    check = 1;
                    return;
                }
                if (check == 1)
                {
                    PL.sausage.Image = image2;
                    check = 2;
                    return;
                }
                if (check == 2)
                {
                    PL.sausage.Image = image3;
                    check = 3;
                    return;
                }
                if (check == 3)
                {
                    PL.sausage.Image = image2;
                    check = 0;
                    return;
                }
            } //(direction == 1)

            else if (direction == 2)//ylviistoon alavasemmalta oikealle ylös
            {

                if (check == 0)
                {
                    PL.sausage.Image = FlipXimage1;
                    check = 1;
                    return;
                }
                if (check == 1)
                {
                    PL.sausage.Image = FlipXimage2;
                    check = 2;
                    return;
                }
                if (check == 2)
                {
                    PL.sausage.Image = FlipXimage3;
                    check = 3;
                    return;
                }
                if (check == 3)
                {
                    PL.sausage.Image = FlipXimage2;
                    check = 0;
                    return;
                }
            } //(direction == 2)
            else if (direction == 3)//yläviistoon alaoikealta vasemmalle ylös
            {

                if (check == 0)
                {
                    PL.sausage.Image = image1;
                    check = 1;
                    return;
                }
                if (check == 1)
                {
                    PL.sausage.Image = image2;
                    check = 2;
                    return;
                }
                if (check == 2)
                {
                    PL.sausage.Image = image3;
                    check = 3;
                    return;
                }
                if (check == 3)
                {
                    PL.sausage.Image = image2;
                    check = 0;
                    return;
                }
            } //(direction == 3)

        }


    }
}
