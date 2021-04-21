using OpenQA.Selenium;
using Selenium.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.PageModels
{
    public class FormMenu : BasePage
    {

        public FormMenu(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement PracticeForm
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='Practice Form']"));
            }
        }
    }
}
