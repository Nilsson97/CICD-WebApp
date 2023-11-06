using CICD_WebApp.Models;

namespace CICDTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            FirstnameDTO FirstnameDTO = new FirstnameDTO();
            FirstnameDTO.Firstname = "TestFN";
            Assert.IsNotNull(FirstnameDTO.Firstname);
        }

        [TestMethod]
        public void TestLastName()
        {
            LastnameDTO LastnameDTO = new LastnameDTO();
            LastnameDTO.Lastname = "TestLN";
            Assert.IsNotNull(LastnameDTO.Lastname);
        }
    }
}