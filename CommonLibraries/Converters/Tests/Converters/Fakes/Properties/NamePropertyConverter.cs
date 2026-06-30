// <copyright file="NamePropertyConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters.Test.Converters.Fakes.Properties
{
    using Ricardo.CommonLibraries.Converters.Test.Converters.Fakes;
    using Ricardo.CommonLibraries.Converters.Test.Converters.Fakes.Constants;

    /// <summary>
    ///     Represents a property converter that converts the Name property from a <see cref="FakeSourceClass"/> instance.
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