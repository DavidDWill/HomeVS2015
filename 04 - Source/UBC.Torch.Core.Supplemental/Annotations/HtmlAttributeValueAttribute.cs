using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace

namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    ///   Class HtmlAttributeValueAttribute. This class cannot be inherited.
    /// </summary>
    [ AttributeUsage( AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property ) ]
    [ Conditional( "JETBRAINS_ANNOTATIONS" ) ]
    public sealed class HtmlAttributeValueAttribute : Attribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="HtmlAttributeValueAttribute" /> class.
        /// </summary>
        /// <param name="name" >The name.</param>
        public HtmlAttributeValueAttribute( [ NotNull ] string name )
        {
            Name = name;
        }

        /// <summary>
        ///   Gets the name.
        /// </summary>
        /// <value>The name.</value>
        [ NotNull ]
        [ UsedImplicitly ]
        public string Name { get; private set; }
    }
}