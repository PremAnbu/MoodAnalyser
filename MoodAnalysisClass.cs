using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalysis
{
    public class MoodAnalysisClass
    {
        public MoodAnalyser analysisMood(MoodAnalyser obj)
        {
            if (obj.mood == null)
                return new MoodAnalyser("HAPPY");
            string val = obj.mood.ToLower().Split(" ").Contains("sad") ? "HAPPY":"SAD"  ;
            try
            {
                if(!((val.Contains("SAD"))||(val.Contains("HAPPY"))))
                {
                    throw new InvalidMoodException("Invalid Mood .......!!!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return new MoodAnalyser(val);
        }
    }
}
