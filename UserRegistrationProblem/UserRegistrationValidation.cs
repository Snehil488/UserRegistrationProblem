﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserRegistrationValidation
    {
        private List<string> sampleMails = new List<string>()
        {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com"
        };
        private static string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";
        private static string REGEX_LASTNAME = "^[A-Z][a-z]{2,}$";
        private static string REGEX_EMAIL = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
        private static string REGEX_MOBILENUMBER = "^[1-9]{1,3}[ ][1-9][0-9]{9}$";
        private static string REGEX_PASSWORD = "^(?=.*[0-9])(?=.*[A-Z])(?=[^!@#$%&*+-.]*[!@#$%&*+-.][^!@#$%&*+-.]*$)[\\S]{8,}$";
        private static string REGEX_EMAIL2 = "^[a-zA-Z0-9]+([.+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";
        public bool ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, REGEX_FIRSTNAME))
            {
                return true;
            }
            else
            {
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_FIRST_NAME, "Invalid first name.");
            }
        }
        public bool ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, REGEX_LASTNAME))
            {
                return true;
            }
            else
            {
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_LAST_NAME, "Invalid last name.");
            }            
        }
        public bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, REGEX_EMAIL))
            {
                return true;
            }
            else
            {
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_EMAIL, "Invalid email id.");
            }
        }
        public bool ValidateMobileNumber(string mobNumber)
        {
            if (Regex.IsMatch(mobNumber, REGEX_MOBILENUMBER))
            {
                return true;
            }
            else
            {
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid mobile number.");
            }
        }
        public bool ValidatePassword(string password)
        {            
            if (Regex.IsMatch(password, REGEX_PASSWORD))
            {
                return true;
            }
            else
            {
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_PASSWORD, "Invalid password.");
            }
        }
        public bool ValidateEmail2(string email)
        {
            if(Regex.IsMatch(email, REGEX_EMAIL2))
            {
                return true;
            }
            else
            {
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_EMAIL, "Invalid email id.");
            }
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
        public List<string> GetList()
        {
            return sampleMails;
        }
    }
}
