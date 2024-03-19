namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SemaphoreFullException()"/>
   /// <exception cref="SemaphoreFullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SemaphoreFull(this IThrow @throw)
   {
      throw new SemaphoreFullException();
   }

   /// <inheritdoc cref="SemaphoreFullException(string)"/>
   /// <exception cref="SemaphoreFullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SemaphoreFull(this IThrow @throw, string? message)
   {
      throw new SemaphoreFullException(message);
   }

   /// <inheritdoc cref="SemaphoreFullException(string, Exception)"/>
   /// <exception cref="SemaphoreFullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SemaphoreFull(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new SemaphoreFullException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="SemaphoreFullException()"/>
   /// <exception cref="SemaphoreFullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SemaphoreFull<T>(this IThrow @throw)
   {
      SemaphoreFull(@throw);
      return default!;
   }

   /// <inheritdoc cref="SemaphoreFullException(string)"/>
   /// <exception cref="SemaphoreFullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SemaphoreFull<T>(this IThrow @throw, string? message)
   {
      SemaphoreFull(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="SemaphoreFullException(string, Exception)"/>
   /// <exception cref="SemaphoreFullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SemaphoreFull<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      SemaphoreFull(@throw, message, innerException);
      return default!;
   }
   #endregion
}
