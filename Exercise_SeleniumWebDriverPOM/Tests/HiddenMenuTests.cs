﻿namespace Exercise_SeleniumWebDriverPOM.Tests
{
    public class HiddenMenuTests: BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Login("standard_user", "secret_sauce");
        }
        [Test]
        public void TestOpenMenu()
        {
          hiddenMenuPage.ClickHamburgerMenuButton();
            Assert.True(hiddenMenuPage.IsMenuOpen(), "Hidden menu is not open");
        }
        [Test]
        public void TestLogout()
        {
            hiddenMenuPage.ClickHamburgerMenuButton();
            hiddenMenuPage.ClickLogoutButton();
            Assert.True(driver.Url.Equals("https://www.saucedemo.com/"), "User is not logged out");
        }
    }
}
