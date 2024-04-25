namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="OperationCanceledException()"/>
   /// <exception cref="OperationCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void OperationCanceled(this IThrowFor @throw)
   {
      throw new OperationCanceledException();
   }

   /// <inheritdoc cref="OperationCanceledException(string)"/>
   /// <exception cref="OperationCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void OperationCanceled(this IThrowFor @throw, string? message)
   {
      throw new OperationCanceledException(message);
   }

   /// <inheritdoc cref="OperationCanceledException(string, Exception)"/>
   /// <exception cref="OperationCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void OperationCanceled(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new OperationCanceledException(message, innerException);
   }

   /// <inheritdoc cref="OperationCanceledException(CancellationToken)"/>
   /// <exception cref="OperationCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void OperationCanceled(this IThrowFor @throw, CancellationToken token)
   {
      throw new OperationCanceledException(token);
   }

   /// <inheritdoc cref="OperationCanceledException(string, CancellationToken)"/>
   /// <exception cref="OperationCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void OperationCanceled(this IThrowFor @throw, string? message, CancellationToken token)
   {
      throw new OperationCanceledException(message, token);
   }

   /// <inheritdoc cref="OperationCanceledException(string, Exception, CancellationToken)"/>
   /// <exception cref="OperationCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void OperationCanceled(this IThrowFor @throw, string? message, Exception? innerException, CancellationToken token)
   {
      throw new OperationCanceledException(message, innerException, token);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="OperationCanceledException()"/>
   /// <exception cref="OperationCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T OperationCanceled<T>(this IThrowFor @throw)
   {
      OperationCanceled(@throw);
      return default!;
   }

   /// <inheritdoc cref="OperationCanceledException(string)"/>
   /// <exception cref="OperationCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T OperationCanceled<T>(this IThrowFor @throw, string? message)
   {
      OperationCanceled(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="OperationCanceledException(string, Exception)"/>
   /// <exception cref="OperationCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T OperationCanceled<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      OperationCanceled(@throw, message, innerException);
      return default!;
   }

   /// <inheritdoc cref="OperationCanceledException(CancellationToken)"/>
   /// <exception cref="OperationCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T OperationCanceled<T>(this IThrowFor @throw, CancellationToken token)
   {
      OperationCanceled(@throw, token);
      return default!;
   }

   /// <inheritdoc cref="OperationCanceledException(string, CancellationToken)"/>
   /// <exception cref="OperationCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T OperationCanceled<T>(this IThrowFor @throw, string? message, CancellationToken token)
   {
      OperationCanceled(@throw, message, token);
      return default!;
   }

   /// <inheritdoc cref="OperationCanceledException(string, Exception, CancellationToken)"/>
   /// <exception cref="OperationCanceledException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T OperationCanceled<T>(this IThrowFor @throw, string? message, Exception? innerException, CancellationToken token)
   {
      OperationCanceled(@throw, message, innerException, token);
      return default!;
   }
   #endregion
}
