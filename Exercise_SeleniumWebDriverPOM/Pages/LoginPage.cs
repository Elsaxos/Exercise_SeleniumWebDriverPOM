using OpenQA.Selenium;

namespace Exercise_SeleniumWebDriverPOM.Pages
{
    public class LoginPage : BasePage
    {
        private readonly By userNameField = By.XPath("//input[contains(@id,'user-name')]");
        private readonly By passwordField = By.Id("password"); 
        private readonly By loginButton = By.Id("login-button");
        private readonly By errorMesage = By.CssSelector("#login_button_container > div > form > div.error-message-container.error > h3");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void FillUserName(string userName)
        {
            Type(userNameField, userName);
        }

        public void FillPassword(string password) 
        {
            Type(passwordField, password);
        }

        public void ClickLoginButton()
        {
            Click(loginButton); 
        }

        public string GetErrorMessage() 
        {
            return GetText(errorMesage);
        }

        public void LoginUser(string userName, string password)
        {
            FillUserName(userName);
            FillPassword(password);
            ClickLoginButton(); 
        }
    }
}


