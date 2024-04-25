namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InvalidTimeZoneException()"/>
   /// <exception cref="InvalidTimeZoneException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidTimeZone(this IThrowFor @throw)
   {
      throw new InvalidTimeZoneException();
   }

   /// <inheritdoc cref="InvalidTimeZoneException(string)"/>
   /// <exception cref="InvalidTimeZoneException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidTimeZone(this IThrowFor @throw, string? message)
   {
      throw new InvalidTimeZoneException(message);
   }

   /// <inheritdoc cref="InvalidTimeZoneException(string, Exception)"/>
   /// <exception cref="InvalidTimeZoneException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidTimeZone(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new InvalidTimeZoneException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="InvalidTimeZoneException()"/>
   /// <exception cref="InvalidTimeZoneException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidTimeZone<T>(this IThrowFor @throw)
   {
      InvalidTimeZone(@throw);
      return default!;
   }

   /// <inheritdoc cref="InvalidTimeZoneException(string)"/>
   /// <exception cref="InvalidTimeZoneException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidTimeZone<T>(this IThrowFor @throw, string? message)
   {
      InvalidTimeZone(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="InvalidTimeZoneException(string, Exception)"/>
   /// <exception cref="InvalidTimeZoneException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidTimeZone<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      InvalidTimeZone(@throw, message, innerException);
      return default!;
   }
   #endregion
}
