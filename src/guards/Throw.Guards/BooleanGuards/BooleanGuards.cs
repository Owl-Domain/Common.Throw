namespace OwlDomain.Common;

public static partial class GuardExtensions
{
   #region Methods
   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="value"/> is <see langword="true"/>.</summary>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="value"/> is <see langword="true"/>.</exception>
   public static IThrowIf IsTrue(
      this IThrowIf @throw,
      [DoesNotReturnIf(true)] bool? value,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
   {
      if (value is true)
         Throw.For.Argument($"'{valueArgument}' was true.", valueArgument);

      return @throw;
   }

   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="value"/> is not <see langword="true"/>.</summary>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="value"/> is not <see langword="true"/>.</exception>
   public static IThrowIf IsNotTrue(
      this IThrowIf @throw,
      [DoesNotReturnIf(false)] bool? value,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
   {
      if (value is not true)
         Throw.For.Argument($"'{valueArgument}' was expected to be true but it was {value?.ToString() ?? "null"} instead.", valueArgument);

      return @throw;
   }

   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="value"/> is <see langword="false"/>.</summary>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="value"/> is <see langword="false"/>.</exception>
   public static IThrowIf IsFalse(
      this IThrowIf @throw,
      [DoesNotReturnIf(false)] bool? value,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
   {
      if (value is false)
         Throw.For.Argument($"'{valueArgument}' was false.", valueArgument);

      return @throw;
   }

   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="value"/> is not <see langword="false"/>.</summary>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="value"/> is not <see langword="false"/>.</exception>
   public static IThrowIf IsNotFalse(
      this IThrowIf @throw,
      [DoesNotReturnIf(true)] bool? value,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
   {
      if (value is not false)
         Throw.For.Argument($"'{valueArgument}' was expected to be false but it was {value?.ToString() ?? "null"} instead.", valueArgument);

      return @throw;
   }
   #endregion
}
