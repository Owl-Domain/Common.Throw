namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TimeoutException()"/>
   /// <exception cref="TimeoutException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Timeout(this IThrowFor @throw)
   {
      throw new TimeoutException();
   }

   /// <inheritdoc cref="TimeoutException(string)"/>
   /// <exception cref="TimeoutException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Timeout(this IThrowFor @throw, string? message)
   {
      throw new TimeoutException(message);
   }

   /// <inheritdoc cref="TimeoutException(string, Exception)"/>
   /// <exception cref="TimeoutException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Timeout(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new TimeoutException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="TimeoutException()"/>
   /// <exception cref="TimeoutException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Timeout<T>(this IThrowFor @throw)
   {
      Timeout(@throw);
      return default!;
   }

   /// <inheritdoc cref="TimeoutException(string)"/>
   /// <exception cref="TimeoutException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Timeout<T>(this IThrowFor @throw, string? message)
   {
      Timeout(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="TimeoutException(string, Exception)"/>
   /// <exception cref="TimeoutException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Timeout<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      Timeout(@throw, message, innerException);
      return default!;
   }
   #endregion
}
