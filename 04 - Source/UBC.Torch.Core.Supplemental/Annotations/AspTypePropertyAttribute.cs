using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    ///   Class AspTypePropertyAttribute. This class cannot be inherited.
    /// </summary>
    [ AttributeUsage( AttributeTargets.Property ) ]
    [ Conditional( "JETBRAINS_ANNOTATIONS" ) ]
    public sealed class AspTypePropertyAttribute : Attribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="AspTypePropertyAttribute" /> class.
        /// </summary>
        /// <param name="createConstructorReferences" >if set to <c>true</c> [create constructor references].</param>
        public AspTypePropertyAttribute( bool createConstructorReferences )
        {
            CreateConstructorReferences = createConstructorReferences;
        }

        /// <summary>
        ///   Gets a value indicating whether [create constructor references].
        /// </summary>
        /// <value><c>true</c> if [create constructor references]; otherwise, <c>false</c>.</value>
        [ UsedImplicitly ]
        public bool CreateConstructorReferences { get; private set; }
    }
}