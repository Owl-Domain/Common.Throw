namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="OverflowException()"/>
   /// <exception cref="OverflowException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Overflow(this IThrow @throw)
   {
      throw new OverflowException();
   }

   /// <inheritdoc cref="OverflowException(string)"/>
   /// <exception cref="OverflowException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Overflow(this IThrow @throw, string? message)
   {
      throw new OverflowException(message);
   }

   /// <inheritdoc cref="OverflowException(string, Exception)"/>
   /// <exception cref="OverflowException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Overflow(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new OverflowException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="OverflowException()"/>
   /// <exception cref="OverflowException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Overflow<T>(this IThrow @throw)
   {
      Overflow(@throw);
      return default!;
   }

   /// <inheritdoc cref="OverflowException(string)"/>
   /// <exception cref="OverflowException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Overflow<T>(this IThrow @throw, string? message)
   {
      Overflow(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="OverflowException(string, Exception)"/>
   /// <exception cref="OverflowException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Overflow<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      Overflow(@throw, message, innerException);
      return default!;
   }
   #endregion
}
