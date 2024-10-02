#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="OverflowException.OverflowException()"/>
   /// <exception cref="OverflowException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Overflow(this IThrowFor @throw)
   {
      throw new OverflowException();
   }
   
   /// <inheritdoc cref="OverflowException.OverflowException(string?)"/>
   /// <exception cref="OverflowException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Overflow(this IThrowFor @throw, string? message)
   {
      throw new OverflowException(message);
   }
   
   /// <inheritdoc cref="OverflowException.OverflowException(string?, Exception?)"/>
   /// <exception cref="OverflowException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Overflow(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new OverflowException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="OverflowException.OverflowException()"/>
   /// <exception cref="OverflowException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Overflow<T>(this IThrowFor @throw)
   {
      Overflow(@throw);
      return default;
   }
   
   /// <inheritdoc cref="OverflowException.OverflowException(string?)"/>
   /// <exception cref="OverflowException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Overflow<T>(this IThrowFor @throw, string? message)
   {
      Overflow(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="OverflowException.OverflowException(string?, Exception?)"/>
   /// <exception cref="OverflowException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Overflow<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      Overflow(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
