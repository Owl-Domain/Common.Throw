namespace OwlDomain.Common.Guards.Tests;

[TestClass]
public sealed class BooleanGuardTests
{
   #region True tests
   [TestMethod]
   public void IsTrue_WithTrueValue_ThrowsArgumentException()
   {
      // Arrange
      bool? value = true;

      // Act
      void Act() => Throw.If.IsTrue(value);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }

   [DataRow(false, DisplayName = "false")]
   [DataRow(null, DisplayName = "null")]
   [TestMethod]
   public void IsTrue_WithNotTrueValue_DoesNothing(bool? value)
   {
      // Act
      void Act() => Throw.If.IsTrue(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void IsNotTrue_WithTrueValue_DoesNothing()
   {
      // Arrange
      bool? value = true;

      // Act
      void Act() => Throw.If.IsNotTrue(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [DataRow(false, DisplayName = "false")]
   [DataRow(null, DisplayName = "null")]
   [TestMethod]
   public void IsNotTrue_WithNonTrueValue_ThrowsArgumentException(bool? value)
   {
      // Act
      void Act() => Throw.If.IsNotTrue(value);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }
   #endregion

   #region False tests
   [TestMethod]
   public void IsFalse_WithFalseValue_ThrowsArgumentException()
   {
      // Arrange
      bool? value = false;

      // Act
      void Act() => Throw.If.IsFalse(value);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }

   [DataRow(true, DisplayName = "true")]
   [DataRow(null, DisplayName = "null")]
   [TestMethod]
   public void IsFalse_WithNotTrueValue_DoesNothing(bool? value)
   {
      // Act
      void Act() => Throw.If.IsFalse(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void IsNotFalse_WithFalseValue_DoesNothing()
   {
      // Arrange
      bool? value = false;

      // Act
      void Act() => Throw.If.IsNotFalse(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [DataRow(true, DisplayName = "true")]
   [DataRow(null, DisplayName = "null")]
   [TestMethod]
   public void IsNotFalse_WithNonFalseValue_ThrowsArgumentException(bool? value)
   {
      // Act
      void Act() => Throw.If.IsNotFalse(value);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }
   #endregion
}
