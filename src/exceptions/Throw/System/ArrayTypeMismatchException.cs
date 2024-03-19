namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ArrayTypeMismatchException()"/>
   /// <exception cref="ArrayTypeMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArrayTypeMismatch(this IThrow @throw)
   {
      throw new ArrayTypeMismatchException();
   }

   /// <inheritdoc cref="ArrayTypeMismatchException(string)"/>
   /// <exception cref="ArrayTypeMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArrayTypeMismatch(this IThrow @throw, string? message)
   {
      throw new ArrayTypeMismatchException(message);
   }

   /// <inheritdoc cref="ArrayTypeMismatchException(string, Exception)"/>
   /// <exception cref="ArrayTypeMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArrayTypeMismatch(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new ArrayTypeMismatchException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="ArrayTypeMismatchException()"/>
   /// <exception cref="ArrayTypeMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArrayTypeMismatch<T>(this IThrow @throw)
   {
      ArrayTypeMismatch(@throw);
      return default!;
   }

   /// <inheritdoc cref="ArrayTypeMismatchException(string)"/>
   /// <exception cref="ArrayTypeMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArrayTypeMismatch<T>(this IThrow @throw, string? message)
   {
      ArrayTypeMismatch(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="ArrayTypeMismatchException(string, Exception)"/>
   /// <exception cref="ArrayTypeMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArrayTypeMismatch<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      ArrayTypeMismatch(@throw, message, innerException);
      return default!;
   }
   #endregion
}
