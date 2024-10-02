#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="OutOfMemoryException.OutOfMemoryException()"/>
   /// <exception cref="OutOfMemoryException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void OutOfMemory(this IThrowFor @throw)
   {
      throw new OutOfMemoryException();
   }
   
   /// <inheritdoc cref="OutOfMemoryException.OutOfMemoryException(string?)"/>
   /// <exception cref="OutOfMemoryException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void OutOfMemory(this IThrowFor @throw, string? message)
   {
      throw new OutOfMemoryException(message);
   }
   
   /// <inheritdoc cref="OutOfMemoryException.OutOfMemoryException(string?, Exception?)"/>
   /// <exception cref="OutOfMemoryException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void OutOfMemory(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new OutOfMemoryException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="OutOfMemoryException.OutOfMemoryException()"/>
   /// <exception cref="OutOfMemoryException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T OutOfMemory<T>(this IThrowFor @throw)
   {
      OutOfMemory(@throw);
      return default;
   }
   
   /// <inheritdoc cref="OutOfMemoryException.OutOfMemoryException(string?)"/>
   /// <exception cref="OutOfMemoryException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T OutOfMemory<T>(this IThrowFor @throw, string? message)
   {
      OutOfMemory(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="OutOfMemoryException.OutOfMemoryException(string?, Exception?)"/>
   /// <exception cref="OutOfMemoryException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T OutOfMemory<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      OutOfMemory(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
