// <copyright file="IFakeClassPropertyConverter.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
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