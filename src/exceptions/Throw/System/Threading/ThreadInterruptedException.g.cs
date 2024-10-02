#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ThreadInterruptedException.ThreadInterruptedException()"/>
   /// <exception cref="ThreadInterruptedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ThreadInterrupted(this IThrowFor @throw)
   {
      throw new ThreadInterruptedException();
   }
   
   /// <inheritdoc cref="ThreadInterruptedException.ThreadInterruptedException(string?)"/>
   /// <exception cref="ThreadInterruptedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ThreadInterrupted(this IThrowFor @throw, string? message)
   {
      throw new ThreadInterruptedException(message);
   }
   
   /// <inheritdoc cref="ThreadInterruptedException.ThreadInterruptedException(string?, Exception?)"/>
   /// <exception cref="ThreadInterruptedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ThreadInterrupted(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new ThreadInterruptedException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="ThreadInterruptedException.ThreadInterruptedException()"/>
   /// <exception cref="ThreadInterruptedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ThreadInterrupted<T>(this IThrowFor @throw)
   {
      ThreadInterrupted(@throw);
      return default;
   }
   
   /// <inheritdoc cref="ThreadInterruptedException.ThreadInterruptedException(string?)"/>
   /// <exception cref="ThreadInterruptedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ThreadInterrupted<T>(this IThrowFor @throw, string? message)
   {
      ThreadInterrupted(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="ThreadInterruptedException.ThreadInterruptedException(string?, Exception?)"/>
   /// <exception cref="ThreadInterruptedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ThreadInterrupted<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      ThreadInterrupted(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
