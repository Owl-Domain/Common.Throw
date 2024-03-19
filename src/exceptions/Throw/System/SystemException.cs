namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SystemException()"/>
   /// <exception cref="SystemException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void System(this IThrow @throw)
   {
      throw new SystemException();
   }

   /// <inheritdoc cref="SystemException(string)"/>
   /// <exception cref="SystemException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void System(this IThrow @throw, string? message)
   {
      throw new SystemException(message);
   }

   /// <inheritdoc cref="SystemException(string, Exception)"/>
   /// <exception cref="SystemException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void System(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new SystemException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="SystemException()"/>
   /// <exception cref="SystemException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T System<T>(this IThrow @throw)
   {
      System(@throw);
      return default!;
   }

   /// <inheritdoc cref="SystemException(string)"/>
   /// <exception cref="SystemException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T System<T>(this IThrow @throw, string? message)
   {
      System(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="SystemException(string, Exception)"/>
   /// <exception cref="SystemException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T System<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      System(@throw, message, innerException);
      return default!;
   }
   #endregion
}
