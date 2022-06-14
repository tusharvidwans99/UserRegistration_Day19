using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration_Day19
{
    public class UserNameException : Exception
    {
        public UserNameException(string message) : base(message)
        {

        }
    }
}
