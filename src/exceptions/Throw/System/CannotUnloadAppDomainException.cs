namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="CannotUnloadAppDomainException()"/>
   /// <exception cref="CannotUnloadAppDomainException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CannotUnloadAppDomain(this IThrow @throw)
   {
      throw new CannotUnloadAppDomainException();
   }

   /// <inheritdoc cref="CannotUnloadAppDomainException(string)"/>
   /// <exception cref="CannotUnloadAppDomainException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CannotUnloadAppDomain(this IThrow @throw, string? message)
   {
      throw new CannotUnloadAppDomainException(message);
   }

   /// <inheritdoc cref="CannotUnloadAppDomainException(string, Exception)"/>
   /// <exception cref="CannotUnloadAppDomainException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CannotUnloadAppDomain(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new CannotUnloadAppDomainException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="CannotUnloadAppDomainException()"/>
   /// <exception cref="CannotUnloadAppDomainException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CannotUnloadAppDomain<T>(this IThrow @throw)
   {
      CannotUnloadAppDomain(@throw);
      return default!;
   }

   /// <inheritdoc cref="CannotUnloadAppDomainException(string)"/>
   /// <exception cref="CannotUnloadAppDomainException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CannotUnloadAppDomain<T>(this IThrow @throw, string? message)
   {
      CannotUnloadAppDomain(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="CannotUnloadAppDomainException(string, Exception)"/>
   /// <exception cref="CannotUnloadAppDomainException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CannotUnloadAppDomain<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      CannotUnloadAppDomain(@throw, message, innerException);
      return default!;
   }
   #endregion
}
