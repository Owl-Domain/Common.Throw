#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="AppDomainUnloadedException.AppDomainUnloadedException()"/>
   /// <exception cref="AppDomainUnloadedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AppDomainUnloaded(this IThrowFor @throw)
   {
      throw new AppDomainUnloadedException();
   }
   
   /// <inheritdoc cref="AppDomainUnloadedException.AppDomainUnloadedException(string?)"/>
   /// <exception cref="AppDomainUnloadedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AppDomainUnloaded(this IThrowFor @throw, string? message)
   {
      throw new AppDomainUnloadedException(message);
   }
   
   /// <inheritdoc cref="AppDomainUnloadedException.AppDomainUnloadedException(string?, Exception?)"/>
   /// <exception cref="AppDomainUnloadedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AppDomainUnloaded(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new AppDomainUnloadedException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="AppDomainUnloadedException.AppDomainUnloadedException()"/>
   /// <exception cref="AppDomainUnloadedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AppDomainUnloaded<T>(this IThrowFor @throw)
   {
      AppDomainUnloaded(@throw);
      return default;
   }
   
   /// <inheritdoc cref="AppDomainUnloadedException.AppDomainUnloadedException(string?)"/>
   /// <exception cref="AppDomainUnloadedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AppDomainUnloaded<T>(this IThrowFor @throw, string? message)
   {
      AppDomainUnloaded(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="AppDomainUnloadedException.AppDomainUnloadedException(string?, Exception?)"/>
   /// <exception cref="AppDomainUnloadedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AppDomainUnloaded<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      AppDomainUnloaded(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
