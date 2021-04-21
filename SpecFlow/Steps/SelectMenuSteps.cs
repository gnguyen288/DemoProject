using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Models.PageModels;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow.Features
{
    [Binding]
    public class SelectMenuSteps: BasePage
    {
        private readonly Homepage homepage;
        private readonly WidgetsMenu widgets;
        private readonly SelectMenu selectmenu;
        

        public SelectMenuSteps(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            homepage = new Homepage(driver);
            widgets = new WidgetsMenu(driver);
            selectmenu = new SelectMenu(driver);
        }
            [Given(@"I click on Select Menu item")]
        public void GivenIClickOnSelectMenuItem()
        {
            widgets.SelectMenu.Click();
        }
        
        [Given(@"I choose '(.*)' for Select Value")]
        public void GivenIChooseForSelectValue(string p0)
        {
            selectmenu.SelectValue.Click();
            selectmenu.TypeIn(p0);
        }
        
        [Given(@"I choose '(.*)' for Select One")]
        public void GivenIChooseForSelectOne(string p0)
        {
            selectmenu.SelectOne.Click();
            selectmenu.TypeIn(p0);
        }
        
        [Given(@"I choose '(.*)' for Old Style Select Menu")]
        public void GivenIChooseForOldStyleSelectMenu(string p0)
        {
            selectmenu.ChooseValue(p0);
        }

        [Then(@"I should see '(.*)' for Select Value,")]
        public void ThenIShouldSeeForSelectValue(string p0)
        {
            Assert.IsTrue(selectmenu.SelectValue.Text == p0);
        }

        [Then(@"I should see '(.*)' for Select One")]
        public void ThenIShouldSeeForSelectOne(string p1)
        {
            Assert.IsTrue(selectmenu.SelectOne.Text == p1);
        }

        [Then(@"I should see '(.*)' for Old Style Select Menu")]
        public void ThenIShouldSeeForOldStyleSelectMenu(string p2)
        {
            Assert.IsTrue(selectmenu.ChosenValue() == p2);
        }

    }
}
