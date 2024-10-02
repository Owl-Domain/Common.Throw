#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TaskSchedulerException.TaskSchedulerException()"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskScheduler(this IThrowFor @throw)
   {
      throw new TaskSchedulerException();
   }
   
   /// <inheritdoc cref="TaskSchedulerException.TaskSchedulerException(string?)"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskScheduler(this IThrowFor @throw, string? message)
   {
      throw new TaskSchedulerException(message);
   }
   
   /// <inheritdoc cref="TaskSchedulerException.TaskSchedulerException(Exception?)"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskScheduler(this IThrowFor @throw, Exception? innerException)
   {
      throw new TaskSchedulerException(innerException);
   }
   
   /// <inheritdoc cref="TaskSchedulerException.TaskSchedulerException(string?, Exception?)"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskScheduler(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new TaskSchedulerException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="TaskSchedulerException.TaskSchedulerException()"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskScheduler<T>(this IThrowFor @throw)
   {
      TaskScheduler(@throw);
      return default;
   }
   
   /// <inheritdoc cref="TaskSchedulerException.TaskSchedulerException(string?)"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskScheduler<T>(this IThrowFor @throw, string? message)
   {
      TaskScheduler(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="TaskSchedulerException.TaskSchedulerException(Exception?)"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskScheduler<T>(this IThrowFor @throw, Exception? innerException)
   {
      TaskScheduler(@throw, innerException);
      return default;
   }
   
   /// <inheritdoc cref="TaskSchedulerException.TaskSchedulerException(string?, Exception?)"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskScheduler<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      TaskScheduler(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
