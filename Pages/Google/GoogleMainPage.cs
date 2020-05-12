﻿using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages.Google
{
    public sealed class GoogleMainPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='q']")]
        public IWebElement SearchString;
        [FindsBy(How = How.XPath, Using = "(//input[@value='Google Search'])[2]")]
        public IWebElement SearchButton;

        public GoogleMainPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(_webDriver, this);

            _elements = new Dictionary<string, IWebElement>()
            {
                { "Search string", SearchString },
                { "Search button", SearchButton }
            };
        }
    }
}
