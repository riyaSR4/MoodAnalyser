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
                if (message.Contains("Sad"))
                    return "SAD";
                return "HAPPY";
            }catch(NullReferenceException)
            {
                return "HAPPY";
            }
        }
    }
}