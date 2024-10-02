using System.Runtime.CompilerServices;

namespace OwlDomain.Common.Throw.Generator;

internal class Program
{
   #region Constants
   private const string TabString = "   ";
   private const string Namespace = $"{nameof(OwlDomain)}.{nameof(Common)}";
   private const string ContainerClass = "ThrowExtensions";
   private const string ThrowType = "IThrowFor";
   private const string ThrowParameterName = "@throw";
   private const bool Dry = false;
   #endregion

   #region Fields
   private static readonly IReadOnlyCollection<string> GlobalNamespaces =
   [
      "System",
      "System.Collections.Generic",
      "System.Diagnostics",
      "System.Diagnostics.CodeAnalysis",
      "System.Runtime.CompilerServices",
      "System.Threading",
      "System.Threading.Tasks",
   ];
   #endregion

   #region Functions
   public static void Main()
   {
      string path = Path.GetFullPath("../../../../Throw");

      foreach (Type type in GetExceptionTypes())
         Generate(path, type, Dry);
   }
   private static void Generate(string rootPath, Type exceptionType, bool dry)
   {
      string targetPath = EnsureTargetPath(rootPath, exceptionType);

      FileStream? fileStream;
      TextWriter baseWriter;

      if (dry)
      {
         fileStream = null;
         baseWriter = new StringWriter();
      }
      else
      {
         fileStream = File.Open(targetPath, FileMode.Create);
         baseWriter = new StreamWriter(fileStream);
      }

      using (fileStream)
      using (baseWriter)
      using (IndentedTextWriter writer = new(baseWriter, TabString))
      {
         GenerateFile(writer, exceptionType);

         if (dry && exceptionType == typeof(Exception))
         {
            Console.WriteLine("---------------------------");
            Console.WriteLine(baseWriter);
            Console.WriteLine("---------------------------");
         }
      }
   }
   private static void GenerateFile(IndentedTextWriter writer, Type exceptionType)
   {
      IReadOnlyList<ConstructorInfo> constructors = GetExceptionConstructors(exceptionType);
      IReadOnlyList<string> namespaces = GetNamespaces(exceptionType, constructors);

      writer.WriteLine("#nullable enable");
      writer.WriteLine();

      foreach (string name in namespaces)
         writer.WriteLine($"using {name};");

      if (namespaces.Count > 0)
         writer.WriteLine();

      writer.WriteLine($"namespace {Namespace};");
      writer.WriteLine();

      writer.WriteLine($"public static partial class {ContainerClass}");
      using (writer.Indented("{", "}"))
      {

         writer.WriteLine("#region Methods");
         for (int i = 0; i < constructors.Count; i++)
         {
            if (i > 0) writer.WriteLine();

            ConstructorInfo constructor = constructors[i];

            GenerateInheritdoc(writer, constructor);
            GenerateExceptionDocumentation(writer, exceptionType);
            GenerateAttributes(writer, false);
            GenerateSignature(writer, constructor, false);

            using (writer.Indented("{", "}"))
            {
               writer.Write($"throw new {exceptionType.Name}(");
               GenerateArgumentNames(writer, constructor, false);
               writer.WriteLine(");");
            }
         }
         writer.WriteLine("#endregion");

         writer.WriteLine();

         writer.WriteLine("#region Generic methods");
         for (int i = 0; i < constructors.Count; i++)
         {
            if (i > 0) writer.WriteLine();

            ConstructorInfo constructor = constructors[i];

            GenerateInheritdoc(writer, constructor);
            GenerateExceptionDocumentation(writer, exceptionType);
            GenerateAttributes(writer, true);
            GenerateSignature(writer, constructor, true);

            using (writer.Indented("{", "}"))
            {
               string name = GetMethodName(exceptionType);
               writer.Write($"{name}({ThrowParameterName}");
               GenerateArgumentNames(writer, constructor, true);
               writer.WriteLine(");");
               writer.WriteLine("return default;");
            }
         }
         writer.WriteLine("#endregion");

      }
      writer.WriteLine();
      writer.WriteLine("#nullable restore");
   }
   private static void GenerateInheritdoc(TextWriter writer, ConstructorInfo constructor)
   {
      Debug.Assert(constructor.DeclaringType is not null);

      string typeName = constructor.DeclaringType.Name;
      ParameterInfo[] parameters = constructor.GetParameters();

      writer.Write($"/// <inheritdoc cref=\"{typeName}.{typeName}(");

      for (int i = 0; i < parameters.Length; i++)
      {
         if (i > 0) writer.Write(", ");

         writer.WriteParameterDocumentation(parameters[i]);
      }

      writer.WriteLine(")\"/>");
   }
   private static void GenerateExceptionDocumentation(TextWriter writer, Type exceptionType)
   {
      string typeName = exceptionType.Name;

      if (exceptionType == typeof(Exception))
      {
         Debug.Assert(exceptionType.Namespace is not null);
         typeName = $"{exceptionType.Namespace}.{typeName}";
      }

      writer.WriteLine($"/// <exception cref=\"{typeName}\"/>");
   }
   private static void GenerateAttributes(TextWriter writer, bool isGeneric)
   {
      const string suffix = "Attribute";
      string doesNotReturn = nameof(DoesNotReturnAttribute)[..^suffix.Length];
      string stackTraceHidden = nameof(StackTraceHiddenAttribute)[..^suffix.Length];
      string methodImplementation = nameof(MethodImplAttribute)[..^suffix.Length];

      writer.Write($"[{doesNotReturn}, {stackTraceHidden}, {methodImplementation}(");
      writer.Write($"{nameof(MethodImplOptions)}.");
      writer.Write(isGeneric ? MethodImplOptions.AggressiveInlining : MethodImplOptions.NoInlining);
      writer.WriteLine(")]");
   }
   private static void GenerateSignature(TextWriter writer, ConstructorInfo constructor, bool isGeneric)
   {
      Debug.Assert(constructor.DeclaringType is not null);
      string name = GetMethodName(constructor.DeclaringType);

      writer.Write("public static ");
      writer.Write(isGeneric ? "T " : "void ");
      writer.Write(name);
      writer.Write(isGeneric ? $"<T>(" : "(");
      writer.Write($"this {ThrowType} {ThrowParameterName}");

      foreach (ParameterInfo parameter in constructor.GetParameters())
      {
         writer.Write(", ");
         writer.WriteParameterDefinition(parameter);
      }

      writer.WriteLine(")");
   }
   private static string GetMethodName(Type exceptionType)
   {
      const string suffix = nameof(Exception);
      string name = exceptionType.Name;
      if (name is not suffix)
      {
         Debug.Assert(name.EndsWith(suffix));
         name = name[..^suffix.Length];
      }

      return name;
   }
   private static void GenerateArgumentNames(TextWriter writer, ConstructorInfo constructor, bool prefixSeparator)
   {
      ParameterInfo[] parameters = constructor.GetParameters();

      for (int i = 0; i < parameters.Length; i++)
      {
         if (i > 0 || prefixSeparator) writer.Write(", ");

         ParameterInfo parameter = parameters[i];
         Debug.Assert(parameter.Name is not null);

         writer.Write(parameter.Name);
      }
   }
   #endregion

