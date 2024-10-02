#nullable enable

using System.Reflection;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="CustomAttributeFormatException.CustomAttributeFormatException()"/>
   /// <exception cref="CustomAttributeFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CustomAttributeFormat(this IThrowFor @throw)
   {
      throw new CustomAttributeFormatException();
   }
   
   /// <inheritdoc cref="CustomAttributeFormatException.CustomAttributeFormatException(string?)"/>
   /// <exception cref="CustomAttributeFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CustomAttributeFormat(this IThrowFor @throw, string? message)
   {
      throw new CustomAttributeFormatException(message);
   }
   
   /// <inheritdoc cref="CustomAttributeFormatException.CustomAttributeFormatException(string?, Exception?)"/>
   /// <exception cref="CustomAttributeFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void CustomAttributeFormat(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new CustomAttributeFormatException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="CustomAttributeFormatException.CustomAttributeFormatException()"/>
   /// <exception cref="CustomAttributeFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CustomAttributeFormat<T>(this IThrowFor @throw)
   {
      CustomAttributeFormat(@throw);
      return default;
   }
   
   /// <inheritdoc cref="CustomAttributeFormatException.CustomAttributeFormatException(string?)"/>
   /// <exception cref="CustomAttributeFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CustomAttributeFormat<T>(this IThrowFor @throw, string? message)
   {
      CustomAttributeFormat(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="CustomAttributeFormatException.CustomAttributeFormatException(string?, Exception?)"/>
   /// <exception cref="CustomAttributeFormatException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T CustomAttributeFormat<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      CustomAttributeFormat(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
