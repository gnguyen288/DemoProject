using OpenQA.Selenium;
using Selenium.Selenium.Extensions;

namespace Selenium.Models.PageModels
{
    public class BasePage
    {
        public IWebDriver driver;
        protected SeleniumExtGeneral _seleniumExtGeneral;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            _seleniumExtGeneral = new SeleniumExtGeneral(driver);
        }
    }
}
