using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    ///   Indicates how method invocation affects content of the collection
    /// </summary>
    [ AttributeUsage( AttributeTargets.Method ) ]
    [ Conditional( "JETBRAINS_ANNOTATIONS" ) ]
    public sealed class CollectionAccessAttribute : Attribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="CollectionAccessAttribute" /> class.
        /// </summary>
        /// <param name="collectionAccessType" >Type of the collection access.</param>
        public CollectionAccessAttribute( CollectionAccessType collectionAccessType )
        {
            CollectionAccessType = collectionAccessType;
        }

        /// <summary>
        ///   Gets the type of the collection access.
        /// </summary>
        /// <value>The type of the collection access.</value>
        [ UsedImplicitly ]
        public CollectionAccessType CollectionAccessType { get; private set; }
    }
}