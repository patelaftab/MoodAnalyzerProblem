using MoodAnalyser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyser.CustomeException;

namespace MoodAnalyzer
{
    public class MoodAnalyzerProblem
    {
        string message;
        public MoodAnalyzerProblem()
        {
            //message = null;
        }
        public MoodAnalyzerProblem(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                    throw new CustomeException(CustomeExceptionType.EMPTY_MOOD, "Please do not Enter the empty Input");
                if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch(NullReferenceException)
            {
                throw new CustomeException(CustomeExceptionType.NULL_MOOD, "Please do not Enter the Null Input");
            }
        }
        
    }
}
