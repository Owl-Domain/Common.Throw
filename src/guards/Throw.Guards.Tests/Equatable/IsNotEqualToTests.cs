namespace OwlDomain.Common.Guards.Tests.Equatable;

[TestClass]
public sealed class IsNotEqualToTests
{
   #region Equatable tests
   [TestMethod]
   public void IsNotEqualTo_Equatable_IsNotEqualTo_ThrowsArgumentException()
   {
      // Arrange
      IEquatable<int> value = 1;
      const int expected = 2;
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.IfArgument.IsNotEqualTo(value, expected);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNotEqualTo_Equatable_AreEqual_DoesNothing()
   {
      // Arrange
      IEquatable<int> value = 1;
      const int expected = 1;

      // Act
      void Act() => Throw.IfArgument.IsNotEqualTo(value, expected);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion

   #region Comparable tests
   [TestMethod]
   public void IsNotEqualTo_Comparable_IsNotEqualTo_ThrowsArgumentException()
   {
      // Arrange
      IComparable<int> value = 1;
      const int expected = 2;
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.IfArgument.IsNotEqualTo(value, expected);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNotEqualTo_Comparable_AreEqual_DoesNothing()
   {
      // Arrange
      IComparable<int> value = 1;
      const int expected = 1;

      // Act
      void Act() => Throw.IfArgument.IsNotEqualTo(value, expected);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion

   #region Non-equatable tests
   [TestMethod]
   public void IsNotEqualTo_IsNotEqualTo_ThrowsArgumentException()
   {
      // Arrange
      const int value = 1;
      const int expected = 2;
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsNotEqualTo(value, expected);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsNotEqualTo_AreEqual_DoesNothing()
   {
      // Arrange
      const int value = 1;
      const int expected = 1;

      // Act
      static void Act() => Throw.IfArgument.IsNotEqualTo(value, expected);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
