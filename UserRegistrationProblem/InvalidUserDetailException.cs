using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProblem
{
    public class InvalidUserDetailException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }
        private ExceptionType type;
        public InvalidUserDetailException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
