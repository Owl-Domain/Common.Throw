#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="BadImageFormatException.BadImageFormatException()"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void BadImageFormat(this IThrowFor @throw)
   {
      throw new BadImageFormatException();
   }
   
   /// <inheritdoc cref="BadImageFormatException.BadImageFormatException(string?)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void BadImageFormat(this IThrowFor @throw, string? message)
   {
      throw new BadImageFormatException(message);
   }
   
   /// <inheritdoc cref="BadImageFormatException.BadImageFormatException(string?, Exception?)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void BadImageFormat(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new BadImageFormatException(message, inner);
   }
   
   /// <inheritdoc cref="BadImageFormatException.BadImageFormatException(string?, string?)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void BadImageFormat(this IThrowFor @throw, string? message, string? fileName)
   {
      throw new BadImageFormatException(message, fileName);
   }
   
   /// <inheritdoc cref="BadImageFormatException.BadImageFormatException(string?, string?, Exception?)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void BadImageFormat(this IThrowFor @throw, string? message, string? fileName, Exception? inner)
   {
      throw new BadImageFormatException(message, fileName, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="BadImageFormatException.BadImageFormatException()"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T BadImageFormat<T>(this IThrowFor @throw)
   {
      BadImageFormat(@throw);
      return default;
   }
   
   /// <inheritdoc cref="BadImageFormatException.BadImageFormatException(string?)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T BadImageFormat<T>(this IThrowFor @throw, string? message)
   {
      BadImageFormat(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="BadImageFormatException.BadImageFormatException(string?, Exception?)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T BadImageFormat<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      BadImageFormat(@throw, message, inner);
      return default;
   }
   
   /// <inheritdoc cref="BadImageFormatException.BadImageFormatException(string?, string?)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T BadImageFormat<T>(this IThrowFor @throw, string? message, string? fileName)
   {
      BadImageFormat(@throw, message, fileName);
      return default;
   }
   
   /// <inheritdoc cref="BadImageFormatException.BadImageFormatException(string?, string?, Exception?)"/>
   /// <exception cref="BadImageFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T BadImageFormat<T>(this IThrowFor @throw, string? message, string? fileName, Exception? inner)
   {
      BadImageFormat(@throw, message, fileName, inner);
      return default;
   }
   #endregion
}

#nullable restore
