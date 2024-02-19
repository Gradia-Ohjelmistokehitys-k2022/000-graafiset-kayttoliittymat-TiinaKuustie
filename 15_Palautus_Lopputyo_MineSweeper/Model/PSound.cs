using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace _15_Palautus_Lopputyo_MineSweeper.Model
{
   public class PSound
    {
        // string soundlink = @"c:\Windows\Media\chimes.wav";
        // SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");

        /*
        chimes happy piano like
        Ring01   could be finding a treasure?
        Ring08 olis kiva taustamusiikiksi. jos löytys pidempi versio
        ringout  vois olla fail
        Speech On pu-whip positive checkmark?
        tada fanfare
        recycle rapina
        Ring06  blimbim
          */

        public PSound() { }
        public void playSimpleSound(string sound)
        {
            string soundlink = @"c:\Windows\Media\" + sound + ".wav";

            SoundPlayer simpleSound = new SoundPlayer(soundlink);
            simpleSound.Play();
        }

    }
}
