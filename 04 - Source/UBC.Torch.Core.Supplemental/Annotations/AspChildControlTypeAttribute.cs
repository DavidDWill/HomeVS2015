using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace

namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    ///   Class AspChildControlTypeAttribute. This class cannot be inherited.
    /// </summary>
    [ AttributeUsage( AttributeTargets.Class, AllowMultiple = true ) ]
    [ Conditional( "JETBRAINS_ANNOTATIONS" ) ]
    public sealed class AspChildControlTypeAttribute : Attribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="AspChildControlTypeAttribute" /> class.
        /// </summary>
        /// <param name="tagName" >Name of the tag.</param>
        /// <param name="controlType" >Type of the control.</param>
        public AspChildControlTypeAttribute( string tagName, Type controlType )
        {
            TagName = tagName;
            ControlType = controlType;
        }

        /// <summary>
        ///   Gets the name of the tag.
        /// </summary>
        /// <value>The name of the tag.</value>
        [ UsedImplicitly ]
        public string TagName { get; private set; }

        /// <summary>
        ///   Gets the type of the control.
        /// </summary>
        /// <value>The type of the control.</value>
        [UsedImplicitly]
        public Type ControlType { get; private set; }
    }
}