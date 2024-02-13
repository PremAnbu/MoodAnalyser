using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalysis
{
    public class MoodAnalyser
    {
        public string mood {  get; set; }
        public MoodAnalyser() { }
        public MoodAnalyser(string mood) {
            this.mood = mood;
        }

        public static MoodAnalyser m=null;
        public static MoodAnalyser getObject()
        {
            if (m == null)
                return new MoodAnalyser();
            return null;
        }
        public override bool Equals(object obj)
        {
            MoodAnalyser other = (MoodAnalyser)obj;
            return this.mood == other.mood;
        }
    }
}
