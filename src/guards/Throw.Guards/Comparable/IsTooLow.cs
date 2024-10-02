namespace OwlDomain.Common;

public static partial class ThrowIfArgumentExtensions
{
   #region Methods
   /// <summary>
   ///   Throws the <see cref="ArgumentOutOfRangeException"/> if the given <paramref name="argument"/>
   ///   was lower than the (inclusive) <paramref name="threshold"/> value.
   /// </summary>
   /// <typeparam name="T">The type of the <paramref name="argument"/> and the <paramref name="threshold"/> values.</typeparam>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="threshold"></param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentOutOfRangeException">
   ///   Thrown if the given <paramref name="argument"/> was lower than the (inclusive) <paramref name="threshold"/> value.
   /// </exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsTooLow<T>(
      this IThrowIfArgument @throw,
      IComparable<T> argument,
      T threshold,
      [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
   {
      if (argument.CompareTo(threshold) < 0)
         Throw.For.ArgumentOutOfRange(argumentExpression, argument, $"The given argument value was lower than the allowed threshold of ({threshold}).");

      return @throw;
   }
   #endregion
}
