#nullable enable

using System.IO;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="PathTooLongException.PathTooLongException()"/>
   /// <exception cref="PathTooLongException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void PathTooLong(this IThrowFor @throw)
   {
      throw new PathTooLongException();
   }
   
   /// <inheritdoc cref="PathTooLongException.PathTooLongException(string?)"/>
   /// <exception cref="PathTooLongException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void PathTooLong(this IThrowFor @throw, string? message)
   {
      throw new PathTooLongException(message);
   }
   
   /// <inheritdoc cref="PathTooLongException.PathTooLongException(string?, Exception?)"/>
   /// <exception cref="PathTooLongException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void PathTooLong(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new PathTooLongException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="PathTooLongException.PathTooLongException()"/>
   /// <exception cref="PathTooLongException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T PathTooLong<T>(this IThrowFor @throw)
   {
      PathTooLong(@throw);
      return default;
   }
   
   /// <inheritdoc cref="PathTooLongException.PathTooLongException(string?)"/>
   /// <exception cref="PathTooLongException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T PathTooLong<T>(this IThrowFor @throw, string? message)
   {
      PathTooLong(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="PathTooLongException.PathTooLongException(string?, Exception?)"/>
   /// <exception cref="PathTooLongException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T PathTooLong<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      PathTooLong(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
