namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="NullReferenceException()"/>
   /// <exception cref="NullReferenceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NullReference(this IThrow @throw)
   {
      throw new NullReferenceException();
   }

   /// <inheritdoc cref="NullReferenceException(string)"/>
   /// <exception cref="NullReferenceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NullReference(this IThrow @throw, string? message)
   {
      throw new NullReferenceException(message);
   }

   /// <inheritdoc cref="NullReferenceException(string, Exception)"/>
   /// <exception cref="NullReferenceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NullReference(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new NullReferenceException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="NullReferenceException()"/>
   /// <exception cref="NullReferenceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NullReference<T>(this IThrow @throw)
   {
      NullReference(@throw);
      return default!;
   }

   /// <inheritdoc cref="NullReferenceException(string)"/>
   /// <exception cref="NullReferenceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NullReference<T>(this IThrow @throw, string? message)
   {
      NullReference(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="NullReferenceException(string, Exception)"/>
   /// <exception cref="NullReferenceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NullReference<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      NullReference(@throw, message, innerException);
      return default!;
   }
   #endregion
}
