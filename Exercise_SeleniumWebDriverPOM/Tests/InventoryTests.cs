using Exercise_SeleniumWebDriverPOM.Pages;

namespace Exercise_SeleniumWebDriverPOM.Tests
{
    public class InventoryTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Login("standard_user", "secret_sauce");
        }

        [Test]
        public void TestInventoryDisplay()
        {
            Assert.That(inventoryPage.IsInventoryPageDisplayed(), Is.True, "Inventory page has no items displayed");
        }
        [Test]
        public void TestAddToCartByIndex()
        {
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.ClickCartLink();
           
            Assert.That(cartPage.IsCartItemDisplayed(), Is.True, "cart item was not added in the cart");
        }
        [Test]
        public void TestAddToCartByName()
        {
            inventoryPage.AddToCartByName("Sauce Labs Backpack");
            inventoryPage.ClickCartLink();

            Assert.That(cartPage.IsCartItemDisplayed(), Is.True, "cart item  added in the cart");
        }
        [Test]
        public void TestPageTitle ()
        {
            Assert.That(inventoryPage.IsInventoryPageLoaded(), Is.True, "Inventory page is not loaded corectly");
        }
    }
}
