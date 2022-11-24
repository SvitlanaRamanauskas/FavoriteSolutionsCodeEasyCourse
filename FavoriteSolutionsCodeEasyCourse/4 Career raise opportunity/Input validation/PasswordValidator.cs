using System;

namespace InputValidation
{
    class PasswordValidator
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            while (!PasswordIsValid(password))
            {
                if (password.Length < 8)
                    Console.WriteLine("Password length should be 8 symbols or more.");
                if (!ContainsUpperLetter(password))
                    Console.WriteLine("Password should contain at least one uppercase letter.");
                if (!ContainsLowerLetter(password))
                    Console.WriteLine("Password should contain at least one lowercase letter.");
                if (!ContainsDigit(password))
                    Console.WriteLine("Password should contain at least one digit.");
                password = Console.ReadLine();
            }
            Console.WriteLine("Your password is properly set!");
        }
        static bool ContainsUpperLetter(string password)
        {
            foreach (char c in password)
            {
                if ((Char.IsLetter(c)) && (Char.IsUpper(c)))
                    return true;
            }
            return false;
        }

        static bool ContainsLowerLetter(string password)
        {
            foreach (char c in password)
            {
                if ((Char.IsLetter(c)) && (Char.IsLower(c)))
                    return true;
            }
            return false;
        }
        static bool ContainsDigit(string password)
        {
            foreach (char c in password)
            {
                if (Char.IsDigit(c))
                    return true;
            }
            return false;
        }
        static bool PasswordIsValid(string password)
        {
            if ((password.Length > 8) && ContainsUpperLetter(password) && ContainsLowerLetter(password) && ContainsDigit(password))
            {
                return true;
            }
            return false;
        }

    }
}
/*TASK   Write a program that validates a password. It should read the password from the new line and check that it is at least 8 characters long and contains at least one uppercase letter, one lowercase letter, and one digit. If the input doesn't meet these requirements, your program should output an error-specific message as follows: 
"Password length should be 8 symbols or more."
"Password should contain at least one uppercase letter."
"Password should contain at least one lowercase letter."
"Password should contain at least one digit."
If the user violates several rules at once, write all error-specific messages that apply, each on a new line, in the same order as listed here. The program should continue to ask for and read the password until the user inputs a valid value. Once a valid value is given, the program should output: "Your password is properly set!" For example:
>secret
Password length should be 8 symbols or more.
Password should contain at least one uppercase letter.
Password should contain at least one digit.

>Secret
Password length should be 8 symbols or more.
Password should contain at least one digit.

>Secret8
Password length should be 8 symbols or more.

>Secret88
Your password is properly set!*/