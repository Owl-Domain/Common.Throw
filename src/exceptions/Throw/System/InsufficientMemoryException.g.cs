#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InsufficientMemoryException.InsufficientMemoryException()"/>
   /// <exception cref="InsufficientMemoryException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InsufficientMemory(this IThrowFor @throw)
   {
      throw new InsufficientMemoryException();
   }
   
   /// <inheritdoc cref="InsufficientMemoryException.InsufficientMemoryException(string?)"/>
   /// <exception cref="InsufficientMemoryException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InsufficientMemory(this IThrowFor @throw, string? message)
   {
      throw new InsufficientMemoryException(message);
   }
   
   /// <inheritdoc cref="InsufficientMemoryException.InsufficientMemoryException(string?, Exception?)"/>
   /// <exception cref="InsufficientMemoryException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InsufficientMemory(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new InsufficientMemoryException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="InsufficientMemoryException.InsufficientMemoryException()"/>
   /// <exception cref="InsufficientMemoryException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InsufficientMemory<T>(this IThrowFor @throw)
   {
      InsufficientMemory(@throw);
      return default;
   }
   
   /// <inheritdoc cref="InsufficientMemoryException.InsufficientMemoryException(string?)"/>
   /// <exception cref="InsufficientMemoryException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InsufficientMemory<T>(this IThrowFor @throw, string? message)
   {
      InsufficientMemory(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="InsufficientMemoryException.InsufficientMemoryException(string?, Exception?)"/>
   /// <exception cref="InsufficientMemoryException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InsufficientMemory<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      InsufficientMemory(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
