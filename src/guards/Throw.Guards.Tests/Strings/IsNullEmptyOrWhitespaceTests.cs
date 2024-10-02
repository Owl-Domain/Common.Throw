namespace OwlDomain.Common.Guards.Tests.Strings;

[TestClass]
public sealed class IsNullEmptyOrWhitespaceTests
{
   #region IsEmpty tests
   [TestMethod]
   public void IsEmpty_WithEmptyValue_ThrowsArgumentException()
   {
      // Arrange
      const string value = "";
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsEmpty(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsEmpty_WithNonEmptyValue_DoesNothing()
   {
      // Arrange
      const string value = "1";

      // Act
      static void Act() => Throw.IfArgument.IsEmpty(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion

   #region IsNullOrEmpty tests
   [TestMethod]
   public void IsNullOrEmpty_WithNullValue_ThrowsArgumentNullException()
   {
      // Arrange
      const string? value = null;
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsNullOrEmpty(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentNullException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNullOrEmpty_WithEmptyValue_ThrowsArgumentException()
   {
      // Arrange
      const string value = "";
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsNullOrEmpty(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNullOrEmpty_WithNonEmptyValue_DoesNothing()
   {
      // Arrange
      const string value = "1";

      // Act
      static void Act() => Throw.IfArgument.IsNullOrEmpty(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion

   #region IsEmptyOrWhitespace tests
   [TestMethod]
   public void IsEmptyOrWhitespace_WithEmptyValue_ThrowsArgumentException()
   {
      // Arrange
      const string value = "";
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsEmptyOrWhitespace(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsEmptyOrWhitespace_WithWhitespaceValue_ThrowsArgumentException()
   {
      // Arrange
      const string value = " ";
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsEmptyOrWhitespace(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsEmptyOrWhitespace_WithNonEmptyNonWhitespaceValue_DoesNothing()
   {
      // Arrange
      const string value = "1";

      // Act
      static void Act() => Throw.IfArgument.IsEmptyOrWhitespace(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion

   #region IsNullOrWhitespace tests
   [TestMethod]
   public void IsNullOrWhitespace_WithNullValue_ThrowsArgumentNullException()
   {
      // Arrange
      const string? value = null;
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsNullOrWhitespace(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentNullException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNullOrWhitespace_WithWhitespaceValue_ThrowsArgumentException()
   {
      // Arrange
      const string value = " ";
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsNullOrWhitespace(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNullOrWhitespace_WithNonWhitespaceValue_DoesNothing()
   {
      // Arrange
      const string value = "1";

      // Act
      static void Act() => Throw.IfArgument.IsNullOrWhitespace(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void IsNullOrWhitespace_WithEmptyValue_DoesNothing()
   {
      // Arrange
      const string value = "";

      // Act
      static void Act() => Throw.IfArgument.IsNullOrWhitespace(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion

   #region IsNullEmptyOrWhitespace tests
   [TestMethod]
   public void IsNullEmptyOrWhitespace_WithNullValue_ThrowsArgumentNullException()
   {
      // Arrange
      const string? value = null;
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsNullEmptyOrWhitespace(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentNullException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNullEmptyOrWhitespace_WithEmptyValue_ThrowsArgumentException()
   {
      // Arrange
      const string value = "";
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsNullEmptyOrWhitespace(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNullEmptyOrWhitespace_WithWhitespaceValue_ThrowsArgumentException()
   {
      // Arrange
      const string value = " ";
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsNullEmptyOrWhitespace(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNullEmptyOrWhitespace_WithNonEmptyNonWhitespaceValue_DoesNothing()
   {
      // Arrange
      const string value = "1";

      // Act
      static void Act() => Throw.IfArgument.IsNullEmptyOrWhitespace(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
