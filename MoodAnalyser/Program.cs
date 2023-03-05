using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Mood Analyzer Problem");
            MoodAnalyzerProblem moodAnalyzerProblem = new MoodAnalyzerProblem();
            moodAnalyzerProblem.AnalyzeMood("I Am Sad");
            Console.ReadLine();
        }
    }
}
