namespace OwlDomain.Common;

public static partial class GuardExtensions
{
   #region IsEmptyWhitespace methods
   /// <summary>
   ///   Throws the <see cref="ArgumentNullException"/> if the given <paramref name="value"/> 
   ///   is either an empty <see cref="string"/> or it consists entirely of whitespace characters.
   /// </summary>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <remarks>The check is performed using <see cref="char.IsWhiteSpace(char)"/>.</remarks>
   /// <exception cref="ArgumentNullException">
   ///   Thrown if the given <paramref name="value"/> is either an empty 
   ///   <see cref="string"/> or it consists entirely of whitespace characters.
   /// </exception>
   public static IThrowIf IsEmptyOrWhitespace(this IThrowIf @throw, string value, [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
   {
      if (IsEmptyOrWhitespace(value))
         Throw.For.Argument($"", valueArgument);

      return @throw;
   }

   /// <summary>
   ///   Throws the <see cref="ArgumentNullException"/> if the given <paramref name="value"/> is
   ///   neither an empty <see cref="string"/> nor does it entirely consist of whitespace characters.
   /// </summary>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <remarks>The check is performed using <see cref="char.IsWhiteSpace(char)"/>.</remarks>
   /// <exception cref="ArgumentNullException">
   ///   Thrown if the given <paramref name="value"/> is neither an empty
   ///   <see cref="string"/> nor does it entirely consist of whitespace characters.
   /// </exception>
   public static IThrowIf IsNotEmptyOrWhitespace(this IThrowIf @throw, string value, [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
   {
      if (IsEmptyOrWhitespace(value) is false)
         Throw.For.Argument($"", valueArgument);

      return @throw;
   }

   private static bool IsEmptyOrWhitespace(string value)
   {
      foreach (char ch in value)
      {
         if (char.IsWhiteSpace(ch) is false)
            return false;
      }

      return true;
   }
   #endregion
}
