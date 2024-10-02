namespace OwlDomain.Common.Guards.Tests.Comparable;

[TestClass]
public sealed class IsTooHighTests
{
   #region Tests
   [TestMethod]
   public void IsTooHigh_WithTooHighValue_ThrowsArgumentOutOfRangeException()
   {
      // Arrange
      const int value = 15;
      const int threshold = 10;

      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsTooHigh(value, threshold);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentOutOfRangeException exception)
         .AreEqual(exception.ParamName, expectedParameterName)
         .AreEqual(exception.ActualValue, value);
   }

   [DataRow(10, 10, DisplayName = "Equal to threshold")]
   [DataRow(5, 10, DisplayName = "Lower than threshold")]
   [TestMethod]
   public void IsTooHigh_WithTooHighValue_DoesNothing(int value, int threshold)
   {
      // Act
      void Act() => Throw.IfArgument.IsTooHigh(value, threshold);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
