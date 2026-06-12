// <copyright file="IFakeClassPropertyConverter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters.Fakes
{
    using Ricardo.CommonLibraries.Tests.Converters.Fakes;

    /// <summary>
    /// Defines a contract for converting properties between fake source and destination classes.
    /// </summary>
    public interface IFakeClassPropertyConverter : IClassPropertyConverter<FakeSourceClass, FakeDestinationClass>
    {
    }
}