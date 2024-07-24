using Exercise_SeleniumWebDriverPOM.Pages;

namespace Exercise_SeleniumWebDriverPOM.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void TestLoginWithInvalidCredentials()
        {
            Login("standard_user", "secret_sauce");
            Assert.That(inventoryPage.IsInventoryPageLoaded(), Is.True,
                "The invertory page is not loaded after succesfull login");
        }

        [Test]
        public void TestLoginWithValidCredentials()
        {
            Login("invalid_User", "secret_sauce");
            
            string error = loginPage.GetErrorMessage();
            Assert.That(error.Contains("Epic sadface: Username and password do not match any user in this service"));
           
        }

        [Test]
        public void TestLoginWithLockedOutUser()
        {
            Login("locked_out_user", "secret_sauce");
            
            string error = loginPage.GetErrorMessage();
            Assert.That(error.Contains("Epic sadface: Sorry, this user has been locked out."));

        }
    }
}
