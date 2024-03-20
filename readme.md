Common.Throw
===

A package that provides non-inlinable helper methods for throwing 
different exceptions, meant to reduce the compiled code size.



## Structure

This project is split into 2 areas, the base library, and the throw library.

- Base library - This library contains the `IThrow` interface that all the
  throw extension methods are expected to be based on, along with the
  static `Throw` class which is used to access a singleton implementation of 
  the `IThrow` interface, using which the throw extension methods can be accessed.

- The throw library - This is the main library which contains all of the throw
  extension methods, for throwing all of the exceptions that are present in the
  .NET runtime, the throw methods provide overloads for all of the constructors
  that are present in those exceptions, aside from the obsolete ones.

The project has been split up in this manner to make it 
easy to add/replace the throw methods.



## Installation

To use this package download the [latest release files](https://github.com/Owl-Domain/Common.Throw/releases/tag/v1.0.0-throw),
and add them to a 
[local NuGet feed](https://learn.microsoft.com/nuget/hosting-packages/local-feeds),
after that you can reference it from your .NET project.
An official [nuget.org](https://www.nuget.org/) package will be released at a later point in time.

In C#, that would look like this:
```csproj
<ItemGroup>
  <PackageReference Include="OwlDomain.Common.Throw" Version="1.0.0" />
</ItemGroup>
```



## Usage

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



## Contributions

Code contributions will not be accepted, however feel free to provide feedback / suggestions 
by creating a [new issue](https://github.com/Owl-Domain/Common.Throw/issues/new), or look at 
the [existing issues](https://github.com/Owl-Domain/Common.Throw/issues?q=) to see if your
concern / suggestion has already been raised.



## License

This project (the source, and the release files, e.t.c) are not currently under any license, 
all rights are reserved, however it will become more permissive at a later date.
