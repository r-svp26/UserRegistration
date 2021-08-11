using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class User
    {
        public const string FIRST_NAME = "^[A-Z]{1}[a-z]{2}";
        /// <summary>
        /// valid user first name
        /// </summary>
        /// <returns></returns>
        public static bool ValidateFirstName()
        {
            Regex regex = new Regex(FIRST_NAME);
            return regex.IsMatch("Ritesh");
        }
    }
}
