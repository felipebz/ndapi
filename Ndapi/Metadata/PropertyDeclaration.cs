using System;

using Ndapi.Core;

namespace Ndapi.Metadata;

/// <summary>
/// A typed member mapped to a Forms property, as NdapiSourceGenerator lists it in <c>PropertyDeclarations</c>.
/// </summary>
internal readonly record struct PropertyDeclaration(NdapiConstant PropertyId, string Name, bool CanWrite, Type PropertyType);
