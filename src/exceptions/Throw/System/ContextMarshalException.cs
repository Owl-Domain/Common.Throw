namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ContextMarshalException()"/>
   /// <exception cref="ContextMarshalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ContextMarshal(this IThrow @throw)
   {
      throw new ContextMarshalException();
   }

   /// <inheritdoc cref="ContextMarshalException(string)"/>
   /// <exception cref="ContextMarshalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ContextMarshal(this IThrow @throw, string? message)
   {
      throw new ContextMarshalException(message);
   }

   /// <inheritdoc cref="ContextMarshalException(string, Exception)"/>
   /// <exception cref="ContextMarshalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ContextMarshal(this IThrow @throw, string? message, Exception? inner)
   {
      throw new ContextMarshalException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="ContextMarshalException()"/>
   /// <exception cref="ContextMarshalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ContextMarshal<T>(this IThrow @throw)
   {
      ContextMarshal(@throw);
      return default!;
   }

   /// <inheritdoc cref="ContextMarshalException(string)"/>
   /// <exception cref="ContextMarshalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ContextMarshal<T>(this IThrow @throw, string? message)
   {
      ContextMarshal(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="ContextMarshalException(string, Exception)"/>
   /// <exception cref="ContextMarshalException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ContextMarshal<T>(this IThrow @throw, string? message, Exception? inner)
   {
      ContextMarshal(@throw, message, inner);
      return default!;
   }
   #endregion
}
