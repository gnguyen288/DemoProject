using System;
using TechTalk.SpecFlow;
using Selenium.Models.PageModels;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SpecFlow.Features
{
    [Binding]
    public class DatePickerSteps:BasePage
    {
        private readonly Homepage homepage;
        private readonly WidgetsMenu widgets;
        private readonly DatePicker datepicker;
        private readonly bool _IsPageReady = false;

        public DatePickerSteps(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            homepage = new Homepage(driver);
            widgets = new WidgetsMenu(driver);
            datepicker = new DatePicker(driver);
        }


        [Given(@"I click on widgets menu")]
        public void GivenIClickOnWidgetsMenu()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 8);
            // ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", homepage.Widgets);
            _seleniumExtGeneral.ScrollToElement(homepage.Widgets);
            homepage.Widgets.Click();
            homepage.Widgets.Click();
        }
        
        [Given(@"I click on Date Picker item")]
        public void GivenIClickOnDatePickerItem()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", widgets.DatePicker);
            widgets.DatePicker.Click();
            
        }
        
        [Given(@"I click on Select Date field")]
        public void GivenIClickOnSelectDateField()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            datepicker.SDate.Click();
        }
        

        [Given(@"I pick '(.*)' as Month, '(.*)' as Date and '(.*)' as Year")]
        public void GivenIPickAsMonthAsDateAndAsYear(string p0, string p1, string p2)
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            datepicker.SelectMonthYearDate(p0, p2, p1);
        }


        [Given(@"I click Date And Time field")]
        public void GivenIClickDateAndTimeField()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            datepicker.DateTime.Click();
        }


        [Given(@"I pick '(.*)' as Month, '(.*)' as Date, '(.*)' as Year and '(.*)' as Time")]
        public void GivenIPickAsMonthAsDateAsYearAndAsTime(string p0, string p1, string p2, string p3)
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            datepicker.SelectDateTime(p0, p2, p1, p3);
        }


        [Then(@"I should see '(.*)' in Select Date box and")]
        public void ThenIShouldSeeInSelectDateBoxAnd(string p0)
        {
            Assert.AreEqual(datepicker.SDate.GetAttribute("value"), p0);
        }

        [Then(@"I should see '(.*)' from Date and Time Box")]
        public void ThenIShouldSeeFromDateAndTimeBox(string p1)
        {
            Assert.AreEqual(datepicker.DateTime.GetAttribute("value"), p1);
        }

    }
}
