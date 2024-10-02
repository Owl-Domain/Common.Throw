#nullable enable

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="RuntimeWrappedException.RuntimeWrappedException(object)"/>
   /// <exception cref="RuntimeWrappedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.NoInlining)]
   public static void RuntimeWrapped(this IThrowFor @throw, object thrownObject)
   {
      throw new RuntimeWrappedException(thrownObject);
   }
   #endregion
   
   #region Generic methods
   /// <inheritdoc cref="RuntimeWrappedException.RuntimeWrappedException(object)"/>
   /// <exception cref="RuntimeWrappedException"/>
   [DoesNotReturn, StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T RuntimeWrapped<T>(this IThrowFor @throw, object thrownObject)
   {
      RuntimeWrapped(@throw, thrownObject);
      return default;
   }
   #endregion
}

#nullable restore
