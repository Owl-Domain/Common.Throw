using System.Globalization;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="CultureNotFoundException()"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrow @throw)
   {
      throw new CultureNotFoundException();
   }

   /// <inheritdoc cref="CultureNotFoundException(string)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrow @throw, string? message)
   {
      throw new CultureNotFoundException(message);
   }

   /// <inheritdoc cref="CultureNotFoundException(string, string)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrow @throw, string? paramName, string? message)
   {
      throw new CultureNotFoundException(paramName, message);
   }

   /// <inheritdoc cref="CultureNotFoundException(string, Exception)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new CultureNotFoundException(message, innerException);
   }

   /// <inheritdoc cref="CultureNotFoundException(string, string, string)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrow @throw, string? paramName, string? invalidCultureName, string? message)
   {
      throw new CultureNotFoundException(paramName, invalidCultureName, message);
   }

   /// <inheritdoc cref="CultureNotFoundException(string, string, Exception)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrow @throw, string? message, string? invalidCultureName, Exception? innerException)
   {
      throw new CultureNotFoundException(message, invalidCultureName, innerException);
   }

   /// <inheritdoc cref="CultureNotFoundException(string, int, Exception)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrow @throw, string? message, int invalidCultureId, Exception? innerException)
   {
      throw new CultureNotFoundException(message, invalidCultureId, innerException);
   }

   /// <inheritdoc cref="CultureNotFoundException(string, int, string)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrow @throw, string? paramName, int invalidCultureId, string? message)
   {
      throw new CultureNotFoundException(paramName, invalidCultureId, message);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="CultureNotFoundException()"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrow @throw)
   {
      CultureNotFound(@throw);
      return default!;
   }

   /// <inheritdoc cref="CultureNotFoundException(string)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrow @throw, string? message)
   {
      CultureNotFound(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="CultureNotFoundException(string, string)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrow @throw, string? paramName, string? message)
   {
      CultureNotFound(@throw, paramName, message);
      return default!;
   }

   /// <inheritdoc cref="CultureNotFoundException(string, Exception)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      CultureNotFound(@throw, message, innerException);
      return default!;
   }

   /// <inheritdoc cref="CultureNotFoundException(string, string, string)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrow @throw, string? paramName, string? invalidCultureName, string? message)
   {
      CultureNotFound(@throw, paramName, invalidCultureName, message);
      return default!;
   }

   /// <inheritdoc cref="CultureNotFoundException(string, string, Exception)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrow @throw, string? message, string? invalidCultureName, Exception? innerException)
   {
      CultureNotFound(@throw, message, invalidCultureName, innerException);
      return default!;
   }

   /// <inheritdoc cref="CultureNotFoundException(string, int, Exception)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrow @throw, string? message, int invalidCultureId, Exception? innerException)
   {
      CultureNotFound(@throw, message, invalidCultureId, innerException);
      return default!;
   }

   /// <inheritdoc cref="CultureNotFoundException(string, int, string)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrow @throw, string? paramName, int invalidCultureId, string? message)
   {
      CultureNotFound(@throw, paramName, invalidCultureId, message);
      return default!;
   }
   #endregion
}
