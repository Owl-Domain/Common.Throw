namespace OwlDomain.Common.Throw.Generator;

public static class AttributeExtensions
{
   #region Methods
   public static bool HasAttribute<T>(this MemberInfo member) where T : Attribute
   {
      return member.GetCustomAttribute<T>() is not null;
   }

   public static bool HasAttribute<T>(this ParameterInfo parameter) where T : Attribute
   {
      return parameter.GetCustomAttribute<T>() is not null;
   }

   public static bool TryGetAttribute<T>(this ParameterInfo parameter, [NotNullWhen(true)] out T? attribute) where T : Attribute
   {
      attribute = parameter.GetCustomAttribute<T>();
      return attribute is not null;
   }
   #endregion
}
