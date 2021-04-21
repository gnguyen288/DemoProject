using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
    public class ProgressBar:BasePage
    {
        public ProgressBar(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement startbutton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("startStopButton"));
            }
        }

        public IWebElement resetbutton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("resetButton"));
            }
        }

        public IWebElement bar
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("progressBar"));
            }
        }

        public IWebElement progress
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector(".progress-bar"));
            }
        }

       

    }
}
