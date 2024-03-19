using System.Reflection;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="ReflectionTypeLoadException(Type[], Exception[])"/>
   /// <exception cref="ReflectionTypeLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ReflectionTypeLoad(this IThrow @throw, Type?[]? classes, Exception?[]? exceptions)
   {
      throw new ReflectionTypeLoadException(classes, exceptions);
   }

   /// <inheritdoc cref="ReflectionTypeLoadException(Type[], Exception[], string)"/>
   /// <exception cref="ReflectionTypeLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void ReflectionTypeLoad(this IThrow @throw, Type?[]? classes, Exception?[]? exceptions, string? message)
   {
      throw new ReflectionTypeLoadException(classes, exceptions, message);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="ReflectionTypeLoadException(Type[], Exception[])"/>
   /// <exception cref="ReflectionTypeLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ReflectionTypeLoad<T>(this IThrow @throw, Type?[]? classes, Exception?[]? exceptions)
   {
      ReflectionTypeLoad(@throw, classes, exceptions);
      return default!;
   }

   /// <inheritdoc cref="ReflectionTypeLoadException(Type[], Exception[], string)"/>
   /// <exception cref="ReflectionTypeLoadException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T ReflectionTypeLoad<T>(this IThrow @throw, Type?[]? classes, Exception?[]? exceptions, string? message)
   {
      ReflectionTypeLoad(@throw, classes, exceptions, message);
      return default!;
   }
   #endregion
}
