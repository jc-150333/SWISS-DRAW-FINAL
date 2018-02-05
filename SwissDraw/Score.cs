using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissDraw
{
    public class Score
    {
        // くじの番号
        public int LotNumber { get; set; }
        public int winCount { get; set; }
        public int score { get; set; }

        public static Dictionary<int, Score> CalcWinClont(Match[] result)
        {
            Dictionary<int, Score> cw = new Dictionary<int, Score>(result.Length * 2);

            Score s = new Score();

            for (int i = 1; i <= result.Length * 2; i++)
            {
                s = new Score();

                s.LotNumber = i;

                s.winCount = Match.getWinCount(i, result);

                s.score = 0;

                cw.Add(i, s);
            }
            return cw;
        }

        public static Dictionary<int, Score> CalcScore(Match[] result)
        {
            Dictionary<int, Score> cs = CalcWinClont(result);

            Score s = new Score();

            int ss = 0;

            foreach (int key in cs.Keys)
            {
                foreach(Match r in result)
                {
                    if (Match.checkWin(key, r))
                    {
                        if(r.Person1 == key)
                        {
                            
                            ss = cs[key].score;

                            ss += Match.getWinCount(r.Person2, result);

                            cs[key].score = ss;
                            
                        }
                        else if (r.Person2 == key)
                        {

                            ss = cs[key].score;

                            ss += Match.getWinCount(r.Person1, result);

                            cs[key].score = ss;
                            
                        }
                    }
                }
            }

            return cs;
        }
    }
}
