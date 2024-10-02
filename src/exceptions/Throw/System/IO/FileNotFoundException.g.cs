#nullable enable

using System.IO;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="FileNotFoundException.FileNotFoundException()"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileNotFound(this IThrowFor @throw)
   {
      throw new FileNotFoundException();
   }
   
   /// <inheritdoc cref="FileNotFoundException.FileNotFoundException(string?)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileNotFound(this IThrowFor @throw, string? message)
   {
      throw new FileNotFoundException(message);
   }
   
   /// <inheritdoc cref="FileNotFoundException.FileNotFoundException(string?, Exception?)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileNotFound(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new FileNotFoundException(message, innerException);
   }
   
   /// <inheritdoc cref="FileNotFoundException.FileNotFoundException(string?, string?)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileNotFound(this IThrowFor @throw, string? message, string? fileName)
   {
      throw new FileNotFoundException(message, fileName);
   }
   
   /// <inheritdoc cref="FileNotFoundException.FileNotFoundException(string?, string?, Exception?)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileNotFound(this IThrowFor @throw, string? message, string? fileName, Exception? innerException)
   {
      throw new FileNotFoundException(message, fileName, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="FileNotFoundException.FileNotFoundException()"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileNotFound<T>(this IThrowFor @throw)
   {
      FileNotFound(@throw);
      return default;
   }
   
   /// <inheritdoc cref="FileNotFoundException.FileNotFoundException(string?)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileNotFound<T>(this IThrowFor @throw, string? message)
   {
      FileNotFound(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="FileNotFoundException.FileNotFoundException(string?, Exception?)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileNotFound<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      FileNotFound(@throw, message, innerException);
      return default;
   }
   
   /// <inheritdoc cref="FileNotFoundException.FileNotFoundException(string?, string?)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileNotFound<T>(this IThrowFor @throw, string? message, string? fileName)
   {
      FileNotFound(@throw, message, fileName);
      return default;
   }
   
   /// <inheritdoc cref="FileNotFoundException.FileNotFoundException(string?, string?, Exception?)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileNotFound<T>(this IThrowFor @throw, string? message, string? fileName, Exception? innerException)
   {
      FileNotFound(@throw, message, fileName, innerException);
      return default;
   }
   #endregion
}

#nullable restore
