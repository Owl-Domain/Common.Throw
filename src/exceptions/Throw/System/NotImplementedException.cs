namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="NotImplementedException()"/>
   /// <exception cref="NotImplementedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotImplemented(this IThrowFor @throw)
   {
      throw new NotImplementedException();
   }

   /// <inheritdoc cref="NotImplementedException(string)"/>
   /// <exception cref="NotImplementedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotImplemented(this IThrowFor @throw, string? message)
   {
      throw new NotImplementedException(message);
   }

   /// <inheritdoc cref="NotImplementedException(string, Exception)"/>
   /// <exception cref="NotImplementedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NotImplemented(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new NotImplementedException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="NotImplementedException()"/>
   /// <exception cref="NotImplementedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotImplemented<T>(this IThrowFor @throw)
   {
      NotImplemented(@throw);
      return default!;
   }

   /// <inheritdoc cref="NotImplementedException(string)"/>
   /// <exception cref="NotImplementedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotImplemented<T>(this IThrowFor @throw, string? message)
   {
      NotImplemented(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="NotImplementedException(string, Exception)"/>
   /// <exception cref="NotImplementedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NotImplemented<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      NotImplemented(@throw, message, inner);
      return default!;
   }
   #endregion
}
