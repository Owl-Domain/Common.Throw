namespace OwlDomain.Common;

public static partial class ThrowIfArgumentExtensions
{
   #region Methods
   /// <summary>
   ///   Throws the <see cref="ArgumentException"/> if the given <paramref name="argument"/> was equal to <see cref="string.Empty"/>.
   /// </summary>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="argument"/> was equal to <see cref="string.Empty"/>.</exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsEmpty(
      this IThrowIfArgument @throw,
      string argument,
      [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
   {
      if (argument == string.Empty)
         Throw.For.Argument($"The given argument value was equal to an empty string.", argumentExpression);

      return @throw;
   }

   /// <summary>
   ///   Throws either the <see cref="ArgumentNullException"/> if the given <paramref name="argument"/>
   ///   was <see langword="null"/>, or the <see cref="ArgumentException"/> if the given
   ///   <paramref name="argument"/> was equal to <see cref="string.Empty"/>.
   /// </summary>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentNullException">Thrown if the given <paramref name="argument"/> was <see langword="null"/>.</exception>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="argument"/> was equal to <see cref="string.Empty"/>.</exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsNullOrEmpty(
      this IThrowIfArgument @throw,
      [NotNull] string? argument,
      [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
   {
      Throw.IfArgument.IsNull(argument, argumentExpression);

      if (argument == string.Empty)
         Throw.For.Argument($"The given argument value was equal to an empty string.", argumentExpression);

      return @throw;
   }

   /// <summary>
   ///   Throws the <see cref="ArgumentException"/> if the given <paramref name="argument"/> was
   ///   either equal to <see cref="string.Empty"/>, or only consisted of whitespace characters.
   /// </summary>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentException">
   ///   Thrown if the given <paramref name="argument"/> was either equal to
   ///   <see cref="string.Empty"/>, or only consisted of whitespace characters.
   /// </exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsEmptyOrWhitespace(
      this IThrowIfArgument @throw,
      string argument,
      [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
   {
      if (argument == string.Empty)
         Throw.For.Argument($"The given argument value was equal to an empty string.", argumentExpression);

      if (IsOnlyWhitespace(argument))
         Throw.For.Argument($"The given argument value only consisted of whitespace characters.", argumentExpression);

      return @throw;
   }

   /// <summary>
   ///   Throws either the <see cref="ArgumentNullException"/> if the given <paramref name="argument"/>
   ///   was <see langword="null"/>, or the <see cref="ArgumentException"/> if the given
   ///   <paramref name="argument"/> only consisted of whitespace characters.
   /// </summary>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentNullException">Thrown if the given <paramref name="argument"/> was <see langword="null"/>.</exception>
   /// <exception cref="ArgumentException">Thrown if the given <paramref name="argument"/> only consisted of whitespace characters. </exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsNullOrWhitespace(
     this IThrowIfArgument @throw,
     [NotNull] string? argument,
     [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
   {
      Throw.IfArgument.IsNull(argument, argumentExpression);

      if (argument != string.Empty && IsOnlyWhitespace(argument))
         Throw.For.Argument($"The given argument value only consisted of whitespace characters.", argumentExpression);

      return @throw;
   }

   /// <summary>
   ///   Throws either the <see cref="ArgumentNullException"/> if the given <paramref name="argument"/>
   ///   was <see langword="null"/>, or the <see cref="ArgumentException"/> if the given <paramref name="argument"/> 
   ///   was either equal to <see cref="string.Empty"/>, or only consisted of whitespace characters.
   /// </summary>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentNullException">Thrown if the given <paramref name="argument"/> was <see langword="null"/>.</exception>
   /// <exception cref="ArgumentException">
   ///   Thrown if the given <paramref name="argument"/> was either equal to
   ///   <see cref="string.Empty"/>, or only consisted of whitespace characters.
   /// </exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsNullEmptyOrWhitespace(
     this IThrowIfArgument @throw,
     [NotNull] string? argument,
     [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
   {
      Throw.IfArgument.IsNull(argument, argumentExpression);

      if (argument == string.Empty)
         Throw.For.Argument($"The given argument value was equal to an empty string.", argumentExpression);

      if (IsOnlyWhitespace(argument))
         Throw.For.Argument($"The given argument value only consisted of whitespace characters.", argumentExpression);

      return @throw;
   }
   #endregion

   #region Helpers
   private static bool IsOnlyWhitespace(ReadOnlySpan<char> span)
   {
      foreach (char character in span)
      {
         if (char.IsWhiteSpace(character) is false)
            return false;
      }

      return true;
   }
   #endregion
}
