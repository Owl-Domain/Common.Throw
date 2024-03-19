using System.Security;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="VerificationException()"/>
   /// <exception cref="VerificationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Verification(this IThrow @throw)
   {
      throw new VerificationException();
   }

   /// <inheritdoc cref="VerificationException(string)"/>
   /// <exception cref="VerificationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Verification(this IThrow @throw, string? message)
   {
      throw new VerificationException(message);
   }

   /// <inheritdoc cref="VerificationException(string, Exception)"/>
   /// <exception cref="VerificationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Verification(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new VerificationException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="VerificationException()"/>
   /// <exception cref="VerificationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Verification<T>(this IThrow @throw)
   {
      Verification(@throw);
      return default!;
   }

   /// <inheritdoc cref="VerificationException(string)"/>
   /// <exception cref="VerificationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Verification<T>(this IThrow @throw, string? message)
   {
      Verification(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="VerificationException(string, Exception)"/>
   /// <exception cref="VerificationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Verification<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      Verification(@throw, message, innerException);
      return default!;
   }
   #endregion
}
