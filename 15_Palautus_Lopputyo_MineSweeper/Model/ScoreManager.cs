using _15_Palautus_Lopputyo_MineSweeper.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _15_Palautus_Lopputyo_MineSweeper.Model
{
   public class ScoreManager
    {
        private string Player {  get; set; }
        private int Score { get; set; }
        private int GottenSausages { get; set; }
        private int MissedSausages { get; set; }

        private int frozen {  get; set; }   

        private static int HighScore {  get; set; }
     //   private static string CurrentlyPlaying {  get; set; }
        public ScoreManager()
        {
           // Player = player;
            Score = 0;
            GottenSausages = 0;
            MissedSausages = 0;
        }

        public ScoreManager(string player) //pelaajaolio
        {
            Player = player;
            Score = 0;
            GottenSausages = 0;
            MissedSausages = 0; 
        }


        public void changeScore(int score, string data, int nakkeja) // data = onko missed vai gotten
        {
            Score = Score + score;
            Label scoreLabel = new Label();
            Label highs = new Label();

           Valinta valinta = System.Windows.Forms.Application.OpenForms.OfType<Valinta>().FirstOrDefault();

            Pelilauta PL = System.Windows.Forms.Application.OpenForms.OfType<Pelilauta>().FirstOrDefault();
           scoreLabel = PL.ScoreLabel;
           highs = PL.Highscore;

            if(valinta.HighScore > 0) { HighScore = valinta.HighScore; }
          
    

            if (data.ToUpper() == "M")//missed
            {
                MissedSausages++;
            }
            else if (data.ToUpper() == "G") //gotten
            {
                GottenSausages++;
            }

            int remaining = nakkeja - GottenSausages - MissedSausages;

          //  Console.WriteLine("Letter: " + data + " Nakkeja " +nakkeja + " gotten " + GottenSausages + " Missed " + MissedSausages + " = remaining " + remaining);

            if (data.ToUpper() == "F") //frozen
            {
                frozen++;

                if (frozen > 9) // lose
                {
                    scoreLabel.Text = $"Score: {Score}\nGotten: {GottenSausages}\nSmashed: {MissedSausages}\nRemaining: {remaining}\nFingers: {10 - frozen}/10";
                    if (Score > HighScore) { HighScore = Score; valinta.HighScore = HighScore; highs.Text = "Highest score: " + HighScore.ToString(); MessageBox.Show("You surpassed the highscore!"); }
                    PL.GameOver("frozen");
                }
            }
            else if (data.ToUpper() == "O") //all buttons opened 
            {

                scoreLabel.Text = $"Score: {Score}\nGotten: {GottenSausages}\nSmashed: {MissedSausages}\nRemaining: {remaining}\nFingers: {10 - frozen}/10";
                if (Score > HighScore) { HighScore = Score; valinta.HighScore = HighScore; highs.Text = "Highest score: " + HighScore.ToString(); MessageBox.Show("You surpassed the highscore!"); }

                if (GottenSausages < (nakkeja/2))
                {
                   PL.GameOver("less");
                }
                else if (GottenSausages >= (nakkeja / 2) || remaining == 0) { PL.GameOver("win"); } //win
            }
            else if (remaining == 0) // win
            {
                scoreLabel.Text = $"Score: {Score}\nGotten: {GottenSausages}\nSmashed: {MissedSausages}\nRemaining: {remaining}\nFingers: {10 - frozen}/10";
                if (Score > HighScore)
                {
                    HighScore = Score;
                    highs.Text = "Highest score: " + HighScore.ToString();
                    valinta.HighScore = HighScore; MessageBox.Show("You surpassed the highscore!");

                }
                PL.GameOver("win");
            }
            else
            {
                highs.Text = "Highest score: " + HighScore.ToString();

                if (PL != null) //form on luotu eikös?
                {
                    scoreLabel.Text = $"Score: {Score}\nGotten: {GottenSausages}\nSmashed: {MissedSausages}\nRemaining: {remaining}\nFingers: {10 - frozen}/10";
                }
            }//else
        }

    }
}
