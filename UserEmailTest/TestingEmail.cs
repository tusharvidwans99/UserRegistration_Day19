using UserRegistration_Day19;

namespace UserEmailTest
{
    [TestClass]
    public class TestingEmail
    {
        [TestMethod]
        [DataRow ("abc@yahoo.com") ]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void TestValidEmails(string Email)
        {
            //Arrange
            string expected_output = "Email is Valid";
            string actual_output;
            UserRegistration userRegistration = new UserRegistration();

            //Act
            actual_output = userRegistration.validateEmail(Email);

            //Assert
            Assert.AreEqual(expected_output, actual_output);
        }


        [TestMethod]
        [DataRow("abc")]
        [DataRow("abc@gmail.com.aa.au")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@abc @gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc123@.com.com")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc@.com.my")]
        public void TestInValidEmails(string Email)
        {
            //Arrange
            string expected_output = "Email is Invalid";
            string actual_output;
            UserRegistration userRegistration = new UserRegistration();

            //Act
            actual_output = userRegistration.validateEmail(Email);

            //Assert
            Assert.AreEqual(expected_output, actual_output);
        }
    }
}