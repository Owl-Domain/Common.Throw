namespace OwlDomain.Common.Guards.Tests.Enums;

[TestClass]
public sealed class HasInvalidFlagsTests
{
   #region Nested types
   [Flags]
   private enum TestEnum : byte { A = 1, B = 2, C = 4 }
   #endregion

   #region Tests
   [TestMethod]
   public void HasInvalidFlags_WithInvalidFlags_ThrowsArgumentException()
   {
      // Arrange
      const TestEnum value = TestEnum.B | (TestEnum)8;
      const string expectedParameterName = nameof(value);

      // Act
      static void Act() => Throw.IfArgument.HasInvalidFlags(value);

      // Assert
      Assert.That
         .ThrowsExactException(Act, out ArgumentException exception)
         .AreEqual(exception.ParamName, expectedParameterName);
   }

   [TestMethod]
   public void HasInvalidFlags_WithValidFlags_DoesNothing()
   {
      // Arrange
      const TestEnum value = TestEnum.A | TestEnum.C;

      // Act
      static void Act() => Throw.IfArgument.HasInvalidFlags(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
