using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class User
    {
        public const string FIRST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string LAST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string EMAIL = "^[a-zA-z]{3}([.]*[a-zA-Z])+[@][a-zA-z]+([.][a-z]{2,3})*$";
        public const string  MOBILE= "^([9][1])+[ ]+[789]{1}[0-9]{9}$";
        /// <summary>
        /// valid user first name
        /// </summary>
        /// <returns></returns>
        public static bool ValidateFirstName()
        {
            Regex regex = new Regex(FIRST_NAME);
            return regex.IsMatch("Ritesh");
        }
        /// <summary>
        /// valid user last name
        /// </summary>
        /// <returns></returns>
        public static bool ValidateLastName()
        {
            Regex regex = new Regex(LAST_NAME);
            return regex.IsMatch("KUMAR");
        }
        /// <summary>
        /// validate user email id
        /// </summary>
        /// <returns></returns>
        public static bool ValidateEmail()
        {
            Regex regex = new Regex(EMAIL);
            return regex.IsMatch("abc.xyz@bl.co.in");
        }
        /// <summary>
        /// validate user phone number
        /// </summary>
        /// <returns></returns>
        public static bool ValidatePhone()
        {
            Regex regex = new Regex(MOBILE);
            return regex.IsMatch("91 9907296689");
        }
    }
}
