using _15_Palautus_Lopputyo_MineSweeper.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace _15_Palautus_Lopputyo_MineSweeper.Model
{
    public class Ruutu
    {
       public string task {get;set;}
        private bool[][] nakkiMap {  get; set; }
        internal HashSet<int> Discovered {  get; set; }
        internal HashSet<int>   Flagged { get; set; }

        internal int TrueAmount;
        public bool Started { get; set; }
        public int nakit { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }

        public Ruutu() { }

        public Ruutu(int row, int col, int nakkeja)
        {
            nakit = nakkeja;
            Row = row;
            Col = col;
            Started = false;

            nakkiMap = new bool[row][];
            Discovered = new HashSet<int>();
            Flagged = new HashSet<int>();

            foreach(int i in Enumerable.Range(0, row))
            {
                nakkiMap[i] = new bool[col];
            }

            foreach (int i in Enumerable.Range(0, row))
            {
                foreach (int j in Enumerable.Range(0, col))
                {
                    nakkiMap[i][j] = false; //tyhjennetään koko taulu
                }
            }

        }//  public Field(int row, int col, int nakkeja)


        internal void Initialize(int first_click_x,int first_click_y)
        {
            Started = true;
            HashSet<int> TodNakit  = new HashSet<int>();
            int num = 0;
            var rand = new Random();
        

            while (num < nakit) //arvotaan nakkien sijainnit
            {
                int i = rand.Next(Row); 
                int j = rand.Next(Col);

                if(TodNakit.Contains(i * Col * j)){ continue; }

                if(Math.Abs(i - first_click_x) < 2 && Math.Abs(j - first_click_y) < 2) { continue;  } //this ensures the first click will not have a mine

                nakkiMap[i][j] = true;
                num++;
                TodNakit.Add(i * Col + j);


            }
    
            //lasketaan taipeet nakeille
            for (int i = 0; i < Row -1; i++) // X = up/down   y = left/right
            {
                for (int j = 0; j < Col -1; j++)
                {
                    int rivi = i;
                    int kolumni = j;

                    bool r = false;
                    bool d = false;
                    bool u = false;
                    bool l = false;

                   // Console.WriteLine($"Klikattu X: {rivi}  Y: {kolumni}");

                    if (rivi != Row && rivi > 0 && kolumni != Col && kolumni > 0)
                    {
                        r = OnkoNakki(rivi, kolumni + 1); //seuraava kolumni okealla = +1
                        d = OnkoNakki(rivi - 1, kolumni); // ylempi rivi -1
                        u = OnkoNakki(rivi + 1, kolumni); //aiempi rivi = +1
                        l = OnkoNakki(rivi, kolumni - 1); //edellinen kolumni vas = -1
                    }
                    else if (rivi == Row && kolumni != Col && kolumni > 0)
                    {
                        r = OnkoNakki(rivi, kolumni + 1); //seuraava kolumni okealla = +1
                        d = OnkoNakki(rivi - 1, kolumni); //  ylempi rivi -1
                        l = OnkoNakki(rivi, kolumni - 1); //edellinen kolumni vas = -1
                    }
                    else if (rivi != Row && rivi > 0 && kolumni == Col)
                    {
                        d = OnkoNakki(rivi - 1, kolumni); // ylempi rivi -1
                        u = OnkoNakki(rivi + 1, kolumni); //aiempi rivi = +1
                        l = OnkoNakki(rivi, kolumni - 1); //edellinen kolumni vas = -1
                    }
                    else if (rivi == Row && kolumni == Col) // 30,30
                    {
                        d = OnkoNakki(rivi - 1, kolumni); // ylempi rivi -1
                        l = OnkoNakki(rivi, kolumni - 1); //edellinen kolumni vas = -1
                    }
                    else if (rivi == Row && kolumni == 0) // 30,0
                    {
                        d = OnkoNakki(rivi - 1, kolumni); // ylempi rivi -1
                        r = OnkoNakki(rivi, kolumni + 1); //seuraava kolumni okealla = +1
                    }

                    else if (rivi == 0 && kolumni == 0) // 0,0
                    {
                        u = OnkoNakki(rivi + 1, kolumni); //aiempi rivi = +1
                        r = OnkoNakki(rivi, kolumni + 1); //seuraava kolumni okealla = +1
                    }
                    else if (rivi == 0 && kolumni == Col) // 0,30
                    {
                        u = OnkoNakki(rivi +1, kolumni); //aiempi rivi = +1
                        l = OnkoNakki(rivi, kolumni - 1); //edellinen kolumni vas = -1
                    }


                    //KULMAPALAT   Lasketaan onko pelis nakkeja vinottain, jotta vois laittaa kulman niiden väliin (Piirränakki hoitaa pelilaudassa kuvan)
                    if ((r == true && d == true) || (r == true && u == true) || (l == true && d == true) || (l == true && u == true))
                    {
                        if (TodNakit.Count == nakit){  }                    
                        else if (TodNakit.Count < nakit)
                        {
                            nakkiMap[i][j] = true;
                            TodNakit.Add(i * Col + j);
                        }
               
                    }//kulmapalat

                }//for
                
            }
     
            // VARMISTETAAN ETTÄ NAKKEJA ON AINA OIKEA MÄÄRÄ
            if (TodNakit.Count < nakit) 
            {
             
                int x =  nakit - TodNakit.Count;
                int i = 0;
                while ( i < x)
                {
                    Random random = new Random();
                    int rndx = random.Next(0, Row - 1);
                    int rndy = random.Next(0, Col - 1);

                    int cord = rndx * Col + rndy;
                    if (!TodNakit.Contains(cord)) { nakkiMap[rndx][rndy] = true; TodNakit.Add(rndx * Col + rndy); i++; }
                }
            }
           
            nakit = TodNakit.Count; //emme voi poistaa ylimääräisiä nakkeja, mutta ylimääräisien mahd on olematon, tää ottaa senkin huomioon

            Pelilauta PL = System.Windows.Forms.Application.OpenForms.OfType<Pelilauta>().FirstOrDefault();
            PL.ReNakit(nakit);//läheteään korjattu nakkien määrä pelilaudalle

     
        } //  internal void Initialize(int first_click_x,int first_click_y)


        internal bool OnkoNakki(int i, int j) //onko täs nakkia?
        {
          //  Console.WriteLine($"OnkoNakki: Row: {Row} Col: {Col} I: {i}  J: {j} Task: {task}");
            try
            {
                return nakkiMap[i][j];
            }
            catch (Exception e) { return false; } //tällä estetään out of bouds, ei siel oo laidan ulkopuolel nakkia
        }
        public int LaskeNakit(int click_x, int click_y) 
        {
            int count = 0; 

            for(int i = Math.Max(click_x - 1,0); i <= Math.Min(click_x + 1,Row -1); i++)
            {
                for (int j = Math.Max(click_y - 1, 0); j <= Math.Min(click_y + 1, Col - 1); j++)
                {
                    if (nakkiMap[i][j]) { count++; }
                }
            }
            return count;
        }//public int LaskeNakit(int click_x, int click_y)

        public HashSet<int> GetNeighbors(int x, int y)
        {
            HashSet<int> result = new HashSet<int>(); //like an array, but each element in a HashSet must be unique.

            for (int i = Math.Max(x - 1, 0);i <= Math.Min(x + 1, Row -1); i++)
            {
                for (int j = Math.Max(y - 1, 0); j <= Math.Min(y + 1, Col - 1); j++)
                {
                    if(i != x || j !=y) { result.Add(i * Col + j); }
                }

            }
            
            return result;
        }//     public HashSet<int> GetNeighbors(int x, int y)

        public HashSet<int> GetSafeIsland(int click_x, int click_y)
        {
            HashSet<int> result = new HashSet<int>();
            Queue<int> q = new Queue<int>();

            bool[][] visited = new bool[Row][];

            foreach (int i in Enumerable.Range(0, Row))
            {
                visited[i] = new bool[Col];
            }
            foreach (int i in Enumerable.Range(0, Row))
            {
                foreach (int j in Enumerable.Range(0, Col))
                {
                    visited[i][j] = false;
                }
            }
            visited[click_x][click_y] = true;

            q.Enqueue(click_x * Col + click_y);

            while(q.Count > 0)
            {
                int d = q.Dequeue();
                result.Add(d);
                Discovered.Add(d);

                if (LaskeNakit(d / Col, d % Col) > 0) { continue; } //if true laskenakit() > 0

                foreach(int neighbor in GetNeighbors(d/Col,d % Col))
                {
                    if (!visited[neighbor / Col][neighbor % Col]) // if false
                    {
                        visited[neighbor / Col][neighbor % Col] = true;
                        q.Enqueue((int)neighbor);
                    }
                }

            }//while

            return result;
        }


     
    }
}
