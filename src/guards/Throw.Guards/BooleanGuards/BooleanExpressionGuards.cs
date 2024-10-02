namespace OwlDomain.Common;

public static partial class GuardExtensions
{
   #region Methods
   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="expression"/> is <see langword="true"/>.</summary>
   /// <param name="throw">An instance of the <see cref="IThrowIfArgument"/> interface used to access the guard extension method.</param>
   /// <param name="expression">The expression to check.</param>
   /// <param name="paramterName">The parameter to pass in to the thrown <see cref="ArgumentException"/>.</param>
   /// <param name="expressionArgument">The argument expression that was passed in as the <paramref name="expression"/>.</param>
   /// <returns>The expression passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="expression"/> is <see langword="true"/>.</exception>
   /// <remarks>
   ///   Use this guard instead of <see cref="IsTrue(IThrowIfArgument, bool?, string)"/> 
   ///   when you are checking an expression instead of a single value for
   ///   a more detailed exception message.
   /// </remarks>
   public static IThrowIfArgument IsExpressionTrue(
      this IThrowIfArgument @throw,
      [DoesNotReturnIf(true)] bool? expression,
      string? paramterName,
      [CallerArgumentExpression(nameof(expression))] string expressionArgument = "<expression>")
   {
      if (expression is true)
         Throw.For.Argument($"The expression '{expressionArgument}' was true.", paramterName);

      return @throw;
   }

   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="expression"/> is not <see langword="true"/>.</summary>
   /// <param name="throw">An instance of the <see cref="IThrowIfArgument"/> interface used to access the guard extension method.</param>
   /// <param name="expression">The expression to check.</param>
   /// <param name="paramterName">The parameter to pass in to the thrown <see cref="ArgumentException"/>.</param>
   /// <param name="expressionArgument">The argument expression that was passed in as the <paramref name="expression"/>.</param>
   /// <returns>The expression passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="expression"/> is not <see langword="true"/>.</exception>
   /// <remarks>
   ///   Use this guard instead of <see cref="IsNotTrue(IThrowIfArgument, bool?, string)"/> 
   ///   when you are checking an expression instead of a single value for
   ///   a more detailed exception message.
   /// </remarks>
   public static IThrowIfArgument IsExpressionNotTrue(
      this IThrowIfArgument @throw,
      [DoesNotReturnIf(false)] bool? expression,
      string? paramterName,
      [CallerArgumentExpression(nameof(expression))] string expressionArgument = "<expression>")
   {
      if (expression is not true)
         Throw.For.Argument($"The expression '{expressionArgument}' was expected to be true but it was {expression?.ToString() ?? "null"} instead.", paramterName);

      return @throw;
   }

   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="expression"/> is <see langword="false"/>.</summary>
   /// <param name="throw">An instance of the <see cref="IThrowIfArgument"/> interface used to access the guard extension method.</param>
   /// <param name="expression">The expression to check.</param>
   /// <param name="paramterName">The parameter to pass in to the thrown <see cref="ArgumentException"/>.</param>
   /// <param name="expressionArgument">The argument expression that was passed in as the <paramref name="expression"/>.</param>
   /// <returns>The expression passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="expression"/> is <see langword="false"/>.</exception>
   /// <remarks>
   ///   Use this guard instead of <see cref="IsFalse(IThrowIfArgument, bool?, string)"/> 
   ///   when you are checking an expression instead of a single value for
   ///   a more detailed exception message.
   /// </remarks>
   public static IThrowIfArgument IsExpressionFalse(
      this IThrowIfArgument @throw,
      [DoesNotReturnIf(false)] bool? expression,
      string? paramterName,
      [CallerArgumentExpression(nameof(expression))] string expressionArgument = "<expression>")
   {
      if (expression is false)
         Throw.For.Argument($"The expression '{expressionArgument}' was false.", paramterName);

      return @throw;
   }

   /// <summary>Throws the <see cref="ArgumentException"/> if the given <paramref name="expression"/> is not <see langword="false"/>.</summary>
   /// <param name="throw">An instance of the <see cref="IThrowIfArgument"/> interface used to access the guard extension method.</param>
   /// <param name="expression">The expression to check.</param>
   /// <param name="paramterName">The parameter to pass in to the thrown <see cref="ArgumentException"/>.</param>
   /// <param name="expressionArgument">The argument expression that was passed in as the <paramref name="expression"/>.</param>
   /// <returns>The expression passed in as the <paramref name="throw"/> argument to use for chaining guard methods.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="expression"/> is not <see langword="false"/>.</exception>
   /// <remarks>
   ///   Use this guard instead of <see cref="IsNotFalse(IThrowIfArgument, bool?, string)"/> 
   ///   when you are checking an expression instead of a single value for
   ///   a more detailed exception message.
   /// </remarks>
   public static IThrowIfArgument IsExpressionNotFalse(
      this IThrowIfArgument @throw,
      [DoesNotReturnIf(true)] bool? expression,
      string? paramterName,
      [CallerArgumentExpression(nameof(expression))] string expressionArgument = "<expression>")
   {
      if (expression is not false)
         Throw.For.Argument($"The expression '{expressionArgument}' was expected to be false but it was {expression?.ToString() ?? "null"} instead.", paramterName);

      return @throw;
   }
   #endregion
}
