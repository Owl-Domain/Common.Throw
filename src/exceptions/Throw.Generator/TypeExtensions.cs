namespace OwlDomain.Common.Throw.Generator;

public static class TypeExtensions
{
   #region Fields
   private static readonly NullabilityInfoContext NullabilityContext = new();
   private static readonly Dictionary<Type, string> TypeKeywords = new()
   {
      { typeof(byte), "byte" },
      { typeof(sbyte), "sbyte" },
      { typeof(ushort), "ushort" },
      { typeof(short), "short" },
      { typeof(uint), "uint" },
      { typeof(int), "int" },
      { typeof(ulong), "ulong" },
      { typeof(long), "long" },

      { typeof(float), "float" },
      { typeof(double), "double" },
      { typeof(decimal), "decimal" },

      { typeof(object), "object" },
      { typeof(bool), "bool" },
      { typeof(char), "char" },
      { typeof(string), "string" },
      { typeof(void), "void" },
   };
   #endregion

   #region Methods
   public static void WriteParameterDefinition(this TextWriter writer, ParameterInfo parameter)
   {
      IReadOnlyList<Attribute> attributes = GetSupportedAttributes(parameter);
      if (attributes.Count > 0)
      {
         writer.Write('[');
         for (int i = 0; i < attributes.Count; i++)
         {
            if (i > 0) writer.Write(", ");
            Attribute attribute = attributes[i];

            if (attribute is StringSyntaxAttribute stringSyntax)
            {
               Debug.Assert(stringSyntax.Arguments.Length is 0);
               writer.Write($"StringSyntax({nameof(StringSyntaxAttribute)}.{stringSyntax.Syntax})");
            }
            else
               Debug.Fail("Unsupported attribute.");
         }
         writer.Write("] ");
      }

      if (parameter.HasAttribute<ParamArrayAttribute>())
         writer.Write("params ");

      NullabilityInfo info = NullabilityContext.Create(parameter);

      Write(writer, parameter.ParameterType, info, false);

      Debug.Assert(parameter.Name is not null);

      writer.Write(' ');
      writer.Write(parameter.Name);
   }
   public static void WriteParameterDocumentation(this TextWriter writer, ParameterInfo parameter)
   {
      NullabilityInfo info = NullabilityContext.Create(parameter);

      Write(writer, parameter.ParameterType, info, true);
   }
   private static void Write(TextWriter writer, Type type, NullabilityInfo nullability, bool isDocumentation)
   {
      Type? baseNullableType = Nullable.GetUnderlyingType(type);
      if (baseNullableType is not null)
      {
         Write(writer, baseNullableType, nullability, isDocumentation);
         writer.Write('?');
         return;
      }

      if (TypeKeywords.TryGetValue(type, out string? keyword))
      {
         writer.Write(keyword);

         if (nullability.IsNullable())
            writer.Write('?');

         return;
      }

      if (type.IsSZArray)
      {
         Type? elementType = type.GetElementType();

         Debug.Assert(type.HasElementType);
         Debug.Assert(elementType is not null);
         Debug.Assert(nullability.ElementType is not null);

         Write(writer, elementType, nullability.ElementType, isDocumentation);

         writer.Write("[]");

         if (isDocumentation is false && nullability.IsNullable())
            writer.Write('?');

         return;
      }

      if (type.IsConstructedGenericType)
      {
         string name = type.Name[..type.Name.IndexOf('`')];
         writer.Write(name);
         writer.Write(isDocumentation ? '{' : '<');

         Type[] generics = type.GetGenericArguments();

         for (int i = 0; i < generics.Length; i++)
         {
            if (i > 0) writer.Write(", ");

            Write(writer, generics[i], nullability.GenericTypeArguments[i], isDocumentation);
         }

         writer.Write(isDocumentation ? '}' : '>');

         if (nullability.IsNullable())
            writer.Write('?');

         return;
      }

      writer.Write(type.Name);

      if (nullability.IsNullable())
         writer.Write('?');
   }
   #endregion

   #region Helpers
   private static bool IsNullable(this NullabilityInfo nullability)
   {
      return
         nullability.WriteState is NullabilityState.Nullable ||
         nullability.ReadState is NullabilityState.Nullable;
   }
   private static IReadOnlyList<Attribute> GetSupportedAttributes(ParameterInfo parameter)
   {
      List<Attribute> attributes = [];

      if (parameter.TryGetAttribute(out StringSyntaxAttribute? stringSyntax))
         attributes.Add(stringSyntax);

      return attributes;
   }
   #endregion
}
