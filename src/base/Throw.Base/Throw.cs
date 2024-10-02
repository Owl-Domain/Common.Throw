namespace OwlDomain.Common;

/// <summary>
/// Represents a class that can be used to access extension methods for throwing exceptions.
/// </summary>
public sealed class Throw : IThrowFor, IThrowIfArgument
{
   #region Properties
   /// <summary>The property through which the extension methods for throwing exceptions can be accessed.</summary>
   public static IThrowFor For { get; }

   /// <summary>The property through which the extension methods for argument guard checks can be accessed.</summary>
   public static IThrowIfArgument IfArgument { get; }
   #endregion

   #region Constructors
   private Throw() { }
   static Throw()
   {
      Throw instance = new();

      For = instance;
      IfArgument = instance;
   }
   #endregion
}
