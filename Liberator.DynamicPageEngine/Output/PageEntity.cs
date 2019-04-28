using System.Collections.Generic;

namespace Liberator.DynamicPageEngine.Output
{
    public class PageEntity
    {
        public string Name { get; set; }

        public IEnumerable<PageElement> PageObjects { get; set; }
    }
}
