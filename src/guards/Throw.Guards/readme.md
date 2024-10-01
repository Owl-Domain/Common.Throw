Common.Throw.Guards
===

A package that provides guard methods used for throwing 
exceptions if the required conditions are not met.

This package is optional and you can always replace it with your own custom guard methods,
if you wish to do so check out the `OwlDomain.Common.Throw.Base` package.



## Usage

Using the provided packages is extremely simple, after referencing them from your project
simply use the `OwlDomain.Common` namespace, which will provide you access to the static
`Throw` class, which provides the static property `If`, on which you will have
access to all of the guard extension methods for conditionally throwing exceptions.

An example of this would be:
```csharp
using OwlDomain.Common;

void Foo(int index)
{
   Throw.If.IsFalse(index >= 0);
}
```

This package also makes use of the throw extension methods provided by the
`OwlDomain.Common.Throw` package.



## License

This project (the source, and the release files, e.t.c) is release under the [OwlDomain License](/license.md).