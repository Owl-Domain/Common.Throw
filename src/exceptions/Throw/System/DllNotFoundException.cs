namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="DllNotFoundException()"/>
   /// <exception cref="DllNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DllNotFound(this IThrow @throw)
   {
      throw new DllNotFoundException();
   }

   /// <inheritdoc cref="DllNotFoundException(string)"/>
   /// <exception cref="DllNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DllNotFound(this IThrow @throw, string? message)
   {
      throw new DllNotFoundException(message);
   }

   /// <inheritdoc cref="DllNotFoundException(string, Exception)"/>
   /// <exception cref="DllNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void DllNotFound(this IThrow @throw, string? message, Exception? inner)
   {
      throw new DllNotFoundException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="DllNotFoundException()"/>
   /// <exception cref="DllNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DllNotFound<T>(this IThrow @throw)
   {
      DllNotFound(@throw);
      return default!;
   }

   /// <inheritdoc cref="DllNotFoundException(string)"/>
   /// <exception cref="DllNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DllNotFound<T>(this IThrow @throw, string? message)
   {
      DllNotFound(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="DllNotFoundException(string, Exception)"/>
   /// <exception cref="DllNotFoundException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T DllNotFound<T>(this IThrow @throw, string? message, Exception? inner)
   {
      DllNotFound(@throw, message, inner);
      return default!;
   }
   #endregion
}
