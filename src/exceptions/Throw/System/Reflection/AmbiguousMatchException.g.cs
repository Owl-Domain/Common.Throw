#nullable enable

using System.Reflection;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="AmbiguousMatchException.AmbiguousMatchException()"/>
   /// <exception cref="AmbiguousMatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AmbiguousMatch(this IThrowFor @throw)
   {
      throw new AmbiguousMatchException();
   }
   
   /// <inheritdoc cref="AmbiguousMatchException.AmbiguousMatchException(string?)"/>
   /// <exception cref="AmbiguousMatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AmbiguousMatch(this IThrowFor @throw, string? message)
   {
      throw new AmbiguousMatchException(message);
   }
   
   /// <inheritdoc cref="AmbiguousMatchException.AmbiguousMatchException(string?, Exception?)"/>
   /// <exception cref="AmbiguousMatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AmbiguousMatch(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new AmbiguousMatchException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="AmbiguousMatchException.AmbiguousMatchException()"/>
   /// <exception cref="AmbiguousMatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AmbiguousMatch<T>(this IThrowFor @throw)
   {
      AmbiguousMatch(@throw);
      return default;
   }
   
   /// <inheritdoc cref="AmbiguousMatchException.AmbiguousMatchException(string?)"/>
   /// <exception cref="AmbiguousMatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AmbiguousMatch<T>(this IThrowFor @throw, string? message)
   {
      AmbiguousMatch(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="AmbiguousMatchException.AmbiguousMatchException(string?, Exception?)"/>
   /// <exception cref="AmbiguousMatchException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AmbiguousMatch<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      AmbiguousMatch(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
