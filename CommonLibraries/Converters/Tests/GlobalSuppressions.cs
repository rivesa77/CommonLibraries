// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
    "Style",
    "IDE0300:Simplify collection initialization",
    Justification = "Es correcto",
    Scope = "namespace",
    Target = "~N:Ricardo.CommonLibraries.Tests.Converters")]
[assembly: SuppressMessage(
    "Usage",
    "MSTEST0063:Test classes should have valid constructors",
    Justification = "Es correcto",
    Scope = "namespace",
    Target = "~N:Ricardo.CommonLibraries.Tests.Converters")]
[assembly: SuppressMessage(
    "Style",
    "IDE0090:Use 'new(...)'",
    Justification = "Es correcto>",
    Scope = "namespaceanddescendants",
    Target = "~N:Ricardo.CommonLibraries.Tests.Converters")]