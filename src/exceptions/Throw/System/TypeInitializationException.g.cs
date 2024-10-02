#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TypeInitializationException.TypeInitializationException(string?, Exception?)"/>
   /// <exception cref="TypeInitializationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeInitialization(this IThrowFor @throw, string? fullTypeName, Exception? innerException)
   {
      throw new TypeInitializationException(fullTypeName, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="TypeInitializationException.TypeInitializationException(string?, Exception?)"/>
   /// <exception cref="TypeInitializationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeInitialization<T>(this IThrowFor @throw, string? fullTypeName, Exception? innerException)
   {
      TypeInitialization(@throw, fullTypeName, innerException);
      return default;
   }
   #endregion
}

#nullable restore
