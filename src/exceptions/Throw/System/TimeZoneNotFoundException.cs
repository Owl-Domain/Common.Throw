namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TimeZoneNotFoundException()"/>
   /// <exception cref="TimeZoneNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TimeZoneNotFound(this IThrowFor @throw)
   {
      throw new TimeZoneNotFoundException();
   }

   /// <inheritdoc cref="TimeZoneNotFoundException(string)"/>
   /// <exception cref="TimeZoneNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TimeZoneNotFound(this IThrowFor @throw, string? message)
   {
      throw new TimeZoneNotFoundException(message);
   }

   /// <inheritdoc cref="TimeZoneNotFoundException(string, Exception)"/>
   /// <exception cref="TimeZoneNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TimeZoneNotFound(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new TimeZoneNotFoundException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="TimeZoneNotFoundException()"/>
   /// <exception cref="TimeZoneNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TimeZoneNotFound<T>(this IThrowFor @throw)
   {
      TimeZoneNotFound(@throw);
      return default!;
   }

   /// <inheritdoc cref="TimeZoneNotFoundException(string)"/>
   /// <exception cref="TimeZoneNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TimeZoneNotFound<T>(this IThrowFor @throw, string? message)
   {
      TimeZoneNotFound(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="TimeZoneNotFoundException(string, Exception)"/>
   /// <exception cref="TimeZoneNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TimeZoneNotFound<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      TimeZoneNotFound(@throw, message, innerException);
      return default!;
   }
   #endregion
}
