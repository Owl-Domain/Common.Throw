#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="LockRecursionException.LockRecursionException()"/>
   /// <exception cref="LockRecursionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void LockRecursion(this IThrowFor @throw)
   {
      throw new LockRecursionException();
   }
   
   /// <inheritdoc cref="LockRecursionException.LockRecursionException(string?)"/>
   /// <exception cref="LockRecursionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void LockRecursion(this IThrowFor @throw, string? message)
   {
      throw new LockRecursionException(message);
   }
   
   /// <inheritdoc cref="LockRecursionException.LockRecursionException(string?, Exception?)"/>
   /// <exception cref="LockRecursionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void LockRecursion(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new LockRecursionException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="LockRecursionException.LockRecursionException()"/>
   /// <exception cref="LockRecursionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T LockRecursion<T>(this IThrowFor @throw)
   {
      LockRecursion(@throw);
      return default;
   }
   
   /// <inheritdoc cref="LockRecursionException.LockRecursionException(string?)"/>
   /// <exception cref="LockRecursionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T LockRecursion<T>(this IThrowFor @throw, string? message)
   {
      LockRecursion(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="LockRecursionException.LockRecursionException(string?, Exception?)"/>
   /// <exception cref="LockRecursionException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T LockRecursion<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      LockRecursion(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
