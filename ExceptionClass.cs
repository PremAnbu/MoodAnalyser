using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalysis
{
     class ExceptionClass
    {
    }
    public class InvalidMoodException : Exception
    {
        public InvalidMoodException(string message) : base(message) { 
        }
    }
    public class MoodAnalysisException : Exception { 
        public MoodAnalysisException(string message) : base(message) { }
    }
}
