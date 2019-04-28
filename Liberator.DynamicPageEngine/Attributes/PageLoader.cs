﻿using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Liberator.DynamicPageEngine.Attributes
{
    /// <summary>
    /// Static class used to load page objects for Selenium
    /// </summary>
    public static class PageLoader
    {
        public static void Initialise(IPageObject pageObject, out IEnumerable<IWebElement> webElements)
        {
            webElements = null;
        }


        internal static By GetLocator(PageObjectAttribute pageObjectAttribute)
        {
            var how = pageObjectAttribute.How;
            var usingValue = pageObjectAttribute.Using;

            switch (how)
            {
                case How.Id:
                    return By.Id(usingValue);
                case How.Name:
                    return By.Name(usingValue);
                case How.TagName:
                    return By.TagName(usingValue);
                case How.ClassName:
                    return By.ClassName(usingValue);
                case How.CssSelector:
                    return By.CssSelector(usingValue);
                case How.LinkText:
                    return By.LinkText(usingValue);
                case How.PartialLinkText:
                    return By.PartialLinkText(usingValue);
                case How.XPath:
                    return By.XPath(usingValue);
                case How.Custom:
                    throw new ArgumentException("Custom finders are currently active in this version.");
            }
            throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Did not know how to construct How from how {0}, using {1}", how, usingValue));
        }
    }
}