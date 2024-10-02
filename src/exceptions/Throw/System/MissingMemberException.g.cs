#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="MissingMemberException.MissingMemberException()"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingMember(this IThrowFor @throw)
   {
      throw new MissingMemberException();
   }
   
   /// <inheritdoc cref="MissingMemberException.MissingMemberException(string?)"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingMember(this IThrowFor @throw, string? message)
   {
      throw new MissingMemberException(message);
   }
   
   /// <inheritdoc cref="MissingMemberException.MissingMemberException(string?, Exception?)"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingMember(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new MissingMemberException(message, inner);
   }
   
   /// <inheritdoc cref="MissingMemberException.MissingMemberException(string?, string?)"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingMember(this IThrowFor @throw, string? className, string? memberName)
   {
      throw new MissingMemberException(className, memberName);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="MissingMemberException.MissingMemberException()"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingMember<T>(this IThrowFor @throw)
   {
      MissingMember(@throw);
      return default;
   }
   
   /// <inheritdoc cref="MissingMemberException.MissingMemberException(string?)"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingMember<T>(this IThrowFor @throw, string? message)
   {
      MissingMember(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="MissingMemberException.MissingMemberException(string?, Exception?)"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingMember<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      MissingMember(@throw, message, inner);
      return default;
   }
   
   /// <inheritdoc cref="MissingMemberException.MissingMemberException(string?, string?)"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingMember<T>(this IThrowFor @throw, string? className, string? memberName)
   {
      MissingMember(@throw, className, memberName);
      return default;
   }
   #endregion
}

#nullable restore
