using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InvalidComObjectException()"/>
   /// <exception cref="InvalidComObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidComObject(this IThrow @throw)
   {
      throw new InvalidComObjectException();
   }

   /// <inheritdoc cref="InvalidComObjectException(string)"/>
   /// <exception cref="InvalidComObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidComObject(this IThrow @throw, string? message)
   {
      throw new InvalidComObjectException(message);
   }

   /// <inheritdoc cref="InvalidComObjectException(string, Exception)"/>
   /// <exception cref="InvalidComObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidComObject(this IThrow @throw, string? message, Exception? inner)
   {
      throw new InvalidComObjectException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="InvalidComObjectException()"/>
   /// <exception cref="InvalidComObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidComObject<T>(this IThrow @throw)
   {
      InvalidComObject(@throw);
      return default!;
   }

   /// <inheritdoc cref="InvalidComObjectException(string)"/>
   /// <exception cref="InvalidComObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidComObject<T>(this IThrow @throw, string? message)
   {
      InvalidComObject(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="InvalidComObjectException(string, Exception)"/>
   /// <exception cref="InvalidComObjectException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidComObject<T>(this IThrow @throw, string? message, Exception? inner)
   {
      InvalidComObject(@throw, message, inner);
      return default!;
   }
   #endregion
}
