using System.Resources;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="MissingManifestResourceException()"/>
   /// <exception cref="MissingManifestResourceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingManifestResource(this IThrow @throw)
   {
      throw new MissingManifestResourceException();
   }

   /// <inheritdoc cref="MissingManifestResourceException(string)"/>
   /// <exception cref="MissingManifestResourceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingManifestResource(this IThrow @throw, string? message)
   {
      throw new MissingManifestResourceException(message);
   }

   /// <inheritdoc cref="MissingManifestResourceException(string, Exception)"/>
   /// <exception cref="MissingManifestResourceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingManifestResource(this IThrow @throw, string? message, Exception? inner)
   {
      throw new MissingManifestResourceException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="MissingManifestResourceException()"/>
   /// <exception cref="MissingManifestResourceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingManifestResource<T>(this IThrow @throw)
   {
      MissingManifestResource(@throw);
      return default!;
   }

   /// <inheritdoc cref="MissingManifestResourceException(string)"/>
   /// <exception cref="MissingManifestResourceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingManifestResource<T>(this IThrow @throw, string? message)
   {
      MissingManifestResource(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="MissingManifestResourceException(string, Exception)"/>
   /// <exception cref="MissingManifestResourceException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingManifestResource<T>(this IThrow @throw, string? message, Exception? inner)
   {
      MissingManifestResource(@throw, message, inner);
      return default!;
   }
   #endregion
}
