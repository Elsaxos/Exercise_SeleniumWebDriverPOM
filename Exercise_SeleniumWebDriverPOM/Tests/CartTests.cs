namespace Exercise_SeleniumWebDriverPOM.Tests
{
    public class CartTests: BaseTest
    {
        [SetUp]
        public void Setup ()
        {
            Login("standard_user", "secret_sauce");
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.ClickCartLink();
        }
        [Test]
        public void TestCartItemDisplayed()
        {
            Assert.True(cartPage.IsCartItemDisplayed(), "There is no products in the cart");
        }
        [Test]
        public void TestClickCheckout() 
        {
            cartPage.ClickCheckOutButton();
            Assert.True(checkoutPage.IsPageLoaded(), "Not navigated to check out page");
        }
    }
}
