#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ThreadStateException.ThreadStateException()"/>
   /// <exception cref="ThreadStateException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ThreadState(this IThrowFor @throw)
   {
      throw new ThreadStateException();
   }
   
   /// <inheritdoc cref="ThreadStateException.ThreadStateException(string?)"/>
   /// <exception cref="ThreadStateException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ThreadState(this IThrowFor @throw, string? message)
   {
      throw new ThreadStateException(message);
   }
   
   /// <inheritdoc cref="ThreadStateException.ThreadStateException(string?, Exception?)"/>
   /// <exception cref="ThreadStateException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ThreadState(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new ThreadStateException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="ThreadStateException.ThreadStateException()"/>
   /// <exception cref="ThreadStateException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ThreadState<T>(this IThrowFor @throw)
   {
      ThreadState(@throw);
      return default;
   }
   
   /// <inheritdoc cref="ThreadStateException.ThreadStateException(string?)"/>
   /// <exception cref="ThreadStateException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ThreadState<T>(this IThrowFor @throw, string? message)
   {
      ThreadState(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="ThreadStateException.ThreadStateException(string?, Exception?)"/>
   /// <exception cref="ThreadStateException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ThreadState<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      ThreadState(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
