Ndapi
=====

[![Build](https://github.com/felipebz/ndapi/actions/workflows/build.yml/badge.svg)](https://github.com/felipebz/ndapi/actions/workflows/build.yml)
[![NuGet Version](https://img.shields.io/nuget/v/Ndapi)](https://www.nuget.org/packages/Ndapi)
[![License](https://img.shields.io/github/license/felipebz/ndapi)](https://github.com/felipebz/ndapi/blob/main/LICENSE)
[![OpenSSF Scorecard](https://api.scorecard.dev/projects/github.com/felipebz/ndapi/badge)](https://scorecard.dev/viewer/?uri=github.com/felipebz/ndapi)

Ndapi lets .NET applications read, create, modify and compile Oracle Forms modules (`.fmb`, `.mmb`, `.olb`, `.pll`).
It wraps the Oracle Forms Open API in a strongly-typed C# object model: blocks, items, triggers and program units are
classes with typed properties and enumerable collections.

```csharp
using Ndapi;

using var module = FormModule.Open("orders.fmb");

foreach (var block in module.Blocks)
{
    foreach (var item in block.Items.Where(i => i.IsRequired))
    {
        Console.WriteLine($"{block.Name}.{item.Name}: {item.Prompt}");
    }
}
```

## Installation

```bash
dotnet add package Ndapi
```

Every build of `main` is published to GitHub Packages as a prerelease. GitHub Packages needs authentication even for
public packages: use a personal access token with the `read:packages` scope.

```bash
dotnet nuget add source "https://nuget.pkg.github.com/felipebz/index.json" --name "ndapi-dev" \
    --username <github-user> --password <token> --store-password-in-clear-text
dotnet add package Ndapi --prerelease -s "ndapi-dev"
```

## Requirements

Ndapi calls the Open API of an Oracle Forms installation, so Forms must be installed on the machine that runs your
application. Ndapi targets .NET 8 or later and supports trimming and NativeAOT.

| Oracle Forms                    | Build your app for | OS             |
|---------------------------------|--------------------|----------------|
| 6i (6.0.8.22.1)                 | `x86`              | Windows        |
| 12c (12.2.1.3, 12.2.1.4, 12.2.1.19) | `x64`          | Windows, Linux |
| 14c (14.1.2.0)                  | `x64`              | Windows, Linux |

* **Windows:** run Ndapi on an STA thread, e.g. mark `Main` with `[STAThread]`. Top-level statements run on an MTA
  thread, and the first call then throws an `NdapiException` asking for STA.
* **Linux:** set `ORACLE_HOME` to the Forms installation. Forms itself needs Motif (`libXm.so.4`) and `libXp.so.6`.

Need another version? [Open an issue](https://github.com/felipebz/ndapi/issues/new).

## Usage

### Modify and save a module

```csharp
using var module = FormModule.Open("orders.fmb");

var block = module.Blocks.First(b => b.Name == "ORDERS");
block.WhereClause = "status = 'OPEN'";

var trigger = new Trigger(block, "WHEN-NEW-RECORD-INSTANCE")
{
    Text = "message('New order');"
};

module.Save("orders_v2.fmb");
```

### Create a module from scratch

```csharp
using Ndapi.Enums;

using var module = new FormModule("EMPLOYEES");
var window = new Window(module, "MAIN");
var canvas = new Canvas(module, "MAIN") { Window = window, Width = 400, Height = 300 };

var block = new Block(module, "EMP")
{
    IsDatabaseBlock = true,
    QueryDataSourceType = QueryDataSourceType.Table,
    QueryDataSourceName = "EMP"
};

_ = new Item(block, "ENAME")
{
    ItemType = ItemType.TextItem,
    DataType = ItemDataType.Char,
    MaximumLength = 10,
    Canvas = canvas
};

module.Save("employees.fmb");
```

The [CreateModuleDemo](https://github.com/felipebz/ndapi/blob/main/samples/CreateModuleDemo/Program.cs) sample builds
a complete master-detail form.

### Compile

Compiling generates the `.fmx`/`.mmx`/`.plx` file and needs a database connection:

```csharp
NdapiContext.ConnectToDatabase("scott/tiger@orcl");

using var module = FormModule.Open("orders.fmb");
module.CompileFile();
```

### Convert to and from text

```csharp
NdapiModule.ConvertToText<FormModule>("orders.fmb");   // writes orders.fmt
NdapiModule.ConvertFromText<FormModule>("orders.fmt"); // writes orders.fmb
```

### Properties without a typed member

Every object also exposes the raw Open API accessors, keyed by the `D2FP_*` constants of the Forms headers:

```csharp
using Ndapi.Core;

var prompt = item.GetStringProperty(NdapiConstant.D2FP_PRMPT);
item.SetNumberProperty(NdapiConstant.D2FP_PRMPT_STRID, 42);
```

`NdapiMetadata` lists the classes, their typed properties and the properties supported by the running Forms version.

## Differences between Forms versions

The same code runs against every supported version. Each Forms release adds or drops properties, so some members only
work on some versions: the XML documentation says so ("Forms 12c and later", "Forms 6i only"), and using one on a
version that lacks it throws an `NdapiException` that names the property.

## Things to know

* Disposing a module you opened or created unloads it from Forms (`using` does it for you; `Destroy()` does it
  explicitly). Objects obtained from it are invalid afterwards.
* The Forms API keeps one context per process. Don't use Ndapi from several threads at the same time.

## License

[MIT](https://github.com/felipebz/ndapi/blob/main/LICENSE)
