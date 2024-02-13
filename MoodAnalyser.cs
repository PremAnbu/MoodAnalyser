using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalysis
{
    public class MoodAnalyser
    {
        public string mood { get; set; }
        public MoodAnalyser() { }
        public MoodAnalyser(string mood) {
            this.mood = mood;
        }
    }
}
