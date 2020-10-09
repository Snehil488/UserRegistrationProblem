using System;
using System.Collections.Generic;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationValidation validate = new UserRegistrationValidation();
            Console.WriteLine("Enter First Name : ");
            string firstName = Console.ReadLine();
            bool fNameResult = validate.ValidateFirstName(firstName);
            validate.PrintResult(fNameResult);
            Console.WriteLine("Enter Last Name : ");
            string lastName = Console.ReadLine();
            bool lNameResult = validate.ValidateLastName(lastName);
            validate.PrintResult(lNameResult);
            Console.WriteLine("Enter Email Id : ");
            string email = Console.ReadLine();
            bool emailResult = validate.ValidateEmail(email);
            validate.PrintResult(emailResult);
            Console.WriteLine("Enter Mobile Number : ");
            string mobNumber = Console.ReadLine();
            bool mobNumberResult = validate.ValidateMobileNumber(mobNumber);
            validate.PrintResult(mobNumberResult);
            Console.WriteLine("Enter Password : ");
            string password = Console.ReadLine();
            bool passwordResult = validate.ValidatePassword(password);
            validate.PrintResult(passwordResult);
            Console.WriteLine("Checking for sample mails : ");
            foreach (string mail in validate.GetList())
            {
                Console.Write(mail + " : ");
                validate.PrintResult(validate.ValidateEmail2(mail));
            }
        }
    }
}
