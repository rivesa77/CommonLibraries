// <copyright file="AgePropertyConverter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters.Fakes.Properties
{
    using Ricardo.CommonLibraries.Tests.Converters.Fakes;

    /// <summary>
    /// Represents a property converter that converts the Age property from a <see cref="FakeSourceClass"/> instance.
    /// </summary>
    internal class AgePropertyConverter : IFakeClassPropertyConverter
    {
        /// <inheritdoc/>
        public void Convert(FakeSourceClass source, in FakeDestinationClass result)
        {
            result.Age = source.Age + 1;
        }
    }
}