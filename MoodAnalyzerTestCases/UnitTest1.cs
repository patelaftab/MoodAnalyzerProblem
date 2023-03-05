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

    }
}