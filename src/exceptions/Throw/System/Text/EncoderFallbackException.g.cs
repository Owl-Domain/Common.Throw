#nullable enable

using System.Text;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="EncoderFallbackException.EncoderFallbackException()"/>
   /// <exception cref="EncoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EncoderFallback(this IThrowFor @throw)
   {
      throw new EncoderFallbackException();
   }
   
   /// <inheritdoc cref="EncoderFallbackException.EncoderFallbackException(string?)"/>
   /// <exception cref="EncoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EncoderFallback(this IThrowFor @throw, string? message)
   {
      throw new EncoderFallbackException(message);
   }
   
   /// <inheritdoc cref="EncoderFallbackException.EncoderFallbackException(string?, Exception?)"/>
   /// <exception cref="EncoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EncoderFallback(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new EncoderFallbackException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="EncoderFallbackException.EncoderFallbackException()"/>
   /// <exception cref="EncoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EncoderFallback<T>(this IThrowFor @throw)
   {
      EncoderFallback(@throw);
      return default;
   }
   
   /// <inheritdoc cref="EncoderFallbackException.EncoderFallbackException(string?)"/>
   /// <exception cref="EncoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EncoderFallback<T>(this IThrowFor @throw, string? message)
   {
      EncoderFallback(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="EncoderFallbackException.EncoderFallbackException(string?, Exception?)"/>
   /// <exception cref="EncoderFallbackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EncoderFallback<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      EncoderFallback(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
