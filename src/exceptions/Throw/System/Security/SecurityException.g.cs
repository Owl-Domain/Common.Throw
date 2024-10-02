#nullable enable

using System.Security;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SecurityException.SecurityException()"/>
   /// <exception cref="SecurityException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Security(this IThrowFor @throw)
   {
      throw new SecurityException();
   }
   
   /// <inheritdoc cref="SecurityException.SecurityException(string?)"/>
   /// <exception cref="SecurityException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Security(this IThrowFor @throw, string? message)
   {
      throw new SecurityException(message);
   }
   
   /// <inheritdoc cref="SecurityException.SecurityException(string?, Exception?)"/>
   /// <exception cref="SecurityException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Security(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new SecurityException(message, inner);
   }
   
   /// <inheritdoc cref="SecurityException.SecurityException(string?, Type?)"/>
   /// <exception cref="SecurityException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Security(this IThrowFor @throw, string? message, Type? type)
   {
      throw new SecurityException(message, type);
   }
   
   /// <inheritdoc cref="SecurityException.SecurityException(string?, Type?, string?)"/>
   /// <exception cref="SecurityException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Security(this IThrowFor @throw, string? message, Type? type, string? state)
   {
      throw new SecurityException(message, type, state);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="SecurityException.SecurityException()"/>
   /// <exception cref="SecurityException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Security<T>(this IThrowFor @throw)
   {
      Security(@throw);
      return default;
   }
   
   /// <inheritdoc cref="SecurityException.SecurityException(string?)"/>
   /// <exception cref="SecurityException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Security<T>(this IThrowFor @throw, string? message)
   {
      Security(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="SecurityException.SecurityException(string?, Exception?)"/>
   /// <exception cref="SecurityException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Security<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      Security(@throw, message, inner);
      return default;
   }
   
   /// <inheritdoc cref="SecurityException.SecurityException(string?, Type?)"/>
   /// <exception cref="SecurityException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Security<T>(this IThrowFor @throw, string? message, Type? type)
   {
      Security(@throw, message, type);
      return default;
   }
   
   /// <inheritdoc cref="SecurityException.SecurityException(string?, Type?, string?)"/>
   /// <exception cref="SecurityException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Security<T>(this IThrowFor @throw, string? message, Type? type, string? state)
   {
      Security(@throw, message, type, state);
      return default;
   }
   #endregion
}

#nullable restore
