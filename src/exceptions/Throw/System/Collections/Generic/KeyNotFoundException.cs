namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="KeyNotFoundException()"/>
   /// <exception cref="KeyNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void KeyNotFound(this IThrowFor @throw)
   {
      throw new KeyNotFoundException();
   }

   /// <inheritdoc cref="KeyNotFoundException(string)"/>
   /// <exception cref="KeyNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void KeyNotFound(this IThrowFor @throw, string? message)
   {
      throw new KeyNotFoundException(message);
   }

   /// <inheritdoc cref="KeyNotFoundException(string, Exception)"/>
   /// <exception cref="KeyNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void KeyNotFound(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new KeyNotFoundException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="KeyNotFoundException()"/>
   /// <exception cref="KeyNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T KeyNotFound<T>(this IThrowFor @throw)
   {
      KeyNotFound(@throw);
      return default!;
   }

   /// <inheritdoc cref="KeyNotFoundException(string)"/>
   /// <exception cref="KeyNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T KeyNotFound<T>(this IThrowFor @throw, string? message)
   {
      KeyNotFound(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="KeyNotFoundException(string, Exception)"/>
   /// <exception cref="KeyNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T KeyNotFound<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      KeyNotFound(@throw, message, innerException);
      return default!;
   }
   #endregion
}
