#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InvalidCastException.InvalidCastException()"/>
   /// <exception cref="InvalidCastException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidCast(this IThrowFor @throw)
   {
      throw new InvalidCastException();
   }
   
   /// <inheritdoc cref="InvalidCastException.InvalidCastException(string?)"/>
   /// <exception cref="InvalidCastException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidCast(this IThrowFor @throw, string? message)
   {
      throw new InvalidCastException(message);
   }
   
   /// <inheritdoc cref="InvalidCastException.InvalidCastException(string?, Exception?)"/>
   /// <exception cref="InvalidCastException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidCast(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new InvalidCastException(message, innerException);
   }
   
   /// <inheritdoc cref="InvalidCastException.InvalidCastException(string?, int)"/>
   /// <exception cref="InvalidCastException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidCast(this IThrowFor @throw, string? message, int errorCode)
   {
      throw new InvalidCastException(message, errorCode);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="InvalidCastException.InvalidCastException()"/>
   /// <exception cref="InvalidCastException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidCast<T>(this IThrowFor @throw)
   {
      InvalidCast(@throw);
      return default;
   }
   
   /// <inheritdoc cref="InvalidCastException.InvalidCastException(string?)"/>
   /// <exception cref="InvalidCastException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidCast<T>(this IThrowFor @throw, string? message)
   {
      InvalidCast(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="InvalidCastException.InvalidCastException(string?, Exception?)"/>
   /// <exception cref="InvalidCastException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidCast<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      InvalidCast(@throw, message, innerException);
      return default;
   }
   
   /// <inheritdoc cref="InvalidCastException.InvalidCastException(string?, int)"/>
   /// <exception cref="InvalidCastException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidCast<T>(this IThrowFor @throw, string? message, int errorCode)
   {
      InvalidCast(@throw, message, errorCode);
      return default;
   }
   #endregion
}

#nullable restore
