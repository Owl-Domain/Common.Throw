namespace OwlDomain.Common.Guards.Tests;

[TestClass]
public sealed class NullGuardTests
{
   #region Reference tests
   [TestMethod]
   public void IsNull_WithNullReference_ThrowsArgumentNullException()
   {
      // Arrange
      object? value = null;

      // Act
      void Act() => Throw.If.IsNull(value);

      // Assert
      Assert.That.ThrowsExactException<ArgumentNullException>(Act);
   }

   [TestMethod]
   public void IsNull_WithNonNullReference_DoesNothing()
   {
      // Arrange
      object? value = new();

      // Act
      void Act() => Throw.If.IsNull(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void IsNotNull_WithNullReference_DoesNothing()
   {
      // Arrange
      object? value = null;

      // Act
      void Act() => Throw.If.IsNotNull(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void IsNotNull_WithNonNullReference_ThrowsArgumentException()
   {
      // Arrange
      object? value = new();

      // Act
      void Act() => Throw.If.IsNotNull(value);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }
   #endregion

   #region Value type tests
   [TestMethod]
   public void IsNull_WithNullValueType_ThrowsArgumentNullException()
   {
      // Arrange
      int? value = null;

      // Act
      void Act() => Throw.If.IsNull(value);

      // Assert
      Assert.That.ThrowsExactException<ArgumentNullException>(Act);
   }

   [TestMethod]
   public void IsNull_WithNonNullValueType_DoesNothing()
   {
      // Arrange
      int? value = 1;

      // Act
      void Act() => Throw.If.IsNull(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void IsNotNull_WithNullValueType_DoesNothing()
   {
      // Arrange
      int? value = null;

      // Act
      void Act() => Throw.If.IsNotNull(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void IsNotNull_WithNonNullValueType_ThrowsArgumentException()
   {
      // Arrange
      int? value = 1;

      // Act
      void Act() => Throw.If.IsNotNull(value);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }
   #endregion
}
