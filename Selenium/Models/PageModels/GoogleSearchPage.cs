using OpenQA.Selenium;

namespace Selenium.Models.PageModels
{
    public class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement SearchBox
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("div>div.a4bIc>input"));
            }
        }

        public IWebElement SearchBoxResults
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("#result-stats"));
            }
        }
    }
}
