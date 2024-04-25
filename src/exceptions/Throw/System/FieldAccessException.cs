namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="FieldAccessException()"/>
   /// <exception cref="FieldAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FieldAccess(this IThrowFor @throw)
   {
      throw new FieldAccessException();
   }

   /// <inheritdoc cref="FieldAccessException(string)"/>
   /// <exception cref="FieldAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FieldAccess(this IThrowFor @throw, string? message)
   {
      throw new FieldAccessException(message);
   }

   /// <inheritdoc cref="FieldAccessException(string, Exception)"/>
   /// <exception cref="FieldAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FieldAccess(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new FieldAccessException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="FieldAccessException()"/>
   /// <exception cref="FieldAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FieldAccess<T>(this IThrowFor @throw)
   {
      FieldAccess(@throw);
      return default!;
   }

   /// <inheritdoc cref="FieldAccessException(string)"/>
   /// <exception cref="FieldAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FieldAccess<T>(this IThrowFor @throw, string? message)
   {
      FieldAccess(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="FieldAccessException(string, Exception)"/>
   /// <exception cref="FieldAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FieldAccess<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      FieldAccess(@throw, message, inner);
      return default!;
   }
   #endregion
}
