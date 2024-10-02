#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="PlatformNotSupportedException.PlatformNotSupportedException()"/>
   /// <exception cref="PlatformNotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void PlatformNotSupported(this IThrowFor @throw)
   {
      throw new PlatformNotSupportedException();
   }
   
   /// <inheritdoc cref="PlatformNotSupportedException.PlatformNotSupportedException(string?)"/>
   /// <exception cref="PlatformNotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void PlatformNotSupported(this IThrowFor @throw, string? message)
   {
      throw new PlatformNotSupportedException(message);
   }
   
   /// <inheritdoc cref="PlatformNotSupportedException.PlatformNotSupportedException(string?, Exception?)"/>
   /// <exception cref="PlatformNotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void PlatformNotSupported(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new PlatformNotSupportedException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="PlatformNotSupportedException.PlatformNotSupportedException()"/>
   /// <exception cref="PlatformNotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T PlatformNotSupported<T>(this IThrowFor @throw)
   {
      PlatformNotSupported(@throw);
      return default;
   }
   
   /// <inheritdoc cref="PlatformNotSupportedException.PlatformNotSupportedException(string?)"/>
   /// <exception cref="PlatformNotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T PlatformNotSupported<T>(this IThrowFor @throw, string? message)
   {
      PlatformNotSupported(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="PlatformNotSupportedException.PlatformNotSupportedException(string?, Exception?)"/>
   /// <exception cref="PlatformNotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T PlatformNotSupported<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      PlatformNotSupported(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
