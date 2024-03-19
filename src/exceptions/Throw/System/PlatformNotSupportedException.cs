namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="PlatformNotSupportedException()"/>
   /// <exception cref="PlatformNotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void PlatformNotSupported(this IThrow @throw)
   {
      throw new PlatformNotSupportedException();
   }

   /// <inheritdoc cref="PlatformNotSupportedException(string)"/>
   /// <exception cref="PlatformNotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void PlatformNotSupported(this IThrow @throw, string? message)
   {
      throw new PlatformNotSupportedException(message);
   }

   /// <inheritdoc cref="PlatformNotSupportedException(string, Exception)"/>
   /// <exception cref="PlatformNotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void PlatformNotSupported(this IThrow @throw, string? message, Exception? inner)
   {
      throw new PlatformNotSupportedException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="PlatformNotSupportedException()"/>
   /// <exception cref="PlatformNotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T PlatformNotSupported<T>(this IThrow @throw)
   {
      PlatformNotSupported(@throw);
      return default!;
   }

   /// <inheritdoc cref="PlatformNotSupportedException(string)"/>
   /// <exception cref="PlatformNotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T PlatformNotSupported<T>(this IThrow @throw, string? message)
   {
      PlatformNotSupported(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="PlatformNotSupportedException(string, Exception)"/>
   /// <exception cref="PlatformNotSupportedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T PlatformNotSupported<T>(this IThrow @throw, string? message, Exception? inner)
   {
      PlatformNotSupported(@throw, message, inner);
      return default!;
   }
   #endregion
}
