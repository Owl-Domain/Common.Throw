#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ContextMarshalException.ContextMarshalException()"/>
   /// <exception cref="ContextMarshalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ContextMarshal(this IThrowFor @throw)
   {
      throw new ContextMarshalException();
   }
   
   /// <inheritdoc cref="ContextMarshalException.ContextMarshalException(string?)"/>
   /// <exception cref="ContextMarshalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ContextMarshal(this IThrowFor @throw, string? message)
   {
      throw new ContextMarshalException(message);
   }
   
   /// <inheritdoc cref="ContextMarshalException.ContextMarshalException(string?, Exception?)"/>
   /// <exception cref="ContextMarshalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ContextMarshal(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new ContextMarshalException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="ContextMarshalException.ContextMarshalException()"/>
   /// <exception cref="ContextMarshalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ContextMarshal<T>(this IThrowFor @throw)
   {
      ContextMarshal(@throw);
      return default;
   }
   
   /// <inheritdoc cref="ContextMarshalException.ContextMarshalException(string?)"/>
   /// <exception cref="ContextMarshalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ContextMarshal<T>(this IThrowFor @throw, string? message)
   {
      ContextMarshal(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="ContextMarshalException.ContextMarshalException(string?, Exception?)"/>
   /// <exception cref="ContextMarshalException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ContextMarshal<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      ContextMarshal(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
