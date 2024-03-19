namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="OutOfMemoryException()"/>
   /// <exception cref="OutOfMemoryException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void OutOfMemory(this IThrow @throw)
   {
      throw new OutOfMemoryException();
   }

   /// <inheritdoc cref="OutOfMemoryException(string)"/>
   /// <exception cref="OutOfMemoryException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void OutOfMemory(this IThrow @throw, string? message)
   {
      throw new OutOfMemoryException(message);
   }

   /// <inheritdoc cref="OutOfMemoryException(string, Exception)"/>
   /// <exception cref="OutOfMemoryException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void OutOfMemory(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new OutOfMemoryException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="OutOfMemoryException()"/>
   /// <exception cref="OutOfMemoryException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T OutOfMemory<T>(this IThrow @throw)
   {
      OutOfMemory(@throw);
      return default!;
   }

   /// <inheritdoc cref="OutOfMemoryException(string)"/>
   /// <exception cref="OutOfMemoryException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T OutOfMemory<T>(this IThrow @throw, string? message)
   {
      OutOfMemory(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="OutOfMemoryException(string, Exception)"/>
   /// <exception cref="OutOfMemoryException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T OutOfMemory<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      OutOfMemory(@throw, message, innerException);
      return default!;
   }
   #endregion
}
