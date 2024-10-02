#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ArgumentNullException.ArgumentNullException()"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArgumentNull(this IThrowFor @throw)
   {
      throw new ArgumentNullException();
   }
   
   /// <inheritdoc cref="ArgumentNullException.ArgumentNullException(string?)"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArgumentNull(this IThrowFor @throw, string? paramName)
   {
      throw new ArgumentNullException(paramName);
   }
   
   /// <inheritdoc cref="ArgumentNullException.ArgumentNullException(string?, Exception?)"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArgumentNull(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new ArgumentNullException(message, innerException);
   }
   
   /// <inheritdoc cref="ArgumentNullException.ArgumentNullException(string?, string?)"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ArgumentNull(this IThrowFor @throw, string? paramName, string? message)
   {
      throw new ArgumentNullException(paramName, message);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="ArgumentNullException.ArgumentNullException()"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArgumentNull<T>(this IThrowFor @throw)
   {
      ArgumentNull(@throw);
      return default;
   }
   
   /// <inheritdoc cref="ArgumentNullException.ArgumentNullException(string?)"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArgumentNull<T>(this IThrowFor @throw, string? paramName)
   {
      ArgumentNull(@throw, paramName);
      return default;
   }
   
   /// <inheritdoc cref="ArgumentNullException.ArgumentNullException(string?, Exception?)"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArgumentNull<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      ArgumentNull(@throw, message, innerException);
      return default;
   }
   
   /// <inheritdoc cref="ArgumentNullException.ArgumentNullException(string?, string?)"/>
   /// <exception cref="ArgumentNullException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ArgumentNull<T>(this IThrowFor @throw, string? paramName, string? message)
   {
      ArgumentNull(@throw, paramName, message);
      return default;
   }
   #endregion
}

#nullable restore
