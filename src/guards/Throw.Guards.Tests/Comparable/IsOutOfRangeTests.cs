namespace OwlDomain.Common.Guards.Tests.Comparable;

[TestClass]
public sealed class IsOutOfRangeTests
{
   #region Tests
   [DataRow(0, 5, 10, DisplayName = "Value too low")]
   [DataRow(10, 0, 5, DisplayName = "Value too high")]
   [TestMethod]
   public void IsOutOfRange_WithValueOutOfRange_ThrowsArgumentOutOfRangeException(int value, int minimum, int maximum)
   {
      // Arrange
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.IfArgument.IsOutOfRange(value, minimum, maximum);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentOutOfRangeException exception)
         .AreEqual(exception.ParamName, expectedParameterName)
         .AreEqual(exception.ActualValue, value);
   }

   [DataRow(5, 5, 10, DisplayName = "Value equal to minimum")]
   [DataRow(5, 0, 5, DisplayName = "Value equal to maximum")]
   [DataRow(5, 0, 10, DisplayName = "Value in the middle")]
   [TestMethod]
   public void IsOutOfRange_WithValueInRange_DoesNothing(int value, int minimum, int maximum)
   {
      // Act
      void Act() => Throw.IfArgument.IsOutOfRange(value, minimum, maximum);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
