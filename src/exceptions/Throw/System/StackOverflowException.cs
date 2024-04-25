namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="StackOverflowException()"/>
   /// <exception cref="StackOverflowException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void StackOverflow(this IThrowFor @throw)
   {
      throw new StackOverflowException();
   }

   /// <inheritdoc cref="StackOverflowException(string)"/>
   /// <exception cref="StackOverflowException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void StackOverflow(this IThrowFor @throw, string? message)
   {
      throw new StackOverflowException(message);
   }

   /// <inheritdoc cref="StackOverflowException(string, Exception)"/>
   /// <exception cref="StackOverflowException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void StackOverflow(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new StackOverflowException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="StackOverflowException()"/>
   /// <exception cref="StackOverflowException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T StackOverflow<T>(this IThrowFor @throw)
   {
      StackOverflow(@throw);
      return default!;
   }

   /// <inheritdoc cref="StackOverflowException(string)"/>
   /// <exception cref="StackOverflowException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T StackOverflow<T>(this IThrowFor @throw, string? message)
   {
      StackOverflow(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="StackOverflowException(string, Exception)"/>
   /// <exception cref="StackOverflowException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T StackOverflow<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      StackOverflow(@throw, message, innerException);
      return default!;
   }
   #endregion
}
