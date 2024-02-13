using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalysis
{
    public class MoodAnalysisMain
    {
        public static void Main()
        {
            MoodAnalysisClass m=new MoodAnalysisClass();
            MoodAnalyser analyser=new MoodAnalyser("I Am In happy Mood");
           // MoodAnalyser analyser = new MoodAnalyser();

            MoodAnalyser obj = m.analysisMood(analyser);
            if (obj != null)
            {
                Console.WriteLine(obj.mood);
            }
        }
    }
}   
