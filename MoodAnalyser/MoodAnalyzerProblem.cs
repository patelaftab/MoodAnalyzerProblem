using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerProblem
    {
        string message;
        public MoodAnalyzerProblem(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
                if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
        }
        
    }
}
