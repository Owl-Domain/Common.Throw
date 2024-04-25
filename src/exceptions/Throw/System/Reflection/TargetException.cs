using System.Reflection;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TargetException()"/>
   /// <exception cref="TargetException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Target(this IThrowFor @throw)
   {
      throw new TargetException();
   }

   /// <inheritdoc cref="TargetException(string)"/>
   /// <exception cref="TargetException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Target(this IThrowFor @throw, string? message)
   {
      throw new TargetException(message);
   }

   /// <inheritdoc cref="TargetException(string, Exception)"/>
   /// <exception cref="TargetException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Target(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new TargetException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="TargetException()"/>
   /// <exception cref="TargetException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Target<T>(this IThrowFor @throw)
   {
      Target(@throw);
      return default!;
   }

   /// <inheritdoc cref="TargetException(string)"/>
   /// <exception cref="TargetException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Target<T>(this IThrowFor @throw, string? message)
   {
      Target(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="TargetException(string, Exception)"/>
   /// <exception cref="TargetException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Target<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      Target(@throw, message, inner);
      return default!;
   }
   #endregion
}
