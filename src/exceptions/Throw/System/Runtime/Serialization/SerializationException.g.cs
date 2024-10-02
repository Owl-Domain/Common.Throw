#nullable enable

using System.Runtime.Serialization;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SerializationException.SerializationException()"/>
   /// <exception cref="SerializationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Serialization(this IThrowFor @throw)
   {
      throw new SerializationException();
   }
   
   /// <inheritdoc cref="SerializationException.SerializationException(string?)"/>
   /// <exception cref="SerializationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Serialization(this IThrowFor @throw, string? message)
   {
      throw new SerializationException(message);
   }
   
   /// <inheritdoc cref="SerializationException.SerializationException(string?, Exception?)"/>
   /// <exception cref="SerializationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Serialization(this IThrowFor @throw, string? message, Exception? innerException)
   {
      throw new SerializationException(message, innerException);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="SerializationException.SerializationException()"/>
   /// <exception cref="SerializationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Serialization<T>(this IThrowFor @throw)
   {
      Serialization(@throw);
      return default;
   }
   
   /// <inheritdoc cref="SerializationException.SerializationException(string?)"/>
   /// <exception cref="SerializationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Serialization<T>(this IThrowFor @throw, string? message)
   {
      Serialization(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="SerializationException.SerializationException(string?, Exception?)"/>
   /// <exception cref="SerializationException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Serialization<T>(this IThrowFor @throw, string? message, Exception? innerException)
   {
      Serialization(@throw, message, innerException);
      return default;
   }
   #endregion
}

#nullable restore
