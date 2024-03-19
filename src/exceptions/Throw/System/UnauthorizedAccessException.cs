namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="UnauthorizedAccessException()"/>
   /// <exception cref="UnauthorizedAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void UnauthorizedAccess(this IThrow @throw)
   {
      throw new UnauthorizedAccessException();
   }

   /// <inheritdoc cref="UnauthorizedAccessException(string)"/>
   /// <exception cref="UnauthorizedAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void UnauthorizedAccess(this IThrow @throw, string? message)
   {
      throw new UnauthorizedAccessException(message);
   }

   /// <inheritdoc cref="UnauthorizedAccessException(string, Exception)"/>
   /// <exception cref="UnauthorizedAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void UnauthorizedAccess(this IThrow @throw, string? message, Exception? inner)
   {
      throw new UnauthorizedAccessException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="UnauthorizedAccessException()"/>
   /// <exception cref="UnauthorizedAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T UnauthorizedAccess<T>(this IThrow @throw)
   {
      UnauthorizedAccess(@throw);
      return default!;
   }

   /// <inheritdoc cref="UnauthorizedAccessException(string)"/>
   /// <exception cref="UnauthorizedAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T UnauthorizedAccess<T>(this IThrow @throw, string? message)
   {
      UnauthorizedAccess(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="UnauthorizedAccessException(string, Exception)"/>
   /// <exception cref="UnauthorizedAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T UnauthorizedAccess<T>(this IThrow @throw, string? message, Exception? inner)
   {
      UnauthorizedAccess(@throw, message, inner);
      return default!;
   }
   #endregion
}
