namespace OwlDomain.Common.Guards.Tests.StringGuards;

[TestClass]
public sealed class IsEmptyGuards
{
   #region Tests
   [TestMethod]
   public void IsEmpty_WithEmptyValue_ThrowsArgumentException()
   {
      // Arrange
      string value = string.Empty;
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.IfArgument.IsEmpty(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [DataRow("   ", DisplayName = "Space only")]
   [DataRow(" \t\n\r  ", DisplayName = "Complex whitespace")]
   [DataRow("test", DisplayName = "\"test\"")]
   [TestMethod]
   public void IsEmpty_WithNonEmptyValue_DoesNothing(string value)
   {
      // Act
      void Act() => Throw.IfArgument.IsEmpty(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [DataRow("   ", DisplayName = "Space only")]
   [DataRow(" \t\n\r  ", DisplayName = "Complex whitespace")]
   [DataRow("test", DisplayName = "\"test\"")]
   [TestMethod]
   public void IsNotEmpty_WithNonEmptyValue_ThrowsArgumentException(string value)
   {
      // Arrange
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.IfArgument.IsNotEmpty(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNotEmpty_WithEmptyValue_DoesNothing()
   {
      // Arrange
      string value = string.Empty;

      // Act
      void Act() => Throw.IfArgument.IsNotEmpty(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
