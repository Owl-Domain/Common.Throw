#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="MissingMethodException.MissingMethodException()"/>
   /// <exception cref="MissingMethodException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingMethod(this IThrowFor @throw)
   {
      throw new MissingMethodException();
   }
   
   /// <inheritdoc cref="MissingMethodException.MissingMethodException(string?)"/>
   /// <exception cref="MissingMethodException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingMethod(this IThrowFor @throw, string? message)
   {
      throw new MissingMethodException(message);
   }
   
   /// <inheritdoc cref="MissingMethodException.MissingMethodException(string?, Exception?)"/>
   /// <exception cref="MissingMethodException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingMethod(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new MissingMethodException(message, inner);
   }
   
   /// <inheritdoc cref="MissingMethodException.MissingMethodException(string?, string?)"/>
   /// <exception cref="MissingMethodException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingMethod(this IThrowFor @throw, string? className, string? methodName)
   {
      throw new MissingMethodException(className, methodName);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="MissingMethodException.MissingMethodException()"/>
   /// <exception cref="MissingMethodException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingMethod<T>(this IThrowFor @throw)
   {
      MissingMethod(@throw);
      return default;
   }
   
   /// <inheritdoc cref="MissingMethodException.MissingMethodException(string?)"/>
   /// <exception cref="MissingMethodException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingMethod<T>(this IThrowFor @throw, string? message)
   {
      MissingMethod(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="MissingMethodException.MissingMethodException(string?, Exception?)"/>
   /// <exception cref="MissingMethodException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingMethod<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      MissingMethod(@throw, message, inner);
      return default;
   }
   
   /// <inheritdoc cref="MissingMethodException.MissingMethodException(string?, string?)"/>
   /// <exception cref="MissingMethodException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingMethod<T>(this IThrowFor @throw, string? className, string? methodName)
   {
      MissingMethod(@throw, className, methodName);
      return default;
   }
   #endregion
}

#nullable restore
