using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Models.PageModels;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlow.Features
{
    [Binding]
    public class ProgressBarSteps:BasePage 
    {
        private readonly Homepage homepage;
        private readonly WidgetsMenu widgets;
        private readonly ProgressBar progressbar;
        private readonly bool _IsPageReady = false;

        public ProgressBarSteps(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            homepage = new Homepage(driver);
            widgets = new WidgetsMenu(driver);
            progressbar = new ProgressBar(driver);
        }

        [Given(@"I click on Progress Bar")]
        public void GivenIClickOnProgressBar()
        {
            widgets.ProgressBar.Click();
        }
        
        [When(@"I click on Start button")]
        public void WhenIClickOnStartButton()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 3);
           progressbar.startbutton.Click();
        }
        
        
        [Then(@"The progress bar should be active")]
        public void ThenTheProgressBarShouldBeActive()
        {
            
            _seleniumExtGeneral.Wait(_IsPageReady, 3);
            string value = progressbar.progress.GetAttribute("aria-valuenow");
            Assert.IsTrue(value != "100" && value != "0");

        }

        [When(@"I click on Reset button")]
        public void WhenIClickOnResetButton()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 3);
            string value = progressbar.progress.GetAttribute("aria-valuenow");
            if (value!= "100")
            {
                Thread.Sleep(7000);
                progressbar.resetbutton.Click();
            }
            else
            {
                progressbar.resetbutton.Click();
            }
           
        }

        [Then(@"The progress bar should be inactive")]
        public void ThenTheProgressBarShouldBeInactive()
        {
            string value=progressbar.progress.GetAttribute("aria-valuenow");
            Assert.IsTrue(value == "0");
        }
    }
}
