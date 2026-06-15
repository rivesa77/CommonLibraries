// <copyright file="ClassPropertyConverterBaseTests.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Tests.Converters
{
    using FluentAssertions;
    using Ricardo.CommonLibraries.Converters;
    using Ricardo.CommonLibraries.Converters.Fakes.Constants;
    using Ricardo.CommonLibraries.Tests.Converters.Fakes;

    /// <inheritdoc/>
    [TestClass]
    public class ClassPropertyConverterBaseTests :
        ClassPropertyConverterBase<
            FakeSourceClass,
            FakeDestinationClass,
            string>
    {
        /// <summary>
        /// Tests that the Convert method returns the expected result when a valid name is provided.
        /// </summary>
        [TestMethod]
        public void Convert_WithValidName_ReturnsExpectedResult()
        {
            FakeSourceClass source = new FakeSourceClass()
            {
                Name = FakeTestConstants.Name,
            };

            FakeDestinationClass result = new FakeDestinationClass();

            this.Convert(source, result);

            FakeDestinationClass expectedResult = new FakeDestinationClass()
            {
                Name = FakeTestConstants.Name,
            };

            result
                .Should()
                .BeEquivalentTo(expectedResult);
        }

        /// <summary>
        /// Tests that the Convert method returns the expected result when a default property is provided.
        /// </summary>
        [TestMethod]
        public void Convert_WithDefaultProperty_ReturnsExpectedResult()
        {
            FakeSourceClass source = default;

            FakeDestinationClass result = new FakeDestinationClass();

            this.Convert(source, result);

            FakeDestinationClass expectedResult = new FakeDestinationClass();

            result
                .Should()
                .BeEquivalentTo(expectedResult);
        }

        /// <summary>
        /// Tests that the Convert method returns the expected result when a valid name is provided.
        /// </summary>
        [TestMethod]
        public void Convert_WithEmptyProperty_ReturnsExpectedResult()
        {
            FakeSourceClass source = new FakeSourceClass()
            {
                Age = FakeTestConstants.AgeOffset,
            };

            FakeDestinationClass result = new FakeDestinationClass();

            this.Convert(source, result);

            FakeDestinationClass expectedResult = new FakeDestinationClass();

            result
                .Should()
                .BeEquivalentTo(expectedResult);
        }

        /// <inheritdoc/>
        protected override string GetPropertyValue(FakeSourceClass source)
        {
            return source.Name;
        }

        /// <inheritdoc/>
        protected override void SetPropertyValue(in FakeDestinationClass result, string propertyValue)
        {
            result.Name = propertyValue;
        }
    }
}