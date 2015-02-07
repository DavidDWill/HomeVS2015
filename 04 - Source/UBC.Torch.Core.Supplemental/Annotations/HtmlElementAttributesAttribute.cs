using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    /// Class HtmlElementAttributesAttribute. This class cannot be inherited.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field)]
    [Conditional("JETBRAINS_ANNOTATIONS")]
    public sealed class HtmlElementAttributesAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlElementAttributesAttribute"/> class.
        /// </summary>
        public HtmlElementAttributesAttribute()
        { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlElementAttributesAttribute"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public HtmlElementAttributesAttribute( string name )
        {
            Name = name;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        [ UsedImplicitly ]
        public string Name
        { get; private set; }
    }
}