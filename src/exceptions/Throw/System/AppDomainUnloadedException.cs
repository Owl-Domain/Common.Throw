namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="AppDomainUnloadedException()"/>
   /// <exception cref="AppDomainUnloadedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AppDomainUnloaded(this IThrow @throw)
   {
      throw new AppDomainUnloadedException();
   }

   /// <inheritdoc cref="AppDomainUnloadedException(string)"/>
   /// <exception cref="AppDomainUnloadedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AppDomainUnloaded(this IThrow @throw, string? message)
   {
      throw new AppDomainUnloadedException(message);
   }

   /// <inheritdoc cref="AppDomainUnloadedException(string, Exception)"/>
   /// <exception cref="AppDomainUnloadedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AppDomainUnloaded(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new AppDomainUnloadedException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="AppDomainUnloadedException()"/>
   /// <exception cref="AppDomainUnloadedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AppDomainUnloaded<T>(this IThrow @throw)
   {
      AppDomainUnloaded(@throw);
      return default!;
   }

   /// <inheritdoc cref="AppDomainUnloadedException(string)"/>
   /// <exception cref="AppDomainUnloadedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AppDomainUnloaded<T>(this IThrow @throw, string? message)
   {
      AppDomainUnloaded(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="AppDomainUnloadedException(string, Exception)"/>
   /// <exception cref="AppDomainUnloadedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AppDomainUnloaded<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      AppDomainUnloaded(@throw, message, innerException);
      return default!;
   }
   #endregion
}
