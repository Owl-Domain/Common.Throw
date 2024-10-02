#nullable enable

using System.Reflection;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InvalidFilterCriteriaException.InvalidFilterCriteriaException()"/>
   /// <exception cref="InvalidFilterCriteriaException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidFilterCriteria(this IThrowFor @throw)
   {
      throw new InvalidFilterCriteriaException();
   }
   
   /// <inheritdoc cref="InvalidFilterCriteriaException.InvalidFilterCriteriaException(string?)"/>
   /// <exception cref="InvalidFilterCriteriaException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidFilterCriteria(this IThrowFor @throw, string? message)
   {
      throw new InvalidFilterCriteriaException(message);
   }
   
   /// <inheritdoc cref="InvalidFilterCriteriaException.InvalidFilterCriteriaException(string?, Exception?)"/>
   /// <exception cref="InvalidFilterCriteriaException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidFilterCriteria(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new InvalidFilterCriteriaException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="InvalidFilterCriteriaException.InvalidFilterCriteriaException()"/>
   /// <exception cref="InvalidFilterCriteriaException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidFilterCriteria<T>(this IThrowFor @throw)
   {
      InvalidFilterCriteria(@throw);
      return default;
   }
   
   /// <inheritdoc cref="InvalidFilterCriteriaException.InvalidFilterCriteriaException(string?)"/>
   /// <exception cref="InvalidFilterCriteriaException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidFilterCriteria<T>(this IThrowFor @throw, string? message)
   {
      InvalidFilterCriteria(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="InvalidFilterCriteriaException.InvalidFilterCriteriaException(string?, Exception?)"/>
   /// <exception cref="InvalidFilterCriteriaException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidFilterCriteria<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      InvalidFilterCriteria(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
