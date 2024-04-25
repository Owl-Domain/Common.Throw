namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="MethodAccessException()"/>
   /// <exception cref="MethodAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MethodAccess(this IThrowFor @throw)
   {
      throw new MethodAccessException();
   }

   /// <inheritdoc cref="MethodAccessException(string)"/>
   /// <exception cref="MethodAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MethodAccess(this IThrowFor @throw, string? message)
   {
      throw new MethodAccessException(message);
   }

   /// <inheritdoc cref="MethodAccessException(string, Exception)"/>
   /// <exception cref="MethodAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MethodAccess(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new MethodAccessException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="MethodAccessException()"/>
   /// <exception cref="MethodAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MethodAccess<T>(this IThrowFor @throw)
   {
      MethodAccess(@throw);
      return default!;
   }

   /// <inheritdoc cref="MethodAccessException(string)"/>
   /// <exception cref="MethodAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MethodAccess<T>(this IThrowFor @throw, string? message)
   {
      MethodAccess(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="MethodAccessException(string, Exception)"/>
   /// <exception cref="MethodAccessException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MethodAccess<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      MethodAccess(@throw, message, inner);
      return default!;
   }
   #endregion
}
