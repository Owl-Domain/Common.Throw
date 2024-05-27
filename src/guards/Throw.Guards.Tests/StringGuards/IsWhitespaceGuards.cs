namespace OwlDomain.Common.Guards.Tests.StringGuards;

[TestClass]
public sealed class IsWhitespaceGuards
{
   #region Tests
   [DataRow("   ", DisplayName = "Space only")]
   [DataRow(" \t\n\r  ", DisplayName = "Complex whitespace")]
   [TestMethod]
   public void IsWhitespace_WithWhitespaceValue_ThrowsArgumentException(string value)
   {
      // Arrange
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.If.IsWhitespace(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [DataRow("", DisplayName = "Empty")]
   [DataRow("test", DisplayName = "\"test\"")]
   [TestMethod]
   public void IsWhitespace_WithNonWhitespaceValue_DoesNothing(string value)
   {
      // Act
      void Act() => Throw.If.IsWhitespace(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [DataRow("", DisplayName = "Empty")]
   [DataRow("test", DisplayName = "\"test\"")]
   [TestMethod]
   public void IsNotWhitespace_WithNonWhitespaceValue_ThrowsArgumentException(string value)
   {
      // Arrange
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.If.IsNotWhitespace(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [DataRow("   ", DisplayName = "Space only")]
   [DataRow(" \t\n\r  ", DisplayName = "Complex whitespace")]
   [TestMethod]
   public void IsNotWhitespace_WithWhitespaceValue_DoesNothing(string value)
   {
      // Act
      void Act() => Throw.If.IsNotWhitespace(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
