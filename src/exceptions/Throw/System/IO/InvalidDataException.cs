using System.IO;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InvalidDataException()"/>
   /// <exception cref="InvalidDataException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidData(this IThrow @throw)
   {
      throw new InvalidDataException();
   }

   /// <inheritdoc cref="InvalidDataException(string)"/>
   /// <exception cref="InvalidDataException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidData(this IThrow @throw, string? message)
   {
      throw new InvalidDataException(message);
   }

   /// <inheritdoc cref="InvalidDataException(string, Exception)"/>
   /// <exception cref="InvalidDataException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidData(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new InvalidDataException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="InvalidDataException()"/>
   /// <exception cref="InvalidDataException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidData<T>(this IThrow @throw)
   {
      InvalidData(@throw);
      return default!;
   }

   /// <inheritdoc cref="InvalidDataException(string)"/>
   /// <exception cref="InvalidDataException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidData<T>(this IThrow @throw, string? message)
   {
      InvalidData(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="InvalidDataException(string, Exception)"/>
   /// <exception cref="InvalidDataException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidData<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      InvalidData(@throw, message, innerException);
      return default!;
   }
   #endregion
}
