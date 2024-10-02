namespace OwlDomain.Common.Guards.Tests.Equatable;

[TestClass]
public sealed class IsEqualToTests
{
   #region Equatable tests
   [TestMethod]
   public void IsEqualTo_Equatable_EqualTo_ThrowsArgumentException()
   {
      // Arrange
      IEquatable<int> value = 1;
      const int expected = 1;
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.IfArgument.IsEqualTo(value, expected);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsEqualTo_Equatable_NotEqualTo_DoesNothing()
   {
      // Arrange
      IEquatable<int> value = 1;
      const int expected = 2;

      // Act
      void Act() => Throw.IfArgument.IsEqualTo(value, expected);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion

   #region Comparable tests
   [TestMethod]
   public void IsEqualTo_Comparable_EqualTo_ThrowsArgumentException()
   {
      // Arrange
      IComparable<int> value = 1;
      const int expected = 1;
      const string expectedParameterName = nameof(value);

      // Act
      void Act() => Throw.IfArgument.IsEqualTo(value, expected);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsEqualTo_Comparable_NotEqualTo_DoesNothing()
   {
      // Arrange
      IComparable<int> value = 1;
      const int expected = 2;

      // Act
      void Act() => Throw.IfArgument.IsEqualTo(value, expected);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion

   #region Non-equatable tests
   [TestMethod]
   public void IsEqualTo_EqualTo_ThrowsArgumentException()
   {
      // Arrange
      const int value = 1;
      const int expected = 1;
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.IsEqualTo(value, expected);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void IsEqualTo_NotEqualTo_DoesNothing()
   {
      // Arrange
      const int value = 1;
      const int expected = 2;

      // Act
      static void Act() => Throw.IfArgument.IsEqualTo(value, expected);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
