namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InsufficientMemoryException()"/>
   /// <exception cref="InsufficientMemoryException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InsufficientMemory(this IThrow @throw)
   {
      throw new InsufficientMemoryException();
   }

   /// <inheritdoc cref="InsufficientMemoryException(string)"/>
   /// <exception cref="InsufficientMemoryException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InsufficientMemory(this IThrow @throw, string? message)
   {
      throw new InsufficientMemoryException(message);
   }

   /// <inheritdoc cref="InsufficientMemoryException(string, Exception)"/>
   /// <exception cref="InsufficientMemoryException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InsufficientMemory(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new InsufficientMemoryException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="InsufficientMemoryException()"/>
   /// <exception cref="InsufficientMemoryException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InsufficientMemory<T>(this IThrow @throw)
   {
      InsufficientMemory(@throw);
      return default!;
   }

   /// <inheritdoc cref="InsufficientMemoryException(string)"/>
   /// <exception cref="InsufficientMemoryException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InsufficientMemory<T>(this IThrow @throw, string? message)
   {
      InsufficientMemory(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="InsufficientMemoryException(string, Exception)"/>
   /// <exception cref="InsufficientMemoryException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InsufficientMemory<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      InsufficientMemory(@throw, message, innerException);
      return default!;
   }
   #endregion
}
