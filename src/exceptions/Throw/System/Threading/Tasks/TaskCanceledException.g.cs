#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TaskCanceledException.TaskCanceledException()"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskCanceled(this IThrowFor @throw)
   {
      throw new TaskCanceledException();
   }
   
   /// <inheritdoc cref="TaskCanceledException.TaskCanceledException(string?)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskCanceled(this IThrowFor @throw, string? message)
   {
      throw new TaskCanceledException(message);
   }
   
   /// <inheritdoc cref="TaskCanceledException.TaskCanceledException(string?, Exception?)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskCanceled(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new TaskCanceledException(message, innerException);
   }
   
   /// <inheritdoc cref="TaskCanceledException.TaskCanceledException(string?, Exception?, CancellationToken)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskCanceled(this IThrowFor @throw, string? message, Exception? innerException, CancellationToken token)
   {
      throw new TaskCanceledException(message, innerException, token);
   }
   
   /// <inheritdoc cref="TaskCanceledException.TaskCanceledException(Task?)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskCanceled(this IThrowFor @throw, Task? task)
   {
      throw new TaskCanceledException(task);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="TaskCanceledException.TaskCanceledException()"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskCanceled<T>(this IThrowFor @throw)
   {
      TaskCanceled(@throw);
      return default;
   }
   
   /// <inheritdoc cref="TaskCanceledException.TaskCanceledException(string?)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskCanceled<T>(this IThrowFor @throw, string? message)
   {
      TaskCanceled(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="TaskCanceledException.TaskCanceledException(string?, Exception?)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskCanceled<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      TaskCanceled(@throw, message, innerException);
      return default;
   }
   
   /// <inheritdoc cref="TaskCanceledException.TaskCanceledException(string?, Exception?, CancellationToken)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskCanceled<T>(this IThrowFor @throw, string? message, Exception? innerException, CancellationToken token)
   {
      TaskCanceled(@throw, message, innerException, token);
      return default;
   }
   
   /// <inheritdoc cref="TaskCanceledException.TaskCanceledException(Task?)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskCanceled<T>(this IThrowFor @throw, Task? task)
   {
      TaskCanceled(@throw, task);
      return default;
   }
   #endregion
}

#nullable restore
