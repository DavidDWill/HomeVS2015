using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    /// Class AspDataFieldsAttribute. This class cannot be inherited.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
    [Conditional("JETBRAINS_ANNOTATIONS")]
    public sealed class AspDataFieldsAttribute : Attribute
    {
    }
}