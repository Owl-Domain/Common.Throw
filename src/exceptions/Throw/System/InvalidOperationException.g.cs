#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InvalidOperationException.InvalidOperationException()"/>
   /// <exception cref="InvalidOperationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidOperation(this IThrowFor @throw)
   {
      throw new InvalidOperationException();
   }
   
   /// <inheritdoc cref="InvalidOperationException.InvalidOperationException(string?)"/>
   /// <exception cref="InvalidOperationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidOperation(this IThrowFor @throw, string? message)
   {
      throw new InvalidOperationException(message);
   }
   
   /// <inheritdoc cref="InvalidOperationException.InvalidOperationException(string?, Exception?)"/>
   /// <exception cref="InvalidOperationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidOperation(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new InvalidOperationException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="InvalidOperationException.InvalidOperationException()"/>
   /// <exception cref="InvalidOperationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidOperation<T>(this IThrowFor @throw)
   {
      InvalidOperation(@throw);
      return default;
   }
   
   /// <inheritdoc cref="InvalidOperationException.InvalidOperationException(string?)"/>
   /// <exception cref="InvalidOperationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidOperation<T>(this IThrowFor @throw, string? message)
   {
      InvalidOperation(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="InvalidOperationException.InvalidOperationException(string?, Exception?)"/>
   /// <exception cref="InvalidOperationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidOperation<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      InvalidOperation(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
