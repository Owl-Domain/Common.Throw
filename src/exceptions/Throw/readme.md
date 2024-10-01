Common.Throw
===

A package that provides non-inlinable helper methods for throwing 
different exceptions, meant to reduce the binary size.

This package is optional and you can always replace it with your own custom throw methods,
if you wish to do so check out the `OwlDomain.Common.Throw.Base` package.



## Usage

Using the provided packages is extremely simple, after referencing them from your project
simply use the `OwlDomain.Common` namespace, which will provide you access to the static
`Throw` class, which provides the static property `For`, on which you will have
access to all of the extension methods for throwing exceptions.

An example of this would be
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



## License

This project (the source, and the release files, e.t.c) is release under the [OwlDomain License](/license.md).