using System;
using System.ComponentModel;

namespace Liberator.DynamicPageEngine.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    public class PageObjectAttribute : Attribute
    {
        internal Byte Finder { get; set; }

        /// <summary>
        /// The priority for the find attributes
        /// </summary>
        [DefaultValue(0)]
        public int Priority { get; set; }

        /// <summary>
        /// The type of finder to be used
        /// </summary>
        [DefaultValue(How.Id)]
        public How How { get; set; }

        /// <summary>
        /// The find value to be used
        /// </summary>
        public string Using { get; set; }

        /// <summary>
        /// The type of custom finder object to use
        /// </summary>
        public Type CustomFinderType { get; set; }

        public static bool operator ==(PageObjectAttribute one, PageObjectAttribute two)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(one, two)) return true;
            return (one is null) || (two is null) ? false : one.Equals(two);
        }

        public static bool operator !=(PageObjectAttribute one, PageObjectAttribute two)
        {
            return !(one == two);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            PageObjectAttribute other = obj as PageObjectAttribute;
            if (other == null)
            {
                return false;
            }

            if (other.Priority != this.Priority)
            {
                return false;
            }

            if (other.Finder != this.Finder)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.Finder.GetHashCode();
        }
    }
}
