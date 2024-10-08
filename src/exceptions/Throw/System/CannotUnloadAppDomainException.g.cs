#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="CannotUnloadAppDomainException.CannotUnloadAppDomainException()"/>
   /// <exception cref="CannotUnloadAppDomainException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CannotUnloadAppDomain(this IThrowFor @throw)
   {
      throw new CannotUnloadAppDomainException();
   }
   
   /// <inheritdoc cref="CannotUnloadAppDomainException.CannotUnloadAppDomainException(string?)"/>
   /// <exception cref="CannotUnloadAppDomainException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CannotUnloadAppDomain(this IThrowFor @throw, string? message)
   {
      throw new CannotUnloadAppDomainException(message);
   }
   
   /// <inheritdoc cref="CannotUnloadAppDomainException.CannotUnloadAppDomainException(string?, Exception?)"/>
   /// <exception cref="CannotUnloadAppDomainException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CannotUnloadAppDomain(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new CannotUnloadAppDomainException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="CannotUnloadAppDomainException.CannotUnloadAppDomainException()"/>
   /// <exception cref="CannotUnloadAppDomainException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CannotUnloadAppDomain<T>(this IThrowFor @throw)
   {
      CannotUnloadAppDomain(@throw);
      return default;
   }
   
   /// <inheritdoc cref="CannotUnloadAppDomainException.CannotUnloadAppDomainException(string?)"/>
   /// <exception cref="CannotUnloadAppDomainException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CannotUnloadAppDomain<T>(this IThrowFor @throw, string? message)
   {
      CannotUnloadAppDomain(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="CannotUnloadAppDomainException.CannotUnloadAppDomainException(string?, Exception?)"/>
   /// <exception cref="CannotUnloadAppDomainException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CannotUnloadAppDomain<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      CannotUnloadAppDomain(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
