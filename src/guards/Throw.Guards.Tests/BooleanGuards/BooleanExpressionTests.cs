namespace OwlDomain.Common.Guards.Tests;

[TestClass]
public sealed class BooleanExpressionGuardTests
{
   #region True tests
   [TestMethod]
   public void IsExpressionTrue_WithTrueValue_ThrowsArgumentException()
   {
      // Arrange
      bool? value = true;
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.If.IsExpressionTrue(value, expectedParameterName);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [DataRow(false, DisplayName = "false")]
   [DataRow(null, DisplayName = "null")]
   [TestMethod]
   public void IsExpressionTrue_WithNotTrueValue_DoesNothing(bool? value)
   {
      // Act
      void Act() => Throw.If.IsExpressionTrue(value, nameof(value));

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void IsExpressionNotTrue_WithTrueValue_DoesNothing()
   {
      // Arrange
      bool? value = true;

      // Act
      void Act() => Throw.If.IsExpressionNotTrue(value, nameof(value));

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [DataRow(false, DisplayName = "false")]
   [DataRow(null, DisplayName = "null")]
   [TestMethod]
   public void IsExpressionNotTrue_WithNonTrueValue_ThrowsArgumentException(bool? value)
   {
      // Arrange
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.If.IsExpressionNotTrue(value, expectedParameterName);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }
   #endregion

   #region False tests
   [TestMethod]
   public void IsExpressionFalse_WithFalseValue_ThrowsArgumentException()
   {
      // Arrange
      bool? value = false;
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.If.IsExpressionFalse(value, expectedParameterName);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [DataRow(true, DisplayName = "true")]
   [DataRow(null, DisplayName = "null")]
   [TestMethod]
   public void IsExpressionFalse_WithNotTrueValue_DoesNothing(bool? value)
   {
      // Act
      void Act() => Throw.If.IsExpressionFalse(value, nameof(value));

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void IsExpressionNotFalse_WithFalseValue_DoesNothing()
   {
      // Arrange
      bool? value = false;

      // Act
      void Act() => Throw.If.IsExpressionNotFalse(value, nameof(value));

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [DataRow(true, DisplayName = "true")]
   [DataRow(null, DisplayName = "null")]
   [TestMethod]
   public void IsExpressionNotFalse_WithNonFalseValue_ThrowsArgumentException(bool? value)
   {
      // Arrange
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.If.IsExpressionNotFalse(value, nameof(value));

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }
   #endregion
}
