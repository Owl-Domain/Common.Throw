namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="MemberAccessException()"/>
   /// <exception cref="MemberAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MemberAccess(this IThrow @throw)
   {
      throw new MemberAccessException();
   }

   /// <inheritdoc cref="MemberAccessException(string)"/>
   /// <exception cref="MemberAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MemberAccess(this IThrow @throw, string? message)
   {
      throw new MemberAccessException(message);
   }

   /// <inheritdoc cref="MemberAccessException(string, Exception)"/>
   /// <exception cref="MemberAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MemberAccess(this IThrow @throw, string? message, Exception? inner)
   {
      throw new MemberAccessException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="MemberAccessException()"/>
   /// <exception cref="MemberAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MemberAccess<T>(this IThrow @throw)
   {
      MemberAccess(@throw);
      return default!;
   }

   /// <inheritdoc cref="MemberAccessException(string)"/>
   /// <exception cref="MemberAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MemberAccess<T>(this IThrow @throw, string? message)
   {
      MemberAccess(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="MemberAccessException(string, Exception)"/>
   /// <exception cref="MemberAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MemberAccess<T>(this IThrow @throw, string? message, Exception? inner)
   {
      MemberAccess(@throw, message, inner);
      return default!;
   }
   #endregion
}
