namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="NotFiniteNumberException()"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotFiniteNumber(this IThrow @throw)
   {
      throw new NotFiniteNumberException();
   }

   /// <inheritdoc cref="NotFiniteNumberException(Double)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotFiniteNumber(this IThrow @throw, Double offendingNumber)
   {
      throw new NotFiniteNumberException(offendingNumber);
   }

   /// <inheritdoc cref="NotFiniteNumberException(string)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotFiniteNumber(this IThrow @throw, string? message)
   {
      throw new NotFiniteNumberException(message);
   }

   /// <inheritdoc cref="NotFiniteNumberException(string, Double)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotFiniteNumber(this IThrow @throw, string? message, Double offendingNumber)
   {
      throw new NotFiniteNumberException(message, offendingNumber);
   }

   /// <inheritdoc cref="NotFiniteNumberException(string, Exception)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotFiniteNumber(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new NotFiniteNumberException(message, innerException);
   }

   /// <inheritdoc cref="NotFiniteNumberException(string, Double, Exception)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotFiniteNumber(this IThrow @throw, string? message, Double offendingNumber, Exception? innerException)
   {
      throw new NotFiniteNumberException(message, offendingNumber, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="NotFiniteNumberException()"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotFiniteNumber<T>(this IThrow @throw)
   {
      NotFiniteNumber(@throw);
      return default!;
   }

   /// <inheritdoc cref="NotFiniteNumberException(Double)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotFiniteNumber<T>(this IThrow @throw, Double offendingNumber)
   {
      NotFiniteNumber(@throw, offendingNumber);
      return default!;
   }

   /// <inheritdoc cref="NotFiniteNumberException(string)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotFiniteNumber<T>(this IThrow @throw, string? message)
   {
      NotFiniteNumber(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="NotFiniteNumberException(string, Double)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotFiniteNumber<T>(this IThrow @throw, string? message, Double offendingNumber)
   {
      NotFiniteNumber(@throw, message, offendingNumber);
      return default!;
   }

   /// <inheritdoc cref="NotFiniteNumberException(string, Exception)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotFiniteNumber<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      NotFiniteNumber(@throw, message, innerException);
      return default!;
   }

   /// <inheritdoc cref="NotFiniteNumberException(string, Double, Exception)"/>
   /// <exception cref="NotFiniteNumberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotFiniteNumber<T>(this IThrow @throw, string? message, Double offendingNumber, Exception? innerException)
   {
      NotFiniteNumber(@throw, message, offendingNumber, innerException);
      return default!;
   }
   #endregion
}
