using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissDraw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissDraw.Tests
{
    [TestClass()]
    public class ScoreTests
    {
        [TestMethod()]
        public void CalcWinClontTest()
        {
            Match[] result = new Match[3];
            result[0] = new Match(1, 3);
            result[0].Result = 1;
            result[1] = new Match(2, 5);
            result[1].Result = 1;
            result[2] = new Match(4, 6);
            result[2].Result = 1;

            var score = Score.CalcScore(result);
            Assert.AreEqual(1, score[1].winCount);
            Assert.AreEqual(1, score[2].winCount);
            Assert.AreEqual(1, score[4].winCount);
            Assert.AreEqual(0, score[3].winCount);
            Assert.AreEqual(0, score[5].winCount);
            Assert.AreEqual(0, score[6].winCount);

            Match[] result2 = new Match[6];
            result2[0] = new Match(1, 3);
            result2[0].Result = 1;
            result2[1] = new Match(2, 5);
            result2[1].Result = 1;
            result2[2] = new Match(4, 6);
            result2[2].Result = 1;
            result2[3] = new Match(1, 2);
            result2[3].Result = 1;
            result2[4] = new Match(4, 5);
            result2[4].Result = 1;
            result2[5] = new Match(3, 6);
            result2[5].Result = 1;

            var score2 = Score.CalcScore(result2);
            Assert.AreEqual(2, score2[1].winCount);
            Assert.AreEqual(1, score2[2].winCount);
            Assert.AreEqual(1, score2[3].winCount);
            Assert.AreEqual(2, score2[4].winCount);
            Assert.AreEqual(0, score2[5].winCount);
            Assert.AreEqual(0, score2[6].winCount);


        }

        [TestMethod()]
        public void CalcScoreTest()
        {
            Match[] result2 = new Match[6];
            result2[0] = new Match(1, 3);
            result2[0].Result = 1;
            result2[1] = new Match(2, 5);
            result2[1].Result = 1;
            result2[2] = new Match(4, 6);
            result2[2].Result = 1;
            result2[3] = new Match(1, 2);
            result2[3].Result = 1;
            result2[4] = new Match(4, 5);
            result2[4].Result = 1;
            result2[5] = new Match(3, 6);
            result2[5].Result = 1;

            var score2 = Score.CalcScore(result2);
            Assert.AreEqual(2, score2[1].winCount);
            Assert.AreEqual(1, score2[2].winCount);
            Assert.AreEqual(1, score2[3].winCount);
            Assert.AreEqual(2, score2[4].winCount);
            Assert.AreEqual(0, score2[5].winCount);
            Assert.AreEqual(0, score2[6].winCount);

            Assert.AreEqual(1 + 1, score2[1].score);    //3,2
            Assert.AreEqual(0, score2[2].score);        //5
            Assert.AreEqual(0, score2[3].score);        //6
            Assert.AreEqual(0 + 0, score2[4].score);    //5,6
            Assert.AreEqual(0, score2[5].score);
            Assert.AreEqual(0, score2[6].score);
            
        }

        [TestMethod()]
        public void CalcScoreTest2()
        {
            
            Match[] result3 = new Match[18];
            result3[0] = new Match(1, 4);
            result3[0].Result = 1;
            result3[1] = new Match(2, 5);
            result3[1].Result = 1;
            result3[2] = new Match(3, 6);
            result3[2].Result = 1;
            result3[3] = new Match(7, 8);
            result3[3].Result = 1;
            result3[4] = new Match(9, 10);
            result3[4].Result = 1;
            result3[5] = new Match(11, 12);
            result3[5].Result = 1;
            result3[6] = new Match(13, 14);
            result3[6].Result = 1;
            result3[7] = new Match(15, 16);
            result3[7].Result = 1;
            result3[8] = new Match(17, 18);
            result3[8].Result = 1;
            result3[9] = new Match(1, 7);
            result3[9].Result = 1;
            result3[10] = new Match(2, 9);
            result3[10].Result = 2;
            result3[11] = new Match(3, 11);
            result3[11].Result = 2;
            result3[12] = new Match(13, 15);
            result3[12].Result = 2;
            result3[13] = new Match(17, 6);
            result3[13].Result = 1;
            result3[14] = new Match(4, 8);
            result3[14].Result = 1;
            result3[15] = new Match(5, 10);
            result3[15].Result = 2;
            result3[16] = new Match(12, 14);
            result3[16].Result = 1;
            result3[17] = new Match(16, 18);
            result3[17].Result = 2;

            var score3 = Score.CalcScore(result3);
            Assert.AreEqual(2, score3[1].winCount);
            Assert.AreEqual(1, score3[2].winCount);
            Assert.AreEqual(1, score3[3].winCount);
            Assert.AreEqual(1, score3[4].winCount);
            Assert.AreEqual(0, score3[5].winCount);
            Assert.AreEqual(0, score3[6].winCount);
            Assert.AreEqual(1, score3[7].winCount);
            Assert.AreEqual(0, score3[8].winCount);
            Assert.AreEqual(2, score3[9].winCount);
            Assert.AreEqual(1, score3[10].winCount);
            Assert.AreEqual(2, score3[11].winCount);
            Assert.AreEqual(1, score3[12].winCount);
            Assert.AreEqual(1, score3[13].winCount);
            Assert.AreEqual(0, score3[14].winCount);
            Assert.AreEqual(2, score3[15].winCount);
            Assert.AreEqual(0, score3[16].winCount);
            Assert.AreEqual(2, score3[17].winCount);
            Assert.AreEqual(1, score3[18].winCount);


            Assert.AreEqual(2, score3[1].score);        //4,7 
            Assert.AreEqual(0, score3[2].score);        //5
            Assert.AreEqual(0, score3[3].score);        //6
            Assert.AreEqual(0 + 0, score3[4].score);    //8
            Assert.AreEqual(0, score3[5].score);        
            Assert.AreEqual(0, score3[6].score);        
            Assert.AreEqual(0, score3[7].score);        //8
            Assert.AreEqual(0, score3[8].score);        
            Assert.AreEqual(2, score3[9].score);        //10,2
            Assert.AreEqual(0 + 0, score3[10].score);   //5
            Assert.AreEqual(2, score3[11].score);       //12,3
            Assert.AreEqual(0, score3[12].score);       //14
            Assert.AreEqual(0, score3[13].score);       //14
            Assert.AreEqual(0, score3[14].score);
            Assert.AreEqual(1, score3[15].score);       //16,13
            Assert.AreEqual(0, score3[16].score);   
            Assert.AreEqual(1, score3[17].score);       //18,6
            Assert.AreEqual(0, score3[18].score);
        }
    }
}