   #region Helpers
   private static string EnsureTargetPath(string rootDirectory, Type exceptionType)
   {
      Debug.Assert(exceptionType.Namespace is not null);
      string relativeDirectory = exceptionType.Namespace.Replace('.', Path.DirectorySeparatorChar);
      string directory = Path.Combine(rootDirectory, relativeDirectory);

      if (Directory.Exists(directory) is false)
         Directory.CreateDirectory(directory);

      return Path.Combine(directory, $"{exceptionType.Name}.g.cs");
   }
   private static IReadOnlyList<Type> GetExceptionTypes()
   {
      List<Type> types = [];

      Assembly assembly = typeof(Exception).Assembly;
      foreach (Type type in assembly.ExportedTypes)
      {
         if (type.IsAssignableTo(typeof(Exception)) is false)
            continue;

         if (type.HasAttribute<ObsoleteAttribute>())
            continue;

         if (type.FullName is "System.Diagnostics.Contracts.ContractException")
            continue;

         types.Add(type);
      }

      return types;
   }
   private static IReadOnlyList<ConstructorInfo> GetExceptionConstructors(Type exceptionType)
   {
      List<ConstructorInfo> constructors = [];

      foreach (ConstructorInfo constructor in exceptionType.GetConstructors())
      {
         if (constructor.HasAttribute<ObsoleteAttribute>())
            continue;

         constructors.Add(constructor);
      }

      return constructors;
   }
   private static IReadOnlyList<string> GetNamespaces(Type exceptionType, IReadOnlyList<ConstructorInfo> constructors)
   {
      HashSet<string> namespaces = [];

      Debug.Assert(exceptionType.Namespace is not null);
      namespaces.Add(exceptionType.Namespace);

      foreach (ConstructorInfo constructor in constructors)
      {
         foreach (ParameterInfo parameter in constructor.GetParameters())
         {
            Debug.Assert(parameter.ParameterType.Namespace is not null);
            namespaces.Add(parameter.ParameterType.Namespace);
         }
      }

      namespaces.ExceptWith(GlobalNamespaces);

      return [.. namespaces];
   }
   #endregion
}
