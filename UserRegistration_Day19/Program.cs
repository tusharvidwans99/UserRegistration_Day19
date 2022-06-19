namespace UserRegistration_Day19
{
    class Program
    {

        /// <summary>
        /// In this program we are validating user input with the regular expression.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Welcome to the User Registraion problem");

            //Validating First Name
            userRegistration.validateFirstName();

            //validating Last Name
            userRegistration.validateLastname();

            //Validating Email
            userRegistration.validateEmail();

            //Validating Phone Number
            userRegistration.validatePhoneNumber();

            //Validating Password
            userRegistration.validatePassword();


        }
    }
}