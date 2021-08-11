using System;

namespace UserRegistration
{
    /*
     * UC1-validate-user-first-name
     * UC2-validate-user-last-name
     */
    class Program
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool rs = User.ValidateLastName();
            Console.WriteLine(rs);
        }    
    }
}
