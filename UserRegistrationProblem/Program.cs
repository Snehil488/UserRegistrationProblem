using System;

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
        }
    }
}
