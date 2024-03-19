namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ApplicationException()"/>
   /// <exception cref="ApplicationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Application(this IThrow @throw)
   {
      throw new ApplicationException();
   }

   /// <inheritdoc cref="ApplicationException(string)"/>
   /// <exception cref="ApplicationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Application(this IThrow @throw, string? message)
   {
      throw new ApplicationException(message);
   }

   /// <inheritdoc cref="ApplicationException(string, Exception)"/>
   /// <exception cref="ApplicationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Application(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new ApplicationException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="ApplicationException()"/>
   /// <exception cref="ApplicationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Application<T>(this IThrow @throw)
   {
      Application(@throw);
      return default!;
   }

   /// <inheritdoc cref="ApplicationException(string)"/>
   /// <exception cref="ApplicationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Application<T>(this IThrow @throw, string? message)
   {
      Application(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="ApplicationException(string, Exception)"/>
   /// <exception cref="ApplicationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Application<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      Application(@throw, message, innerException);
      return default!;
   }
   #endregion
}
