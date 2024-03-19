namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="BadImageFormatException()"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void BadImageFormat(this IThrow @throw)
   {
      throw new BadImageFormatException();
   }

   /// <inheritdoc cref="BadImageFormatException(string)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void BadImageFormat(this IThrow @throw, string? message)
   {
      throw new BadImageFormatException(message);
   }

   /// <inheritdoc cref="BadImageFormatException(string, Exception)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void BadImageFormat(this IThrow @throw, string? message, Exception? inner)
   {
      throw new BadImageFormatException(message, inner);
   }

   /// <inheritdoc cref="BadImageFormatException(string, string)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void BadImageFormat(this IThrow @throw, string? message, string? fileName)
   {
      throw new BadImageFormatException(message, fileName);
   }

   /// <inheritdoc cref="BadImageFormatException(string, string, Exception)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void BadImageFormat(this IThrow @throw, string? message, string? fileName, Exception? inner)
   {
      throw new BadImageFormatException(message, fileName, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="BadImageFormatException()"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T BadImageFormat<T>(this IThrow @throw)
   {
      BadImageFormat(@throw);
      return default!;
   }

   /// <inheritdoc cref="BadImageFormatException(string)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T BadImageFormat<T>(this IThrow @throw, string? message)
   {
      BadImageFormat(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="BadImageFormatException(string, Exception)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T BadImageFormat<T>(this IThrow @throw, string? message, Exception? inner)
   {
      BadImageFormat(@throw, message, inner);
      return default!;
   }

   /// <inheritdoc cref="BadImageFormatException(string, string)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T BadImageFormat<T>(this IThrow @throw, string? message, string? fileName)
   {
      BadImageFormat(@throw, message, fileName);
      return default!;
   }

   /// <inheritdoc cref="BadImageFormatException(string, string, Exception)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T BadImageFormat<T>(this IThrow @throw, string? message, string? fileName, Exception? inner)
   {
      BadImageFormat(@throw, message, fileName, inner);
      return default!;
   }
   #endregion
}
