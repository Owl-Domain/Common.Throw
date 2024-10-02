#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TimeoutException.TimeoutException()"/>
   /// <exception cref="TimeoutException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Timeout(this IThrowFor @throw)
   {
      throw new TimeoutException();
   }
   
   /// <inheritdoc cref="TimeoutException.TimeoutException(string?)"/>
   /// <exception cref="TimeoutException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Timeout(this IThrowFor @throw, string? message)
   {
      throw new TimeoutException(message);
   }
   
   /// <inheritdoc cref="TimeoutException.TimeoutException(string?, Exception?)"/>
   /// <exception cref="TimeoutException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Timeout(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new TimeoutException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="TimeoutException.TimeoutException()"/>
   /// <exception cref="TimeoutException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Timeout<T>(this IThrowFor @throw)
   {
      Timeout(@throw);
      return default;
   }
   
   /// <inheritdoc cref="TimeoutException.TimeoutException(string?)"/>
   /// <exception cref="TimeoutException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Timeout<T>(this IThrowFor @throw, string? message)
   {
      Timeout(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="TimeoutException.TimeoutException(string?, Exception?)"/>
   /// <exception cref="TimeoutException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Timeout<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      Timeout(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
