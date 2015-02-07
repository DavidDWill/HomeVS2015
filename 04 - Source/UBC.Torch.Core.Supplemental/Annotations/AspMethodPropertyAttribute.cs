using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    /// Class AspMethodPropertyAttribute. This class cannot be inherited.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    [Conditional("JETBRAINS_ANNOTATIONS")]
    public sealed class AspMethodPropertyAttribute : Attribute
    {
    }
}