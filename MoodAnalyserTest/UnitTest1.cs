using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    public class Tests
    {
        
        [Test]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyseMood();
            Assert.AreEqual(actual,"SAD");
        }

        [Test]
        public void GivenAnyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = "I am in Any Mood";
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyseMood();
            Assert.AreEqual(actual, "HAPPY");
        }

        [Test]
        public void GivenNullMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = null;
            MoodAnalyser analyser = new MoodAnalyser(message);
            try
            {
                string actual = analyser.AnalyseMood();
            }catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
        [Test]
        public void GivenEmptyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = "";
            MoodAnalyser analyser = new MoodAnalyser(message);
            try
            {
                string actual = analyser.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }
    }
}