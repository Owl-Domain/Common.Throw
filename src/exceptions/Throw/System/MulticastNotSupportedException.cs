namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="MulticastNotSupportedException()"/>
   /// <exception cref="MulticastNotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MulticastNotSupported(this IThrow @throw)
   {
      throw new MulticastNotSupportedException();
   }

   /// <inheritdoc cref="MulticastNotSupportedException(string)"/>
   /// <exception cref="MulticastNotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MulticastNotSupported(this IThrow @throw, string? message)
   {
      throw new MulticastNotSupportedException(message);
   }

   /// <inheritdoc cref="MulticastNotSupportedException(string, Exception)"/>
   /// <exception cref="MulticastNotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MulticastNotSupported(this IThrow @throw, string? message, Exception? inner)
   {
      throw new MulticastNotSupportedException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="MulticastNotSupportedException()"/>
   /// <exception cref="MulticastNotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MulticastNotSupported<T>(this IThrow @throw)
   {
      MulticastNotSupported(@throw);
      return default!;
   }

   /// <inheritdoc cref="MulticastNotSupportedException(string)"/>
   /// <exception cref="MulticastNotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MulticastNotSupported<T>(this IThrow @throw, string? message)
   {
      MulticastNotSupported(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="MulticastNotSupportedException(string, Exception)"/>
   /// <exception cref="MulticastNotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MulticastNotSupported<T>(this IThrow @throw, string? message, Exception? inner)
   {
      MulticastNotSupported(@throw, message, inner);
      return default!;
   }
   #endregion
}
