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

        public string regex_for_name = "^[A-Z]{1}[a-z]{2,10}$";

        public bool validateFirstName(string fName)
        {

            return Regex.IsMatch(fName, regex_for_name);

        }
    }
}
