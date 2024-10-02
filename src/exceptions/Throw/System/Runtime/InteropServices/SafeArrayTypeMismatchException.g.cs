#nullable enable

using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SafeArrayTypeMismatchException.SafeArrayTypeMismatchException()"/>
   /// <exception cref="SafeArrayTypeMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SafeArrayTypeMismatch(this IThrowFor @throw)
   {
      throw new SafeArrayTypeMismatchException();
   }
   
   /// <inheritdoc cref="SafeArrayTypeMismatchException.SafeArrayTypeMismatchException(string?)"/>
   /// <exception cref="SafeArrayTypeMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SafeArrayTypeMismatch(this IThrowFor @throw, string? message)
   {
      throw new SafeArrayTypeMismatchException(message);
   }
   
   /// <inheritdoc cref="SafeArrayTypeMismatchException.SafeArrayTypeMismatchException(string?, Exception?)"/>
   /// <exception cref="SafeArrayTypeMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SafeArrayTypeMismatch(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new SafeArrayTypeMismatchException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="SafeArrayTypeMismatchException.SafeArrayTypeMismatchException()"/>
   /// <exception cref="SafeArrayTypeMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SafeArrayTypeMismatch<T>(this IThrowFor @throw)
   {
      SafeArrayTypeMismatch(@throw);
      return default;
   }
   
   /// <inheritdoc cref="SafeArrayTypeMismatchException.SafeArrayTypeMismatchException(string?)"/>
   /// <exception cref="SafeArrayTypeMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SafeArrayTypeMismatch<T>(this IThrowFor @throw, string? message)
   {
      SafeArrayTypeMismatch(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="SafeArrayTypeMismatchException.SafeArrayTypeMismatchException(string?, Exception?)"/>
   /// <exception cref="SafeArrayTypeMismatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SafeArrayTypeMismatch<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      SafeArrayTypeMismatch(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
