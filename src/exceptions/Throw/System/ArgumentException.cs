namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ArgumentException()"/>
   /// <exception cref="ArgumentException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Argument(this IThrowFor @throw)
   {
      throw new ArgumentException();
   }

   /// <inheritdoc cref="ArgumentException(string)"/>
   /// <exception cref="ArgumentException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Argument(this IThrowFor @throw, string? message)
   {
      throw new ArgumentException(message);
   }

   /// <inheritdoc cref="ArgumentException(string, Exception)"/>
   /// <exception cref="ArgumentException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Argument(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new ArgumentException(message, innerException);
   }

   /// <inheritdoc cref="ArgumentException(string, string, Exception)"/>
   /// <exception cref="ArgumentException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Argument(this IThrowFor @throw, string? message, string? paramName, Exception? innerException)
   {
      throw new ArgumentException(message, paramName, innerException);
   }

   /// <inheritdoc cref="ArgumentException(string, string)"/>
   /// <exception cref="ArgumentException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Argument(this IThrowFor @throw, string? message, string? paramName)
   {
      throw new ArgumentException(message, paramName);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="ArgumentException()"/>
   /// <exception cref="ArgumentException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Argument<T>(this IThrowFor @throw)
   {
      Argument(@throw);
      return default!;
   }

   /// <inheritdoc cref="ArgumentException(string)"/>
   /// <exception cref="ArgumentException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Argument<T>(this IThrowFor @throw, string? message)
   {
      Argument(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="ArgumentException(string, Exception)"/>
   /// <exception cref="ArgumentException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Argument<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      Argument(@throw, message, innerException);
      return default!;
   }

   /// <inheritdoc cref="ArgumentException(string, string, Exception)"/>
   /// <exception cref="ArgumentException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Argument<T>(this IThrowFor @throw, string? message, string? paramName, Exception? innerException)
   {
      Argument(@throw, message, paramName, innerException);
      return default!;
   }

   /// <inheritdoc cref="ArgumentException(string, string)"/>
   /// <exception cref="ArgumentException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Argument<T>(this IThrowFor @throw, string? message, string? paramName)
   {
      Argument(@throw, message, paramName);
      return default!;
   }
   #endregion
}
