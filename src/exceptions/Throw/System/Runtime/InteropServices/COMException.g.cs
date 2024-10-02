#nullable enable

using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="COMException.COMException()"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void COM(this IThrowFor @throw)
   {
      throw new COMException();
   }
   
   /// <inheritdoc cref="COMException.COMException(string?)"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void COM(this IThrowFor @throw, string? message)
   {
      throw new COMException(message);
   }
   
   /// <inheritdoc cref="COMException.COMException(string?, Exception?)"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void COM(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new COMException(message, inner);
   }
   
   /// <inheritdoc cref="COMException.COMException(string?, int)"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void COM(this IThrowFor @throw, string? message, int errorCode)
   {
      throw new COMException(message, errorCode);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="COMException.COMException()"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T COM<T>(this IThrowFor @throw)
   {
      COM(@throw);
      return default;
   }
   
   /// <inheritdoc cref="COMException.COMException(string?)"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T COM<T>(this IThrowFor @throw, string? message)
   {
      COM(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="COMException.COMException(string?, Exception?)"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T COM<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      COM(@throw, message, inner);
      return default;
   }
   
   /// <inheritdoc cref="COMException.COMException(string?, int)"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T COM<T>(this IThrowFor @throw, string? message, int errorCode)
   {
      COM(@throw, message, errorCode);
      return default;
   }
   #endregion
}

#nullable restore
