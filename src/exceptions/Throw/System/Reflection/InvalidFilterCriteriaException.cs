using System.Reflection;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="InvalidFilterCriteriaException()"/>
   /// <exception cref="InvalidFilterCriteriaException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidFilterCriteria(this IThrow @throw)
   {
      throw new InvalidFilterCriteriaException();
   }

   /// <inheritdoc cref="InvalidFilterCriteriaException(string)"/>
   /// <exception cref="InvalidFilterCriteriaException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidFilterCriteria(this IThrow @throw, string? message)
   {
      throw new InvalidFilterCriteriaException(message);
   }

   /// <inheritdoc cref="InvalidFilterCriteriaException(string, Exception)"/>
   /// <exception cref="InvalidFilterCriteriaException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void InvalidFilterCriteria(this IThrow @throw, string? message, Exception? inner)
   {
      throw new InvalidFilterCriteriaException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="InvalidFilterCriteriaException()"/>
   /// <exception cref="InvalidFilterCriteriaException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidFilterCriteria<T>(this IThrow @throw)
   {
      InvalidFilterCriteria(@throw);
      return default!;
   }

   /// <inheritdoc cref="InvalidFilterCriteriaException(string)"/>
   /// <exception cref="InvalidFilterCriteriaException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidFilterCriteria<T>(this IThrow @throw, string? message)
   {
      InvalidFilterCriteria(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="InvalidFilterCriteriaException(string, Exception)"/>
   /// <exception cref="InvalidFilterCriteriaException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T InvalidFilterCriteria<T>(this IThrow @throw, string? message, Exception? inner)
   {
      InvalidFilterCriteria(@throw, message, inner);
      return default!;
   }
   #endregion
}
