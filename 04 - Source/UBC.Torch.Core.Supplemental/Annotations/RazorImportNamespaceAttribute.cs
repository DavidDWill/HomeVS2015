using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace UBC.Torch.Core.Annotations
{
    /// <summary>
    /// Class RazorImportNamespaceAttribute. This class cannot be inherited.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    [Conditional("JETBRAINS_ANNOTATIONS")]
    public sealed class RazorImportNamespaceAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RazorImportNamespaceAttribute"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public RazorImportNamespaceAttribute( string name )
        {
            Name = name;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        [ UsedImplicitly ]
        public string Name
        { get; private set; }
    }
}