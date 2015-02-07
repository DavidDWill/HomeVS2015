using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace

namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    ///   Class RazorInjectionAttribute. This class cannot be inherited.
    /// </summary>
    [ AttributeUsage( AttributeTargets.Assembly, AllowMultiple = true ) ]
    [ Conditional( "JETBRAINS_ANNOTATIONS" ) ]
    public sealed class RazorInjectionAttribute : Attribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="RazorInjectionAttribute" /> class.
        /// </summary>
        /// <param name="type" >The type.</param>
        /// <param name="fieldName" >Name of the field.</param>
        public RazorInjectionAttribute( string type, string fieldName )
        {
            Type = type;
            FieldName = fieldName;
        }

        /// <summary>
        ///   Gets the type.
        /// </summary>
        /// <value>The type.</value>
        [ UsedImplicitly ]
        public string Type { get; private set; }

        /// <summary>
        ///   Gets the name of the field.
        /// </summary>
        /// <value>The name of the field.</value>
        [ UsedImplicitly ]
        public string FieldName { get; private set; }
    }
}