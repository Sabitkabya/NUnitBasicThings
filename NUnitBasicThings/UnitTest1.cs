using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Tests
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]                             
        public void Setup()
        {
            driver = new ChromeDriver(@"D:\Drivers\chromedriver_win32 _86");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
        }
        [Test]
        public void CheckBoxTest()
        {
            driver.Url = "https://www.fdmdigital.co.uk/formidable-forms-radio-buttons-checkbox-styling/";
            IReadOnlyCollection<IWebElement>checkBoxes = driver.FindElements(By.Id("frm_checkbox_944-933"));
            foreach (IWebElement checkBox in checkBoxes)
            {
                if (!checkBox.Enabled)
                {
                    checkBox.Click();
                    Thread.Sleep(5000);
                }

                else
                {
                    checkBox.Click();

                }
                
            }
        }
    }
}