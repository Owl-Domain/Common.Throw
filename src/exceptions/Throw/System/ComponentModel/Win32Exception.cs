using System.ComponentModel;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="Win32Exception()"/>
   /// <exception cref="Win32Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Win32(this IThrow @throw)
   {
      throw new Win32Exception();
   }

   /// <inheritdoc cref="Win32Exception(int)"/>
   /// <exception cref="Win32Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Win32(this IThrow @throw, int error)
   {
      throw new Win32Exception(error);
   }

   /// <inheritdoc cref="Win32Exception(int, string)"/>
   /// <exception cref="Win32Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Win32(this IThrow @throw, int error, string? message)
   {
      throw new Win32Exception(error, message);
   }

   /// <inheritdoc cref="Win32Exception(string)"/>
   /// <exception cref="Win32Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Win32(this IThrow @throw, string? message)
   {
      throw new Win32Exception(message);
   }

   /// <inheritdoc cref="Win32Exception(string, Exception)"/>
   /// <exception cref="Win32Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Win32(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new Win32Exception(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="Win32Exception()"/>
   /// <exception cref="Win32Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Win32<T>(this IThrow @throw)
   {
      Win32(@throw);
      return default!;
   }

   /// <inheritdoc cref="Win32Exception(int)"/>
   /// <exception cref="Win32Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Win32<T>(this IThrow @throw, int error)
   {
      Win32(@throw, error);
      return default!;
   }

   /// <inheritdoc cref="Win32Exception(int, string)"/>
   /// <exception cref="Win32Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Win32<T>(this IThrow @throw, int error, string? message)
   {
      Win32(@throw, error, message);
      return default!;
   }

   /// <inheritdoc cref="Win32Exception(string)"/>
   /// <exception cref="Win32Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Win32<T>(this IThrow @throw, string? message)
   {
      Win32(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="Win32Exception(string, Exception)"/>
   /// <exception cref="Win32Exception"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Win32<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      Win32(@throw, message, innerException);
      return default!;
   }
   #endregion
}
