// <copyright file="IFakeClassPropertyConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters.Test.Converters.Fakes
{
    using Ricardo.CommonLibraries.Converters.Converters;

    /// <summary>
    ///     Defines a contract for converting properties between fake source and destination classes.
    /// </summary>
    public interface IFakeClassPropertyConverter : IClassPropertyConverter<FakeSourceClass, FakeDestinationClass>
    {
    }
}