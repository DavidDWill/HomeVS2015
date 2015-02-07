using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    /// Indicates that collection or enumerable value can contain null elements
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
        AttributeTargets.Delegate | AttributeTargets.Field)]
    [Conditional("JETBRAINS_ANNOTATIONS")]
    public sealed class ItemCanBeNullAttribute : Attribute
    {
    }
}