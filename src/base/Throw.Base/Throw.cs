namespace OwlDomain.Common;

/// <summary>
/// Represents a class that can be used to access extension methods for throwing exceptions.
/// </summary>
public sealed class Throw : IThrowFor, IThrowIf
{
   #region Properties
   /// <summary>The property through which the extension methods for throwing exceptions can be accessed.</summary>
   public static IThrowFor For { get; }

   /// <summary>The property through which the extension methods for guard checks can be accessed.</summary>
   public static IThrowIf If { get; }
   #endregion

   #region Constructors
   private Throw() { }
   static Throw()
   {
      Throw instance = new Throw();

      For = instance;
      If = instance;
   }
   #endregion
}
