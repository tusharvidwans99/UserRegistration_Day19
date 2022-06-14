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


       
        public void validateFirstName(string fName)
        {
            try
            {
                if (Regex.IsMatch(fName, regex_for_fname))
                    Console.WriteLine("First Name is valid");
                else
                    exceptionHandlerOfUser.username();
            }catch(UserNameException e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void validateLastname(string lName)
        {
            if (Regex.IsMatch(lName, regex_for_lname))
                Console.WriteLine("Last Name is valid");
            else
                Console.WriteLine("Last name is invalid");
        }

        public string validateEmail(string Email)
        {
            if (Regex.IsMatch(Email, regex_for_email))
            {
                Console.WriteLine("Email is Valid");
                return "Email is Valid";
            }
            else
            {
                Console.WriteLine("Email is Invalid");
                return "Email is Invalid";
            }
        }

        public void validatePhoneNumber(string PhoneNumber)
        {
            if (Regex.IsMatch(PhoneNumber, regex_for_phone))
                Console.WriteLine("Phone Number is Valid");
            else
                Console.WriteLine("Phone Number is invalid");
        }


        public void validatePassword(string password)
        {
            if (Regex.IsMatch(password, regex_for_Password))
                Console.WriteLine("Password is Valid");
            else
                Console.WriteLine("Password is invalid");
        }
    }
}
