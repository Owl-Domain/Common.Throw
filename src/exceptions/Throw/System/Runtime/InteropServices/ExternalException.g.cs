#nullable enable

using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ExternalException.ExternalException()"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void External(this IThrowFor @throw)
   {
      throw new ExternalException();
   }
   
   /// <inheritdoc cref="ExternalException.ExternalException(string?)"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void External(this IThrowFor @throw, string? message)
   {
      throw new ExternalException(message);
   }
   
   /// <inheritdoc cref="ExternalException.ExternalException(string?, Exception?)"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void External(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new ExternalException(message, inner);
   }
   
   /// <inheritdoc cref="ExternalException.ExternalException(string?, int)"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void External(this IThrowFor @throw, string? message, int errorCode)
   {
      throw new ExternalException(message, errorCode);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="ExternalException.ExternalException()"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T External<T>(this IThrowFor @throw)
   {
      External(@throw);
      return default;
   }
   
   /// <inheritdoc cref="ExternalException.ExternalException(string?)"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T External<T>(this IThrowFor @throw, string? message)
   {
      External(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="ExternalException.ExternalException(string?, Exception?)"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T External<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      External(@throw, message, inner);
      return default;
   }
   
   /// <inheritdoc cref="ExternalException.ExternalException(string?, int)"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T External<T>(this IThrowFor @throw, string? message, int errorCode)
   {
      External(@throw, message, errorCode);
      return default;
   }
   #endregion
}

#nullable restore
