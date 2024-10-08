#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="RankException.RankException()"/>
   /// <exception cref="RankException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Rank(this IThrowFor @throw)
   {
      throw new RankException();
   }
   
   /// <inheritdoc cref="RankException.RankException(string?)"/>
   /// <exception cref="RankException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Rank(this IThrowFor @throw, string? message)
   {
      throw new RankException(message);
   }
   
   /// <inheritdoc cref="RankException.RankException(string?, Exception?)"/>
   /// <exception cref="RankException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Rank(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new RankException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="RankException.RankException()"/>
   /// <exception cref="RankException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Rank<T>(this IThrowFor @throw)
   {
      Rank(@throw);
      return default;
   }
   
   /// <inheritdoc cref="RankException.RankException(string?)"/>
   /// <exception cref="RankException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Rank<T>(this IThrowFor @throw, string? message)
   {
      Rank(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="RankException.RankException(string?, Exception?)"/>
   /// <exception cref="RankException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Rank<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      Rank(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
