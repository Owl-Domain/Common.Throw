#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ArithmeticException.ArithmeticException()"/>
   /// <exception cref="ArithmeticException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Arithmetic(this IThrowFor @throw)
   {
      throw new ArithmeticException();
   }
   
   /// <inheritdoc cref="ArithmeticException.ArithmeticException(string?)"/>
   /// <exception cref="ArithmeticException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Arithmetic(this IThrowFor @throw, string? message)
   {
      throw new ArithmeticException(message);
   }
   
   /// <inheritdoc cref="ArithmeticException.ArithmeticException(string?, Exception?)"/>
   /// <exception cref="ArithmeticException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Arithmetic(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new ArithmeticException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="ArithmeticException.ArithmeticException()"/>
   /// <exception cref="ArithmeticException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Arithmetic<T>(this IThrowFor @throw)
   {
      Arithmetic(@throw);
      return default;
   }
   
   /// <inheritdoc cref="ArithmeticException.ArithmeticException(string?)"/>
   /// <exception cref="ArithmeticException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Arithmetic<T>(this IThrowFor @throw, string? message)
   {
      Arithmetic(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="ArithmeticException.ArithmeticException(string?, Exception?)"/>
   /// <exception cref="ArithmeticException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Arithmetic<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      Arithmetic(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
