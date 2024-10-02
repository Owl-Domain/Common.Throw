#nullable enable

using System.Resources;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="MissingSatelliteAssemblyException.MissingSatelliteAssemblyException()"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingSatelliteAssembly(this IThrowFor @throw)
   {
      throw new MissingSatelliteAssemblyException();
   }
   
   /// <inheritdoc cref="MissingSatelliteAssemblyException.MissingSatelliteAssemblyException(string?)"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingSatelliteAssembly(this IThrowFor @throw, string? message)
   {
      throw new MissingSatelliteAssemblyException(message);
   }
   
   /// <inheritdoc cref="MissingSatelliteAssemblyException.MissingSatelliteAssemblyException(string?, string?)"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingSatelliteAssembly(this IThrowFor @throw, string? message, string? cultureName)
   {
      throw new MissingSatelliteAssemblyException(message, cultureName);
   }
   
   /// <inheritdoc cref="MissingSatelliteAssemblyException.MissingSatelliteAssemblyException(string?, Exception?)"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void MissingSatelliteAssembly(this IThrowFor @throw, string? message, Exception? inner)
   {
      throw new MissingSatelliteAssemblyException(message, inner);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="MissingSatelliteAssemblyException.MissingSatelliteAssemblyException()"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingSatelliteAssembly<T>(this IThrowFor @throw)
   {
      MissingSatelliteAssembly(@throw);
      return default;
   }
   
   /// <inheritdoc cref="MissingSatelliteAssemblyException.MissingSatelliteAssemblyException(string?)"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingSatelliteAssembly<T>(this IThrowFor @throw, string? message)
   {
      MissingSatelliteAssembly(@throw, message);
      return default;
   }
   
   /// <inheritdoc cref="MissingSatelliteAssemblyException.MissingSatelliteAssemblyException(string?, string?)"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingSatelliteAssembly<T>(this IThrowFor @throw, string? message, string? cultureName)
   {
      MissingSatelliteAssembly(@throw, message, cultureName);
      return default;
   }
   
   /// <inheritdoc cref="MissingSatelliteAssemblyException.MissingSatelliteAssemblyException(string?, Exception?)"/>
   /// <exception cref="MissingSatelliteAssemblyException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T MissingSatelliteAssembly<T>(this IThrowFor @throw, string? message, Exception? inner)
   {
      MissingSatelliteAssembly(@throw, message, inner);
      return default;
   }
   #endregion
}

#nullable restore
