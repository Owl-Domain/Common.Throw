namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="AggregateException()"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Aggregate(this IThrowFor @throw)
   {
      throw new AggregateException();
   }

   /// <inheritdoc cref="AggregateException(string)"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Aggregate(this IThrowFor @throw, string? message)
   {
      throw new AggregateException(message);
   }

   /// <inheritdoc cref="AggregateException(string, Exception)"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Aggregate(this IThrowFor @throw, string? message, Exception innerException)
   {
      throw new AggregateException(message, innerException);
   }

   /// <inheritdoc cref="AggregateException(IEnumerable{Exception})"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Aggregate(this IThrowFor @throw, IEnumerable<Exception> innerExceptions)
   {
      throw new AggregateException(innerExceptions);
   }

   /// <inheritdoc cref="AggregateException(Exception[])"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Aggregate(this IThrowFor @throw, params Exception[] innerExceptions)
   {
      throw new AggregateException(innerExceptions);
   }

   /// <inheritdoc cref="AggregateException(string, IEnumerable{Exception})"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Aggregate(this IThrowFor @throw, string? message, IEnumerable<Exception> innerExceptions)
   {
      throw new AggregateException(message, innerExceptions);
   }

   /// <inheritdoc cref="AggregateException(string, Exception[])"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Aggregate(this IThrowFor @throw, string? message, params Exception[] innerExceptions)
   {
      throw new AggregateException(message, innerExceptions);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="AggregateException()"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Aggregate<T>(this IThrowFor @throw)
   {
      Aggregate(@throw);
      return default!;
   }

   /// <inheritdoc cref="AggregateException(string)"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Aggregate<T>(this IThrowFor @throw, string? message)
   {
      Aggregate(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="AggregateException(string, Exception)"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Aggregate<T>(this IThrowFor @throw, string? message, Exception innerException)
   {
      Aggregate(@throw, message, innerException);
      return default!;
   }

   /// <inheritdoc cref="AggregateException(IEnumerable{Exception})"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Aggregate<T>(this IThrowFor @throw, IEnumerable<Exception> innerExceptions)
   {
      Aggregate(@throw, innerExceptions);
      return default!;
   }

   /// <inheritdoc cref="AggregateException(Exception[])"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Aggregate<T>(this IThrowFor @throw, params Exception[] innerExceptions)
   {
      Aggregate(@throw, innerExceptions);
      return default!;
   }

   /// <inheritdoc cref="AggregateException(string, IEnumerable{Exception})"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Aggregate<T>(this IThrowFor @throw, string? message, IEnumerable<Exception> innerExceptions)
   {
      Aggregate(@throw, message, innerExceptions);
      return default!;
   }

   /// <inheritdoc cref="AggregateException(string, Exception[])"/>
   /// <exception cref="AggregateException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Aggregate<T>(this IThrowFor @throw, string? message, params Exception[] innerExceptions)
   {
      Aggregate(@throw, message, innerExceptions);
      return default!;
   }
   #endregion
}
