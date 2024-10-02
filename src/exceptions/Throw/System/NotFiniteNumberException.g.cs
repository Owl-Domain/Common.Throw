#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="NotFiniteNumberException.NotFiniteNumberException()"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotFiniteNumber(this IThrowFor @throw)
   {
      throw new NotFiniteNumberException();
   }
   
   /// <inheritdoc cref="NotFiniteNumberException.NotFiniteNumberException(double)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotFiniteNumber(this IThrowFor @throw, double offendingNumber)
   {
      throw new NotFiniteNumberException(offendingNumber);
   }
   
   /// <inheritdoc cref="NotFiniteNumberException.NotFiniteNumberException(string?)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotFiniteNumber(this IThrowFor @throw, string? message)
   {
      throw new NotFiniteNumberException(message);
   }
   
   /// <inheritdoc cref="NotFiniteNumberException.NotFiniteNumberException(string?, double)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotFiniteNumber(this IThrowFor @throw, string? message, double offendingNumber)
   {
      throw new NotFiniteNumberException(message, offendingNumber);
   }
   
   /// <inheritdoc cref="NotFiniteNumberException.NotFiniteNumberException(string?, Exception?)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotFiniteNumber(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new NotFiniteNumberException(message, innerException);
   }
   
   /// <inheritdoc cref="NotFiniteNumberException.NotFiniteNumberException(string?, double, Exception?)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotFiniteNumber(this IThrowFor @throw, string? message, double offendingNumber, Exception? innerException)
   {
      throw new NotFiniteNumberException(message, offendingNumber, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="NotFiniteNumberException.NotFiniteNumberException()"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotFiniteNumber<T>(this IThrowFor @throw)
   {
      NotFiniteNumber(@throw);
      return default;
   }
   
   /// <inheritdoc cref="NotFiniteNumberException.NotFiniteNumberException(double)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotFiniteNumber<T>(this IThrowFor @throw, double offendingNumber)
   {
      NotFiniteNumber(@throw, offendingNumber);
      return default;
   }
   
   /// <inheritdoc cref="NotFiniteNumberException.NotFiniteNumberException(string?)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotFiniteNumber<T>(this IThrowFor @throw, string? message)
   {
      NotFiniteNumber(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="NotFiniteNumberException.NotFiniteNumberException(string?, double)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotFiniteNumber<T>(this IThrowFor @throw, string? message, double offendingNumber)
   {
      NotFiniteNumber(@throw, message, offendingNumber);
      return default;
   }
   
   /// <inheritdoc cref="NotFiniteNumberException.NotFiniteNumberException(string?, Exception?)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotFiniteNumber<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      NotFiniteNumber(@throw, message, innerException);
      return default;
   }
   
   /// <inheritdoc cref="NotFiniteNumberException.NotFiniteNumberException(string?, double, Exception?)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotFiniteNumber<T>(this IThrowFor @throw, string? message, double offendingNumber, Exception? innerException)
   {
      NotFiniteNumber(@throw, message, offendingNumber, innerException);
      return default;
   }
   #endregion
}

#nullable restore
