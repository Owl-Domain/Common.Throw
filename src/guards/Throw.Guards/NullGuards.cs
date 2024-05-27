namespace OwlDomain.Common;

public static partial class GuardExtensions
{
   #region Methods
   /// <summary>Throws the <see cref="ArgumentNullException"/> if the given <paramref name="value"/> is <see langword="null"/>.</summary>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentNullException">Thrown if the given <paramref name="value"/> is <see langword="null"/>.</exception>
   public static IThrowIf IsNull(
      this IThrowIf @throw,
      [NotNull] object? value,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
   {
      if (value is null)
         Throw.For.ArgumentNull(valueArgument, $"'{valueArgument}' was null.");

      return @throw;
   }

   /// <summary>Throws the <see cref="ArgumentNullException"/> if the given <paramref name="value"/> is <see langword="null"/>.</summary>
   /// <typeparam name="T">The type of the given <paramref name="value"/>, must be a <see langword="struct"/>.</typeparam>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentNullException">Thrown if the given <paramref name="value"/> is <see langword="null"/>.</exception>
   public static IThrowIf IsNull<T>(
      this IThrowIf @throw,
      [NotNull] T? value,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
      where T : struct
   {
      if (value is null)
         Throw.For.ArgumentNull(valueArgument, $"'{valueArgument}' was null.");

      return @throw;
   }

   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="value"/> is not <see langword="null"/>.</summary>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="value"/> is not <see langword="null"/>.</exception>
   public static IThrowIf IsNotNull(
      this IThrowIf @throw,
      object? value,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
   {
      if (value is not null)
         Throw.For.Argument($"'{valueArgument}' was expected to be null but instead it was '{value}'.", valueArgument);

      return @throw;
   }

   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="value"/> is not <see langword="null"/>.</summary>
   /// <typeparam name="T">The type of the given <paramref name="value"/>, must be a <see langword="struct"/>.</typeparam>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="value"/> is not <see langword="null"/>.</exception>
   public static IThrowIf IsNotNull<T>(
      this IThrowIf @throw,
      T? value,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
      where T : struct
   {
      if (value is not null)
         Throw.For.Argument($"'{valueArgument}' was expected to be null but instead it was '{value}'.", valueArgument);

      return @throw;
   }
   #endregion
}
