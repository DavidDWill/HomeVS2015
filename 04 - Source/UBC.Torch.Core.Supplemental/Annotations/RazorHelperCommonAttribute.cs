using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    /// Class RazorHelperCommonAttribute. This class cannot be inherited.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    [Conditional("JETBRAINS_ANNOTATIONS")]
    public sealed class RazorHelperCommonAttribute : Attribute
    {
    }
}