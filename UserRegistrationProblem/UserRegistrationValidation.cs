using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class UserRegistrationValidation
    {
        private static string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";
        private static string REGEX_LASTNAME = "^[A-Z][a-z]{2,}$";
        private static string REGEX_EMAIL = "^[a-zA-Z]+([.][A-Za-z]+)*[@][a-zA-Z]+[.][a-zA-Z]+([.][a-zA-Z]+)*$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }    
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LASTNAME);
        }        
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
    }
}
