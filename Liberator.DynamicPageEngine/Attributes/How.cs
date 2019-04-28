namespace Liberator.DynamicPageEngine.Attributes
{
    /// <summary>
    /// How the Selenium driver is to find the element
    /// </summary>
    public enum How
    {
        /// <summary>
        /// Finds by <see cref="OpenQA.Selenium.By.Id" />
        /// </summary>
        Id,

        /// <summary>
        /// Finds by <see cref="OpenQA.Selenium.By.Name" />
        /// </summary>
        Name,

        /// <summary>
        /// Finds by <see cref="OpenQA.Selenium.By.TagName" />
        /// </summary>
        TagName,

        /// <summary>
        /// Finds by <see cref="OpenQA.Selenium.By.ClassName" />
        /// </summary>
        ClassName,

        /// <summary>
        /// Finds by <see cref="OpenQA.Selenium.By.CssSelector" />
        /// </summary>
        CssSelector,

        /// <summary>
        /// Finds by <see cref="OpenQA.Selenium.By.LinkText" />
        /// </summary>
        LinkText,

        /// <summary>
        /// Finds by <see cref="OpenQA.Selenium.By.PartialLinkText" />
        /// </summary>
        PartialLinkText,

        /// <summary>
        /// Finds by <see cref="OpenQA.Selenium.By.XPath" />
        /// </summary>
        XPath,

        /// <summary>
        /// Finds by a custom implementation.
        /// </summary>
        Custom
    }
}
