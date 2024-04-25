namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TypeAccessException()"/>
   /// <exception cref="TypeAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeAccess(this IThrowFor @throw)
   {
      throw new TypeAccessException();
   }

   /// <inheritdoc cref="TypeAccessException(string)"/>
   /// <exception cref="TypeAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeAccess(this IThrowFor @throw, string? message)
   {
      throw new TypeAccessException(message);
   }

   /// <inheritdoc cref="TypeAccessException(string, Exception)"/>
   /// <exception cref="TypeAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeAccess(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new TypeAccessException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="TypeAccessException()"/>
   /// <exception cref="TypeAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeAccess<T>(this IThrowFor @throw)
   {
      TypeAccess(@throw);
      return default!;
   }

   /// <inheritdoc cref="TypeAccessException(string)"/>
   /// <exception cref="TypeAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeAccess<T>(this IThrowFor @throw, string? message)
   {
      TypeAccess(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="TypeAccessException(string, Exception)"/>
   /// <exception cref="TypeAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeAccess<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      TypeAccess(@throw, message, inner);
      return default!;
   }
   #endregion
}
