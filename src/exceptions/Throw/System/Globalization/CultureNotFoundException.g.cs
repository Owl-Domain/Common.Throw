#nullable enable

using System.Globalization;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException()"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrowFor @throw)
   {
      throw new CultureNotFoundException();
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrowFor @throw, string? message)
   {
      throw new CultureNotFoundException(message);
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?, string?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrowFor @throw, string? paramName, string? message)
   {
      throw new CultureNotFoundException(paramName, message);
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?, Exception?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new CultureNotFoundException(message, innerException);
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?, string?, string?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrowFor @throw, string? paramName, string? invalidCultureName, string? message)
   {
      throw new CultureNotFoundException(paramName, invalidCultureName, message);
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?, string?, Exception?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrowFor @throw, string? message, string? invalidCultureName, Exception? innerException)
   {
      throw new CultureNotFoundException(message, invalidCultureName, innerException);
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?, int, Exception?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrowFor @throw, string? message, int invalidCultureId, Exception? innerException)
   {
      throw new CultureNotFoundException(message, invalidCultureId, innerException);
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?, int, string?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CultureNotFound(this IThrowFor @throw, string? paramName, int invalidCultureId, string? message)
   {
      throw new CultureNotFoundException(paramName, invalidCultureId, message);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException()"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrowFor @throw)
   {
      CultureNotFound(@throw);
      return default;
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrowFor @throw, string? message)
   {
      CultureNotFound(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?, string?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrowFor @throw, string? paramName, string? message)
   {
      CultureNotFound(@throw, paramName, message);
      return default;
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?, Exception?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      CultureNotFound(@throw, message, innerException);
      return default;
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?, string?, string?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrowFor @throw, string? paramName, string? invalidCultureName, string? message)
   {
      CultureNotFound(@throw, paramName, invalidCultureName, message);
      return default;
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?, string?, Exception?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrowFor @throw, string? message, string? invalidCultureName, Exception? innerException)
   {
      CultureNotFound(@throw, message, invalidCultureName, innerException);
      return default;
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?, int, Exception?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrowFor @throw, string? message, int invalidCultureId, Exception? innerException)
   {
      CultureNotFound(@throw, message, invalidCultureId, innerException);
      return default;
   }
   
   /// <inheritdoc cref="CultureNotFoundException.CultureNotFoundException(string?, int, string?)"/>
   /// <exception cref="CultureNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CultureNotFound<T>(this IThrowFor @throw, string? paramName, int invalidCultureId, string? message)
   {
      CultureNotFound(@throw, paramName, invalidCultureId, message);
      return default;
   }
   #endregion
}

#nullable restore
