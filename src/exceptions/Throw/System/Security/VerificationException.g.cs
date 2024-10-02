#nullable enable

using System.Security;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="VerificationException.VerificationException()"/>
   /// <exception cref="VerificationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Verification(this IThrowFor @throw)
   {
      throw new VerificationException();
   }
   
   /// <inheritdoc cref="VerificationException.VerificationException(string?)"/>
   /// <exception cref="VerificationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Verification(this IThrowFor @throw, string? message)
   {
      throw new VerificationException(message);
   }
   
   /// <inheritdoc cref="VerificationException.VerificationException(string?, Exception?)"/>
   /// <exception cref="VerificationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Verification(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new VerificationException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="VerificationException.VerificationException()"/>
   /// <exception cref="VerificationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Verification<T>(this IThrowFor @throw)
   {
      Verification(@throw);
      return default;
   }
   
   /// <inheritdoc cref="VerificationException.VerificationException(string?)"/>
   /// <exception cref="VerificationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Verification<T>(this IThrowFor @throw, string? message)
   {
      Verification(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="VerificationException.VerificationException(string?, Exception?)"/>
   /// <exception cref="VerificationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Verification<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      Verification(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
