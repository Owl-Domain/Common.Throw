using System.Diagnostics;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="UnreachableException()"/>
   /// <exception cref="UnreachableException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Unreachable(this IThrowFor @throw)
   {
      throw new UnreachableException();
   }

   /// <inheritdoc cref="UnreachableException(string)"/>
   /// <exception cref="UnreachableException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Unreachable(this IThrowFor @throw, string? message)
   {
      throw new UnreachableException(message);
   }

   /// <inheritdoc cref="UnreachableException(string, Exception)"/>
   /// <exception cref="UnreachableException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Unreachable(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new UnreachableException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="UnreachableException()"/>
   /// <exception cref="UnreachableException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Unreachable<T>(this IThrowFor @throw)
   {
      Unreachable(@throw);
      return default!;
   }

   /// <inheritdoc cref="UnreachableException(string)"/>
   /// <exception cref="UnreachableException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Unreachable<T>(this IThrowFor @throw, string? message)
   {
      Unreachable(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="UnreachableException(string, Exception)"/>
   /// <exception cref="UnreachableException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Unreachable<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      Unreachable(@throw, message, innerException);
      return default!;
   }
   #endregion
}
