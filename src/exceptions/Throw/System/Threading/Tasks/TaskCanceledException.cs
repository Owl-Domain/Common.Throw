namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TaskCanceledException()"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskCanceled(this IThrow @throw)
   {
      throw new TaskCanceledException();
   }

   /// <inheritdoc cref="TaskCanceledException(string)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskCanceled(this IThrow @throw, string? message)
   {
      throw new TaskCanceledException(message);
   }

   /// <inheritdoc cref="TaskCanceledException(string, Exception)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskCanceled(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new TaskCanceledException(message, innerException);
   }

   /// <inheritdoc cref="TaskCanceledException(string, Exception, CancellationToken)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskCanceled(this IThrow @throw, string? message, Exception? innerException, CancellationToken token)
   {
      throw new TaskCanceledException(message, innerException, token);
   }

   /// <inheritdoc cref="TaskCanceledException(Task)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskCanceled(this IThrow @throw, Task? task)
   {
      throw new TaskCanceledException(task);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="TaskCanceledException()"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskCanceled<T>(this IThrow @throw)
   {
      TaskCanceled(@throw);
      return default!;
   }

   /// <inheritdoc cref="TaskCanceledException(string)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskCanceled<T>(this IThrow @throw, string? message)
   {
      TaskCanceled(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="TaskCanceledException(string, Exception)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskCanceled<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      TaskCanceled(@throw, message, innerException);
      return default!;
   }

   /// <inheritdoc cref="TaskCanceledException(string, Exception, CancellationToken)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskCanceled<T>(this IThrow @throw, string? message, Exception? innerException, CancellationToken token)
   {
      TaskCanceled(@throw, message, innerException, token);
      return default!;
   }

   /// <inheritdoc cref="TaskCanceledException(Task)"/>
   /// <exception cref="TaskCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskCanceled<T>(this IThrow @throw, Task? task)
   {
      TaskCanceled(@throw, task);
      return default!;
   }
   #endregion
}
