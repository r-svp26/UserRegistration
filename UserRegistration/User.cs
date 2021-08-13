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
        public const string EMAIL = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public const string MOBILE = "^([9][1])+[ ]+[789]{1}[0-9]{9}$";
        public const string PASSWORD_R1 = "^[a-zA-Z0-9]{8}";
        public const string PASSWORD_R2 = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        public const string PASSWORD_R3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        public const string PASSWORD_R4 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";
        public const string SAMPLE_EMAIL = "^[a-zA-z]{3}([+-_ .]*[a-zA-Z0-9]+)*[@][a-zA-z0-9]+(.[a-z]{2,3})*$";

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
        /// <summary>
        /// validate password rule1
        /// </summary>
        /// <returns></returns>
        public static bool PasswordR1()
        {
            Regex regex = new Regex(PASSWORD_R1);
            return regex.IsMatch("Rkxyb302");
        }
        /// <summary>
        /// minimum one character should be upper case
        /// </summary>
        /// <returns></returns>
        public static bool PasswordR2()
        {
            Regex regex = new Regex(PASSWORD_R2);
            return regex.IsMatch("akXyb302");
        }
        /// <summary>
        /// minimum one numeric value
        /// </summary>
        /// <returns></returns>
        public static bool PasswordR3()
        {
            Regex regex = new Regex(PASSWORD_R3);
            return regex.IsMatch("akXybxy3");
        }
        /// <summary>
        /// atleast one special character
        /// </summary>
        /// <returns></returns>
        public static bool PasswordR4()
        {
            Regex regex = new Regex(PASSWORD_R4);
            return regex.IsMatch("akXs@bx3");
        }
        /// <summary>
        /// valid the email id.
        /// </summary>
        public static void ValidatingEmail()
        {
            string[] sample = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc-100@abc.net", "abc.100@abc.com.au",
                                 "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,"abc","abc@.com","abc123@gmail.a", "abc123@.com" ,
                                 "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a"};
            Regex regex = new Regex(SAMPLE_EMAIL);
            Console.WriteLine("Validates Email ID");
            Validate(sample, regex);
        }
        /// <summary>
        /// printing email id status
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="regex"></param>
        public static void Validate(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool rs = regex.IsMatch(arr[i]);
                if (rs == true)
                    Console.WriteLine(arr[i] + "-->" + "Valid Email ID");
                else
                    Console.WriteLine(arr[i] + "-->" + "Invalid Email ID");
            }
        }
    }
}
