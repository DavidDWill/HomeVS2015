using System;
using System.Globalization;
using System.Linq;

using UBC.Torch.Core.Annotations;

namespace UBC.Torch.Core
{
    /// <summary>
    /// Provides additional extensions to the existing ones.
    /// </summary>
    public static class Extensions
    {
        #region Public Methods and Operators

        /// <summary>
        /// Replaces the format items in a specified string with the string representations of corresponding objects in a specified array. A parameter supplies culture-specific formatting information.
        /// </summary>
        /// <param name="format">A <see href="https://msdn.microsoft.com/en-us/library/txafckwd(v=vs.110).aspx">composite format string</see>.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <param name="arguments">An object array that contains zero or more objects to format.</param>
        /// <returns>A copy of format in which the format items have been replaced by the string representation of the corresponding objects in <paramref name="arguments"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="format"/> or <paramref name="arguments"/> is <see langword="null" />.</exception>
        /// <exception cref="FormatException">
        /// <para><paramref name="format"/> is invalid.</para>
        /// <para>- or -</para>
        /// <para>The index of a format item is less than zero, or greater than or equal to the length of the <paramref name="arguments"/> array.</para>
        /// </exception>
        [ Pure ]
        [ NotNull ]
        [ PublicAPI ]
        [ StringFormatMethod( "format" ) ]
        [ ContractAnnotation( @"format:null=>halt" ) ]
        [ ContractAnnotation( @"arguments:null=>halt" ) ]
        public static string FormatWith( this string format, [ CanBeNull ] IFormatProvider provider, [ NotNull ] params object[] arguments )
        {
            if ( format == null ) { throw new ArgumentNullException( nameof( format ) ); }
            if ( arguments == null ) { throw new ArgumentNullException( nameof( arguments ) ); }
#if CODE_CONTRACTS
            Contract.Ensures( Contract.Result<string>() != null );
#endif
            if ( provider == null ) { provider = CultureInfo.InvariantCulture; }

            return string.Format( provider, format, arguments );
        }

        /// <summary>
        /// Replaces the format items in a specified string with the string representations of corresponding objects in a specified array. A parameter supplies culture-specific formatting information.
        /// </summary>
        /// <param name="format">A <see href="https://msdn.microsoft.com/en-us/library/txafckwd(v=vs.110).aspx">composite format string</see>.</param>
        /// <param name="arguments">An object array that contains zero or more objects to format.</param>
        /// <returns>A copy of format in which the format items have been replaced by the string representation of the corresponding objects in <paramref name="arguments"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="format"/> or <paramref name="arguments"/> is <see langword="null" />.</exception>
        /// <exception cref="FormatException">
        /// <para><paramref name="format"/> is invalid.</para>
        /// <para>- or -</para>
        /// <para>The index of a format item is less than zero, or greater than or equal to the length of the <paramref name="arguments"/> array.</para>
        /// </exception>
        [ Pure ]
        [ NotNull ]
        [ PublicAPI ]
        [ StringFormatMethod( "format" ) ]
        [ ContractAnnotation( @"format:null=>halt" ) ]
        [ ContractAnnotation( @"arguments:null=>halt" ) ]
        public static string FormatWith( this string format, [ NotNull ] params object[] arguments )
        {
            if ( format == null ) { throw new ArgumentNullException( nameof( format ) ); }
            if ( arguments == null ) { throw new ArgumentNullException( nameof( arguments ) ); }
#if CODE_CONTRACTS
            Contract.Ensures( Contract.Result<string>() != null );
#endif

            return format.FormatWith( CultureInfo.InvariantCulture, arguments );
        }

        #endregion
    }
}