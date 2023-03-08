using MoodAnalyser;
using MoodAnalyzer;
namespace MoodAnalyzerTestCases
{
    public class Tests
    {
        [Test]
        public void GivenSadMood_WhenAnalyzed_ShouldReturnSad()
        {
            MoodAnalyzerProblem moodAnalyzer = new MoodAnalyzerProblem("Im In Sad Mood");

            string result = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual(result, "Sad");
        }
        [Test]
        public void GivenAnyMood_WhenAnalyzed_ShouldReturnHappy()
        {
            MoodAnalyzerProblem moodAnalyzer = new MoodAnalyzerProblem("Im In Any Mood");

            string result = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMood_WhenAnalyzed_ShouldReturnHappy()
        {
            MoodAnalyzerProblem moodAnalyzer = new MoodAnalyzerProblem(null);
                string result = moodAnalyzer.AnalyzeMood();
                Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMood_ThrowMoodAnalysisException_NullMessage()
        {
            MoodAnalyzerProblem moodAnalyzer = new MoodAnalyzerProblem(null);
            try
            {
                string result = moodAnalyzer.AnalyzeMood();
            }
            catch (CustomeException obj)
            {
                Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
            }
        }
        [Test]
        public void GivenEmptyMood_ThrowMoodAnalysisException_EmptyMessage()
        {
            MoodAnalyzerProblem moodAnalyzer = new MoodAnalyzerProblem("");
            try
            {
                string result = moodAnalyzer.AnalyzeMood();
            }
            catch (CustomeException obj)
            {
                Assert.AreEqual("Please do not Enter the empty Input", obj.Message);
            }
        }
    }
}