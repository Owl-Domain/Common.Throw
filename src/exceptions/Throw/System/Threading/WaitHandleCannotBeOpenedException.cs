namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="WaitHandleCannotBeOpenedException()"/>
   /// <exception cref="WaitHandleCannotBeOpenedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void WaitHandleCannotBeOpened(this IThrow @throw)
   {
      throw new WaitHandleCannotBeOpenedException();
   }

   /// <inheritdoc cref="WaitHandleCannotBeOpenedException(string)"/>
   /// <exception cref="WaitHandleCannotBeOpenedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void WaitHandleCannotBeOpened(this IThrow @throw, string? message)
   {
      throw new WaitHandleCannotBeOpenedException(message);
   }

   /// <inheritdoc cref="WaitHandleCannotBeOpenedException(string, Exception)"/>
   /// <exception cref="WaitHandleCannotBeOpenedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void WaitHandleCannotBeOpened(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new WaitHandleCannotBeOpenedException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="WaitHandleCannotBeOpenedException()"/>
   /// <exception cref="WaitHandleCannotBeOpenedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T WaitHandleCannotBeOpened<T>(this IThrow @throw)
   {
      WaitHandleCannotBeOpened(@throw);
      return default!;
   }

   /// <inheritdoc cref="WaitHandleCannotBeOpenedException(string)"/>
   /// <exception cref="WaitHandleCannotBeOpenedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T WaitHandleCannotBeOpened<T>(this IThrow @throw, string? message)
   {
      WaitHandleCannotBeOpened(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="WaitHandleCannotBeOpenedException(string, Exception)"/>
   /// <exception cref="WaitHandleCannotBeOpenedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T WaitHandleCannotBeOpened<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      WaitHandleCannotBeOpened(@throw, message, innerException);
      return default!;
   }
   #endregion
}
