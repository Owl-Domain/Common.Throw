namespace OwlDomain.Common;

public static partial class GuardExtensions
{
   #region IsWhitespace methods
   /// <summary>Throws the <see cref="ArgumentNullException"/> if the given <paramref name="value"/> consists entirely of whitespace characters.</summary>
   /// <param name="throw">An instance of the <see cref="IThrowIfArgument"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <remarks>The check is performed using <see cref="char.IsWhiteSpace(char)"/>.</remarks>
   /// <exception cref="ArgumentNullException">Thrown if the given <paramref name="value"/> consists entirely of whitespace characters.</exception>
   public static IThrowIfArgument IsWhitespace(this IThrowIfArgument @throw, string value, [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
   {
      if (IsWhitespace(value))
         Throw.For.Argument($"'{valueArgument}' only consisted of whitespace characters.", valueArgument);

      return @throw;
   }

   /// <summary>
   ///   Throws the <see cref="ArgumentNullException"/> if the given <paramref name="value"/> is either
   ///   an empty <see cref="string"/> or contains characters that are not considered whitespace.
   /// </summary>
   /// <param name="throw">An instance of the <see cref="IThrowIfArgument"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <remarks>The check is performed using <see cref="char.IsWhiteSpace(char)"/>.</remarks>
   /// <exception cref="ArgumentNullException">
   ///   Thrown if the given <paramref name="value"/> is either an empty <see cref="string"/> 
   ///   or contains characters that are not considered whitespace.
   /// </exception>
   public static IThrowIfArgument IsNotWhitespace(this IThrowIfArgument @throw, string value, [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
   {
      if (IsWhitespace(value) is false)
         Throw.For.Argument($"'{valueArgument}' was either empty or only consisted of whitespace characters.", valueArgument);

      return @throw;
   }

   private static bool IsWhitespace(string value)
   {
      if (value.Length is 0)
         return false;

      bool result = IsEmptyOrWhitespace(value);
      return result;
   }
   #endregion
}
