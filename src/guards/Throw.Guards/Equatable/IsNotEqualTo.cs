namespace OwlDomain.Common;

public static partial class ThrowIfArgumentExtensions
{
   #region Methods
   /// <summary>
   ///   Throws the <see cref="ArgumentException"/> if the given <paramref name="argument"/>
   ///   is not equal to the given <paramref name="expected"/> value.
   /// </summary>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="expected">The value to check the <paramref name="argument"/> against.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentException">
   ///   Thrown if the given <paramref name="argument"/> is not equal to the <paramref name="expected"/> value.
   /// </exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsNotEqualTo<T>(
      this IThrowIfArgument @throw,
      IEquatable<T> argument,
      T expected,
      [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
   {
      if (argument.Equals(expected) is false)
         Throw.For.Argument($"The given argument value ({argument}) was not equal to the expected value ({expected}).", argumentExpression);

      return @throw;
   }

   /// <summary>
   ///   Throws the <see cref="ArgumentException"/> if the given <paramref name="argument"/>
   ///   is not equal to the given <paramref name="expected"/> value.
   /// </summary>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="expected">The value to check the <paramref name="argument"/> against.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentException">
   ///   Thrown if the given <paramref name="argument"/> is not equal to the <paramref name="expected"/> value.
   /// </exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsNotEqualTo<T>(
      this IThrowIfArgument @throw,
      IComparable<T> argument,
      T expected,
      [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
   {
      if (argument.CompareTo(expected) is not 0)
         Throw.For.Argument($"The given argument value ({argument}) was not equal to the expected value ({expected}).", argumentExpression);

      return @throw;
   }

   /// <summary>
   ///   Throws the <see cref="ArgumentException"/> if the given <paramref name="argument"/>
   ///   is not equal to the given <paramref name="expected"/> value.
   /// </summary>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="expected">The value to check the <paramref name="argument"/> against.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentException">
   ///   Thrown if the given <paramref name="argument"/> is not equal to the <paramref name="expected"/> value.
   /// </exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsNotEqualTo<T>(
      this IThrowIfArgument @throw,
      T argument,
      T expected,
      [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
   {
      if (EqualityComparer<T>.Default.Equals(argument, expected) is false)
         Throw.For.Argument($"The given argument value ({argument}) was not equal to the expected value ({expected}).", argumentExpression);

      return @throw;
   }
   #endregion
}
