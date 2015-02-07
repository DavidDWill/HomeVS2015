using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    ///   Class AspRequiredAttributeAttribute. This class cannot be inherited.
    /// </summary>
    [ AttributeUsage( AttributeTargets.Class, AllowMultiple = true ) ]
    [ Conditional( "JETBRAINS_ANNOTATIONS" ) ]
    public sealed class AspRequiredAttributeAttribute : Attribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="AspRequiredAttributeAttribute" /> class.
        /// </summary>
        /// <param name="attribute" >The attribute.</param>
        public AspRequiredAttributeAttribute( [ NotNull ] string attribute )
        {
            Attribute = attribute;
        }

        /// <summary>
        ///   Gets the attribute.
        /// </summary>
        /// <value>The attribute.</value>
        [ UsedImplicitly ]
        public string Attribute { get; private set; }
    }
}