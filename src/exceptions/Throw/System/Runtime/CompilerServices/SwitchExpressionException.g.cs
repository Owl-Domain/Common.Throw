#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SwitchExpressionException.SwitchExpressionException()"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SwitchExpression(this IThrowFor @throw)
   {
      throw new SwitchExpressionException();
   }
   
   /// <inheritdoc cref="SwitchExpressionException.SwitchExpressionException(Exception?)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SwitchExpression(this IThrowFor @throw, Exception? innerException)
   {
      throw new SwitchExpressionException(innerException);
   }
   
   /// <inheritdoc cref="SwitchExpressionException.SwitchExpressionException(object?)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SwitchExpression(this IThrowFor @throw, object? unmatchedValue)
   {
      throw new SwitchExpressionException(unmatchedValue);
   }
   
   /// <inheritdoc cref="SwitchExpressionException.SwitchExpressionException(string?)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SwitchExpression(this IThrowFor @throw, string? message)
   {
      throw new SwitchExpressionException(message);
   }
   
   /// <inheritdoc cref="SwitchExpressionException.SwitchExpressionException(string?, Exception?)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SwitchExpression(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new SwitchExpressionException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="SwitchExpressionException.SwitchExpressionException()"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SwitchExpression<T>(this IThrowFor @throw)
   {
      SwitchExpression(@throw);
      return default;
   }
   
   /// <inheritdoc cref="SwitchExpressionException.SwitchExpressionException(Exception?)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SwitchExpression<T>(this IThrowFor @throw, Exception? innerException)
   {
      SwitchExpression(@throw, innerException);
      return default;
   }
   
   /// <inheritdoc cref="SwitchExpressionException.SwitchExpressionException(object?)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SwitchExpression<T>(this IThrowFor @throw, object? unmatchedValue)
   {
      SwitchExpression(@throw, unmatchedValue);
      return default;
   }
   
   /// <inheritdoc cref="SwitchExpressionException.SwitchExpressionException(string?)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SwitchExpression<T>(this IThrowFor @throw, string? message)
   {
      SwitchExpression(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="SwitchExpressionException.SwitchExpressionException(string?, Exception?)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SwitchExpression<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      SwitchExpression(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
