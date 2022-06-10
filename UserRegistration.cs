﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Day19
{
    public class UserRegistration
    {

        public string regex_for_fname = "^[A-Z]{1}[a-z]{2,10}$";
        public string regex_for_lname = "^[A-Z]{1}[a-z]{2,10}$";

        public void validateFirstName(string fName)
        {
            if (Regex.IsMatch(fName, regex_for_fname))
                Console.WriteLine("First Name is valid");
            else
                Console.WriteLine("First Name is invalid");          

        }

        public void validateLastname(string lName)
        {
            if (Regex.IsMatch(lName, regex_for_lname))
                Console.WriteLine("Last Name is valid");
            else
                Console.WriteLine("Last name is invalid");
        }
    }
}
