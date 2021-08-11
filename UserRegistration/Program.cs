using System;

namespace UserRegistration
{
    /*
     * UC1-validate-user-first-name
     */
    class Program
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool rs = User.ValidateFirstName();
            Console.WriteLine(rs);
        }    
    }
}
