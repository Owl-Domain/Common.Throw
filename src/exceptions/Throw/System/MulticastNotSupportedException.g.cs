#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="MulticastNotSupportedException.MulticastNotSupportedException()"/>
   /// <exception cref="MulticastNotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MulticastNotSupported(this IThrowFor @throw)
   {
      throw new MulticastNotSupportedException();
   }
   
   /// <inheritdoc cref="MulticastNotSupportedException.MulticastNotSupportedException(string?)"/>
   /// <exception cref="MulticastNotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MulticastNotSupported(this IThrowFor @throw, string? message)
   {
      throw new MulticastNotSupportedException(message);
   }
   
   /// <inheritdoc cref="MulticastNotSupportedException.MulticastNotSupportedException(string?, Exception?)"/>
   /// <exception cref="MulticastNotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MulticastNotSupported(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new MulticastNotSupportedException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="MulticastNotSupportedException.MulticastNotSupportedException()"/>
   /// <exception cref="MulticastNotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MulticastNotSupported<T>(this IThrowFor @throw)
   {
      MulticastNotSupported(@throw);
      return default;
   }
   
   /// <inheritdoc cref="MulticastNotSupportedException.MulticastNotSupportedException(string?)"/>
   /// <exception cref="MulticastNotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MulticastNotSupported<T>(this IThrowFor @throw, string? message)
   {
      MulticastNotSupported(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="MulticastNotSupportedException.MulticastNotSupportedException(string?, Exception?)"/>
   /// <exception cref="MulticastNotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MulticastNotSupported<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      MulticastNotSupported(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
