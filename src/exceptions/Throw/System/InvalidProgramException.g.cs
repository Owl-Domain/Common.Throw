#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InvalidProgramException.InvalidProgramException()"/>
   /// <exception cref="InvalidProgramException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidProgram(this IThrowFor @throw)
   {
      throw new InvalidProgramException();
   }
   
   /// <inheritdoc cref="InvalidProgramException.InvalidProgramException(string?)"/>
   /// <exception cref="InvalidProgramException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidProgram(this IThrowFor @throw, string? message)
   {
      throw new InvalidProgramException(message);
   }
   
   /// <inheritdoc cref="InvalidProgramException.InvalidProgramException(string?, Exception?)"/>
   /// <exception cref="InvalidProgramException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidProgram(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new InvalidProgramException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="InvalidProgramException.InvalidProgramException()"/>
   /// <exception cref="InvalidProgramException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidProgram<T>(this IThrowFor @throw)
   {
      InvalidProgram(@throw);
      return default;
   }
   
   /// <inheritdoc cref="InvalidProgramException.InvalidProgramException(string?)"/>
   /// <exception cref="InvalidProgramException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidProgram<T>(this IThrowFor @throw, string? message)
   {
      InvalidProgram(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="InvalidProgramException.InvalidProgramException(string?, Exception?)"/>
   /// <exception cref="InvalidProgramException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidProgram<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      InvalidProgram(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
