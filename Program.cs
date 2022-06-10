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
            Console.Write("Enter the First name: ");
            string Firstname = Console.ReadLine();

            if (userRegistration.validateFirstName(Firstname))
                Console.WriteLine("Pattern Match");
            else
                Console.WriteLine("Pattern not Match");
        }
    }
}