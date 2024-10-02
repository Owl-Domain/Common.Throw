#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="DivideByZeroException.DivideByZeroException()"/>
   /// <exception cref="DivideByZeroException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DivideByZero(this IThrowFor @throw)
   {
      throw new DivideByZeroException();
   }
   
   /// <inheritdoc cref="DivideByZeroException.DivideByZeroException(string?)"/>
   /// <exception cref="DivideByZeroException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DivideByZero(this IThrowFor @throw, string? message)
   {
      throw new DivideByZeroException(message);
   }
   
   /// <inheritdoc cref="DivideByZeroException.DivideByZeroException(string?, Exception?)"/>
   /// <exception cref="DivideByZeroException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DivideByZero(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new DivideByZeroException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="DivideByZeroException.DivideByZeroException()"/>
   /// <exception cref="DivideByZeroException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DivideByZero<T>(this IThrowFor @throw)
   {
      DivideByZero(@throw);
      return default;
   }
   
   /// <inheritdoc cref="DivideByZeroException.DivideByZeroException(string?)"/>
   /// <exception cref="DivideByZeroException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DivideByZero<T>(this IThrowFor @throw, string? message)
   {
      DivideByZero(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="DivideByZeroException.DivideByZeroException(string?, Exception?)"/>
   /// <exception cref="DivideByZeroException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DivideByZero<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      DivideByZero(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
