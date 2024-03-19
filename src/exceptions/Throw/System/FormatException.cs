namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="FormatException()"/>
   /// <exception cref="FormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Format(this IThrow @throw)
   {
      throw new FormatException();
   }

   /// <inheritdoc cref="FormatException(string)"/>
   /// <exception cref="FormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Format(this IThrow @throw, string? message)
   {
      throw new FormatException(message);
   }

   /// <inheritdoc cref="FormatException(string, Exception)"/>
   /// <exception cref="FormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Format(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new FormatException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="FormatException()"/>
   /// <exception cref="FormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Format<T>(this IThrow @throw)
   {
      Format(@throw);
      return default!;
   }

   /// <inheritdoc cref="FormatException(string)"/>
   /// <exception cref="FormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Format<T>(this IThrow @throw, string? message)
   {
      Format(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="FormatException(string, Exception)"/>
   /// <exception cref="FormatException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Format<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      Format(@throw, message, innerException);
      return default!;
   }
   #endregion
}
