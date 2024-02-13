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
            try
            {
                if (obj.mood == null)
                    throw new MoodAnalysisException("Mood Can't be : " + EnumChoice.Null);
                else if (obj.mood.Equals(""))
                    throw new MoodAnalysisException("Mood Can't be : " + EnumChoice.Empty);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new MoodAnalyser("");
            }
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
                return new MoodAnalyser("");

            }
            return new MoodAnalyser(val);
        }

        public bool bothObjectEqualOrNot(MoodAnalyser a,MoodAnalyser b)
        {
            if(a.Equals(b))
                return true;
            return false;
        }
    }
}
