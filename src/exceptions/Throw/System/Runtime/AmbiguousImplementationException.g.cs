#nullable enable

using System.Runtime;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="AmbiguousImplementationException.AmbiguousImplementationException()"/>
   /// <exception cref="AmbiguousImplementationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AmbiguousImplementation(this IThrowFor @throw)
   {
      throw new AmbiguousImplementationException();
   }
   
   /// <inheritdoc cref="AmbiguousImplementationException.AmbiguousImplementationException(string?)"/>
   /// <exception cref="AmbiguousImplementationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AmbiguousImplementation(this IThrowFor @throw, string? message)
   {
      throw new AmbiguousImplementationException(message);
   }
   
   /// <inheritdoc cref="AmbiguousImplementationException.AmbiguousImplementationException(string?, Exception?)"/>
   /// <exception cref="AmbiguousImplementationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void AmbiguousImplementation(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new AmbiguousImplementationException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="AmbiguousImplementationException.AmbiguousImplementationException()"/>
   /// <exception cref="AmbiguousImplementationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AmbiguousImplementation<T>(this IThrowFor @throw)
   {
      AmbiguousImplementation(@throw);
      return default;
   }
   
   /// <inheritdoc cref="AmbiguousImplementationException.AmbiguousImplementationException(string?)"/>
   /// <exception cref="AmbiguousImplementationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AmbiguousImplementation<T>(this IThrowFor @throw, string? message)
   {
      AmbiguousImplementation(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="AmbiguousImplementationException.AmbiguousImplementationException(string?, Exception?)"/>
   /// <exception cref="AmbiguousImplementationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T AmbiguousImplementation<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      AmbiguousImplementation(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
