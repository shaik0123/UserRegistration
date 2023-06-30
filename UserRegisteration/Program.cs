using System;

namespace UserRegisteration
{
    public class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello World!");
             Console.WriteLine("enter first name");
             string FirstName = Console.ReadLine();
             User user = new User();
             user.FirstName(FirstName);
             Console.WriteLine("enter last name");
             string LastName = Console.ReadLine();
             user.LastName(LastName);
             Console.WriteLine("enter email");
              string Email = Console.ReadLine();
              user.Email(Email);
             Console.WriteLine("enter mobile number");
             string MobileNumber = Console.ReadLine();
             user.MobileNumber(MobileNumber);
             Console.WriteLine("enter password ");
             string Password1 = Console.ReadLine();
             user.PasswordRule1(Password1);
            Console.WriteLine("enter password ");
            string Password2 = Console.ReadLine();
            user.PasswordRule2(Password2);
            Console.WriteLine("enter password ");
            string Password3 = Console.ReadLine();
            user.PasswordRule3(Password3);
            Console.WriteLine("enter password ");
            string Password4 = Console.ReadLine();
            user.PasswordRule4(Password4);

        }
    }
}
