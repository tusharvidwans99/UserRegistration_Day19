using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration_Day19
{
    public class FirstNameException : Exception
    {
        public FirstNameException(string message) : base(message)
        {

        }
    }

    public class LastNameException: Exception
    {
        public LastNameException(string message) : base(message)
        {

        }
    }

    public class EmailException : Exception
    {
        public EmailException(string message) : base(message)
        {

        }
    }

    public class PhoneNumberException : Exception
    {
        public PhoneNumberException(string message) : base(message)
        {

        }
    }
}
