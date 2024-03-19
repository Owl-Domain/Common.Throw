using System.Diagnostics.Tracing;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="EventSourceException()"/>
   /// <exception cref="EventSourceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EventSource(this IThrow @throw)
   {
      throw new EventSourceException();
   }

   /// <inheritdoc cref="EventSourceException(string)"/>
   /// <exception cref="EventSourceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EventSource(this IThrow @throw, string? message)
   {
      throw new EventSourceException(message);
   }

   /// <inheritdoc cref="EventSourceException(string, Exception)"/>
   /// <exception cref="EventSourceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EventSource(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new EventSourceException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="EventSourceException()"/>
   /// <exception cref="EventSourceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EventSource<T>(this IThrow @throw)
   {
      EventSource(@throw);
      return default!;
   }

   /// <inheritdoc cref="EventSourceException(string)"/>
   /// <exception cref="EventSourceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EventSource<T>(this IThrow @throw, string? message)
   {
      EventSource(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="EventSourceException(string, Exception)"/>
   /// <exception cref="EventSourceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EventSource<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      EventSource(@throw, message, innerException);
      return default!;
   }
   #endregion
}
