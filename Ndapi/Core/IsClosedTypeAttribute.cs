#if !NET11_0_OR_GREATER
using System.ComponentModel;

namespace System.Runtime.CompilerServices;

// emitted by the compiler on `closed` classes; part of the runtime only from .NET 11
[EditorBrowsable(EditorBrowsableState.Never)]
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
internal sealed class IsClosedTypeAttribute : Attribute;
#endif
