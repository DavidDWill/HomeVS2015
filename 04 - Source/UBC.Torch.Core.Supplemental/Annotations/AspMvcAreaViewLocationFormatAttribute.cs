using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    ///   Class AspMvcAreaViewLocationFormatAttribute. This class cannot be inherited.
    /// </summary>
    [ AttributeUsage( AttributeTargets.Assembly, AllowMultiple = true ) ]
    [ Conditional( "JETBRAINS_ANNOTATIONS" ) ]
    public sealed class AspMvcAreaViewLocationFormatAttribute : Attribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="AspMvcAreaViewLocationFormatAttribute" /> class.
        /// </summary>
        /// <param name="format" >The format.</param>
        public AspMvcAreaViewLocationFormatAttribute( string format )
        {
            Format = format;
        }

        /// <summary>
        ///   Gets the format.
        /// </summary>
        /// <value>The format.</value>
        [ UsedImplicitly ]
        public string Format { get; private set; }
    }
}