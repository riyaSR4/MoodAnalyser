namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message) 
        {
            this.message = message;
        }
        public string AnalyseMood() 
        {
            try
            {
                if (this.message == string.Empty)
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD,
                        "Message is Empty");
                if (message.Contains("Sad"))
                    return "SAD";
                return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD,
                     "Message is Null");
            }
        }
    }
}