using System;

namespace Liberator.DynamicPageEngine.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PageAttribute : Attribute
    {
        /// <summary>
        /// The name of the page
        /// </summary>
        public string Name { get; set; }
    }
}
