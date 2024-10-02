#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="UnauthorizedAccessException.UnauthorizedAccessException()"/>
   /// <exception cref="UnauthorizedAccessException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void UnauthorizedAccess(this IThrowFor @throw)
   {
      throw new UnauthorizedAccessException();
   }
   
   /// <inheritdoc cref="UnauthorizedAccessException.UnauthorizedAccessException(string?)"/>
   /// <exception cref="UnauthorizedAccessException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void UnauthorizedAccess(this IThrowFor @throw, string? message)
   {
      throw new UnauthorizedAccessException(message);
   }
   
   /// <inheritdoc cref="UnauthorizedAccessException.UnauthorizedAccessException(string?, Exception?)"/>
   /// <exception cref="UnauthorizedAccessException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void UnauthorizedAccess(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new UnauthorizedAccessException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="UnauthorizedAccessException.UnauthorizedAccessException()"/>
   /// <exception cref="UnauthorizedAccessException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T UnauthorizedAccess<T>(this IThrowFor @throw)
   {
      UnauthorizedAccess(@throw);
      return default;
   }
   
   /// <inheritdoc cref="UnauthorizedAccessException.UnauthorizedAccessException(string?)"/>
   /// <exception cref="UnauthorizedAccessException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T UnauthorizedAccess<T>(this IThrowFor @throw, string? message)
   {
      UnauthorizedAccess(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="UnauthorizedAccessException.UnauthorizedAccessException(string?, Exception?)"/>
   /// <exception cref="UnauthorizedAccessException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T UnauthorizedAccess<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      UnauthorizedAccess(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
