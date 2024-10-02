#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="DllNotFoundException.DllNotFoundException()"/>
   /// <exception cref="DllNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DllNotFound(this IThrowFor @throw)
   {
      throw new DllNotFoundException();
   }
   
   /// <inheritdoc cref="DllNotFoundException.DllNotFoundException(string?)"/>
   /// <exception cref="DllNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DllNotFound(this IThrowFor @throw, string? message)
   {
      throw new DllNotFoundException(message);
   }
   
   /// <inheritdoc cref="DllNotFoundException.DllNotFoundException(string?, Exception?)"/>
   /// <exception cref="DllNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DllNotFound(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new DllNotFoundException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="DllNotFoundException.DllNotFoundException()"/>
   /// <exception cref="DllNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DllNotFound<T>(this IThrowFor @throw)
   {
      DllNotFound(@throw);
      return default;
   }
   
   /// <inheritdoc cref="DllNotFoundException.DllNotFoundException(string?)"/>
   /// <exception cref="DllNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DllNotFound<T>(this IThrowFor @throw, string? message)
   {
      DllNotFound(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="DllNotFoundException.DllNotFoundException(string?, Exception?)"/>
   /// <exception cref="DllNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DllNotFound<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      DllNotFound(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
