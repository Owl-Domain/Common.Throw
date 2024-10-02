#nullable enable

using System.IO;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="FileLoadException.FileLoadException()"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileLoad(this IThrowFor @throw)
   {
      throw new FileLoadException();
   }
   
   /// <inheritdoc cref="FileLoadException.FileLoadException(string?)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileLoad(this IThrowFor @throw, string? message)
   {
      throw new FileLoadException(message);
   }
   
   /// <inheritdoc cref="FileLoadException.FileLoadException(string?, Exception?)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileLoad(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new FileLoadException(message, inner);
   }
   
   /// <inheritdoc cref="FileLoadException.FileLoadException(string?, string?)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileLoad(this IThrowFor @throw, string? message, string? fileName)
   {
      throw new FileLoadException(message, fileName);
   }
   
   /// <inheritdoc cref="FileLoadException.FileLoadException(string?, string?, Exception?)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileLoad(this IThrowFor @throw, string? message, string? fileName, Exception? inner)
   {
      throw new FileLoadException(message, fileName, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="FileLoadException.FileLoadException()"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileLoad<T>(this IThrowFor @throw)
   {
      FileLoad(@throw);
      return default;
   }
   
   /// <inheritdoc cref="FileLoadException.FileLoadException(string?)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileLoad<T>(this IThrowFor @throw, string? message)
   {
      FileLoad(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="FileLoadException.FileLoadException(string?, Exception?)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileLoad<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      FileLoad(@throw, message, inner);
      return default;
   }
   
   /// <inheritdoc cref="FileLoadException.FileLoadException(string?, string?)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileLoad<T>(this IThrowFor @throw, string? message, string? fileName)
   {
      FileLoad(@throw, message, fileName);
      return default;
   }
   
   /// <inheritdoc cref="FileLoadException.FileLoadException(string?, string?, Exception?)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileLoad<T>(this IThrowFor @throw, string? message, string? fileName, Exception? inner)
   {
      FileLoad(@throw, message, fileName, inner);
      return default;
   }
   #endregion
}

#nullable restore
