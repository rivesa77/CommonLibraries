// <copyright file="ClassConverterBaseTests.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters.Test.Converters
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Ricardo.CommonLibraries.Converters.Converters;
    using Ricardo.CommonLibraries.Converters.Test.Converters.Fakes;
    using Ricardo.CommonLibraries.Converters.Test.Converters.Fakes.Constants;
    using Ricardo.CommonLibraries.Converters.Test.Converters.Fakes.Properties;

    /// <inheritdoc/>
    [TestClass]
    [TestCategory("Converters")]
    public class ClassConverterBaseTests :
        ClassConverterBase<
            FakeSourceClass,
            FakeDestinationClass,
            IFakeClassPropertyConverter>
    {
        private static readonly IEnumerable<IFakeClassPropertyConverter> PropertyConverters =
         [
                new AgePropertyConverter(),
                new NamePropertyConverter(),
         ];

        /// <summary>
        ///     Initializes a new instance of the <see cref="ClassConverterBaseTests"/> class.
        /// </summary>
        public ClassConverterBaseTests()
            : base(PropertyConverters)
        {
        }

        /// <summary>
        ///     Tests that the <see cref="ClassConverterNonInitializeBase{FakeSourceClass, FakeDestinationClass, IFakeClassPropertyConverter}.Convert(FakeSourceClass)"/> method converts
        ///     the source class to the destination class.
        /// </summary>
        [TestMethod]
        public void Convert_WithValidPropertyConverters_ReturnsConvertedClass()
        {
            // Arrange
            FakeSourceClass source = new FakeSourceClass()
            {
                Name = FakeTestConstants.Name,
                Age = FakeTestConstants.AgeOffset,
            };

            // Act
            FakeDestinationClass result = this.Convert(source);

            // Assert
            FakeDestinationClass expectedResult = new FakeDestinationClass()
            {
                Name = $"{FakeTestConstants.Name}{FakeTestConstants.TextSuffix}",
                Age = 31,
            };

            result
                .Should()
                .BeEquivalentTo(expectedResult);
        }

        /// <inheritdoc/>
        protected override FakeDestinationClass InitializeDestination()
        {
            return new FakeDestinationClass();
        }
    }
}
