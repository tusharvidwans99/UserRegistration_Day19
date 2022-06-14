using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration_Day19
{
    public class ExceptionHandlerOfUser
    {
        public void username()
        {
            throw (new UserNameException("Wrong Pattern for First Name: \nFirst letter should be capital and it should have minimum 3 characters"));
        }
    }
}
