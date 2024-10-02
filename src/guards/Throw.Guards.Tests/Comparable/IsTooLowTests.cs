namespace OwlDomain.Common.Guards.Tests.Comparable;

[TestClass]
public sealed class IsTooLowTests
{
   #region Tests
   [TestMethod]
   public void IsTooLow_WithTooLowValue_ThrowsArgumentOutOfRangeException()
   {
      // Arrange
      const int value = 5;
      const int threshold = 10;

      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsTooLow(value, threshold);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentOutOfRangeException exception)
         .AreEqual(exception.ParamName, expectedParameterName)
         .AreEqual(exception.ActualValue, value);
   }

   [DataRow(10, 10, DisplayName = "Equal to threshold")]
   [DataRow(15, 10, DisplayName = "Higher than threshold")]
   [TestMethod]
   public void IsTooLow_WithTooLowValue_DoesNothing(int value, int threshold)
   {
      // Act
      void Act() => Throw.IfArgument.IsTooLow(value, threshold);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
