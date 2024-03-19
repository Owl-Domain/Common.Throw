using System.Resources;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="MissingSatelliteAssemblyException()"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingSatelliteAssembly(this IThrow @throw)
   {
      throw new MissingSatelliteAssemblyException();
   }

   /// <inheritdoc cref="MissingSatelliteAssemblyException(string)"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingSatelliteAssembly(this IThrow @throw, string? message)
   {
      throw new MissingSatelliteAssemblyException(message);
   }

   /// <inheritdoc cref="MissingSatelliteAssemblyException(string, string)"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingSatelliteAssembly(this IThrow @throw, string? message, string? cultureName)
   {
      throw new MissingSatelliteAssemblyException(message, cultureName);
   }

   /// <inheritdoc cref="MissingSatelliteAssemblyException(string, Exception)"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingSatelliteAssembly(this IThrow @throw, string? message, Exception? inner)
   {
      throw new MissingSatelliteAssemblyException(message, inner);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="MissingSatelliteAssemblyException()"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingSatelliteAssembly<T>(this IThrow @throw)
   {
      MissingSatelliteAssembly(@throw);
      return default!;
   }

   /// <inheritdoc cref="MissingSatelliteAssemblyException(string)"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingSatelliteAssembly<T>(this IThrow @throw, string? message)
   {
      MissingSatelliteAssembly(@throw, message);
      return default!;
   }

   /// <inheritdoc cref="MissingSatelliteAssemblyException(string, string)"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingSatelliteAssembly<T>(this IThrow @throw, string? message, string? cultureName)
   {
      MissingSatelliteAssembly(@throw, message, cultureName);
      return default!;
   }

   /// <inheritdoc cref="MissingSatelliteAssemblyException(string, Exception)"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingSatelliteAssembly<T>(this IThrow @throw, string? message, Exception? inner)
   {
      MissingSatelliteAssembly(@throw, message, inner);
      return default!;
   }
   #endregion
}
