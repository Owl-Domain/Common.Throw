namespace OwlDomain.Common;

public static partial class ThrowIfArgumentExtensions
{
   #region Methods
   /// <summary>
   ///   Throws the <see cref="ArgumentException"/> if the given <paramref name="argument"/>
   ///   is not of the expected type <typeparamref name="T"/>.
   /// </summary>
   /// <typeparam name="T">The expected type of the <paramref name="argument"/>.</typeparam>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="result">The given <paramref name="argument"/> casted as the expected type.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="argument"/> is not of the expected type <typeparamref name="T"/>.</exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsNotOfType<T>(
      this IThrowIfArgument @throw,
      object argument,
      out T result,
      [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
   {
      result = default!;

      if (argument is T res)
         result = res;
      else
         Throw.For.Argument($"The given argument ({argument}) was not of the expected type ({typeof(T)}).", argumentExpression);

      return @throw;
   }

   /// <summary>
   ///   Throws the <see cref="ArgumentException"/> if the given <paramref name="argument"/>
   ///   is not of the expected type <typeparamref name="T"/>.
   /// </summary>
   /// <typeparam name="T">The expected type of the <paramref name="argument"/>.</typeparam>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="argument"/> is not of the expected type <typeparamref name="T"/>.</exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsNotOfType<T>(
      this IThrowIfArgument @throw,
      object argument,
      [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
   {
      if (argument is not T)
         Throw.For.Argument($"The given argument ({argument}) was not of the expected type ({typeof(T)}).", argumentExpression);

      return @throw;
   }
   #endregion
}
