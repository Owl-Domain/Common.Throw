namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="DivideByZeroException()"/>
   /// <exception cref="DivideByZeroException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DivideByZero(this IThrow @throw)
   {
      throw new DivideByZeroException();
   }

   /// <inheritdoc cref="DivideByZeroException(string)"/>
   /// <exception cref="DivideByZeroException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DivideByZero(this IThrow @throw, string? message)
   {
      throw new DivideByZeroException(message);
   }

   /// <inheritdoc cref="DivideByZeroException(string, Exception)"/>
   /// <exception cref="DivideByZeroException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DivideByZero(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new DivideByZeroException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="DivideByZeroException()"/>
   /// <exception cref="DivideByZeroException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DivideByZero<T>(this IThrow @throw)
   {
      DivideByZero(@throw);
      return default!;
   }

   /// <inheritdoc cref="DivideByZeroException(string)"/>
   /// <exception cref="DivideByZeroException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DivideByZero<T>(this IThrow @throw, string? message)
   {
      DivideByZero(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="DivideByZeroException(string, Exception)"/>
   /// <exception cref="DivideByZeroException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DivideByZero<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      DivideByZero(@throw, message, innerException);
      return default!;
   }
   #endregion
}
