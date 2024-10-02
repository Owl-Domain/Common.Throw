namespace OwlDomain.Common;

public static partial class ThrowIfArgumentExtensions
{
   #region Methods
   /// <summary>Throws the <see cref="ArgumentNullException"/> if the given <paramref name="argument"/> is <see langword="null"/>.</summary>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentNullException">Thrown if the given <paramref name="argument"/> is null.</exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsNull(
      this IThrowIfArgument @throw,
      [NotNull] object? argument,
      [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
   {
      if (argument is null)
         Throw.For.ArgumentNull(argumentExpression);

      return @throw;
   }

   /// <summary>Throws the <see cref="ArgumentNullException"/> if the given <paramref name="argument"/> is <see langword="null"/>.</summary>
   /// <typeparam name="T">The type of the <paramref name="argument"/> value.</typeparam>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentNullException">Thrown if the given <paramref name="argument"/> is null.</exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsNull<T>(
      this IThrowIfArgument @throw,
      [NotNull] T? argument,
      [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
      where T : struct
   {
      if (argument is null)
         Throw.For.ArgumentNull(argumentExpression);

      return @throw;
   }
   #endregion
}
