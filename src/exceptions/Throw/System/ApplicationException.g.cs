#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ApplicationException.ApplicationException()"/>
   /// <exception cref="ApplicationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Application(this IThrowFor @throw)
   {
      throw new ApplicationException();
   }
   
   /// <inheritdoc cref="ApplicationException.ApplicationException(string?)"/>
   /// <exception cref="ApplicationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Application(this IThrowFor @throw, string? message)
   {
      throw new ApplicationException(message);
   }
   
   /// <inheritdoc cref="ApplicationException.ApplicationException(string?, Exception?)"/>
   /// <exception cref="ApplicationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Application(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new ApplicationException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="ApplicationException.ApplicationException()"/>
   /// <exception cref="ApplicationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Application<T>(this IThrowFor @throw)
   {
      Application(@throw);
      return default;
   }
   
   /// <inheritdoc cref="ApplicationException.ApplicationException(string?)"/>
   /// <exception cref="ApplicationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Application<T>(this IThrowFor @throw, string? message)
   {
      Application(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="ApplicationException.ApplicationException(string?, Exception?)"/>
   /// <exception cref="ApplicationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Application<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      Application(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
