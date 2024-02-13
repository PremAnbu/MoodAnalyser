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
          
                MoodAnalysisClass m = new MoodAnalysisClass();
            // MoodAnalyser analyser = new MoodAnalyser("");
            // MoodAnalyser analyser = new MoodAnalyser();
            MoodAnalyser analyser1 = MoodAnalyser.getObject();
            analyser1.mood = "I am happy";
            MoodAnalyser mo1 = m.analysisMood(analyser1);

            MoodAnalyser analyser2 = MoodAnalyser.getObject();
            analyser2.mood = "I am happy";
            if (m.bothObjectEqualOrNot(analyser1, analyser2))
                Console.WriteLine("Both object are Same");
            else
                Console.WriteLine("Both object are different");


            if (mo1 != null)
            {
                Console.WriteLine(mo1.mood);
            }
          
        }
    }
}   
