using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SafeArrayRankMismatchException()"/>
   /// <exception cref="SafeArrayRankMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SafeArrayRankMismatch(this IThrowFor @throw)
   {
      throw new SafeArrayRankMismatchException();
   }

   /// <inheritdoc cref="SafeArrayRankMismatchException(string)"/>
   /// <exception cref="SafeArrayRankMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SafeArrayRankMismatch(this IThrowFor @throw, string? message)
   {
      throw new SafeArrayRankMismatchException(message);
   }

   /// <inheritdoc cref="SafeArrayRankMismatchException(string, Exception)"/>
   /// <exception cref="SafeArrayRankMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SafeArrayRankMismatch(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new SafeArrayRankMismatchException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="SafeArrayRankMismatchException()"/>
   /// <exception cref="SafeArrayRankMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SafeArrayRankMismatch<T>(this IThrowFor @throw)
   {
      SafeArrayRankMismatch(@throw);
      return default!;
   }

   /// <inheritdoc cref="SafeArrayRankMismatchException(string)"/>
   /// <exception cref="SafeArrayRankMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SafeArrayRankMismatch<T>(this IThrowFor @throw, string? message)
   {
      SafeArrayRankMismatch(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="SafeArrayRankMismatchException(string, Exception)"/>
   /// <exception cref="SafeArrayRankMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SafeArrayRankMismatch<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      SafeArrayRankMismatch(@throw, message, inner);
      return default!;
   }
   #endregion
}
