using System.Runtime.InteropServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="MarshalDirectiveException()"/>
   /// <exception cref="MarshalDirectiveException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MarshalDirective(this IThrowFor @throw)
   {
      throw new MarshalDirectiveException();
   }

   /// <inheritdoc cref="MarshalDirectiveException(string)"/>
   /// <exception cref="MarshalDirectiveException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MarshalDirective(this IThrowFor @throw, string? message)
   {
      throw new MarshalDirectiveException(message);
   }

   /// <inheritdoc cref="MarshalDirectiveException(string, Exception)"/>
   /// <exception cref="MarshalDirectiveException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MarshalDirective(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new MarshalDirectiveException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="MarshalDirectiveException()"/>
   /// <exception cref="MarshalDirectiveException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MarshalDirective<T>(this IThrowFor @throw)
   {
      MarshalDirective(@throw);
      return default!;
   }

   /// <inheritdoc cref="MarshalDirectiveException(string)"/>
   /// <exception cref="MarshalDirectiveException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MarshalDirective<T>(this IThrowFor @throw, string? message)
   {
      MarshalDirective(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="MarshalDirectiveException(string, Exception)"/>
   /// <exception cref="MarshalDirectiveException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MarshalDirective<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      MarshalDirective(@throw, message, inner);
      return default!;
   }
   #endregion
}
