Ndapi
=====

[![Build](https://github.com/felipebz/ndapi/actions/workflows/build.yml/badge.svg)](https://github.com/felipebz/ndapi/actions/workflows/build.yml)
[![NuGet Version](https://img.shields.io/nuget/v/Ndapi)](https://www.nuget.org/packages/Ndapi)
[![License](https://img.shields.io/github/license/felipebz/ndapi)](LICENSE)

Oracle Forms ships with an Open API that allows C/C++ developers to open, edit, and compile module files (.fmb, .mmb, 
.olb, .pll). For Java developers, Oracle provides the JDAPI (Java Design-time API) a Java 2 wrapper around the same Open
API functionality. However, JDAPI's pre-generics design and iterator-style collections often result in verbose and 
error-prone code.

Ndapi brings the power of the Open API to .NET, offering an idiomatic, strongly-typed API that feels natural to C# 
developers.

## How Ndapi compares to JDAPI

Here’s a comparison of key points:

|                      | JDAPI (Java)                                | Ndapi (.NET)                                  |
| -------------------- |---------------------------------------------| --------------------------------------------- |
| Language             | Java 2 (pre-generics design)                | C# with modern .NET features                  |
| Type Safety          | Low (manual casting, raw collections)       | High (strongly-typed, generics, LINQ support) |
| Iteration            | Custom iterator (`JdapiIterator`)           | Native .NET `IEnumerable<T>`                  |
| Memory Management    | Manual (`.destroy()` calls required)        | Automatic (IDisposable + `using var`)         |
| Deployment | Requires JVM and Oracle native libraries    | Requires .NET 8.0+ and Oracle native libraries |
| Package Distribution | Manual jar (not available on Maven central) | Distributed via NuGet                         |

### Benefits of Ndapi:

* Leverages modern C# language features
* Strong compile-time type checking
* Simplified resource management (via `IDisposable`)
* Compatible with [.NET Trimming](https://learn.microsoft.com/en-us/dotnet/core/deploying/trimming/trim-self-contained) and [NativeAOT](https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/)

### Example: JDAPI vs Ndapi

#### JDAPI (Java)

```java
FormModule module = FormModule.open(sourceFileName);
JdapiIterator programUnits = module.getProgramUnits();
while (programUnits.hasNext()) {
    ProgramUnit programUnit = (ProgramUnit)programUnits.next();
    String name = programUnit.getName();
    // ...
}
```

#### Ndapi (C#)

```csharp
using var module = FormModule.Open(sourceFileName);
foreach (var programUnit in module.ProgramUnits)
{
    var name = programUnit.Name;
    // ...
}
```

## Supported Oracle Forms versions

| Oracle Forms | Architecture |
|--------------| ------------ |
| 6.0.8.22.1   | x86          |
| 12.2.1.3     | x64          |
| 12.2.1.4     | x64          |
| 12.2.1.19    | x64          |
| 14.1.2.0     | x64          |

> Need support for a different version? [Open an issue](https://github.com/felipebz/ndapi/issues/new).

## Installation

### Stable releases

```bash
> dotnet add package Ndapi
```

### Nightly / CI builds

```bash
> dotnet nuget add source "https://github.com/felipebz/ndapi/pkgs/nuget" --name "ndapi-dev"
> dotnet add package Ndapi --prerelease -s "ndapi-dev"
```

### Platform target

* **Forms 6i** → compile your app for **`x86`**
* **Forms 12c/14c** → compile your app for **`x64`**
