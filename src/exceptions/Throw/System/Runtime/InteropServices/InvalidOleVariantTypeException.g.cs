#nullable enable

using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InvalidOleVariantTypeException.InvalidOleVariantTypeException()"/>
   /// <exception cref="InvalidOleVariantTypeException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidOleVariantType(this IThrowFor @throw)
   {
      throw new InvalidOleVariantTypeException();
   }
   
   /// <inheritdoc cref="InvalidOleVariantTypeException.InvalidOleVariantTypeException(string?)"/>
   /// <exception cref="InvalidOleVariantTypeException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidOleVariantType(this IThrowFor @throw, string? message)
   {
      throw new InvalidOleVariantTypeException(message);
   }
   
   /// <inheritdoc cref="InvalidOleVariantTypeException.InvalidOleVariantTypeException(string?, Exception?)"/>
   /// <exception cref="InvalidOleVariantTypeException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidOleVariantType(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new InvalidOleVariantTypeException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="InvalidOleVariantTypeException.InvalidOleVariantTypeException()"/>
   /// <exception cref="InvalidOleVariantTypeException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidOleVariantType<T>(this IThrowFor @throw)
   {
      InvalidOleVariantType(@throw);
      return default;
   }
   
   /// <inheritdoc cref="InvalidOleVariantTypeException.InvalidOleVariantTypeException(string?)"/>
   /// <exception cref="InvalidOleVariantTypeException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidOleVariantType<T>(this IThrowFor @throw, string? message)
   {
      InvalidOleVariantType(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="InvalidOleVariantTypeException.InvalidOleVariantTypeException(string?, Exception?)"/>
   /// <exception cref="InvalidOleVariantTypeException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidOleVariantType<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      InvalidOleVariantType(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
