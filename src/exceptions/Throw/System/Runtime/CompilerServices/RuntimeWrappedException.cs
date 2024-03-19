using System.Runtime.CompilerServices;

namespace OwlDomain.Common;

public static partial class ThrowExtensions
{
   #region Methods
   /// <inheritdoc cref="RuntimeWrappedException(Object)"/>
   /// <exception cref="RuntimeWrappedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
   public static void RuntimeWrapped(this IThrow @throw, Object thrownObject)
   {
      throw new RuntimeWrappedException(thrownObject);
   }
   #endregion

   #region Generic methods
   /// <inheritdoc cref="RuntimeWrappedException(Object)"/>
   /// <exception cref="RuntimeWrappedException"/>
   [DoesNotReturn, MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static T RuntimeWrapped<T>(this IThrow @throw, Object thrownObject)
   {
      RuntimeWrapped(@throw, thrownObject);
      return default!;
   }
   #endregion
}
