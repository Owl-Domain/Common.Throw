namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ThreadStateException()"/>
   /// <exception cref="ThreadStateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ThreadState(this IThrow @throw)
   {
      throw new ThreadStateException();
   }

   /// <inheritdoc cref="ThreadStateException(string)"/>
   /// <exception cref="ThreadStateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ThreadState(this IThrow @throw, string? message)
   {
      throw new ThreadStateException(message);
   }

   /// <inheritdoc cref="ThreadStateException(string, Exception)"/>
   /// <exception cref="ThreadStateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ThreadState(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new ThreadStateException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="ThreadStateException()"/>
   /// <exception cref="ThreadStateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ThreadState<T>(this IThrow @throw)
   {
      ThreadState(@throw);
      return default!;
   }

   /// <inheritdoc cref="ThreadStateException(string)"/>
   /// <exception cref="ThreadStateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ThreadState<T>(this IThrow @throw, string? message)
   {
      ThreadState(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="ThreadStateException(string, Exception)"/>
   /// <exception cref="ThreadStateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ThreadState<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      ThreadState(@throw, message, innerException);
      return default!;
   }
   #endregion
}
