using System.Diagnostics.CodeAnalysis;

namespace OwlDomain.Common.Guards.Tests;

[TestClass]
public sealed class EnumGuardTests
{
   #region Test enum
   [Flags]
   private enum TestEnum : byte
   {
      A = 1,
      B = 2,
      C = 4,
   }
   #endregion

   #region HasFlag tests
   [TestMethod]
   public void HasFlag_Nullable_ValueWithFlag_ThrowsArgumentException()
   {
      // Arrange
      const TestEnum flag = TestEnum.B;
      const TestEnum value = TestEnum.A | flag;

      // Act
      static void Act() => Throw.If.HasFlag(value, flag);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }

   [TestMethod]
   public void HasFlag_Nullable_ValueWithoutFlag_DoesNothing()
   {
      // Arrange
      TestEnum? flag = TestEnum.B;
      TestEnum? value = TestEnum.A;

      // Act
      void Act() => Throw.If.HasFlag(value, flag);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod, ExcludeFromCodeCoverage(Justification = "The | operator is counted as a branch when it isn't one.")]
   public void HasFlag_NoneNullable_ValueWithFlag_ThrowsArgumentException()
   {
      // Arrange
      TestEnum? flag = TestEnum.B;
      TestEnum? value = TestEnum.A | flag;

      // Act
      void Act() => Throw.If.HasFlag(value, flag);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }

   [TestMethod]
   public void HasFlag_NoneNullable_ValueWithoutFlag_DoesNothing()
   {
      // Arrange
      const TestEnum flag = TestEnum.B;
      const TestEnum value = TestEnum.A;

      // Act
      static void Act() => Throw.If.HasFlag(value, flag);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion

   #region DoesNotHaveFlag tests
   [TestMethod]
   public void DoesNotHaveFlag_Nullable_ValueWithoutFlag_ThrowsArgumentException()
   {
      // Arrange
      TestEnum? flag = TestEnum.B;
      TestEnum? value = TestEnum.A;

      // Act
      void Act() => Throw.If.DoesNotHaveFlag(value, flag);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }

   [TestMethod, ExcludeFromCodeCoverage(Justification = "The | operator is counted as a branch when it isn't one.")]
   public void DoesNotHaveFlag_Nullable_ValueWithFlag_DoesNothing()
   {
      // Arrange
      TestEnum? flag = TestEnum.B;
      TestEnum? value = TestEnum.A | flag;

      // Act
      void Act() => Throw.If.DoesNotHaveFlag(value, flag);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void DoesNotHaveFlag_NoneNullable_ValueWithoutFlag_ThrowsArgumentException()
   {
      // Arrange
      const TestEnum flag = TestEnum.B;
      const TestEnum value = TestEnum.A;

      // Act
      static void Act() => Throw.If.DoesNotHaveFlag(value, flag);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }

   [TestMethod]
   public void DoesNotHaveFlag_NoneNullable_ValueWithFlag_DoesNothing()
   {
      // Arrange
      const TestEnum flag = TestEnum.B;
      const TestEnum value = TestEnum.A | flag;

      // Act
      static void Act() => Throw.If.DoesNotHaveFlag(value, flag);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion

   #region IsDefined tests
   [TestMethod]
   public void IsDefined_Nullable_WithDefinedValue_ThrowsArgumentException()
   {
      // Arrange
      TestEnum? value = TestEnum.A;

      // Act
      void Act() => Throw.If.IsDefined(value);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }

   [TestMethod]
   public void IsDefined_Nullable_WithNotDefinedValue_DoesNothing()
   {
      // Arrange
      TestEnum? value = (TestEnum)5;

      // Act
      void Act() => Throw.If.IsDefined(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void IsDefined_NotNullable_WithDefinedValue_ThrowsArgumentException()
   {
      // Arrange
      const TestEnum value = TestEnum.A;

      // Act
      static void Act() => Throw.If.IsDefined(value);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }

   [TestMethod]
   public void IsDefined_NotNullable_WithNotDefinedValue_DoesNothing()
   {
      // Arrange
      const TestEnum value = (TestEnum)5;

      // Act
      static void Act() => Throw.If.IsDefined(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion

   #region IsNotDefined tests
   [TestMethod]
   public void IsNotDefined_Nullable_WithNotDefinedValue_ThrowsArgumentException()
   {
      // Arrange
      TestEnum? value = (TestEnum)5;

      // Act
      void Act() => Throw.If.IsNotDefined(value);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }

   [TestMethod]
   public void IsNotDefined_Nullable_WithDefinedValue_DoesNothing()
   {
      // Arrange
      TestEnum? value = TestEnum.A;

      // Act
      void Act() => Throw.If.IsNotDefined(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }

   [TestMethod]
   public void IsNotDefined_NotNullable_WithNotDefinedValue_ThrowsArgumentException()
   {
      // Arrange
      const TestEnum value = (TestEnum)5;

      // Act
      static void Act() => Throw.If.IsNotDefined(value);

      // Assert
      Assert.That.ThrowsExactException<ArgumentException>(Act);
   }

   [TestMethod]
   public void IsNotDefined_NotNullable_WithDefinedValue_DoesNothing()
   {
      // Arrange
      const TestEnum value = TestEnum.A;

      // Act
      static void Act() => Throw.If.IsNotDefined(value);

      // Assert
      Assert.That.DoesNotThrowAnyException(Act);
   }
   #endregion
}
