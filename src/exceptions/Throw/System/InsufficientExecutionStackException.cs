namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InsufficientExecutionStackException()"/>
   /// <exception cref="InsufficientExecutionStackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InsufficientExecutionStack(this IThrow @throw)
   {
      throw new InsufficientExecutionStackException();
   }

   /// <inheritdoc cref="InsufficientExecutionStackException(string)"/>
   /// <exception cref="InsufficientExecutionStackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InsufficientExecutionStack(this IThrow @throw, string? message)
   {
      throw new InsufficientExecutionStackException(message);
   }

   /// <inheritdoc cref="InsufficientExecutionStackException(string, Exception)"/>
   /// <exception cref="InsufficientExecutionStackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InsufficientExecutionStack(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new InsufficientExecutionStackException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="InsufficientExecutionStackException()"/>
   /// <exception cref="InsufficientExecutionStackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InsufficientExecutionStack<T>(this IThrow @throw)
   {
      InsufficientExecutionStack(@throw);
      return default!;
   }

   /// <inheritdoc cref="InsufficientExecutionStackException(string)"/>
   /// <exception cref="InsufficientExecutionStackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InsufficientExecutionStack<T>(this IThrow @throw, string? message)
   {
      InsufficientExecutionStack(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="InsufficientExecutionStackException(string, Exception)"/>
   /// <exception cref="InsufficientExecutionStackException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InsufficientExecutionStack<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      InsufficientExecutionStack(@throw, message, innerException);
      return default!;
   }
   #endregion
}
