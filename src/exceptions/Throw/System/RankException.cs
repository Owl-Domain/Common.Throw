namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="RankException()"/>
   /// <exception cref="RankException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Rank(this IThrow @throw)
   {
      throw new RankException();
   }

   /// <inheritdoc cref="RankException(string)"/>
   /// <exception cref="RankException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Rank(this IThrow @throw, string? message)
   {
      throw new RankException(message);
   }

   /// <inheritdoc cref="RankException(string, Exception)"/>
   /// <exception cref="RankException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Rank(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new RankException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="RankException()"/>
   /// <exception cref="RankException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Rank<T>(this IThrow @throw)
   {
      Rank(@throw);
      return default!;
   }

   /// <inheritdoc cref="RankException(string)"/>
   /// <exception cref="RankException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Rank<T>(this IThrow @throw, string? message)
   {
      Rank(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="RankException(string, Exception)"/>
   /// <exception cref="RankException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Rank<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      Rank(@throw, message, innerException);
      return default!;
   }
   #endregion
}
