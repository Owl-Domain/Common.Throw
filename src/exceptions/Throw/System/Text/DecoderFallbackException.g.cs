#nullable enable

using System.Text;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="DecoderFallbackException.DecoderFallbackException()"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DecoderFallback(this IThrowFor @throw)
   {
      throw new DecoderFallbackException();
   }
   
   /// <inheritdoc cref="DecoderFallbackException.DecoderFallbackException(string?)"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DecoderFallback(this IThrowFor @throw, string? message)
   {
      throw new DecoderFallbackException(message);
   }
   
   /// <inheritdoc cref="DecoderFallbackException.DecoderFallbackException(string?, Exception?)"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DecoderFallback(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new DecoderFallbackException(message, innerException);
   }
   
   /// <inheritdoc cref="DecoderFallbackException.DecoderFallbackException(string?, byte[], int)"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DecoderFallback(this IThrowFor @throw, string? message, byte[]? bytesUnknown, int index)
   {
      throw new DecoderFallbackException(message, bytesUnknown, index);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="DecoderFallbackException.DecoderFallbackException()"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DecoderFallback<T>(this IThrowFor @throw)
   {
      DecoderFallback(@throw);
      return default;
   }
   
   /// <inheritdoc cref="DecoderFallbackException.DecoderFallbackException(string?)"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DecoderFallback<T>(this IThrowFor @throw, string? message)
   {
      DecoderFallback(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="DecoderFallbackException.DecoderFallbackException(string?, Exception?)"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DecoderFallback<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      DecoderFallback(@throw, message, innerException);
      return default;
   }
   
   /// <inheritdoc cref="DecoderFallbackException.DecoderFallbackException(string?, byte[], int)"/>
   /// <exception cref="DecoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DecoderFallback<T>(this IThrowFor @throw, string? message, byte[]? bytesUnknown, int index)
   {
      DecoderFallback(@throw, message, bytesUnknown, index);
      return default;
   }
   #endregion
}

#nullable restore
