namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ThreadInterruptedException()"/>
   /// <exception cref="ThreadInterruptedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ThreadInterrupted(this IThrow @throw)
   {
      throw new ThreadInterruptedException();
   }

   /// <inheritdoc cref="ThreadInterruptedException(string)"/>
   /// <exception cref="ThreadInterruptedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ThreadInterrupted(this IThrow @throw, string? message)
   {
      throw new ThreadInterruptedException(message);
   }

   /// <inheritdoc cref="ThreadInterruptedException(string, Exception)"/>
   /// <exception cref="ThreadInterruptedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ThreadInterrupted(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new ThreadInterruptedException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="ThreadInterruptedException()"/>
   /// <exception cref="ThreadInterruptedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ThreadInterrupted<T>(this IThrow @throw)
   {
      ThreadInterrupted(@throw);
      return default!;
   }

   /// <inheritdoc cref="ThreadInterruptedException(string)"/>
   /// <exception cref="ThreadInterruptedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ThreadInterrupted<T>(this IThrow @throw, string? message)
   {
      ThreadInterrupted(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="ThreadInterruptedException(string, Exception)"/>
   /// <exception cref="ThreadInterruptedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ThreadInterrupted<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      ThreadInterrupted(@throw, message, innerException);
      return default!;
   }
   #endregion
}
