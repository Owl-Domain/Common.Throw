namespace OwlDomain.Common.Guards.Tests.Types;

[TestClass]
public sealed class IsNotOfTypeTests
{
   #region Tests
   [TestMethod]
   public void IsNotOfType_WithResult_WithDifferentType_ThrowsArgumentException()
   {
      // Arrange
      object value = "test";
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.IfArgument.IsNotOfType(value, out int _);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNotOfType_WithResult_WithExpectedType_NoExceptionThrownAndReturnsExpectedResult()
   {
      // Arrange
      object value = "test";
      const string expectedResult = "test";

      // Act
      string Act()
      {
         Throw.IfArgument.IsNotOfType(value, out string result);
         return result;
      }

      // Assert
      Assert.That
         .DoesNotThrowAnyException(Act, out string result)
         .AreEqual(result, expectedResult);
   }

   [TestMethod]
   public void IsNotOfType_WithDifferentType_ThrowsArgumentException()
   {
      // Arrange
      object value = "test";
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.IfArgument.IsNotOfType<int>(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNotOfType_WithExpectedType_DoesNothing()
   {
      // Arrange
      object value = "test";

      // Act
      void Act() => Throw.IfArgument.IsNotOfType<string>(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
