using System;

namespace Liberator.DynamicPageEngine.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class FindsByAllAttribute : Attribute
    {

    }
}
