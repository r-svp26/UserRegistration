using System;

namespace UserRegistration
{
    /*
     * UC1-validate-user-first-name
     * UC2-validate-user-last-name
     * UC3-validate-user-email
     * UC4-validate-user-mobile
     * UC5-password-rule1
     * UC6-password-rule2
     * UC-minimum-one-numeric-value
     */
    class Program
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool rs = User.PasswordR3();
            Console.WriteLine(rs);
        }    
    }
}
