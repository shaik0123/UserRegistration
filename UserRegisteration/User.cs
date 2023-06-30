using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegisteration
{
    public class User
    {
        public string Name;
        public User() 
        {

        }
        public User(string name) 
        {
            this.Name = name;
        }
        public string FirstName(string FirstName)
        {
            string regex = "^[A-Z][a-z]{3,20}$";
            if(Regex.IsMatch(FirstName, regex)) 
            {
                Console.WriteLine("valid first name");
            }
            else
            {
                Console.WriteLine("invalid ");
            }
            return FirstName;

        }
        public string LastName(string LastName)
        {
            string regex = "^[A-Z][a-z]{3,20}$";
            if (Regex.IsMatch(LastName, regex))
            {
                Console.WriteLine("valid last name");
            }
            else
            {
                Console.WriteLine("invalid ");
            }
            return LastName;

        }
         public string  Email(string Email)
         {
             string regex = "^[a-zA-Z0-9]+([.][a-zA-Z0-9]+)*[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-z]{2})?$";
             if (Regex.IsMatch(Email, regex))
             {
                 Console.WriteLine("valid email");
             }
             else
             {
                 Console.WriteLine("invalid ");
             }
             return Email;

         }
        public string MobileNumber(string MobileNumber)
        {
            string regex = "^[1-9]{2}[ ][6-9][0-9]{9}$";
            if (Regex.IsMatch(MobileNumber, regex))
            {
                Console.WriteLine("valid mobile number");
            }
            else
            {
                Console.WriteLine("invalid ");
            }
            return MobileNumber;

        }
        public string  PasswordRule1(string Password)
        {
            string regex = "^[A-Za-z].{8,}$";
            if (Regex.IsMatch(Password, regex))
            {
                Console.WriteLine("valid password");
            }
            else
            {
                Console.WriteLine("invalid ");
            }
            return Password;

        }
        public string PasswordRule2(string Password)
        {
            string regex = "^[A-Z][a-z0-9]{7,}$";
            if (Regex.IsMatch(Password, regex))
            {
                Console.WriteLine("valid password");
            }
            else
            {
                Console.WriteLine("invalid ");
            }
            return Password;

        }
        public string PasswordRule3(string Password)
        {
            string regex = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z]).{8,}$";
            if (Regex.IsMatch(Password, regex))
            {
                Console.WriteLine("valid password");
            }
            else
            {
                Console.WriteLine("invalid ");
            }
            return Password;

        }
        public string PasswordRule4(string Password)
        {
            string regex = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=.*[a-z]).{8,}$";
            if (Regex.IsMatch(Password, regex))
            {
                Console.WriteLine("valid password");
            }
            else
            {
                Console.WriteLine("invalid ");
            }
            return Password;

        }



    }
}
