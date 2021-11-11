using System;
namespace MoodAnalyzer1
{
    public class CustomException : Exception
    {
        /// <summary>
        /// Enum for Exception Type.
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE, Empty_Message,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE,
            EMPTY_MESSAGE
        }
        
        /// Creating 'type' variable of type ExceptionType
        private readonly ExceptionType type;

        ///<summary>
        ///parameterized Constructor sets the Exception Type and Message.
        ///</summary>
        ///<param name"Type></param>
        ///<param name"message"></param>
        public CustomException(ExceptionType Type, string message) : base(message)
        { 
           this.type = Type;
        }
    } 
}

         
