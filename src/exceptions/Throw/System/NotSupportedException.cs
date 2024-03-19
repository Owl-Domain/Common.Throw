namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="NotSupportedException()"/>
   /// <exception cref="NotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotSupported(this IThrow @throw)
   {
      throw new NotSupportedException();
   }

   /// <inheritdoc cref="NotSupportedException(string)"/>
   /// <exception cref="NotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotSupported(this IThrow @throw, string? message)
   {
      throw new NotSupportedException(message);
   }

   /// <inheritdoc cref="NotSupportedException(string, Exception)"/>
   /// <exception cref="NotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotSupported(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new NotSupportedException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="NotSupportedException()"/>
   /// <exception cref="NotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotSupported<T>(this IThrow @throw)
   {
      NotSupported(@throw);
      return default!;
   }

   /// <inheritdoc cref="NotSupportedException(string)"/>
   /// <exception cref="NotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotSupported<T>(this IThrow @throw, string? message)
   {
      NotSupported(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="NotSupportedException(string, Exception)"/>
   /// <exception cref="NotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotSupported<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      NotSupported(@throw, message, innerException);
      return default!;
   }
   #endregion
}
