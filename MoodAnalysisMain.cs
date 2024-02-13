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
                MoodAnalyser analyser = new MoodAnalyser("");
                // MoodAnalyser analyser = new MoodAnalyser();

                MoodAnalyser mo = m.analysisMood(analyser);
            if (mo != null)
            {
                Console.WriteLine(mo.mood);
            }
          
        }
    }
}   
