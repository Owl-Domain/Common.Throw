namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="AccessViolationException()"/>
   /// <exception cref="AccessViolationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AccessViolation(this IThrow @throw)
   {
      throw new AccessViolationException();
   }

   /// <inheritdoc cref="AccessViolationException(string)"/>
   /// <exception cref="AccessViolationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AccessViolation(this IThrow @throw, string? message)
   {
      throw new AccessViolationException(message);
   }

   /// <inheritdoc cref="AccessViolationException(string, Exception)"/>
   /// <exception cref="AccessViolationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AccessViolation(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new AccessViolationException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="AccessViolationException()"/>
   /// <exception cref="AccessViolationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AccessViolation<T>(this IThrow @throw)
   {
      AccessViolation(@throw);
      return default!;
   }

   /// <inheritdoc cref="AccessViolationException(string)"/>
   /// <exception cref="AccessViolationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AccessViolation<T>(this IThrow @throw, string? message)
   {
      AccessViolation(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="AccessViolationException(string, Exception)"/>
   /// <exception cref="AccessViolationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AccessViolation<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      AccessViolation(@throw, message, innerException);
      return default!;
   }
   #endregion
}
