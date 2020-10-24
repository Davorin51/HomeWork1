using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Sources;
using System.Linq;

namespace ConsoleApplication
{
    class Episode
    {
        private int view;
        private double score;
        private double maxScore;
        private double sumScore;
       

        
        public Episode(int View, double SumScore, double MaxScore){

            view = View;
            sumScore = SumScore;
            maxScore = MaxScore;
            }
        public Episode()
        {
            sumScore = GetSum();
            view = GetViewerCount();
        }


       

        public void AddView(double SCORE)
        {
            this.score =SCORE;
        }
        public double GetScore()
        {
            return score;

        }

        public void AddScore(double SCORE)
        {
            this.score = SCORE;
        }
        
        public double GenerateRandomScore()
        {
            Random rand = new Random();
            score = (float)rand.NextDouble() * (10.0 - 0.0) + 0.0;
            
            return score;
           
        }
        public double GetMaxScore()
        {

            return score;

        }
        public int GetViewerCount()
        {
            return view;
        }

        public double GetAverageScore()
        {
            double number = sumScore / view;
            return number;

        }
        public double GetSum()
        {
            double[] field = new double[10];
            int i;
            double sum = 0;
            for(i=0; i<10; i++)
            {
                field[i] = GenerateRandomScore();
                field[i] += sum;
            }

            return sum;

        }
    }
}
