using System.Runtime.Serialization;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="SerializationException()"/>
   /// <exception cref="SerializationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Serialization(this IThrow @throw)
   {
      throw new SerializationException();
   }

   /// <inheritdoc cref="SerializationException(string)"/>
   /// <exception cref="SerializationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Serialization(this IThrow @throw, string? message)
   {
      throw new SerializationException(message);
   }

   /// <inheritdoc cref="SerializationException(string, Exception)"/>
   /// <exception cref="SerializationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void Serialization(this IThrow @throw, string? message, Exception? innerException)
   {
      throw new SerializationException(message, innerException);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="SerializationException()"/>
   /// <exception cref="SerializationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Serialization<T>(this IThrow @throw)
   {
      Serialization(@throw);
      return default!;
   }

   /// <inheritdoc cref="SerializationException(string)"/>
   /// <exception cref="SerializationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Serialization<T>(this IThrow @throw, string? message)
   {
      Serialization(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="SerializationException(string, Exception)"/>
   /// <exception cref="SerializationException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T Serialization<T>(this IThrow @throw, string? message, Exception? innerException)
   {
      Serialization(@throw, message, innerException);
      return default!;
   }
   #endregion
}
