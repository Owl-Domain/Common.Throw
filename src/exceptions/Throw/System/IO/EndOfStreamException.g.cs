#nullable enable

using System.IO;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="EndOfStreamException.EndOfStreamException()"/>
   /// <exception cref="EndOfStreamException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EndOfStream(this IThrowFor @throw)
   {
      throw new EndOfStreamException();
   }
   
   /// <inheritdoc cref="EndOfStreamException.EndOfStreamException(string?)"/>
   /// <exception cref="EndOfStreamException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EndOfStream(this IThrowFor @throw, string? message)
   {
      throw new EndOfStreamException(message);
   }
   
   /// <inheritdoc cref="EndOfStreamException.EndOfStreamException(string?, Exception?)"/>
   /// <exception cref="EndOfStreamException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EndOfStream(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new EndOfStreamException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="EndOfStreamException.EndOfStreamException()"/>
   /// <exception cref="EndOfStreamException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EndOfStream<T>(this IThrowFor @throw)
   {
      EndOfStream(@throw);
      return default;
   }
   
   /// <inheritdoc cref="EndOfStreamException.EndOfStreamException(string?)"/>
   /// <exception cref="EndOfStreamException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EndOfStream<T>(this IThrowFor @throw, string? message)
   {
      EndOfStream(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="EndOfStreamException.EndOfStreamException(string?, Exception?)"/>
   /// <exception cref="EndOfStreamException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EndOfStream<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      EndOfStream(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
