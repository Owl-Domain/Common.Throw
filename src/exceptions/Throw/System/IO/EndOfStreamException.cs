using System.IO;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="EndOfStreamException()"/>
   /// <exception cref="EndOfStreamException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EndOfStream(this IThrow @throw)
   {
      throw new EndOfStreamException();
   }

   /// <inheritdoc cref="EndOfStreamException(string)"/>
   /// <exception cref="EndOfStreamException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EndOfStream(this IThrow @throw, string? message)
   {
      throw new EndOfStreamException(message);
   }

   /// <inheritdoc cref="EndOfStreamException(string, Exception)"/>
   /// <exception cref="EndOfStreamException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EndOfStream(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new EndOfStreamException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="EndOfStreamException()"/>
   /// <exception cref="EndOfStreamException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EndOfStream<T>(this IThrow @throw)
   {
      EndOfStream(@throw);
      return default!;
   }

   /// <inheritdoc cref="EndOfStreamException(string)"/>
   /// <exception cref="EndOfStreamException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EndOfStream<T>(this IThrow @throw, string? message)
   {
      EndOfStream(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="EndOfStreamException(string, Exception)"/>
   /// <exception cref="EndOfStreamException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EndOfStream<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      EndOfStream(@throw, message, innerException);
      return default!;
   }
   #endregion
}
