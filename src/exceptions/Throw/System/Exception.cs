namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="Exception.Exception()"/>
   /// <exception cref="System.Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Exception(this IThrowFor @throw)
   {
      throw new Exception();
   }

   /// <inheritdoc cref="Exception.Exception(string)"/>
   /// <exception cref="System.Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Exception(this IThrowFor @throw, string? message)
   {
      throw new Exception(message);
   }

   /// <inheritdoc cref="Exception.Exception(string, Exception)"/>
   /// <exception cref="System.Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Exception(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new Exception(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="Exception.Exception()"/>
   /// <exception cref="System.Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Exception<T>(this IThrowFor @throw)
   {
      Exception(@throw);
      return default!;
   }

   /// <inheritdoc cref="Exception.Exception(string)"/>
   /// <exception cref="System.Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Exception<T>(this IThrowFor @throw, string? message)
   {
      Exception(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="Exception.Exception(string, Exception)"/>
   /// <exception cref="System.Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Exception<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      Exception(@throw, message, innerException);
      return default!;
   }
   #endregion
}
