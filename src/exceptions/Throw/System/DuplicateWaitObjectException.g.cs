#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="DuplicateWaitObjectException.DuplicateWaitObjectException()"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DuplicateWaitObject(this IThrowFor @throw)
   {
      throw new DuplicateWaitObjectException();
   }
   
   /// <inheritdoc cref="DuplicateWaitObjectException.DuplicateWaitObjectException(string?)"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DuplicateWaitObject(this IThrowFor @throw, string? parameterName)
   {
      throw new DuplicateWaitObjectException(parameterName);
   }
   
   /// <inheritdoc cref="DuplicateWaitObjectException.DuplicateWaitObjectException(string?, string?)"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DuplicateWaitObject(this IThrowFor @throw, string? parameterName, string? message)
   {
      throw new DuplicateWaitObjectException(parameterName, message);
   }
   
   /// <inheritdoc cref="DuplicateWaitObjectException.DuplicateWaitObjectException(string?, Exception?)"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DuplicateWaitObject(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new DuplicateWaitObjectException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="DuplicateWaitObjectException.DuplicateWaitObjectException()"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DuplicateWaitObject<T>(this IThrowFor @throw)
   {
      DuplicateWaitObject(@throw);
      return default;
   }
   
   /// <inheritdoc cref="DuplicateWaitObjectException.DuplicateWaitObjectException(string?)"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DuplicateWaitObject<T>(this IThrowFor @throw, string? parameterName)
   {
      DuplicateWaitObject(@throw, parameterName);
      return default;
   }
   
   /// <inheritdoc cref="DuplicateWaitObjectException.DuplicateWaitObjectException(string?, string?)"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DuplicateWaitObject<T>(this IThrowFor @throw, string? parameterName, string? message)
   {
      DuplicateWaitObject(@throw, parameterName, message);
      return default;
   }
   
   /// <inheritdoc cref="DuplicateWaitObjectException.DuplicateWaitObjectException(string?, Exception?)"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DuplicateWaitObject<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      DuplicateWaitObject(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
