using OpenQA.Selenium;

namespace Exercise_SeleniumWebDriverPOM.Pages
{
    public class CheckoutPage: BasePage
    {
        protected readonly By firstNameInput = By.Id("first-name");
        protected readonly By lastNameInput = By.Id("last-name");
        protected readonly By postalCodeInput = By.Id("postal-code");
        protected readonly By continueButton = By.CssSelector("#continue");
        protected readonly By finishButton = By.Id("finish");
        protected readonly By completeHeader= By.CssSelector(".complete-header");
        public CheckoutPage(IWebDriver driver) : base(driver) 
        {
            
        }

        public void FillFirstName(string firstName)
        {
            Type(firstNameInput, firstName);
        }
        public void FillLastName(string lastName)
        {
            Type(lastNameInput, lastName);
        }
        public void FillPostalCode(string postalCode)
        {
            Type(postalCodeInput, postalCode);
        }

        public void ClickContinueButton()
        {
            Click(continueButton);
        }
        public void ClickFinishButton()
        {
            Click(finishButton);
        }
        public bool IsPageLoaded()
        {
            return driver.Url.Contains("checkout-step-one.html") ||  driver.Url.Contains("checkout-step-two.html");
        }
        public bool IsCheckOutComplete()
        {
            return GetText(completeHeader) == "Thank you for your order!";
        }
    }
}
