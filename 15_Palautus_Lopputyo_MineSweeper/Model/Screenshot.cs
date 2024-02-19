using _15_Palautus_Lopputyo_MineSweeper.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Palautus_Lopputyo_MineSweeper.Model
{
  public class Screenshot
    {
        Pelilauta PL;

        string folderName = "Laps";
        string folderPath;
        string fileName = "lap.png";
        string filePath;
        public Screenshot() 
        {
            PL = System.Windows.Forms.Application.OpenForms.OfType<Pelilauta>().FirstOrDefault();
            folderPath = Path.Combine(Application.StartupPath, folderName);
          

            try
            {
             
                if (!Directory.Exists(folderPath)){ Directory.CreateDirectory(folderPath); }
                filePath = Path.Combine(folderPath, fileName);
            }
            catch (Exception ex){throw new ArgumentException(ex.Message);}

        }

        public void TakeScreenshot(Pelilauta PL) //KOSKA WF EI TUE TRUE TRANSPARENCYÄ, VAAN LÄPINÄKYVÄN NAPIN ALTA NÄKYY POHJA, PITÄÄ KIKKAILLA
        {
            PL = System.Windows.Forms.Application.OpenForms.OfType<Pelilauta>().FirstOrDefault();
            if (PL == null) { return; }

            else if (PL != null)
            {


                if ( PL.WindowState == FormWindowState.Minimized)
                {
                    //  MessageBox.Show("Cannot take screenshot while the form is minimized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Skip taking screenshot
                }


                Rectangle clientBounds = PL.ClientRectangle;

                // Convert client bounds to screen coordinates
                Rectangle screenBounds = PL.RectangleToScreen(clientBounds);

                // Create a bitmap to store the screenshot
                Bitmap screenshot = new Bitmap(clientBounds.Width, clientBounds.Height);

                PL.sausage.Visible = false;
                Application.DoEvents();
                Graphics graphics = Graphics.FromImage(screenshot);
                PL.sausage.Visible = true;
                graphics.CopyFromScreen(screenBounds.Location, Point.Empty, clientBounds.Size);
                graphics.Dispose();

              //  screenshot.Save("screenshot.png", System.Drawing.Imaging.ImageFormat.Png);

                screenshot.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                PL.BackgroundImage = screenshot;



            }//else

            //  MessageBox.Show("Screenshot captured!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
