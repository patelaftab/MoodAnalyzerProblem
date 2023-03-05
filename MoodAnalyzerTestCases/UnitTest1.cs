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

    }
}