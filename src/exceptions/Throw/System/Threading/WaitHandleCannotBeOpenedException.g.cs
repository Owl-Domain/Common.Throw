#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="WaitHandleCannotBeOpenedException.WaitHandleCannotBeOpenedException()"/>
   /// <exception cref="WaitHandleCannotBeOpenedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void WaitHandleCannotBeOpened(this IThrowFor @throw)
   {
      throw new WaitHandleCannotBeOpenedException();
   }
   
   /// <inheritdoc cref="WaitHandleCannotBeOpenedException.WaitHandleCannotBeOpenedException(string?)"/>
   /// <exception cref="WaitHandleCannotBeOpenedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void WaitHandleCannotBeOpened(this IThrowFor @throw, string? message)
   {
      throw new WaitHandleCannotBeOpenedException(message);
   }
   
   /// <inheritdoc cref="WaitHandleCannotBeOpenedException.WaitHandleCannotBeOpenedException(string?, Exception?)"/>
   /// <exception cref="WaitHandleCannotBeOpenedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void WaitHandleCannotBeOpened(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new WaitHandleCannotBeOpenedException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="WaitHandleCannotBeOpenedException.WaitHandleCannotBeOpenedException()"/>
   /// <exception cref="WaitHandleCannotBeOpenedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T WaitHandleCannotBeOpened<T>(this IThrowFor @throw)
   {
      WaitHandleCannotBeOpened(@throw);
      return default;
   }
   
   /// <inheritdoc cref="WaitHandleCannotBeOpenedException.WaitHandleCannotBeOpenedException(string?)"/>
   /// <exception cref="WaitHandleCannotBeOpenedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T WaitHandleCannotBeOpened<T>(this IThrowFor @throw, string? message)
   {
      WaitHandleCannotBeOpened(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="WaitHandleCannotBeOpenedException.WaitHandleCannotBeOpenedException(string?, Exception?)"/>
   /// <exception cref="WaitHandleCannotBeOpenedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T WaitHandleCannotBeOpened<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      WaitHandleCannotBeOpened(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
