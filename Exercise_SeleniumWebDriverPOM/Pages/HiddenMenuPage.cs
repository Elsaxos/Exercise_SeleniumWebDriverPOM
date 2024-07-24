using OpenQA.Selenium;

namespace Exercise_SeleniumWebDriverPOM.Pages
{
    public class HiddenMenuPage : BasePage
    {
        protected readonly By hamburgerMenuButton = By.Id("react-burger-menu-btn");
        protected readonly By logoutButton = By.Id("logout_sidebar_link");

        public HiddenMenuPage(IWebDriver driver) : base(driver)
        {
           
        }

        public void ClickHamburgerMenuButton()
        {
            Click(hamburgerMenuButton);
        }
        public void ClickLogoutButton()
        {
            Click(logoutButton);
        }
        public bool IsMenuOpen()
        {
            return FindElement(logoutButton).Displayed;
        }
    }
}
