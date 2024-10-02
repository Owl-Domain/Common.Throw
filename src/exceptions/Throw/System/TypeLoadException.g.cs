#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TypeLoadException.TypeLoadException()"/>
   /// <exception cref="TypeLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeLoad(this IThrowFor @throw)
   {
      throw new TypeLoadException();
   }
   
   /// <inheritdoc cref="TypeLoadException.TypeLoadException(string?)"/>
   /// <exception cref="TypeLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeLoad(this IThrowFor @throw, string? message)
   {
      throw new TypeLoadException(message);
   }
   
   /// <inheritdoc cref="TypeLoadException.TypeLoadException(string?, Exception?)"/>
   /// <exception cref="TypeLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TypeLoad(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new TypeLoadException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="TypeLoadException.TypeLoadException()"/>
   /// <exception cref="TypeLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeLoad<T>(this IThrowFor @throw)
   {
      TypeLoad(@throw);
      return default;
   }
   
   /// <inheritdoc cref="TypeLoadException.TypeLoadException(string?)"/>
   /// <exception cref="TypeLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeLoad<T>(this IThrowFor @throw, string? message)
   {
      TypeLoad(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="TypeLoadException.TypeLoadException(string?, Exception?)"/>
   /// <exception cref="TypeLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TypeLoad<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      TypeLoad(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
