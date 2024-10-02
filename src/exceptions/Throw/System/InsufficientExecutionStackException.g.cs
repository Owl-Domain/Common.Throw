#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InsufficientExecutionStackException.InsufficientExecutionStackException()"/>
   /// <exception cref="InsufficientExecutionStackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InsufficientExecutionStack(this IThrowFor @throw)
   {
      throw new InsufficientExecutionStackException();
   }
   
   /// <inheritdoc cref="InsufficientExecutionStackException.InsufficientExecutionStackException(string?)"/>
   /// <exception cref="InsufficientExecutionStackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InsufficientExecutionStack(this IThrowFor @throw, string? message)
   {
      throw new InsufficientExecutionStackException(message);
   }
   
   /// <inheritdoc cref="InsufficientExecutionStackException.InsufficientExecutionStackException(string?, Exception?)"/>
   /// <exception cref="InsufficientExecutionStackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InsufficientExecutionStack(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new InsufficientExecutionStackException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="InsufficientExecutionStackException.InsufficientExecutionStackException()"/>
   /// <exception cref="InsufficientExecutionStackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InsufficientExecutionStack<T>(this IThrowFor @throw)
   {
      InsufficientExecutionStack(@throw);
      return default;
   }
   
   /// <inheritdoc cref="InsufficientExecutionStackException.InsufficientExecutionStackException(string?)"/>
   /// <exception cref="InsufficientExecutionStackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InsufficientExecutionStack<T>(this IThrowFor @throw, string? message)
   {
      InsufficientExecutionStack(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="InsufficientExecutionStackException.InsufficientExecutionStackException(string?, Exception?)"/>
   /// <exception cref="InsufficientExecutionStackException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InsufficientExecutionStack<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      InsufficientExecutionStack(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
