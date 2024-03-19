namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InvalidOperationException()"/>
   /// <exception cref="InvalidOperationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidOperation(this IThrow @throw)
   {
      throw new InvalidOperationException();
   }

   /// <inheritdoc cref="InvalidOperationException(string)"/>
   /// <exception cref="InvalidOperationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidOperation(this IThrow @throw, string? message)
   {
      throw new InvalidOperationException(message);
   }

   /// <inheritdoc cref="InvalidOperationException(string, Exception)"/>
   /// <exception cref="InvalidOperationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidOperation(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new InvalidOperationException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="InvalidOperationException()"/>
   /// <exception cref="InvalidOperationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidOperation<T>(this IThrow @throw)
   {
      InvalidOperation(@throw);
      return default!;
   }

   /// <inheritdoc cref="InvalidOperationException(string)"/>
   /// <exception cref="InvalidOperationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidOperation<T>(this IThrow @throw, string? message)
   {
      InvalidOperation(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="InvalidOperationException(string, Exception)"/>
   /// <exception cref="InvalidOperationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidOperation<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      InvalidOperation(@throw, message, innerException);
      return default!;
   }
   #endregion
}
