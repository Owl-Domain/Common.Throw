#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ArrayTypeMismatchException.ArrayTypeMismatchException()"/>
   /// <exception cref="ArrayTypeMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArrayTypeMismatch(this IThrowFor @throw)
   {
      throw new ArrayTypeMismatchException();
   }
   
   /// <inheritdoc cref="ArrayTypeMismatchException.ArrayTypeMismatchException(string?)"/>
   /// <exception cref="ArrayTypeMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArrayTypeMismatch(this IThrowFor @throw, string? message)
   {
      throw new ArrayTypeMismatchException(message);
   }
   
   /// <inheritdoc cref="ArrayTypeMismatchException.ArrayTypeMismatchException(string?, Exception?)"/>
   /// <exception cref="ArrayTypeMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArrayTypeMismatch(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new ArrayTypeMismatchException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="ArrayTypeMismatchException.ArrayTypeMismatchException()"/>
   /// <exception cref="ArrayTypeMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArrayTypeMismatch<T>(this IThrowFor @throw)
   {
      ArrayTypeMismatch(@throw);
      return default;
   }
   
   /// <inheritdoc cref="ArrayTypeMismatchException.ArrayTypeMismatchException(string?)"/>
   /// <exception cref="ArrayTypeMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArrayTypeMismatch<T>(this IThrowFor @throw, string? message)
   {
      ArrayTypeMismatch(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="ArrayTypeMismatchException.ArrayTypeMismatchException(string?, Exception?)"/>
   /// <exception cref="ArrayTypeMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArrayTypeMismatch<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      ArrayTypeMismatch(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
