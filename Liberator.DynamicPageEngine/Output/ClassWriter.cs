using System.IO;

namespace Liberator.DynamicPageEngine.Output
{
    public class ClassWriter : IWriter
    {
        internal byte[] fileData;

        /// <summary>
        /// The name of the page.
        /// </summary>
        public string PageName { get; set; }

        /// <summary>
        /// Outputs the c# file required by the Liberator Driver instance
        /// </summary>
        /// <param name="filePath">The path to use when saving the file</param>
        /// <param name="fileName">The name of the .cs file to create</param>
        public void OuputDocument(string filePath, string fileName)
        {
            using (MemoryStream memoryStream = new MemoryStream(fileData, true))
            using (StreamWriter streamWriter = new StreamWriter(memoryStream))
            {

            }
        }

    }
}
