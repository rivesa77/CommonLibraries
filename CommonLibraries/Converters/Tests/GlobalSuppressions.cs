// <copyright file="GlobalSuppressions.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
    "Style",
    "IDE0300:Simplify collection initialization",
    Justification = "Es correcto",
    Scope = "namespace",
    Target = "~N:Ricardo.CommonLibraries.Converters.Test.Converters")]
[assembly: SuppressMessage(
    "Usage",
    "MSTEST0063:Test classes should have valid constructors",
    Justification = "Es correcto",
    Scope = "namespace",
    Target = "~N:Ricardo.CommonLibraries.Converters.Test.Converters")]
[assembly: SuppressMessage(
    "Style",
    "IDE0090:Use 'new(...)'",
    Justification = "Es correcto>",
    Scope = "namespaceanddescendants",
    Target = "~N:Ricardo.CommonLibraries.Converters.Test.Converters")]