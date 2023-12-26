Ndapi
=====

[![Build status](https://ci.appveyor.com/api/projects/status/sm2f9vamtugb4tc0?svg=true)](https://ci.appveyor.com/project/felipebz/ndapi)

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

Installing
----------

To install the latest version, compatible with Oracle Forms 12c, run:

```powershell
Install-Package Ndapi
```

Or use the Package Manager in Visual Studio.

To get the latest builds use https://github.com/felipebz/ndapi/pkgs/nuget/Ndapi.
