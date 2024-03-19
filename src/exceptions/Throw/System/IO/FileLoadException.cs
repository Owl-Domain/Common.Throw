using System.IO;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="FileLoadException()"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileLoad(this IThrow @throw)
   {
      throw new FileLoadException();
   }

   /// <inheritdoc cref="FileLoadException(string)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileLoad(this IThrow @throw, string? message)
   {
      throw new FileLoadException(message);
   }

   /// <inheritdoc cref="FileLoadException(string, Exception)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileLoad(this IThrow @throw, string? message, Exception? inner)
   {
      throw new FileLoadException(message, inner);
   }

   /// <inheritdoc cref="FileLoadException(string, string)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileLoad(this IThrow @throw, string? message, string? fileName)
   {
      throw new FileLoadException(message, fileName);
   }

   /// <inheritdoc cref="FileLoadException(string, string, Exception)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void FileLoad(this IThrow @throw, string? message, string? fileName, Exception? inner)
   {
      throw new FileLoadException(message, fileName, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="FileLoadException()"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileLoad<T>(this IThrow @throw)
   {
      FileLoad(@throw);
      return default!;
   }

   /// <inheritdoc cref="FileLoadException(string)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileLoad<T>(this IThrow @throw, string? message)
   {
      FileLoad(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="FileLoadException(string, Exception)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileLoad<T>(this IThrow @throw, string? message, Exception? inner)
   {
      FileLoad(@throw, message, inner);
      return default!;
   }

   /// <inheritdoc cref="FileLoadException(string, string)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileLoad<T>(this IThrow @throw, string? message, string? fileName)
   {
      FileLoad(@throw, message, fileName);
      return default!;
   }

   /// <inheritdoc cref="FileLoadException(string, string, Exception)"/>
   /// <exception cref="FileLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T FileLoad<T>(this IThrow @throw, string? message, string? fileName, Exception? inner)
   {
      FileLoad(@throw, message, fileName, inner);
      return default!;
   }
   #endregion
}
