using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyzerFactory
    {
        public static object CreateMoodAnalyser(string namesapceandclassname, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            bool result = Regex.IsMatch(namesapceandclassname, pattern);

            if (result)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(namesapceandclassname);
                    return Activator.CreateInstance(moodAnalyserType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomeException(CustomeException.CustomeExceptionType.NO_SUCH_CLASS, "Class Not Found ");
                }
            }
            else
            {
                throw new CustomeException(CustomeException.CustomeExceptionType.NO_SUCH_METHOD, "Constructor not found");
            }
        }
    }
}
