using System.Reflection;
using OwlDomain.Common;

namespace Throw.CodeTests;

[TestClass]
public class MethodAttributeTests
{
   #region Tests
   [DynamicData(nameof(GetAllMethods), DynamicDataSourceType.Method, DynamicDataDisplayName = nameof(DynamicMethodName))]
   [TestMethod]
   public void Method_HasDoesNotReturnAttribute(MethodInfo method)
   {
      // Arrange
      DoesNotReturnAttribute? attribute = method.GetCustomAttribute<DoesNotReturnAttribute>();

      // Assert
      Assert.That.IsNotNull(attribute);
   }

   [DynamicData(nameof(GetAllGenericMethods), DynamicDataSourceType.Method, DynamicDataDisplayName = nameof(DynamicMethodName))]
   [TestMethod]
   public void GenericMethod_IsAggressivelyInlined(MethodInfo method)
   {
      // Arrange
      MethodImplAttributes flags = method.MethodImplementationFlags;

      // Assert
      Assert.That.HasFlag(flags, MethodImplAttributes.AggressiveInlining);
      Assert.That.DoesNotHaveFlag(flags, MethodImplAttributes.NoInlining);
   }

   [DynamicData(nameof(GetAllNonGenericMethods), DynamicDataSourceType.Method, DynamicDataDisplayName = nameof(DynamicMethodName))]
   [TestMethod]
   public void NonGenericMethod_IsNotInlined(MethodInfo method)
   {
      // Arrange
      MethodImplAttributes flags = method.MethodImplementationFlags;

      // Assert
      Assert.That.HasFlag(flags, MethodImplAttributes.NoInlining);
      Assert.That.DoesNotHaveFlag(flags, MethodImplAttributes.AggressiveInlining);
   }
   #endregion

   #region Helpers

   public static string DynamicMethodName(MethodInfo _, object[] values)
   {
      MethodInfo method = (MethodInfo)values[0];

      if (method.IsGenericMethod)
         return $"{method.Name}<T>";

      return method.Name;
   }
   public static IEnumerable<object[]> GetAllNonGenericMethods()
   {
      foreach (MethodInfo method in GetAllMethodsCore())
      {
         if (method.IsGenericMethod is false)
            yield return [method];
      }
   }
   public static IEnumerable<object[]> GetAllGenericMethods()
   {
      foreach (MethodInfo method in GetAllMethodsCore())
      {
         if (method.IsGenericMethod)
            yield return [method];
      }
   }
   public static IEnumerable<object[]> GetAllMethods()
   {
      foreach (MethodInfo method in GetAllMethodsCore())
         yield return [method];
   }
   private static IEnumerable<MethodInfo> GetAllMethodsCore()
   {
      MethodInfo[] methods = typeof(ThrowExtensions).GetMethods(BindingFlags.Public | BindingFlags.Static);
      foreach (MethodInfo method in methods)
         yield return method;
   }
   #endregion
}
