#nullable enable

using System.Reflection;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ReflectionTypeLoadException.ReflectionTypeLoadException(Type?[], Exception?[])"/>
   /// <exception cref="ReflectionTypeLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ReflectionTypeLoad(this IThrowFor @throw, Type?[]? classes, Exception?[]? exceptions)
   {
      throw new ReflectionTypeLoadException(classes, exceptions);
   }
   
   /// <inheritdoc cref="ReflectionTypeLoadException.ReflectionTypeLoadException(Type?[], Exception?[], string?)"/>
   /// <exception cref="ReflectionTypeLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ReflectionTypeLoad(this IThrowFor @throw, Type?[]? classes, Exception?[]? exceptions, string? message)
   {
      throw new ReflectionTypeLoadException(classes, exceptions, message);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="ReflectionTypeLoadException.ReflectionTypeLoadException(Type?[], Exception?[])"/>
   /// <exception cref="ReflectionTypeLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ReflectionTypeLoad<T>(this IThrowFor @throw, Type?[]? classes, Exception?[]? exceptions)
   {
      ReflectionTypeLoad(@throw, classes, exceptions);
      return default;
   }
   
   /// <inheritdoc cref="ReflectionTypeLoadException.ReflectionTypeLoadException(Type?[], Exception?[], string?)"/>
   /// <exception cref="ReflectionTypeLoadException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ReflectionTypeLoad<T>(this IThrowFor @throw, Type?[]? classes, Exception?[]? exceptions, string? message)
   {
      ReflectionTypeLoad(@throw, classes, exceptions, message);
      return default;
   }
   #endregion
}

#nullable restore
