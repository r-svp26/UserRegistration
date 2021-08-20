 using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    class UserException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            NULL_EXCEPTION
        }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public UserException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
