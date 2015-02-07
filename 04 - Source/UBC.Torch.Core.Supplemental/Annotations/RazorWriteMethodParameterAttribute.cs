using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    /// Class RazorWriteMethodParameterAttribute. This class cannot be inherited.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    [Conditional("JETBRAINS_ANNOTATIONS")]
    public sealed class RazorWriteMethodParameterAttribute : Attribute
    {
    }
}