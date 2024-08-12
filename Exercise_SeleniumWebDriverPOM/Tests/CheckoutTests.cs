namespace Exercise_SeleniumWebDriverPOM.Tests
{
    public class CheckoutTests: BaseTest
    {
        [SetUp]
       public void Setup()
        {
            Login("standard_user", "secret_sauce");
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.ClickCartLink();
            cartPage.ClickCheckOutButton();
        }
        [Test]
        public void TestCheckoutPageLoaded()
        {
            Assert.True(checkoutPage.IsPageLoaded(), "Checkout page is not load");
        }
        [Test]
        public void TestContinueToNextStep()
        {
            checkoutPage.FillFirstName("Alabala");
            checkoutPage.FillLastName("Alabalov");
            checkoutPage.FillPostalCode("1000");
            checkoutPage.ClickContinueButton();

            Assert.That(driver.Url.Contains("checkout-step-two.html"), Is.True, "Not navigated to the checkout page");
        }
        [Test]
        public void TestCompleteOrder()
        {
            checkoutPage.FillFirstName("Alabala");
            checkoutPage.FillLastName("Alabalov");
            checkoutPage.FillPostalCode("1000");
            checkoutPage.ClickContinueButton();
            checkoutPage.ClickFinishButton();

            Assert.True(checkoutPage.IsCheckOutComplete(), " Checkout page is not completed");

        }
    }
}
