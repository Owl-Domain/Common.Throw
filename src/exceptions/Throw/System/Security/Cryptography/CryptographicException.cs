using System.Security.Cryptography;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="CryptographicException()"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Cryptographic(this IThrow @throw)
   {
      throw new CryptographicException();
   }

   /// <inheritdoc cref="CryptographicException(int)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Cryptographic(this IThrow @throw, int hr)
   {
      throw new CryptographicException(hr);
   }

   /// <inheritdoc cref="CryptographicException(string)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Cryptographic(this IThrow @throw, string? message)
   {
      throw new CryptographicException(message);
   }

   /// <inheritdoc cref="CryptographicException(string, Exception)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Cryptographic(this IThrow @throw, string? message, Exception? inner)
   {
      throw new CryptographicException(message, inner);
   }

   /// <inheritdoc cref="CryptographicException(string, string)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Cryptographic(this IThrow @throw, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, string? insert)
   {
      throw new CryptographicException(format, insert);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="CryptographicException()"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Cryptographic<T>(this IThrow @throw)
   {
      Cryptographic(@throw);
      return default!;
   }

   /// <inheritdoc cref="CryptographicException(int)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Cryptographic<T>(this IThrow @throw, int hr)
   {
      Cryptographic(@throw, hr);
      return default!;
   }

   /// <inheritdoc cref="CryptographicException(string)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Cryptographic<T>(this IThrow @throw, string? message)
   {
      Cryptographic(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="CryptographicException(string, Exception)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Cryptographic<T>(this IThrow @throw, string? message, Exception? inner)
   {
      Cryptographic(@throw, message, inner);
      return default!;
   }

   /// <inheritdoc cref="CryptographicException(string, string)"/>
   /// <exception cref="CryptographicException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Cryptographic<T>(this IThrow @throw, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, string? insert)
   {
      Cryptographic(@throw, format, insert);
      return default!;
   }
   #endregion
}
