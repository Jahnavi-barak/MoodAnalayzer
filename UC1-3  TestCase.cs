using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer1;
namespace MoodAnalyseMStest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 1.1 Givewn ?I am in Sad Mood? message Should Return SAD .
        /// </summary>
        public void GivenSadMoodShouldReturnSAD()
        {
            // Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            // Act
            string mood = moodAnalyse.AnalayseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }
        /// <summary>
        /// TC 1.2 & 2.1: Given ?Iam in HAPPY Mood? and null message Should Return HAPPY 
        /// </summary>
        [TestMethod]
        /// [DataRow("I am in HAPPY Mood")]
        /// [DataRow(null)]
        public void GivenHAPPYMoodShouldReturnHappy(string message)
        {
            // Arrange
            string expected = "HAPPY";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            // Act 
            string mood = moodAnalyse.AnalayseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }

        ///<summary>
        /// tc 3.1: Given NULL Mood Should Throw MoodAnalyseisException.
        ///</summary>
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_CustomException()
        {
            try
            {
                string message = null;
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                string Mood = moodAnalyse.AnalayseMood();
            }
            catch ( CustomException.e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        ///<summary>
        /// Tc 3.2: Given Empty Mood Should Throw MoodAnalyseException indicating Empty Mood.
        ///</summary>
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_CustomException_Indicating_EmptyMood()
        {
            try
            {
                string message = " ";
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                string mood = moodAnalyse.AnalayseMood();
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}
 

