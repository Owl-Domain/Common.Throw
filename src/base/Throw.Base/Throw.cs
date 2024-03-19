namespace OwlDomain.Common;

/// <summary>
/// Represents a class that can be used to access extension methods for throwing exceptions.
/// </summary>
public sealed class Throw : IThrow
{
   #region Properties
   /// <summary>The property through which the extension methods for throwing exceptions can be accessed.</summary>
   public static IThrow For { get; } = new Throw();
   #endregion

   #region Constructors
   private Throw() { }
   #endregion
}
