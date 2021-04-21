using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
    public class SelectMenu:BasePage
    {
        public SelectMenu(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement SelectValue
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("withOptGroup"));
            }
        }

        public IWebElement SelectOne
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("selectOne"));
            }
        }

        public IWebElement OldStyle
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("oldSelectMenu"));
            }
        }

        public void TypeIn(string value)
        {
            Actions type = new Actions(driver);
            type.SendKeys(value + "\n").Perform();
        }

        public void ChooseValue(string value)
        {
            SelectElement monthselect = new SelectElement(OldStyle);
            monthselect.SelectByText(value);
        }

        public string ChosenValue()
        {
            SelectElement monthselect = new SelectElement(OldStyle);
            string text = monthselect.SelectedOption.Text;
            return text;
        }
    }
}
