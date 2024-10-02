namespace OwlDomain.Common.Guards.Tests.StringGuards;

[TestClass]
public sealed class IsEmptyOrWhitespaceGuards
{
   #region Tests
   [DataRow("", DisplayName = "Empty")]
   [DataRow("   ", DisplayName = "Space only")]
   [DataRow(" \t\n\r  ", DisplayName = "Complex whitespace")]
   [TestMethod]
   public void IsEmptyOrWhitespace_WithEmptyOrWhitespaceValue_ThrowsArgumentException(string value)
   {
      // Arrange
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.IfArgument.IsEmptyOrWhitespace(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsEmptyOrWhitespace_WithNonEmptyOrWhitespaceValue_DoesNothing()
   {
      // Arrange
      const string value = "test";

      // Act
      static void Act() => Throw.IfArgument.IsEmptyOrWhitespace(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void IsNotEmptyOrWhitespace_WithNonEmptyOrWhitespaceValue_ThrowsArgumentException()
   {
      // Arrange
      const string value = "test";
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsNotEmptyOrWhitespace(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [DataRow("", DisplayName = "Empty")]
   [DataRow("   ", DisplayName = "Space only")]
   [DataRow(" \t\n\r  ", DisplayName = "Complex whitespace")]
   [TestMethod]
   public void IsNotEmptyOrWhitespace_WithEmptyOrWhitespaceValue_DoesNothing(string value)
   {
      // Act
      void Act() => Throw.IfArgument.IsNotEmptyOrWhitespace(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
