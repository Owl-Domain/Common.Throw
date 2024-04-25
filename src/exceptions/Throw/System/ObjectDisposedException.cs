namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ObjectDisposedException(string)"/>
   /// <exception cref="ObjectDisposedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ObjectDisposed(this IThrowFor @throw, string? objectName)
   {
      throw new ObjectDisposedException(objectName);
   }

   /// <inheritdoc cref="ObjectDisposedException(string, string)"/>
   /// <exception cref="ObjectDisposedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ObjectDisposed(this IThrowFor @throw, string? objectName, string? message)
   {
      throw new ObjectDisposedException(objectName, message);
   }

   /// <inheritdoc cref="ObjectDisposedException(string, Exception)"/>
   /// <exception cref="ObjectDisposedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ObjectDisposed(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new ObjectDisposedException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="ObjectDisposedException(string)"/>
   /// <exception cref="ObjectDisposedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ObjectDisposed<T>(this IThrowFor @throw, string? objectName)
   {
      ObjectDisposed(@throw, objectName);
      return default!;
   }

   /// <inheritdoc cref="ObjectDisposedException(string, string)"/>
   /// <exception cref="ObjectDisposedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ObjectDisposed<T>(this IThrowFor @throw, string? objectName, string? message)
   {
      ObjectDisposed(@throw, objectName, message);
      return default!;
   }

   /// <inheritdoc cref="ObjectDisposedException(string, Exception)"/>
   /// <exception cref="ObjectDisposedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ObjectDisposed<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      ObjectDisposed(@throw, message, innerException);
      return default!;
   }
   #endregion
}
