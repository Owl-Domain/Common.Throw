using System.Text;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="DecoderFallbackException()"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DecoderFallback(this IThrow @throw)
   {
      throw new DecoderFallbackException();
   }

   /// <inheritdoc cref="DecoderFallbackException(string)"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DecoderFallback(this IThrow @throw, string? message)
   {
      throw new DecoderFallbackException(message);
   }

   /// <inheritdoc cref="DecoderFallbackException(string, Exception)"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DecoderFallback(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new DecoderFallbackException(message, innerException);
   }

   /// <inheritdoc cref="DecoderFallbackException(string, Byte[], int)"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DecoderFallback(this IThrow @throw, string? message, Byte[]? bytesUnknown, int index)
   {
      throw new DecoderFallbackException(message, bytesUnknown, index);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="DecoderFallbackException()"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DecoderFallback<T>(this IThrow @throw)
   {
      DecoderFallback(@throw);
      return default!;
   }

   /// <inheritdoc cref="DecoderFallbackException(string)"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DecoderFallback<T>(this IThrow @throw, string? message)
   {
      DecoderFallback(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="DecoderFallbackException(string, Exception)"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DecoderFallback<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      DecoderFallback(@throw, message, innerException);
      return default!;
   }

   /// <inheritdoc cref="DecoderFallbackException(string, Byte[], int)"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DecoderFallback<T>(this IThrow @throw, string? message, Byte[]? bytesUnknown, int index)
   {
      DecoderFallback(@throw, message, bytesUnknown, index);
      return default!;
   }
   #endregion
}
