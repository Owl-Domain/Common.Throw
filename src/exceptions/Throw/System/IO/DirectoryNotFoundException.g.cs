#nullable enable

using System.IO;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="DirectoryNotFoundException.DirectoryNotFoundException()"/>
   /// <exception cref="DirectoryNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DirectoryNotFound(this IThrowFor @throw)
   {
      throw new DirectoryNotFoundException();
   }
   
   /// <inheritdoc cref="DirectoryNotFoundException.DirectoryNotFoundException(string?)"/>
   /// <exception cref="DirectoryNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DirectoryNotFound(this IThrowFor @throw, string? message)
   {
      throw new DirectoryNotFoundException(message);
   }
   
   /// <inheritdoc cref="DirectoryNotFoundException.DirectoryNotFoundException(string?, Exception?)"/>
   /// <exception cref="DirectoryNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DirectoryNotFound(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new DirectoryNotFoundException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="DirectoryNotFoundException.DirectoryNotFoundException()"/>
   /// <exception cref="DirectoryNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DirectoryNotFound<T>(this IThrowFor @throw)
   {
      DirectoryNotFound(@throw);
      return default;
   }
   
   /// <inheritdoc cref="DirectoryNotFoundException.DirectoryNotFoundException(string?)"/>
   /// <exception cref="DirectoryNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DirectoryNotFound<T>(this IThrowFor @throw, string? message)
   {
      DirectoryNotFound(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="DirectoryNotFoundException.DirectoryNotFoundException(string?, Exception?)"/>
   /// <exception cref="DirectoryNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DirectoryNotFound<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      DirectoryNotFound(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
