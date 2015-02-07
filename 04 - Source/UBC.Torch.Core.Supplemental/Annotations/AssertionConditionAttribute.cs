using System;
using System.Diagnostics;

// ReSharper disable InconsistentNaming
namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    ///   Indicates the condition parameter of the assertion method. The method itself should be
    ///   marked by <see cref="AssertionMethodAttribute" /> attribute. The mandatory argument of
    ///   the attribute is the assertion type.
    /// </summary>
    [ AttributeUsage( AttributeTargets.Parameter ) ]
    [ Conditional( "JETBRAINS_ANNOTATIONS" ) ]
    public sealed class AssertionConditionAttribute : Attribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="AssertionConditionAttribute" /> class.
        /// </summary>
        /// <param name="conditionType" >Type of the condition.</param>
        public AssertionConditionAttribute( AssertionConditionType conditionType )
        {
            ConditionType = conditionType;
        }

        /// <summary>
        ///   Gets the type of the condition.
        /// </summary>
        /// <value>The type of the condition.</value>
        [ UsedImplicitly ]
        public AssertionConditionType ConditionType { get; private set; }
    }
}