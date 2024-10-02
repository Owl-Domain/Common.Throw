namespace OwlDomain.Common.Guards.Tests.Enums;

[TestClass]
public sealed class IsNotDefinedTests
{
   #region Nested types
   private enum TestEnum { A = 1, B = 2, C = 3 }
   #endregion

   #region Tests
   [TestMethod]
   public void IsNotDefined_WithNotDefinedValue_ThrowsArgumentException()
   {
      // Arrange
      const TestEnum value = 0;
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsNotDefined(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNotDefined_WithDefinedValue_DoesNothing()
   {
      // Arrange
      const TestEnum value = TestEnum.A;

      // Act
      static void Act() => Throw.IfArgument.IsNotDefined(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
