namespace OwlDomain.Common;

public static partial class GuardExtensions
{
   #region HasFlag methods
   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="value"/> has the given <paramref name="flag"/> set.</summary>
   /// <typeparam name="T">The type of the <see langword="enum"/> that is used for the <paramref name="value"/> and the <paramref name="flag"/>.</typeparam>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="flag">The flag to check on the given <paramref name="value"/>.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <param name="flagArgument">The argument expression that was passed in as the <paramref name="flag"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="value"/> has the given <paramref name="flag"/> set.</exception>
   public static IThrowIf HasFlag<T>(
      this IThrowIf @throw,
      [DisallowNull] T? value,
      [DisallowNull] T? flag,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>",
      [CallerArgumentExpression(nameof(flag))] string flagArgument = "<flag>")
      where T : struct, Enum
   {
      if (value.Value.HasFlag(flag.Value))
         Throw.For.Argument($"'{valueArgument}' had the flag '{flagArgument}' set when it wasn't expected to.\nValue: {value}\nFlag: {flag}", valueArgument);

      return @throw;
   }

   /// <inheritdoc cref="HasFlag{T}(IThrowIf, T?, T?, string, string)"/>
   public static IThrowIf HasFlag<T>(
      this IThrowIf @throw,
      [DisallowNull] T value,
      [DisallowNull] T flag,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>",
      [CallerArgumentExpression(nameof(flag))] string flagArgument = "<flag>")
      where T : struct, Enum
   {
      if (value.HasFlag(flag))
         Throw.For.Argument($"'{valueArgument}' had the flag '{flagArgument}' set when it wasn't expected to.\nValue: {value}\nFlag: {flag}", valueArgument);

      return @throw;
   }
   #endregion

   #region DoesNotHaveFlag methods
   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="value"/> did not the given <paramref name="flag"/> set.</summary>
   /// <typeparam name="T">The type of the <see langword="enum"/> that is used for the <paramref name="value"/> and the <paramref name="flag"/>.</typeparam>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="flag">The flag to check on the given <paramref name="value"/>.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <param name="flagArgument">The argument expression that was passed in as the <paramref name="flag"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="value"/> did not the given <paramref name="flag"/> set.</exception>
   public static IThrowIf DoesNotHaveFlag<T>(
      this IThrowIf @throw,
      [DisallowNull] T? value,
      [DisallowNull] T? flag,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>",
      [CallerArgumentExpression(nameof(flag))] string flagArgument = "<flag>")
      where T : struct, Enum
   {
      if (value.Value.HasFlag(flag.Value) is false)
         Throw.For.Argument($"'{valueArgument}' didn't have the flag '{flagArgument}' set when it was expected to have it.\nValue: {value}\nFlag: {flag}", valueArgument);

      return @throw;
   }

   /// <inheritdoc cref="DoesNotHaveFlag{T}(IThrowIf, T?, T?, string, string)"/>
   public static IThrowIf DoesNotHaveFlag<T>(
      this IThrowIf @throw,
      [DisallowNull] T value,
      [DisallowNull] T flag,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>",
      [CallerArgumentExpression(nameof(flag))] string flagArgument = "<flag>")
      where T : struct, Enum
   {
      if (value.HasFlag(flag) is false)
         Throw.For.Argument($"'{valueArgument}' didn't have the flag '{flagArgument}' set when it was expected to have it.\nValue: {value}\nFlag: {flag}", valueArgument);

      return @throw;
   }
   #endregion

   #region IsDefined methods
   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="value"/> is defined in the enum of the type <typeparamref name="T"/>.</summary>
   /// <typeparam name="T">The type of the <see langword="enum"/> that is used for the <paramref name="value"/>.</typeparam>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="value"/> is defined in the enum of the type <typeparamref name="T"/>.</exception>
   public static IThrowIf IsDefined<T>(
      this IThrowIf @throw,
      [DisallowNull] T? value,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
      where T : struct, Enum
   {
#if NET7_0_OR_GREATER
      if (Enum.IsDefined(value.Value))
#else
      if (Enum.IsDefined(typeof(T), value.Value))
#endif
         Throw.For.Argument($"'{valueArgument}' was a defined value in the {typeof(T)} enum when it wasn't expected to be.\nValue: {value}", valueArgument);

      return @throw;
   }

   /// <inheritdoc cref="IsDefined{T}(IThrowIf, T?, string)"/>
   public static IThrowIf IsDefined<T>(
      this IThrowIf @throw,
      [DisallowNull] T value,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
      where T : struct, Enum
   {
#if NET7_0_OR_GREATER
      if (Enum.IsDefined(value))
#else
      if (Enum.IsDefined(typeof(T), value))
#endif
         Throw.For.Argument($"'{valueArgument}' was a defined value in the {typeof(T)} enum when it wasn't expected to be.\nValue: {value}", valueArgument);

      return @throw;
   }
   #endregion

   #region IsNotDefined methods
   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="value"/> is not defined in the enum of the type <typeparamref name="T"/>.</summary>
   /// <typeparam name="T">The type of the <see langword="enum"/> that is used for the <paramref name="value"/>.</typeparam>
   /// <param name="throw">An instance of the <see cref="IThrowIf"/> interface used to access the guard extension method.</param>
   /// <param name="value">The value to check.</param>
   /// <param name="valueArgument">The argument expression that was passed in as the <paramref name="value"/>.</param>
   /// <returns>The value passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="value"/> is not defined in the enum of the type <typeparamref name="T"/>.</exception>
   public static IThrowIf IsNotDefined<T>(
      this IThrowIf @throw,
      [DisallowNull] T? value,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
      where T : struct, Enum
   {
#if NET7_0_OR_GREATER
      if (Enum.IsDefined(value.Value) is false)
#else
      if (Enum.IsDefined(typeof(T), value.Value) is false)
#endif
         Throw.For.Argument($"'{valueArgument}' was not defined value in the {typeof(T)} enum when it was expected to be.\nValue: {value}", valueArgument);

      return @throw;
   }

   /// <inheritdoc cref="IsNotDefined{T}(IThrowIf, T?, string)"/>
   public static IThrowIf IsNotDefined<T>(
      this IThrowIf @throw,
      [DisallowNull] T value,
      [CallerArgumentExpression(nameof(value))] string valueArgument = "<value>")
      where T : struct, Enum
   {
#if NET7_0_OR_GREATER
      if (Enum.IsDefined(value) is false)
#else
      if (Enum.IsDefined(typeof(T), value) is false)
#endif
         Throw.For.Argument($"'{valueArgument}' was not defined value in the {typeof(T)} enum when it was expected to be.\nValue: {value}", valueArgument);

      return @throw;
   }
   #endregion
}
