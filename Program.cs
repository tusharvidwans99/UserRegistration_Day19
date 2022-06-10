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

            ////Validating First Name
            //Console.Write("Enter the First name: ");
            //string Firstname = Console.ReadLine();
            //userRegistration.validateFirstName(Firstname);

            ////validating Last Name
            //Console.Write("Enter the last name: ");
            //string Lastname = Console.ReadLine();
            //userRegistration.validateLastname(Lastname);

            ////Validating Email
            //Console.Write("Enter the Email: ");
            //string Email = Console.ReadLine();
            //userRegistration.validateEmail(Email);

            //Validating Phone Number
            Console.Write("Enter the phone number: ");
            string Number = Console.ReadLine();
            userRegistration.validatePhoneNumber(Number);
            
        }
    }
}