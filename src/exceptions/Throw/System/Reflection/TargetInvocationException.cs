using System.Reflection;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="TargetInvocationException(Exception)"/>
   /// <exception cref="TargetInvocationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TargetInvocation(this IThrowFor @throw, Exception? inner)
   {
      throw new TargetInvocationException(inner);
   }

   /// <inheritdoc cref="TargetInvocationException(string, Exception)"/>
   /// <exception cref="TargetInvocationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void TargetInvocation(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new TargetInvocationException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="TargetInvocationException(Exception)"/>
   /// <exception cref="TargetInvocationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TargetInvocation<T>(this IThrowFor @throw, Exception? inner)
   {
      TargetInvocation(@throw, inner);
      return default!;
   }

   /// <inheritdoc cref="TargetInvocationException(string, Exception)"/>
   /// <exception cref="TargetInvocationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T TargetInvocation<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      TargetInvocation(@throw, message, inner);
      return default!;
   }
   #endregion
}
