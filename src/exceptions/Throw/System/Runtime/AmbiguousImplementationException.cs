using System.Runtime;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="AmbiguousImplementationException()"/>
   /// <exception cref="AmbiguousImplementationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AmbiguousImplementation(this IThrow @throw)
   {
      throw new AmbiguousImplementationException();
   }

   /// <inheritdoc cref="AmbiguousImplementationException(string)"/>
   /// <exception cref="AmbiguousImplementationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AmbiguousImplementation(this IThrow @throw, string? message)
   {
      throw new AmbiguousImplementationException(message);
   }

   /// <inheritdoc cref="AmbiguousImplementationException(string, Exception)"/>
   /// <exception cref="AmbiguousImplementationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AmbiguousImplementation(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new AmbiguousImplementationException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="AmbiguousImplementationException()"/>
   /// <exception cref="AmbiguousImplementationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AmbiguousImplementation<T>(this IThrow @throw)
   {
      AmbiguousImplementation(@throw);
      return default!;
   }

   /// <inheritdoc cref="AmbiguousImplementationException(string)"/>
   /// <exception cref="AmbiguousImplementationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AmbiguousImplementation<T>(this IThrow @throw, string? message)
   {
      AmbiguousImplementation(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="AmbiguousImplementationException(string, Exception)"/>
   /// <exception cref="AmbiguousImplementationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AmbiguousImplementation<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      AmbiguousImplementation(@throw, message, innerException);
      return default!;
   }
   #endregion
}
