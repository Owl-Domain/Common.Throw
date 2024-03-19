namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ArgumentNullException()"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArgumentNull(this IThrow @throw)
   {
      throw new ArgumentNullException();
   }

   /// <inheritdoc cref="ArgumentNullException(string)"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArgumentNull(this IThrow @throw, string? paramName)
   {
      throw new ArgumentNullException(paramName);
   }

   /// <inheritdoc cref="ArgumentNullException(string, Exception)"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArgumentNull(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new ArgumentNullException(message, innerException);
   }

   /// <inheritdoc cref="ArgumentNullException(string, string)"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArgumentNull(this IThrow @throw, string? paramName, string? message)
   {
      throw new ArgumentNullException(paramName, message);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="ArgumentNullException()"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArgumentNull<T>(this IThrow @throw)
   {
      ArgumentNull(@throw);
      return default!;
   }

   /// <inheritdoc cref="ArgumentNullException(string)"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArgumentNull<T>(this IThrow @throw, string? paramName)
   {
      ArgumentNull(@throw, paramName);
      return default!;
   }

   /// <inheritdoc cref="ArgumentNullException(string, Exception)"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArgumentNull<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      ArgumentNull(@throw, message, innerException);
      return default!;
   }

   /// <inheritdoc cref="ArgumentNullException(string, string)"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArgumentNull<T>(this IThrow @throw, string? paramName, string? message)
   {
      ArgumentNull(@throw, paramName, message);
      return default!;
   }
   #endregion
}
