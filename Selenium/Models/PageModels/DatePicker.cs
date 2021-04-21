using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
    public class DatePicker:BasePage
    {
        public DatePicker(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement SDate
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("datePickerMonthYearInput"));
            }
        }

        public IWebElement DMonth
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector("select.react-datepicker__month-select"));
            }
        }

        public IWebElement DYear
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector(".react-datepicker__year-select"));
            }
        }

        public void SelectMonthYearDate(string month, string year, string date)
        {
            SelectElement monthselect = new SelectElement(DMonth);
            monthselect.SelectByText(month);
            SelectElement yearselect = new SelectElement(DYear);
            yearselect.SelectByText(year);
            _seleniumExtGeneral.FindElementBy(By.XPath("//*[not(contains(@class,'react-datepicker__day--outside-month')) and text()='"
                        + date + "']")).Click();
        }

        //-------------------------------DateTime Box---------------------------

        public IWebElement DateTime
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.Id("dateAndTimePickerInput"));
            }
        }

        public IWebElement TMonth
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector(".react-datepicker__month-read-view--selected-month"));
            }
        }

        public IWebElement TYear
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.CssSelector(".react-datepicker__year-read-view--selected-year"));
            }
        }

        public void SelectDateTime(string Month, string Year, string Date, string Time)
        {
            DateTime.Click();
            TMonth.Click();
            _seleniumExtGeneral.FindElementBy(By.XPath("//*[text()='"
                    + Month + "']")).Click();
            TYear.Click();
            _seleniumExtGeneral.FindElementBy(By.XPath("//*[ text()='"
                        + Year + "']")).Click();
            _seleniumExtGeneral.FindElementBy(By.XPath("//*[not(contains(@class,'react-datepicker__day--outside-month')) and text()='"
                        + Date + "']")).Click();
            IWebElement time = _seleniumExtGeneral.FindElementBy(By.XPath("//*[@class='react-datepicker__time-list-item ' and text()='"
                        + Time + "']"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", time);
            time.Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", DateTime);

        }


    }
}
