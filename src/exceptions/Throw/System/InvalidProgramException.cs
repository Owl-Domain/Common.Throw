namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InvalidProgramException()"/>
   /// <exception cref="InvalidProgramException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidProgram(this IThrow @throw)
   {
      throw new InvalidProgramException();
   }

   /// <inheritdoc cref="InvalidProgramException(string)"/>
   /// <exception cref="InvalidProgramException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidProgram(this IThrow @throw, string? message)
   {
      throw new InvalidProgramException(message);
   }

   /// <inheritdoc cref="InvalidProgramException(string, Exception)"/>
   /// <exception cref="InvalidProgramException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidProgram(this IThrow @throw, string? message, Exception? inner)
   {
      throw new InvalidProgramException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="InvalidProgramException()"/>
   /// <exception cref="InvalidProgramException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidProgram<T>(this IThrow @throw)
   {
      InvalidProgram(@throw);
      return default!;
   }

   /// <inheritdoc cref="InvalidProgramException(string)"/>
   /// <exception cref="InvalidProgramException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidProgram<T>(this IThrow @throw, string? message)
   {
      InvalidProgram(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="InvalidProgramException(string, Exception)"/>
   /// <exception cref="InvalidProgramException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidProgram<T>(this IThrow @throw, string? message, Exception? inner)
   {
      InvalidProgram(@throw, message, inner);
      return default!;
   }
   #endregion
}
