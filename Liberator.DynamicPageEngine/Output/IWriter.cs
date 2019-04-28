namespace Liberator.DynamicPageEngine.Output
{
    internal interface IWriter
    {
        /// <summary>
        /// The name of the page.
        /// </summary>
        string PageName { get; set; }

        void OuputDocument(string filePath, string fileName);
    }
}