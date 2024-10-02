#nullable enable

using System.Security.Cryptography;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="CryptographicException.CryptographicException()"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Cryptographic(this IThrowFor @throw)
   {
      throw new CryptographicException();
   }
   
   /// <inheritdoc cref="CryptographicException.CryptographicException(int)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Cryptographic(this IThrowFor @throw, int hr)
   {
      throw new CryptographicException(hr);
   }
   
   /// <inheritdoc cref="CryptographicException.CryptographicException(string?)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Cryptographic(this IThrowFor @throw, string? message)
   {
      throw new CryptographicException(message);
   }
   
   /// <inheritdoc cref="CryptographicException.CryptographicException(string?, Exception?)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Cryptographic(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new CryptographicException(message, inner);
   }
   
   /// <inheritdoc cref="CryptographicException.CryptographicException(string, string?)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Cryptographic(this IThrowFor @throw, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, string? insert)
   {
      throw new CryptographicException(format, insert);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="CryptographicException.CryptographicException()"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Cryptographic<T>(this IThrowFor @throw)
   {
      Cryptographic(@throw);
      return default;
   }
   
   /// <inheritdoc cref="CryptographicException.CryptographicException(int)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Cryptographic<T>(this IThrowFor @throw, int hr)
   {
      Cryptographic(@throw, hr);
      return default;
   }
   
   /// <inheritdoc cref="CryptographicException.CryptographicException(string?)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Cryptographic<T>(this IThrowFor @throw, string? message)
   {
      Cryptographic(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="CryptographicException.CryptographicException(string?, Exception?)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Cryptographic<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      Cryptographic(@throw, message, inner);
      return default;
   }
   
   /// <inheritdoc cref="CryptographicException.CryptographicException(string, string?)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Cryptographic<T>(this IThrowFor @throw, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, string? insert)
   {
      Cryptographic(@throw, format, insert);
      return default;
   }
   #endregion
}

#nullable restore
