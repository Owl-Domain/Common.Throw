#nullable enable

using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SEHException.SEHException()"/>
   /// <exception cref="SEHException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SEH(this IThrowFor @throw)
   {
      throw new SEHException();
   }
   
   /// <inheritdoc cref="SEHException.SEHException(string?)"/>
   /// <exception cref="SEHException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SEH(this IThrowFor @throw, string? message)
   {
      throw new SEHException(message);
   }
   
   /// <inheritdoc cref="SEHException.SEHException(string?, Exception?)"/>
   /// <exception cref="SEHException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void SEH(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new SEHException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="SEHException.SEHException()"/>
   /// <exception cref="SEHException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SEH<T>(this IThrowFor @throw)
   {
      SEH(@throw);
      return default;
   }
   
   /// <inheritdoc cref="SEHException.SEHException(string?)"/>
   /// <exception cref="SEHException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SEH<T>(this IThrowFor @throw, string? message)
   {
      SEH(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="SEHException.SEHException(string?, Exception?)"/>
   /// <exception cref="SEHException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T SEH<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      SEH(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
