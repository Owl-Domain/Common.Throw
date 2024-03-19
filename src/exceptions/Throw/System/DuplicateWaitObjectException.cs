namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="DuplicateWaitObjectException()"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DuplicateWaitObject(this IThrow @throw)
   {
      throw new DuplicateWaitObjectException();
   }

   /// <inheritdoc cref="DuplicateWaitObjectException(string)"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DuplicateWaitObject(this IThrow @throw, string? parameterName)
   {
      throw new DuplicateWaitObjectException(parameterName);
   }

   /// <inheritdoc cref="DuplicateWaitObjectException(string, string)"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DuplicateWaitObject(this IThrow @throw, string? parameterName, string? message)
   {
      throw new DuplicateWaitObjectException(parameterName, message);
   }

   /// <inheritdoc cref="DuplicateWaitObjectException(string, Exception)"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DuplicateWaitObject(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new DuplicateWaitObjectException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="DuplicateWaitObjectException()"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DuplicateWaitObject<T>(this IThrow @throw)
   {
      DuplicateWaitObject(@throw);
      return default!;
   }

   /// <inheritdoc cref="DuplicateWaitObjectException(string)"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DuplicateWaitObject<T>(this IThrow @throw, string? parameterName)
   {
      DuplicateWaitObject(@throw, parameterName);
      return default!;
   }

   /// <inheritdoc cref="DuplicateWaitObjectException(string, string)"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DuplicateWaitObject<T>(this IThrow @throw, string? parameterName, string? message)
   {
      DuplicateWaitObject(@throw, parameterName, message);
      return default!;
   }

   /// <inheritdoc cref="DuplicateWaitObjectException(string, Exception)"/>
   /// <exception cref="DuplicateWaitObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DuplicateWaitObject<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      DuplicateWaitObject(@throw, message, innerException);
      return default!;
   }
   #endregion
}
