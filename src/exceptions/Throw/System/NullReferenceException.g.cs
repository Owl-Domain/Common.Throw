#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="NullReferenceException.NullReferenceException()"/>
   /// <exception cref="NullReferenceException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NullReference(this IThrowFor @throw)
   {
      throw new NullReferenceException();
   }
   
   /// <inheritdoc cref="NullReferenceException.NullReferenceException(string?)"/>
   /// <exception cref="NullReferenceException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NullReference(this IThrowFor @throw, string? message)
   {
      throw new NullReferenceException(message);
   }
   
   /// <inheritdoc cref="NullReferenceException.NullReferenceException(string?, Exception?)"/>
   /// <exception cref="NullReferenceException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void NullReference(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new NullReferenceException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="NullReferenceException.NullReferenceException()"/>
   /// <exception cref="NullReferenceException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NullReference<T>(this IThrowFor @throw)
   {
      NullReference(@throw);
      return default;
   }
   
   /// <inheritdoc cref="NullReferenceException.NullReferenceException(string?)"/>
   /// <exception cref="NullReferenceException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NullReference<T>(this IThrowFor @throw, string? message)
   {
      NullReference(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="NullReferenceException.NullReferenceException(string?, Exception?)"/>
   /// <exception cref="NullReferenceException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T NullReference<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      NullReference(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
