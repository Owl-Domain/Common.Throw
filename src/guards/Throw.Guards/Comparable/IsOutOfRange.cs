namespace OwlDomain.Common;

public static partial class ThrowIfArgumentExtensions
{
   #region Methods
   /// <summary>
   ///   Throws the <see cref="ArgumentOutOfRangeException"/> if the given <paramref name="argument"/> is outside
   ///   of the given (inclusive) range specified by the <paramref name="minimum"/> and <paramref name="maximum"/> values.
   /// </summary>
   /// <typeparam name="T">The type of the <paramref name="argument"/>, the <paramref name="minimum"/> and the <paramref name="maximum"/> values.</typeparam>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="minimum">The (inclusively) minimum value allowed for the given <paramref name="argument"/>.</param>
   /// <param name="maximum">The (inclusively) maximum value allowed for the given <paramref name="argument"/>.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentOutOfRangeException">
   ///   Thrown if the given <paramref name="argument"/> is outside of the given (inclusive) range
   ///   specified by the <paramref name="minimum"/> and <paramref name="maximum"/> values.
   /// </exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsOutOfRange<T>(
      this IThrowIfArgument @throw,
      IComparable<T> argument,
      T minimum,
      T maximum,
      [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
   {
      if (argument.CompareTo(minimum) < 0 || argument.CompareTo(maximum) > 0)
         Throw.For.ArgumentOutOfRange(argumentExpression, argument, $"The given argument value was outside of the allowd range of ({minimum}) to ({maximum}).");

      return @throw;
   }
   #endregion
}
