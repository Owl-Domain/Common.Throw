using System.IO;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="FileNotFoundException()"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileNotFound(this IThrow @throw)
   {
      throw new FileNotFoundException();
   }

   /// <inheritdoc cref="FileNotFoundException(string)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileNotFound(this IThrow @throw, string? message)
   {
      throw new FileNotFoundException(message);
   }

   /// <inheritdoc cref="FileNotFoundException(string, Exception)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileNotFound(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new FileNotFoundException(message, innerException);
   }

   /// <inheritdoc cref="FileNotFoundException(string, string)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileNotFound(this IThrow @throw, string? message, string? fileName)
   {
      throw new FileNotFoundException(message, fileName);
   }

   /// <inheritdoc cref="FileNotFoundException(string, string, Exception)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileNotFound(this IThrow @throw, string? message, string? fileName, Exception? innerException)
   {
      throw new FileNotFoundException(message, fileName, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="FileNotFoundException()"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileNotFound<T>(this IThrow @throw)
   {
      FileNotFound(@throw);
      return default!;
   }

   /// <inheritdoc cref="FileNotFoundException(string)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileNotFound<T>(this IThrow @throw, string? message)
   {
      FileNotFound(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="FileNotFoundException(string, Exception)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileNotFound<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      FileNotFound(@throw, message, innerException);
      return default!;
   }

   /// <inheritdoc cref="FileNotFoundException(string, string)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileNotFound<T>(this IThrow @throw, string? message, string? fileName)
   {
      FileNotFound(@throw, message, fileName);
      return default!;
   }

   /// <inheritdoc cref="FileNotFoundException(string, string, Exception)"/>
   /// <exception cref="FileNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileNotFound<T>(this IThrow @throw, string? message, string? fileName, Exception? innerException)
   {
      FileNotFound(@throw, message, fileName, innerException);
      return default!;
   }
   #endregion
}
