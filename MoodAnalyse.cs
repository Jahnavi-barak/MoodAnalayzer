using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer1
{
    public class MoodAnalyse
    {
        private string message;
        public MoodAnalyse(String message)
        {
            this.message = message;
        }
        public string AnalayseMood(string message)
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
