using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    ///   Class AspMvcMasterLocationFormatAttribute. This class cannot be inherited.
    /// </summary>
    [ AttributeUsage( AttributeTargets.Assembly, AllowMultiple = true ) ]
    [ Conditional( "JETBRAINS_ANNOTATIONS" ) ]
    public sealed class AspMvcMasterLocationFormatAttribute : Attribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="AspMvcMasterLocationFormatAttribute" /> class.
        /// </summary>
        /// <param name="format" >The format.</param>
        public AspMvcMasterLocationFormatAttribute( string format )
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