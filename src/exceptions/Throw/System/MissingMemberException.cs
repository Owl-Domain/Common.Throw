namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="MissingMemberException()"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingMember(this IThrow @throw)
   {
      throw new MissingMemberException();
   }

   /// <inheritdoc cref="MissingMemberException(string)"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingMember(this IThrow @throw, string? message)
   {
      throw new MissingMemberException(message);
   }

   /// <inheritdoc cref="MissingMemberException(string, Exception)"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingMember(this IThrow @throw, string? message, Exception? inner)
   {
      throw new MissingMemberException(message, inner);
   }

   /// <inheritdoc cref="MissingMemberException(string, string)"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingMember(this IThrow @throw, string? className, string? memberName)
   {
      throw new MissingMemberException(className, memberName);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="MissingMemberException()"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingMember<T>(this IThrow @throw)
   {
      MissingMember(@throw);
      return default!;
   }

   /// <inheritdoc cref="MissingMemberException(string)"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingMember<T>(this IThrow @throw, string? message)
   {
      MissingMember(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="MissingMemberException(string, Exception)"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingMember<T>(this IThrow @throw, string? message, Exception? inner)
   {
      MissingMember(@throw, message, inner);
      return default!;
   }

   /// <inheritdoc cref="MissingMemberException(string, string)"/>
   /// <exception cref="MissingMemberException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingMember<T>(this IThrow @throw, string? className, string? memberName)
   {
      MissingMember(@throw, className, memberName);
      return default!;
   }
   #endregion
}
