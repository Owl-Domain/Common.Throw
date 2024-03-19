namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SynchronizationLockException()"/>
   /// <exception cref="SynchronizationLockException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SynchronizationLock(this IThrow @throw)
   {
      throw new SynchronizationLockException();
   }

   /// <inheritdoc cref="SynchronizationLockException(string)"/>
   /// <exception cref="SynchronizationLockException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SynchronizationLock(this IThrow @throw, string? message)
   {
      throw new SynchronizationLockException(message);
   }

   /// <inheritdoc cref="SynchronizationLockException(string, Exception)"/>
   /// <exception cref="SynchronizationLockException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SynchronizationLock(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new SynchronizationLockException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="SynchronizationLockException()"/>
   /// <exception cref="SynchronizationLockException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SynchronizationLock<T>(this IThrow @throw)
   {
      SynchronizationLock(@throw);
      return default!;
   }

   /// <inheritdoc cref="SynchronizationLockException(string)"/>
   /// <exception cref="SynchronizationLockException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SynchronizationLock<T>(this IThrow @throw, string? message)
   {
      SynchronizationLock(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="SynchronizationLockException(string, Exception)"/>
   /// <exception cref="SynchronizationLockException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SynchronizationLock<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      SynchronizationLock(@throw, message, innerException);
      return default!;
   }
   #endregion
}
