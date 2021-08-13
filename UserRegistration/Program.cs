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
     * UC7-minimum-one-numeric-value
     * UC8-alteast-one-special-character
     * UC9-email-validation
     */
    class Program
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            User.ValidatingEmail();
        }    
    }
}
