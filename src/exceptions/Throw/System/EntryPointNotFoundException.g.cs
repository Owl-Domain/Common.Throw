#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="EntryPointNotFoundException.EntryPointNotFoundException()"/>
   /// <exception cref="EntryPointNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EntryPointNotFound(this IThrowFor @throw)
   {
      throw new EntryPointNotFoundException();
   }
   
   /// <inheritdoc cref="EntryPointNotFoundException.EntryPointNotFoundException(string?)"/>
   /// <exception cref="EntryPointNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EntryPointNotFound(this IThrowFor @throw, string? message)
   {
      throw new EntryPointNotFoundException(message);
   }
   
   /// <inheritdoc cref="EntryPointNotFoundException.EntryPointNotFoundException(string?, Exception?)"/>
   /// <exception cref="EntryPointNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void EntryPointNotFound(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new EntryPointNotFoundException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="EntryPointNotFoundException.EntryPointNotFoundException()"/>
   /// <exception cref="EntryPointNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EntryPointNotFound<T>(this IThrowFor @throw)
   {
      EntryPointNotFound(@throw);
      return default;
   }
   
   /// <inheritdoc cref="EntryPointNotFoundException.EntryPointNotFoundException(string?)"/>
   /// <exception cref="EntryPointNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EntryPointNotFound<T>(this IThrowFor @throw, string? message)
   {
      EntryPointNotFound(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="EntryPointNotFoundException.EntryPointNotFoundException(string?, Exception?)"/>
   /// <exception cref="EntryPointNotFoundException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T EntryPointNotFound<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      EntryPointNotFound(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
