namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        //Refactor
        string message;
        public MoodAnalyser(string message) 
        {
            this.message = message;
        }
        //UC1
        public string AnalyseMood() 
        {
            if (message.Contains("Sad"))
                return "SAD";
            return "HAPPY";
        }
    }
}