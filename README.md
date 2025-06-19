Ndapi
=====

[![Build](https://github.com/felipebz/ndapi/actions/workflows/build.yml/badge.svg)](https://github.com/felipebz/ndapi/actions/workflows/build.yml)

Oracle Forms includes an API that enables C/C++ developers to create, load, edit, save, and compile Oracle Forms modules (.fmb, .mmb, .olb and .pll files). It gives access to almost all the Forms Builder functionality.

Oracle Forms also includes a Java API (JDAPI) that wraps the Open API functionality and offers a complete API to Java developers. But the API is a bit verbose because it doesn't have any support for generics nor iterators.

A Java sample code with JDAPI looks like:

```java
FormModule module = FormModule.open(sourceFileName);
JdapiIterator programUnits = module.getProgramUnits();
while (programUnits.hasNext()) {
    ProgramUnit programUnit = (ProgramUnit)programUnits.next();
    String name = programUnit.getName();
    // ...
}
```

The objective of this project is to implement a fully featured .NET wrapper for Oracle Forms Open API, providing a more idiomatic API for .NET developers. 

So, the same code with Ndapi would be:

```csharp
var module = FormModule.Open(sourceFileName);
foreach (var programUnit in module.ProgramUnits)
{
    var name = programUnit.Name;
    // ...
}
```

Supported Oracle Forms versions
-------------------------------

Currently this projects is tested with:
- Forms 6.0.8.22.1 (32-bit)
- Forms 12.2.1.3 (64-bit)
- Forms 12.2.1.4 (64-bit)
- Forms 12.2.1.19 (64-bit)
- Forms 14.1.2.0 (64-bit)

Installing
----------

Official releases can be obtained using the [NuGet package](https://www.nuget.org/packages/Ndapi).

To integrate with Forms 6i your application **must** target the platform `x86`. To integrate with Forms 12c
your application **must** target the platform `x64`.

To get the development builds use https://github.com/felipebz/ndapi/pkgs/nuget/Ndapi.
