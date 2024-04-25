namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="IndexOutOfRangeException()"/>
   /// <exception cref="IndexOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void IndexOutOfRange(this IThrowFor @throw)
   {
      throw new IndexOutOfRangeException();
   }

   /// <inheritdoc cref="IndexOutOfRangeException(string)"/>
   /// <exception cref="IndexOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void IndexOutOfRange(this IThrowFor @throw, string? message)
   {
      throw new IndexOutOfRangeException(message);
   }

   /// <inheritdoc cref="IndexOutOfRangeException(string, Exception)"/>
   /// <exception cref="IndexOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void IndexOutOfRange(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new IndexOutOfRangeException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="IndexOutOfRangeException()"/>
   /// <exception cref="IndexOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T IndexOutOfRange<T>(this IThrowFor @throw)
   {
      IndexOutOfRange(@throw);
      return default!;
   }

   /// <inheritdoc cref="IndexOutOfRangeException(string)"/>
   /// <exception cref="IndexOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T IndexOutOfRange<T>(this IThrowFor @throw, string? message)
   {
      IndexOutOfRange(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="IndexOutOfRangeException(string, Exception)"/>
   /// <exception cref="IndexOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T IndexOutOfRange<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      IndexOutOfRange(@throw, message, innerException);
      return default!;
   }
   #endregion
}
