#nullable enable

using System.Diagnostics.Tracing;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="EventSourceException.EventSourceException()"/>
   /// <exception cref="EventSourceException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EventSource(this IThrowFor @throw)
   {
      throw new EventSourceException();
   }
   
   /// <inheritdoc cref="EventSourceException.EventSourceException(string?)"/>
   /// <exception cref="EventSourceException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EventSource(this IThrowFor @throw, string? message)
   {
      throw new EventSourceException(message);
   }
   
   /// <inheritdoc cref="EventSourceException.EventSourceException(string?, Exception?)"/>
   /// <exception cref="EventSourceException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EventSource(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new EventSourceException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="EventSourceException.EventSourceException()"/>
   /// <exception cref="EventSourceException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EventSource<T>(this IThrowFor @throw)
   {
      EventSource(@throw);
      return default;
   }
   
   /// <inheritdoc cref="EventSourceException.EventSourceException(string?)"/>
   /// <exception cref="EventSourceException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EventSource<T>(this IThrowFor @throw, string? message)
   {
      EventSource(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="EventSourceException.EventSourceException(string?, Exception?)"/>
   /// <exception cref="EventSourceException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EventSource<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      EventSource(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
