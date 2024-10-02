#nullable enable

using System.IO;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="IOException.IOException()"/>
   /// <exception cref="IOException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void IO(this IThrowFor @throw)
   {
      throw new IOException();
   }
   
   /// <inheritdoc cref="IOException.IOException(string?)"/>
   /// <exception cref="IOException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void IO(this IThrowFor @throw, string? message)
   {
      throw new IOException(message);
   }
   
   /// <inheritdoc cref="IOException.IOException(string?, int)"/>
   /// <exception cref="IOException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void IO(this IThrowFor @throw, string? message, int hresult)
   {
      throw new IOException(message, hresult);
   }
   
   /// <inheritdoc cref="IOException.IOException(string?, Exception?)"/>
   /// <exception cref="IOException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void IO(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new IOException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="IOException.IOException()"/>
   /// <exception cref="IOException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T IO<T>(this IThrowFor @throw)
   {
      IO(@throw);
      return default;
   }
   
   /// <inheritdoc cref="IOException.IOException(string?)"/>
   /// <exception cref="IOException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T IO<T>(this IThrowFor @throw, string? message)
   {
      IO(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="IOException.IOException(string?, int)"/>
   /// <exception cref="IOException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T IO<T>(this IThrowFor @throw, string? message, int hresult)
   {
      IO(@throw, message, hresult);
      return default;
   }
   
   /// <inheritdoc cref="IOException.IOException(string?, Exception?)"/>
   /// <exception cref="IOException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T IO<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      IO(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
