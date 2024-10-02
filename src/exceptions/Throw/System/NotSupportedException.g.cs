#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="NotSupportedException.NotSupportedException()"/>
   /// <exception cref="NotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotSupported(this IThrowFor @throw)
   {
      throw new NotSupportedException();
   }
   
   /// <inheritdoc cref="NotSupportedException.NotSupportedException(string?)"/>
   /// <exception cref="NotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotSupported(this IThrowFor @throw, string? message)
   {
      throw new NotSupportedException(message);
   }
   
   /// <inheritdoc cref="NotSupportedException.NotSupportedException(string?, Exception?)"/>
   /// <exception cref="NotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotSupported(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new NotSupportedException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="NotSupportedException.NotSupportedException()"/>
   /// <exception cref="NotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotSupported<T>(this IThrowFor @throw)
   {
      NotSupported(@throw);
      return default;
   }
   
   /// <inheritdoc cref="NotSupportedException.NotSupportedException(string?)"/>
   /// <exception cref="NotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotSupported<T>(this IThrowFor @throw, string? message)
   {
      NotSupported(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="NotSupportedException.NotSupportedException(string?, Exception?)"/>
   /// <exception cref="NotSupportedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotSupported<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      NotSupported(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
