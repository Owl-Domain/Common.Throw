using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SafeArrayTypeMismatchException()"/>
   /// <exception cref="SafeArrayTypeMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SafeArrayTypeMismatch(this IThrow @throw)
   {
      throw new SafeArrayTypeMismatchException();
   }

   /// <inheritdoc cref="SafeArrayTypeMismatchException(string)"/>
   /// <exception cref="SafeArrayTypeMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SafeArrayTypeMismatch(this IThrow @throw, string? message)
   {
      throw new SafeArrayTypeMismatchException(message);
   }

   /// <inheritdoc cref="SafeArrayTypeMismatchException(string, Exception)"/>
   /// <exception cref="SafeArrayTypeMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SafeArrayTypeMismatch(this IThrow @throw, string? message, Exception? inner)
   {
      throw new SafeArrayTypeMismatchException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="SafeArrayTypeMismatchException()"/>
   /// <exception cref="SafeArrayTypeMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SafeArrayTypeMismatch<T>(this IThrow @throw)
   {
      SafeArrayTypeMismatch(@throw);
      return default!;
   }

   /// <inheritdoc cref="SafeArrayTypeMismatchException(string)"/>
   /// <exception cref="SafeArrayTypeMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SafeArrayTypeMismatch<T>(this IThrow @throw, string? message)
   {
      SafeArrayTypeMismatch(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="SafeArrayTypeMismatchException(string, Exception)"/>
   /// <exception cref="SafeArrayTypeMismatchException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SafeArrayTypeMismatch<T>(this IThrow @throw, string? message, Exception? inner)
   {
      SafeArrayTypeMismatch(@throw, message, inner);
      return default!;
   }
   #endregion
}
