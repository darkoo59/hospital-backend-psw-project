﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests.E2E.BloodRequest.Pages
{
    public class BloodRequestAcceptedPage
    {
        private readonly IWebDriver Driver;
        public const string URI = "http://localhost:4200/manager/blood-req/approved";

        public string Title => Driver.Title;

        private IWebElement Grid => Driver.FindElement(By.ClassName("grid"));
        private ICollection<IWebElement> ApproveBtn => Driver.FindElements(By.ClassName("approveBtn"));


        public BloodRequestAcceptedPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void EnsurePageIsDisplayed()
        {
            var wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 20));
            wait.Until(condition =>
            {
                try
                {
                    return GridDisplayed();
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
        }

        public bool GridDisplayed()
        {
            return Grid.Displayed;
        }

        public int CountGridElements()
        {
            return Driver.FindElements(By.ClassName("approveBtn")).Count;
        }

        public void Navigate() => Driver.Navigate().GoToUrl(URI);
    }
}
