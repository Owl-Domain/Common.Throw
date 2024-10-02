namespace OwlDomain.Common;

public static partial class ThrowIfArgumentExtensions
{
   #region Methods
   /// <summary>
   ///   Throws the <see cref="ArgumentException"/> if the given <paramref name="argument"/>
   ///   is not a defined value in the <typeparamref name="T"/> <see langword="enum"/>.
   /// </summary>
   /// <typeparam name="T">The type of the <paramref name="argument"/> value.</typeparam>
   /// <param name="throw">The access point for guarding argument values.</param>
   /// <param name="argument">The argument to check.</param>
   /// <param name="argumentExpression">The expression that was passed in for the <paramref name="argument"/>.</param>
   /// <returns>The used <paramref name="throw"/> instance.</returns>
   /// <exception cref="ArgumentException">
   ///   Thrown if the given <paramref name="argument"/> is not a defined
   ///   value in the <typeparamref name="T"/> <see langword="enum"/>.
   /// </exception>
   [StackTraceHidden]
   public static IThrowIfArgument IsNotDefined<T>(
      this IThrowIfArgument @throw,
      T argument,
      [CallerArgumentExpression(nameof(argument))] string argumentExpression = "<argument>")
      where T : struct, Enum
   {
#if NET5_0_OR_GREATER
      bool isDefined = Enum.IsDefined(argument);
#else
      bool isDefined = Enum.IsDefined(typeof(T), argument);
#endif

      if (isDefined is false)
         Throw.For.Argument($"The given argument value ({argument}) was not a defined value in the ({typeof(T)}) enum.", argumentExpression);

      return @throw;
   }
   #endregion
}
