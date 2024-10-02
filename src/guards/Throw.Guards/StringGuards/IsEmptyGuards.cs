namespace OwlDomain.Common;

public static partial class GuardExtensions
{
   #region IsEmpty methods
   /// <summary>Throws the <see cref="ArgumentNullException"/> if the given <paramref name="value"/> is an empty <see cref="string"/>.</summary>
   /// <param name="throw">An instance of the <see cref="IThrowIfArgument"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentNullException">Thrown if the given <paramref name="value"/> is an empty <see cref="string"/>.</exception>
   public static IThrowIfArgument IsEmpty(this IThrowIfArgument @throw, string value, [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
   {
      if (value.Length is 0)
         Throw.For.Argument($"'{valueArgument}' was empty.", valueArgument);

      return @throw;
   }

   /// <summary>Throws the <see cref="ArgumentNullException"/> if the given <paramref name="value"/> is not an empty <see cref="string"/>.</summary>
   /// <param name="throw">An instance of the <see cref="IThrowIfArgument"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentNullException">Thrown if the given <paramref name="value"/> is not an empty <see cref="string"/>.</exception>
   public static IThrowIfArgument IsNotEmpty(this IThrowIfArgument @throw, string value, [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
   {
      if (value.Length is not 0)
         Throw.For.Argument($"'{valueArgument}' was not empty, instead it was '{value}'.", valueArgument);

      return @throw;
   }
   #endregion
}
