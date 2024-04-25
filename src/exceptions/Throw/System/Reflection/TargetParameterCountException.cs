using System.Reflection;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TargetParameterCountException()"/>
   /// <exception cref="TargetParameterCountException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TargetParameterCount(this IThrowFor @throw)
   {
      throw new TargetParameterCountException();
   }

   /// <inheritdoc cref="TargetParameterCountException(string)"/>
   /// <exception cref="TargetParameterCountException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TargetParameterCount(this IThrowFor @throw, string? message)
   {
      throw new TargetParameterCountException(message);
   }

   /// <inheritdoc cref="TargetParameterCountException(string, Exception)"/>
   /// <exception cref="TargetParameterCountException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TargetParameterCount(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new TargetParameterCountException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="TargetParameterCountException()"/>
   /// <exception cref="TargetParameterCountException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TargetParameterCount<T>(this IThrowFor @throw)
   {
      TargetParameterCount(@throw);
      return default!;
   }

   /// <inheritdoc cref="TargetParameterCountException(string)"/>
   /// <exception cref="TargetParameterCountException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TargetParameterCount<T>(this IThrowFor @throw, string? message)
   {
      TargetParameterCount(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="TargetParameterCountException(string, Exception)"/>
   /// <exception cref="TargetParameterCountException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TargetParameterCount<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      TargetParameterCount(@throw, message, inner);
      return default!;
   }
   #endregion
}
