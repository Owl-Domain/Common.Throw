namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ArgumentOutOfRangeException()"/>
   /// <exception cref="ArgumentOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArgumentOutOfRange(this IThrowFor @throw)
   {
      throw new ArgumentOutOfRangeException();
   }

   /// <inheritdoc cref="ArgumentOutOfRangeException(string)"/>
   /// <exception cref="ArgumentOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArgumentOutOfRange(this IThrowFor @throw, string? paramName)
   {
      throw new ArgumentOutOfRangeException(paramName);
   }

   /// <inheritdoc cref="ArgumentOutOfRangeException(string, string)"/>
   /// <exception cref="ArgumentOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArgumentOutOfRange(this IThrowFor @throw, string? paramName, string? message)
   {
      throw new ArgumentOutOfRangeException(paramName, message);
   }

   /// <inheritdoc cref="ArgumentOutOfRangeException(string, Exception)"/>
   /// <exception cref="ArgumentOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArgumentOutOfRange(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new ArgumentOutOfRangeException(message, innerException);
   }

   /// <inheritdoc cref="ArgumentOutOfRangeException(string, Object, string)"/>
   /// <exception cref="ArgumentOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArgumentOutOfRange(this IThrowFor @throw, string? paramName, Object? actualValue, string? message)
   {
      throw new ArgumentOutOfRangeException(paramName, actualValue, message);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="ArgumentOutOfRangeException()"/>
   /// <exception cref="ArgumentOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArgumentOutOfRange<T>(this IThrowFor @throw)
   {
      ArgumentOutOfRange(@throw);
      return default!;
   }

   /// <inheritdoc cref="ArgumentOutOfRangeException(string)"/>
   /// <exception cref="ArgumentOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArgumentOutOfRange<T>(this IThrowFor @throw, string? paramName)
   {
      ArgumentOutOfRange(@throw, paramName);
      return default!;
   }

   /// <inheritdoc cref="ArgumentOutOfRangeException(string, string)"/>
   /// <exception cref="ArgumentOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArgumentOutOfRange<T>(this IThrowFor @throw, string? paramName, string? message)
   {
      ArgumentOutOfRange(@throw, paramName, message);
      return default!;
   }

   /// <inheritdoc cref="ArgumentOutOfRangeException(string, Exception)"/>
   /// <exception cref="ArgumentOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArgumentOutOfRange<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      ArgumentOutOfRange(@throw, message, innerException);
      return default!;
   }

   /// <inheritdoc cref="ArgumentOutOfRangeException(string, Object, string)"/>
   /// <exception cref="ArgumentOutOfRangeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArgumentOutOfRange<T>(this IThrowFor @throw, string? paramName, Object? actualValue, string? message)
   {
      ArgumentOutOfRange(@throw, paramName, actualValue, message);
      return default!;
   }
   #endregion
}
