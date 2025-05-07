Common.Throw
===

> [!WARNING]
> This project has been deprecated!
> [OwlDomain.Common](https://github.com/Owl-Domain/Common) should be used instead.

A package that provides non-inlinable helper methods for throwing 
different exceptions, meant to reduce the compiled code size, 
and for helper guard methods for conditionally throwing exceptions.



## Structure

This project is split into 3 areas, the base library, the throw library, and the guards library.

- Base library - This library contains the `IThrowFor` and the `IThrowIf` interfaces 
  that all the throw extension methods, and guard extension methods are expected to be 
  based on, along with the static `Throw` class which is used to access a singleton 
  implementation of the `IThrowFor` and the `IThrowIf` interfaces, using which the 
  throw extension methods and the guard extension methods can be accessed.

- The throw library - This is one of the main libraries which contains all of the throw
  extension methods, for throwing all of the exceptions that are present in the
  .NET runtime, the throw methods provide overloads for all of the constructors
  that are present in those exceptions, aside from the obsolete ones.

- The guards library - this is one of the main libraries which contains all of the
  guard extension methods, for conditionally throwing exceptions.

The project has been split up in this manner to make it 
easy to add/replace the throw and guard methods.



## Installation

To use this package download the [latest release files](https://github.com/Owl-Domain/Common.Throw/releases/tag/v1.0.0-throw),
and add them to a 
[local NuGet feed](https://learn.microsoft.com/nuget/hosting-packages/local-feeds), or
use the latest [nuget.org](https://www.nuget.org/packages/owlDomain.Common.Throw) release,
then just reference it from your .NET project.

In C#, that would look like this:
```csproj
<ItemGroup>
  <PackageReference Include="OwlDomain.Common.Throw" Version="2.0.0" />
</ItemGroup>
```
or 
```csproj
<ItemGroup>
  <PackageReference Include="OwlDomain.Common.Throw.Guards" Version="2.0.1" />
</ItemGroup>
```
depending on your needs.



## Usage - Throw methods

Using the provided packages is extremely simple, after referencing them from your project
simply use the `OwlDomain.Common` namespace, which will provide you access to the static
`Throw` class, which provides the static property `For`, on which you will have
access to all of the extension methods for throwing exceptions.

An example of this would be:
```csharp
using OwlDomain.Common;

Throw.For.Argument("message", "parameterName");
// Equivalent to
throw new ArgumentException("message", "parameterName");
```

There will be cases where the compiler complains that you aren't returning a value,
when you use the regular throw statements that doesn't happen, however the compiler
will still complain when it comes to methods, even if they are marked with the
[DoesNotReturnAttribute](https://learn.microsoft.com/dotnet/api/system.diagnostics.codeanalysis.doesnotreturnattribute).

For this reason, each of the throw methods also has a generic overload which pretends
to return a value of whatever type you wish, you would use it like so:
```csharp
using OwlDomain.Common;

return Throw.ForArgument<int>("message", "parameterName");
```



## Usage - Argument guard methods

Using the provided packages is extremely simple, after referencing them from your project
simply use the `OwlDomain.Common` namespace, which will provide you access to the static
`Throw` class, which provides the static property `IfArgument`, on which you will have
access to all of the guard extension methods for conditionally throwing exceptions.

An example of this would be:
```csharp
using OwlDomain.Common;

void Foo(int index)
{
   Throw.IfArgument.IsTooLow(index, 0);
}
```

This package also makes use of the throw extension methods provided by the
`OwlDomain.Common.Throw` package.



## Contributions

Code contributions will not be accepted, however feel free to provide feedback / suggestions 
by creating a [new issue](https://github.com/Owl-Domain/Common.Throw/issues/new), or look at 
the [existing issues](https://github.com/Owl-Domain/Common.Throw/issues?q=) to see if your
concern / suggestion has already been raised.



## License

This project (the source, and the release files, e.t.c) is release under the [OwlDomain License](/license.md).
