using System;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Liberator.DynamicPageEngine.Entities
{
    /// <summary>
    /// Internal utilities for XML manipulation.
    /// </summary>
    internal static class XmlUtilities
    {
        /// <summary>
        /// Validates an XML file fits within a specified schema.
        /// </summary>
        /// <param name="pathToXml">Full path to the XML file to be validated.</param>
        /// <returns>True if the XML is valid.</returns>
        internal static bool Validate(string pathToXml)
        {
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    XmlSchemaSet schemaSet = new XmlSchemaSet();
                    schemaSet.Add(null, "schema.xsd");
                    schemaSet.Compile();

                    XDocument document = XDocument.Load(memoryStream, LoadOptions.None);
                    document.Validate(schemaSet, null);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Deserialises an XML document to an object.
        /// </summary>
        /// <typeparam name="T">The type of the object to be created.</typeparam>
        /// <param name="xElement">The XElement object to be deserialised.</param>
        /// <returns>An object containing the data from the XML.</returns>
        internal static T FromXElement<T>(this XElement xElement)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            return (T)xmlSerializer.Deserialize(xElement.CreateReader());
        }

        /// <summary>
        /// Serialises an object into an XElement.
        /// </summary>
        /// <typeparam name="T">The type of the object to be serialised.</typeparam>
        /// <param name="obj">The object to be serialised.</param>
        /// <returns>An XElement object cointaining the object data.</returns>
        internal static XElement ToXElement<T>(this T obj)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (TextWriter streamWriter = new StreamWriter(memoryStream))
                {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, obj);
                    return XElement.Parse(Encoding.Default.GetString(memoryStream.ToArray()));
                }
            }
        }
    }
}
