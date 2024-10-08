#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TypeUnloadedException.TypeUnloadedException()"/>
   /// <exception cref="TypeUnloadedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeUnloaded(this IThrowFor @throw)
   {
      throw new TypeUnloadedException();
   }
   
   /// <inheritdoc cref="TypeUnloadedException.TypeUnloadedException(string?)"/>
   /// <exception cref="TypeUnloadedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeUnloaded(this IThrowFor @throw, string? message)
   {
      throw new TypeUnloadedException(message);
   }
   
   /// <inheritdoc cref="TypeUnloadedException.TypeUnloadedException(string?, Exception?)"/>
   /// <exception cref="TypeUnloadedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeUnloaded(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new TypeUnloadedException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="TypeUnloadedException.TypeUnloadedException()"/>
   /// <exception cref="TypeUnloadedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeUnloaded<T>(this IThrowFor @throw)
   {
      TypeUnloaded(@throw);
      return default;
   }
   
   /// <inheritdoc cref="TypeUnloadedException.TypeUnloadedException(string?)"/>
   /// <exception cref="TypeUnloadedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeUnloaded<T>(this IThrowFor @throw, string? message)
   {
      TypeUnloaded(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="TypeUnloadedException.TypeUnloadedException(string?, Exception?)"/>
   /// <exception cref="TypeUnloadedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeUnloaded<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      TypeUnloaded(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
