#nullable enable

using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SafeArrayRankMismatchException.SafeArrayRankMismatchException()"/>
   /// <exception cref="SafeArrayRankMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SafeArrayRankMismatch(this IThrowFor @throw)
   {
      throw new SafeArrayRankMismatchException();
   }
   
   /// <inheritdoc cref="SafeArrayRankMismatchException.SafeArrayRankMismatchException(string?)"/>
   /// <exception cref="SafeArrayRankMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SafeArrayRankMismatch(this IThrowFor @throw, string? message)
   {
      throw new SafeArrayRankMismatchException(message);
   }
   
   /// <inheritdoc cref="SafeArrayRankMismatchException.SafeArrayRankMismatchException(string?, Exception?)"/>
   /// <exception cref="SafeArrayRankMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SafeArrayRankMismatch(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new SafeArrayRankMismatchException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="SafeArrayRankMismatchException.SafeArrayRankMismatchException()"/>
   /// <exception cref="SafeArrayRankMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SafeArrayRankMismatch<T>(this IThrowFor @throw)
   {
      SafeArrayRankMismatch(@throw);
      return default;
   }
   
   /// <inheritdoc cref="SafeArrayRankMismatchException.SafeArrayRankMismatchException(string?)"/>
   /// <exception cref="SafeArrayRankMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SafeArrayRankMismatch<T>(this IThrowFor @throw, string? message)
   {
      SafeArrayRankMismatch(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="SafeArrayRankMismatchException.SafeArrayRankMismatchException(string?, Exception?)"/>
   /// <exception cref="SafeArrayRankMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SafeArrayRankMismatch<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      SafeArrayRankMismatch(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
