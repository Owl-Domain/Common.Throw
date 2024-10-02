#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="AccessViolationException.AccessViolationException()"/>
   /// <exception cref="AccessViolationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AccessViolation(this IThrowFor @throw)
   {
      throw new AccessViolationException();
   }
   
   /// <inheritdoc cref="AccessViolationException.AccessViolationException(string?)"/>
   /// <exception cref="AccessViolationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AccessViolation(this IThrowFor @throw, string? message)
   {
      throw new AccessViolationException(message);
   }
   
   /// <inheritdoc cref="AccessViolationException.AccessViolationException(string?, Exception?)"/>
   /// <exception cref="AccessViolationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AccessViolation(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new AccessViolationException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="AccessViolationException.AccessViolationException()"/>
   /// <exception cref="AccessViolationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AccessViolation<T>(this IThrowFor @throw)
   {
      AccessViolation(@throw);
      return default;
   }
   
   /// <inheritdoc cref="AccessViolationException.AccessViolationException(string?)"/>
   /// <exception cref="AccessViolationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AccessViolation<T>(this IThrowFor @throw, string? message)
   {
      AccessViolation(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="AccessViolationException.AccessViolationException(string?, Exception?)"/>
   /// <exception cref="AccessViolationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AccessViolation<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      AccessViolation(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
