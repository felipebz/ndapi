Ndapi
=====

Oracle Forms includes an API that enables C/C++ developers to create, load, edit, save, and compile Oracle Forms modules (.fmb, .mmb, .olb and .pll files). It gives access to almost all the Forms Builder functionality.

Oracle Forms also includes a Java API (JDAPI) that wraps the Open API functionality and offer a complete API to Java developers. But the API is a bit verbose because it doesn't have any support for generics nor iterators.

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

While JDAPI can be used in .NET projects after converted by ikvmc (from [IKVM.NET](http://www.ikvm.net/)), the resulting API isn't nice for .NET developers.

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

Initially, the API will support only Forms 6i API.

Features available
------------------

Partial:

- [x] Alert
- [x] Attached Library
- [x] Block
- [x] Canvas
- [x] Data Source
- [x] Data Source Argument
- [x] Editor
- [x] Form Module
- [x] Form Parameter
- [x] Generic Object
- [x] Graphics Object
- [x] Item
- [x] LOV
- [x] LOV column mapping
- [x] Menu
- [x] Menu Item
- [x] Menu Module
- [x] Object Group
- [x] Object Group Child
- [x] Object Library
- [x] Object Library Tab
- [x] Program Unit
- [x] Property
- [x] Record Group
- [x] Record Group Column Specification
- [x] Relation
- [x] Report
- [x] Tab Page
- [x] Trigger
- [x] Visual Attribute
- [x] Window

Missing:

- [ ] Menu Parameter
- [ ] Property Class
