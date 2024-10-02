#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SystemException.SystemException()"/>
   /// <exception cref="SystemException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void System(this IThrowFor @throw)
   {
      throw new SystemException();
   }
   
   /// <inheritdoc cref="SystemException.SystemException(string?)"/>
   /// <exception cref="SystemException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void System(this IThrowFor @throw, string? message)
   {
      throw new SystemException(message);
   }
   
   /// <inheritdoc cref="SystemException.SystemException(string?, Exception?)"/>
   /// <exception cref="SystemException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void System(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new SystemException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="SystemException.SystemException()"/>
   /// <exception cref="SystemException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T System<T>(this IThrowFor @throw)
   {
      System(@throw);
      return default;
   }
   
   /// <inheritdoc cref="SystemException.SystemException(string?)"/>
   /// <exception cref="SystemException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T System<T>(this IThrowFor @throw, string? message)
   {
      System(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="SystemException.SystemException(string?, Exception?)"/>
   /// <exception cref="SystemException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T System<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      System(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
