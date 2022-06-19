using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Day19
{
    public class UserRegistration
    {
        ExceptionHandlerOfUser exceptionHandlerOfUser = new ExceptionHandlerOfUser();

        public string regex_for_fname = "^[A-Z]{1}[a-z]{2,10}$";
        public string regex_for_lname = "^[A-Z]{1}[a-z]{2,10}$";
        public string regex_for_email = "^(?!.*@.*@)[a-z-+_0-9]+.[a-z0-9]+@[a-z0-9]+.[a-z]*.[a-z]{2,}$";
        public string regex_for_phone = "^[+]{1}[9]{1}[1]{1}[' ']{1}[0-9]{10}$";
        public string regex_for_Password = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!#@%^&*(){}])[a-zA-Z0-9+-_!@#$%^&*(){}'.,]{8,}$";


        public bool FirstAndLastName(string input) => Regex.IsMatch(input, regex_for_fname) ? true : false;
        public bool Email(string input) => Regex.IsMatch(input, regex_for_email) ? true : false;
        public bool MobileNo(string input) => Regex.IsMatch(input, regex_for_phone) ? true : false;
        public bool Password(string input) => Regex.IsMatch(input, regex_for_Password) ? true : false;

        public void validateFirstName()
        {
            try
            {
                Console.Write("Enter the First name: ");
                string Firstname = Console.ReadLine();

                bool ValidationforFirstName = FirstAndLastName(Firstname);

                if (ValidationforFirstName)
                    Console.WriteLine("First Name is valid");
                else
                {
                    exceptionHandlerOfUser.username();
                    
                }

                
            }
            catch(FirstNameException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("-------------------------");
                Console.WriteLine("-------------------------");
            }


        }

        public void validateLastname()
        {
            try
            {
                Console.Write("Enter the last name: ");
                string Lastname = Console.ReadLine();

                bool ValidationForLastName = FirstAndLastName(Lastname);

                if (ValidationForLastName)
                    Console.WriteLine("Last Name is valid");
                else
                    exceptionHandlerOfUser.lastname();
            }catch(LastNameException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("-------------------------");
                Console.WriteLine("-------------------------");
            }

        }

        public string validateEmail()
        {
            try
            {
                Console.Write("Enter the Email: ");
                string email = Console.ReadLine();

                bool ValidationForEmail = Email(email);

                if(ValidationForEmail)
                {
                    Console.WriteLine("Email is Valid");
                    return "Email is Valid";
                }
                else
                {
                    Console.WriteLine("Email is Invalid");
                    exceptionHandlerOfUser.Email();
                    return "Email is Invalid";

                }

            }
            catch(EmailException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("-------------------------");
                Console.WriteLine("-------------------------");
                return "Email is Invalid";

            }
        }

        public void validatePhoneNumber()
        {
            try
            {
                Console.Write("Enter the phone number: ");
                string Number = Console.ReadLine();

                bool ValidationForPhoneNumber = MobileNo(Number);

                if (ValidationForPhoneNumber)
                    Console.WriteLine("Phone Number is Valid");
                else
                    exceptionHandlerOfUser.PhoneNumber();
            }
            catch (PhoneNumberException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("-------------------------");
                Console.WriteLine("-------------------------");
            }
        
        
        }


        public void validatePassword()
        {
            try
            {
                Console.Write("Enter the Password: ");
                string password = Console.ReadLine();
                bool ValidationForPassword = Password(password);

                if(ValidationForPassword)
                    Console.WriteLine("Password is Valid");
                else
                {
                    Console.WriteLine("Password is invalid");
                    exceptionHandlerOfUser.Password();
                }
            }catch(PasswordException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
