namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="MissingFieldException()"/>
   /// <exception cref="MissingFieldException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingField(this IThrowFor @throw)
   {
      throw new MissingFieldException();
   }

   /// <inheritdoc cref="MissingFieldException(string)"/>
   /// <exception cref="MissingFieldException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingField(this IThrowFor @throw, string? message)
   {
      throw new MissingFieldException(message);
   }

   /// <inheritdoc cref="MissingFieldException(string, Exception)"/>
   /// <exception cref="MissingFieldException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingField(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new MissingFieldException(message, inner);
   }

   /// <inheritdoc cref="MissingFieldException(string, string)"/>
   /// <exception cref="MissingFieldException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingField(this IThrowFor @throw, string? className, string? fieldName)
   {
      throw new MissingFieldException(className, fieldName);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="MissingFieldException()"/>
   /// <exception cref="MissingFieldException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingField<T>(this IThrowFor @throw)
   {
      MissingField(@throw);
      return default!;
   }

   /// <inheritdoc cref="MissingFieldException(string)"/>
   /// <exception cref="MissingFieldException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingField<T>(this IThrowFor @throw, string? message)
   {
      MissingField(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="MissingFieldException(string, Exception)"/>
   /// <exception cref="MissingFieldException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingField<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      MissingField(@throw, message, inner);
      return default!;
   }

   /// <inheritdoc cref="MissingFieldException(string, string)"/>
   /// <exception cref="MissingFieldException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingField<T>(this IThrowFor @throw, string? className, string? fieldName)
   {
      MissingField(@throw, className, fieldName);
      return default!;
   }
   #endregion
}
