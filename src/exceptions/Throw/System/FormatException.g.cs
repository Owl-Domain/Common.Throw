#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="FormatException.FormatException()"/>
   /// <exception cref="FormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Format(this IThrowFor @throw)
   {
      throw new FormatException();
   }
   
   /// <inheritdoc cref="FormatException.FormatException(string?)"/>
   /// <exception cref="FormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Format(this IThrowFor @throw, string? message)
   {
      throw new FormatException(message);
   }
   
   /// <inheritdoc cref="FormatException.FormatException(string?, Exception?)"/>
   /// <exception cref="FormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Format(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new FormatException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="FormatException.FormatException()"/>
   /// <exception cref="FormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Format<T>(this IThrowFor @throw)
   {
      Format(@throw);
      return default;
   }
   
   /// <inheritdoc cref="FormatException.FormatException(string?)"/>
   /// <exception cref="FormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Format<T>(this IThrowFor @throw, string? message)
   {
      Format(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="FormatException.FormatException(string?, Exception?)"/>
   /// <exception cref="FormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Format<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      Format(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
