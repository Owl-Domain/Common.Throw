#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="AbandonedMutexException.AbandonedMutexException()"/>
   /// <exception cref="AbandonedMutexException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AbandonedMutex(this IThrowFor @throw)
   {
      throw new AbandonedMutexException();
   }
   
   /// <inheritdoc cref="AbandonedMutexException.AbandonedMutexException(string?)"/>
   /// <exception cref="AbandonedMutexException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AbandonedMutex(this IThrowFor @throw, string? message)
   {
      throw new AbandonedMutexException(message);
   }
   
   /// <inheritdoc cref="AbandonedMutexException.AbandonedMutexException(string?, Exception?)"/>
   /// <exception cref="AbandonedMutexException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AbandonedMutex(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new AbandonedMutexException(message, inner);
   }
   
   /// <inheritdoc cref="AbandonedMutexException.AbandonedMutexException(int, WaitHandle?)"/>
   /// <exception cref="AbandonedMutexException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AbandonedMutex(this IThrowFor @throw, int location, WaitHandle? handle)
   {
      throw new AbandonedMutexException(location, handle);
   }
   
   /// <inheritdoc cref="AbandonedMutexException.AbandonedMutexException(string?, int, WaitHandle?)"/>
   /// <exception cref="AbandonedMutexException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AbandonedMutex(this IThrowFor @throw, string? message, int location, WaitHandle? handle)
   {
      throw new AbandonedMutexException(message, location, handle);
   }
   
   /// <inheritdoc cref="AbandonedMutexException.AbandonedMutexException(string?, Exception?, int, WaitHandle?)"/>
   /// <exception cref="AbandonedMutexException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AbandonedMutex(this IThrowFor @throw, string? message, Exception? inner, int location, WaitHandle? handle)
   {
      throw new AbandonedMutexException(message, inner, location, handle);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="AbandonedMutexException.AbandonedMutexException()"/>
   /// <exception cref="AbandonedMutexException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AbandonedMutex<T>(this IThrowFor @throw)
   {
      AbandonedMutex(@throw);
      return default;
   }
   
   /// <inheritdoc cref="AbandonedMutexException.AbandonedMutexException(string?)"/>
   /// <exception cref="AbandonedMutexException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AbandonedMutex<T>(this IThrowFor @throw, string? message)
   {
      AbandonedMutex(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="AbandonedMutexException.AbandonedMutexException(string?, Exception?)"/>
   /// <exception cref="AbandonedMutexException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AbandonedMutex<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      AbandonedMutex(@throw, message, inner);
      return default;
   }
   
   /// <inheritdoc cref="AbandonedMutexException.AbandonedMutexException(int, WaitHandle?)"/>
   /// <exception cref="AbandonedMutexException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AbandonedMutex<T>(this IThrowFor @throw, int location, WaitHandle? handle)
   {
      AbandonedMutex(@throw, location, handle);
      return default;
   }
   
   /// <inheritdoc cref="AbandonedMutexException.AbandonedMutexException(string?, int, WaitHandle?)"/>
   /// <exception cref="AbandonedMutexException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AbandonedMutex<T>(this IThrowFor @throw, string? message, int location, WaitHandle? handle)
   {
      AbandonedMutex(@throw, message, location, handle);
      return default;
   }
   
   /// <inheritdoc cref="AbandonedMutexException.AbandonedMutexException(string?, Exception?, int, WaitHandle?)"/>
   /// <exception cref="AbandonedMutexException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AbandonedMutex<T>(this IThrowFor @throw, string? message, Exception? inner, int location, WaitHandle? handle)
   {
      AbandonedMutex(@throw, message, inner, location, handle);
      return default;
   }
   #endregion
}

#nullable restore
