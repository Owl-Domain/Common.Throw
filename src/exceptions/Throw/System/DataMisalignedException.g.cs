#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="DataMisalignedException.DataMisalignedException()"/>
   /// <exception cref="DataMisalignedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DataMisaligned(this IThrowFor @throw)
   {
      throw new DataMisalignedException();
   }
   
   /// <inheritdoc cref="DataMisalignedException.DataMisalignedException(string?)"/>
   /// <exception cref="DataMisalignedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DataMisaligned(this IThrowFor @throw, string? message)
   {
      throw new DataMisalignedException(message);
   }
   
   /// <inheritdoc cref="DataMisalignedException.DataMisalignedException(string?, Exception?)"/>
   /// <exception cref="DataMisalignedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DataMisaligned(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new DataMisalignedException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="DataMisalignedException.DataMisalignedException()"/>
   /// <exception cref="DataMisalignedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DataMisaligned<T>(this IThrowFor @throw)
   {
      DataMisaligned(@throw);
      return default;
   }
   
   /// <inheritdoc cref="DataMisalignedException.DataMisalignedException(string?)"/>
   /// <exception cref="DataMisalignedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DataMisaligned<T>(this IThrowFor @throw, string? message)
   {
      DataMisaligned(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="DataMisalignedException.DataMisalignedException(string?, Exception?)"/>
   /// <exception cref="DataMisalignedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DataMisaligned<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      DataMisaligned(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
