﻿using System;

namespace UserRegistration
{
    /*
     * UC1-validate-user-first-name
     * UC2-validate-user-last-name
     * UC3-validate-user-email
     * UC4-validate-user-mobile
     * UC5-password-rule1
     */
    class Program
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool rs = User.PasswordR1();
            Console.WriteLine(rs);
        }    
    }
}
