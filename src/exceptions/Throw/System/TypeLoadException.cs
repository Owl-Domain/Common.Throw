namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TypeLoadException()"/>
   /// <exception cref="TypeLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeLoad(this IThrow @throw)
   {
      throw new TypeLoadException();
   }

   /// <inheritdoc cref="TypeLoadException(string)"/>
   /// <exception cref="TypeLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeLoad(this IThrow @throw, string? message)
   {
      throw new TypeLoadException(message);
   }

   /// <inheritdoc cref="TypeLoadException(string, Exception)"/>
   /// <exception cref="TypeLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeLoad(this IThrow @throw, string? message, Exception? inner)
   {
      throw new TypeLoadException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="TypeLoadException()"/>
   /// <exception cref="TypeLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeLoad<T>(this IThrow @throw)
   {
      TypeLoad(@throw);
      return default!;
   }

   /// <inheritdoc cref="TypeLoadException(string)"/>
   /// <exception cref="TypeLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeLoad<T>(this IThrow @throw, string? message)
   {
      TypeLoad(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="TypeLoadException(string, Exception)"/>
   /// <exception cref="TypeLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeLoad<T>(this IThrow @throw, string? message, Exception? inner)
   {
      TypeLoad(@throw, message, inner);
      return default!;
   }
   #endregion
}
