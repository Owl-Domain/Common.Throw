using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="COMException()"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void COM(this IThrow @throw)
   {
      throw new COMException();
   }

   /// <inheritdoc cref="COMException(string)"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void COM(this IThrow @throw, string? message)
   {
      throw new COMException(message);
   }

   /// <inheritdoc cref="COMException(string, Exception)"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void COM(this IThrow @throw, string? message, Exception? inner)
   {
      throw new COMException(message, inner);
   }

   /// <inheritdoc cref="COMException(string, int)"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void COM(this IThrow @throw, string? message, int errorCode)
   {
      throw new COMException(message, errorCode);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="COMException()"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T COM<T>(this IThrow @throw)
   {
      COM(@throw);
      return default!;
   }

   /// <inheritdoc cref="COMException(string)"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T COM<T>(this IThrow @throw, string? message)
   {
      COM(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="COMException(string, Exception)"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T COM<T>(this IThrow @throw, string? message, Exception? inner)
   {
      COM(@throw, message, inner);
      return default!;
   }

   /// <inheritdoc cref="COMException(string, int)"/>
   /// <exception cref="COMException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T COM<T>(this IThrow @throw, string? message, int errorCode)
   {
      COM(@throw, message, errorCode);
      return default!;
   }
   #endregion
}
