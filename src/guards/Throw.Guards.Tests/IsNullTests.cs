namespace OwlDomain.Common.Guards.Tests;

[TestClass]
public sealed class IsNullTests
{
   #region Tests
   [TestMethod]
   public void IsNull_WithNullReferenceType_ThrowsArgumentNullException()
   {
      // Arrange
      object? value = null;
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.IfArgument.IsNull(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentNullException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNull_WithNotNullReferenceType_DoesNothing()
   {
      // Arrange
      object? value = new();

      // Act
      void Act() => Throw.IfArgument.IsNull(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void IsNull_WithNullValueType_ThrowsArgumentNullException()
   {
      // Arrange
      int? value = null;
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.IfArgument.IsNull(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentNullException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNull_WithNotNullValueType_DoesNothing()
   {
      // Arrange
      int? value = 1;

      // Act
      void Act() => Throw.IfArgument.IsNull(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
