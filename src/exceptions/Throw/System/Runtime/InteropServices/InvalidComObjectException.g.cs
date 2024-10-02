#nullable enable

using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InvalidComObjectException.InvalidComObjectException()"/>
   /// <exception cref="InvalidComObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidComObject(this IThrowFor @throw)
   {
      throw new InvalidComObjectException();
   }
   
   /// <inheritdoc cref="InvalidComObjectException.InvalidComObjectException(string?)"/>
   /// <exception cref="InvalidComObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidComObject(this IThrowFor @throw, string? message)
   {
      throw new InvalidComObjectException(message);
   }
   
   /// <inheritdoc cref="InvalidComObjectException.InvalidComObjectException(string?, Exception?)"/>
   /// <exception cref="InvalidComObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidComObject(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new InvalidComObjectException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="InvalidComObjectException.InvalidComObjectException()"/>
   /// <exception cref="InvalidComObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidComObject<T>(this IThrowFor @throw)
   {
      InvalidComObject(@throw);
      return default;
   }
   
   /// <inheritdoc cref="InvalidComObjectException.InvalidComObjectException(string?)"/>
   /// <exception cref="InvalidComObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidComObject<T>(this IThrowFor @throw, string? message)
   {
      InvalidComObject(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="InvalidComObjectException.InvalidComObjectException(string?, Exception?)"/>
   /// <exception cref="InvalidComObjectException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidComObject<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      InvalidComObject(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
