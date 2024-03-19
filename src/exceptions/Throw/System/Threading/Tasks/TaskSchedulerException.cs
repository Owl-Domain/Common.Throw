namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TaskSchedulerException()"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskScheduler(this IThrow @throw)
   {
      throw new TaskSchedulerException();
   }

   /// <inheritdoc cref="TaskSchedulerException(string)"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskScheduler(this IThrow @throw, string? message)
   {
      throw new TaskSchedulerException(message);
   }

   /// <inheritdoc cref="TaskSchedulerException(Exception)"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskScheduler(this IThrow @throw, Exception? innerException)
   {
      throw new TaskSchedulerException(innerException);
   }

   /// <inheritdoc cref="TaskSchedulerException(string, Exception)"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TaskScheduler(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new TaskSchedulerException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="TaskSchedulerException()"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskScheduler<T>(this IThrow @throw)
   {
      TaskScheduler(@throw);
      return default!;
   }

   /// <inheritdoc cref="TaskSchedulerException(string)"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskScheduler<T>(this IThrow @throw, string? message)
   {
      TaskScheduler(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="TaskSchedulerException(Exception)"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskScheduler<T>(this IThrow @throw, Exception? innerException)
   {
      TaskScheduler(@throw, innerException);
      return default!;
   }

   /// <inheritdoc cref="TaskSchedulerException(string, Exception)"/>
   /// <exception cref="TaskSchedulerException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TaskScheduler<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      TaskScheduler(@throw, message, innerException);
      return default!;
   }
   #endregion
}
