#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="UnreachableException.UnreachableException()"/>
   /// <exception cref="UnreachableException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Unreachable(this IThrowFor @throw)
   {
      throw new UnreachableException();
   }
   
   /// <inheritdoc cref="UnreachableException.UnreachableException(string?)"/>
   /// <exception cref="UnreachableException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Unreachable(this IThrowFor @throw, string? message)
   {
      throw new UnreachableException(message);
   }
   
   /// <inheritdoc cref="UnreachableException.UnreachableException(string?, Exception?)"/>
   /// <exception cref="UnreachableException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Unreachable(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new UnreachableException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="UnreachableException.UnreachableException()"/>
   /// <exception cref="UnreachableException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Unreachable<T>(this IThrowFor @throw)
   {
      Unreachable(@throw);
      return default;
   }
   
   /// <inheritdoc cref="UnreachableException.UnreachableException(string?)"/>
   /// <exception cref="UnreachableException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Unreachable<T>(this IThrowFor @throw, string? message)
   {
      Unreachable(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="UnreachableException.UnreachableException(string?, Exception?)"/>
   /// <exception cref="UnreachableException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Unreachable<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      Unreachable(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
