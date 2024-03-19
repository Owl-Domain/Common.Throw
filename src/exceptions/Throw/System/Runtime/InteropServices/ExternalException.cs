using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ExternalException()"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void External(this IThrow @throw)
   {
      throw new ExternalException();
   }

   /// <inheritdoc cref="ExternalException(string)"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void External(this IThrow @throw, string? message)
   {
      throw new ExternalException(message);
   }

   /// <inheritdoc cref="ExternalException(string, Exception)"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void External(this IThrow @throw, string? message, Exception? inner)
   {
      throw new ExternalException(message, inner);
   }

   /// <inheritdoc cref="ExternalException(string, int)"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void External(this IThrow @throw, string? message, int errorCode)
   {
      throw new ExternalException(message, errorCode);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="ExternalException()"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T External<T>(this IThrow @throw)
   {
      External(@throw);
      return default!;
   }

   /// <inheritdoc cref="ExternalException(string)"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T External<T>(this IThrow @throw, string? message)
   {
      External(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="ExternalException(string, Exception)"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T External<T>(this IThrow @throw, string? message, Exception? inner)
   {
      External(@throw, message, inner);
      return default!;
   }

   /// <inheritdoc cref="ExternalException(string, int)"/>
   /// <exception cref="ExternalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T External<T>(this IThrow @throw, string? message, int errorCode)
   {
      External(@throw, message, errorCode);
      return default!;
   }
   #endregion
}
