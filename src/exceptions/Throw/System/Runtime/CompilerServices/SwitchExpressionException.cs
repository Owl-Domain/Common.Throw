using System.Runtime.CompilerServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SwitchExpressionException()"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SwitchExpression(this IThrow @throw)
   {
      throw new SwitchExpressionException();
   }

   /// <inheritdoc cref="SwitchExpressionException(Exception)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SwitchExpression(this IThrow @throw, Exception? innerException)
   {
      throw new SwitchExpressionException(innerException);
   }

   /// <inheritdoc cref="SwitchExpressionException(Object)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SwitchExpression(this IThrow @throw, Object? unmatchedValue)
   {
      throw new SwitchExpressionException(unmatchedValue);
   }

   /// <inheritdoc cref="SwitchExpressionException(string)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SwitchExpression(this IThrow @throw, string? message)
   {
      throw new SwitchExpressionException(message);
   }

   /// <inheritdoc cref="SwitchExpressionException(string, Exception)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SwitchExpression(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new SwitchExpressionException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="SwitchExpressionException()"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SwitchExpression<T>(this IThrow @throw)
   {
      SwitchExpression(@throw);
      return default!;
   }

   /// <inheritdoc cref="SwitchExpressionException(Exception)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SwitchExpression<T>(this IThrow @throw, Exception? innerException)
   {
      SwitchExpression(@throw, innerException);
      return default!;
   }

   /// <inheritdoc cref="SwitchExpressionException(Object)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SwitchExpression<T>(this IThrow @throw, Object? unmatchedValue)
   {
      SwitchExpression(@throw, unmatchedValue);
      return default!;
   }

   /// <inheritdoc cref="SwitchExpressionException(string)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SwitchExpression<T>(this IThrow @throw, string? message)
   {
      SwitchExpression(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="SwitchExpressionException(string, Exception)"/>
   /// <exception cref="SwitchExpressionException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SwitchExpression<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      SwitchExpression(@throw, message, innerException);
      return default!;
   }
   #endregion
}
