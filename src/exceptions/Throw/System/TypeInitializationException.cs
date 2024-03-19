namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TypeInitializationException(string, Exception)"/>
   /// <exception cref="TypeInitializationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeInitialization(this IThrow @throw, string? fullTypeName, Exception? innerException)
   {
      throw new TypeInitializationException(fullTypeName, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="TypeInitializationException(string, Exception)"/>
   /// <exception cref="TypeInitializationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeInitialization<T>(this IThrow @throw, string? fullTypeName, Exception? innerException)
   {
      TypeInitialization(@throw, fullTypeName, innerException);
      return default!;
   }
   #endregion
}
