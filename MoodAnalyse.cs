using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer1
{
    public class MoodAnalyse : MoodAnalyseBase
    {
        private string message;
        public MoodAnalyse(String message)
        {
            this.message = message;
        }
        /// Parameterised Constructor.
        ///  </summary>
        /// <param mame="message"></param>
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");

                }
                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }

        public string AnalayseMood()
        {
            throw new NotImplementedException();
        }
    }
}