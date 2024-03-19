namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TypeUnloadedException()"/>
   /// <exception cref="TypeUnloadedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeUnloaded(this IThrow @throw)
   {
      throw new TypeUnloadedException();
   }

   /// <inheritdoc cref="TypeUnloadedException(string)"/>
   /// <exception cref="TypeUnloadedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeUnloaded(this IThrow @throw, string? message)
   {
      throw new TypeUnloadedException(message);
   }

   /// <inheritdoc cref="TypeUnloadedException(string, Exception)"/>
   /// <exception cref="TypeUnloadedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeUnloaded(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new TypeUnloadedException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="TypeUnloadedException()"/>
   /// <exception cref="TypeUnloadedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeUnloaded<T>(this IThrow @throw)
   {
      TypeUnloaded(@throw);
      return default!;
   }

   /// <inheritdoc cref="TypeUnloadedException(string)"/>
   /// <exception cref="TypeUnloadedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeUnloaded<T>(this IThrow @throw, string? message)
   {
      TypeUnloaded(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="TypeUnloadedException(string, Exception)"/>
   /// <exception cref="TypeUnloadedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeUnloaded<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      TypeUnloaded(@throw, message, innerException);
      return default!;
   }
   #endregion
}
