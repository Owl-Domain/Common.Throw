using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InvalidOleVariantTypeException()"/>
   /// <exception cref="InvalidOleVariantTypeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidOleVariantType(this IThrow @throw)
   {
      throw new InvalidOleVariantTypeException();
   }

   /// <inheritdoc cref="InvalidOleVariantTypeException(string)"/>
   /// <exception cref="InvalidOleVariantTypeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidOleVariantType(this IThrow @throw, string? message)
   {
      throw new InvalidOleVariantTypeException(message);
   }

   /// <inheritdoc cref="InvalidOleVariantTypeException(string, Exception)"/>
   /// <exception cref="InvalidOleVariantTypeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidOleVariantType(this IThrow @throw, string? message, Exception? inner)
   {
      throw new InvalidOleVariantTypeException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="InvalidOleVariantTypeException()"/>
   /// <exception cref="InvalidOleVariantTypeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidOleVariantType<T>(this IThrow @throw)
   {
      InvalidOleVariantType(@throw);
      return default!;
   }

   /// <inheritdoc cref="InvalidOleVariantTypeException(string)"/>
   /// <exception cref="InvalidOleVariantTypeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidOleVariantType<T>(this IThrow @throw, string? message)
   {
      InvalidOleVariantType(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="InvalidOleVariantTypeException(string, Exception)"/>
   /// <exception cref="InvalidOleVariantTypeException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidOleVariantType<T>(this IThrow @throw, string? message, Exception? inner)
   {
      InvalidOleVariantType(@throw, message, inner);
      return default!;
   }
   #endregion
}
