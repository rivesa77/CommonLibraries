// <copyright file="NamePropertyConverter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters.Fakes.Properties
{
    using Ricardo.CommonLibraries.Converters.Fakes.Constants;
    using Ricardo.CommonLibraries.Tests.Converters.Fakes;

    /// <summary>
    /// Represents a property converter that converts the Name property from a <see cref="FakeSourceClass"/> instance.
    /// </summary>
    internal class NamePropertyConverter : IFakeClassPropertyConverter
    {
        /// <inheritdoc/>
        public void Convert(FakeSourceClass source, in FakeDestinationClass result)
        {
            result.Name = source.Name is null ? default : $"{source.Name}{FakeTestConstants.TextSuffix}";
        }
    }
}