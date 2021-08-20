using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class User
    {
        public const string FIRST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string LAST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string EMAIL = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public const string MOBILE = "^([9][1])+[ ]+[789]{1}[0-9]{9}$";
        public const string PASSWORD= "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";
        public const string SAMPLE_EMAIL = "^[a-zA-z]{3}([+-_ .]*[a-zA-Z0-9]+)*[@][a-zA-z0-9]+(.[a-z]{2,3})*$";

        /// <summary>
        /// valid user first name
        /// </summary>
        /// <returns></returns>
        public static string  ValidateFirstName(string name)
        {
            Regex regex = new Regex(FIRST_NAME);
            try
            {
                if (regex.IsMatch(name))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception )
            {
                throw new UserException(UserException.ExceptionType.NULL_EXCEPTION, "First name is not valid");
            }
        }
        /// <summary>
        /// valid user last name
        /// </summary>
        /// <returns></returns>
        public static string ValidateLastName(string name)
        {
            Regex regex = new Regex(LAST_NAME);
            try
            {
                if (regex.IsMatch(name))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new UserException(UserException.ExceptionType.NULL_EXCEPTION, "Last name is not valid");
            }
        }
        /// <summary>
        /// validate user email id
        /// </summary>
        /// <returns></returns>
        public static string ValidateEmail(string email)
        {
            Regex regex = new Regex(EMAIL);
            try
            {
                if (regex.IsMatch(email))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new UserException(UserException.ExceptionType.NULL_EXCEPTION, "Email name is not valid");
            }
        }
        /// <summary>
        /// validate user phone number
        /// </summary>
        /// <returns></returns>
        public static string ValidatePhone(string number)
        {
            Regex regex = new Regex(MOBILE);
            try
            {
                if (regex.IsMatch(number))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new UserException(UserException.ExceptionType.NULL_EXCEPTION, "Phone Number is not valid");
            }
        }
        /// <summary>
        /// validate password rule1
        /// </summary>
        /// <returns></returns>
        public static string ValidatePassword(string password)
        {
            Regex regex = new Regex(PASSWORD);
            try
            {
                if (regex.IsMatch(password))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new UserException(UserException.ExceptionType.NULL_EXCEPTION, "Password is not valid");
            }
        }
        /// <summary>
        /// minimum one character should be upper case
        /// </summary>
        /// <returns></returns>
        
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
