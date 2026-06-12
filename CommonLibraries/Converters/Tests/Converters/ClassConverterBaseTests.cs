// <copyright file="ClassConverterBaseTests.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Tests.Converters
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Ricardo.CommonLibraries.Converters;
    using Ricardo.CommonLibraries.Converters.Fakes;
    using Ricardo.CommonLibraries.Converters.Fakes.Constants;
    using Ricardo.CommonLibraries.Converters.Fakes.Properties;
    using Ricardo.CommonLibraries.Tests.Converters.Fakes;

    /// <inheritdoc/>
    [TestClass]
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
        /// Initializes a new instance of the <see cref="ClassConverterBaseTests"/> class.
        /// </summary>
        public ClassConverterBaseTests()
            : base(PropertyConverters)
        {
        }

        /// <summary>
        /// Tests that the <see cref="ClassConverterBase{TSource, TDestination, TPropertyConverter}.Convert(TSource)"/> method converts the source
        /// class to the destination class.
        /// </summary>
        [TestMethod]
        public void Convert_WithPropertyConverters_ReturnsConvertedClass()
        {
            // Arrange
            FakeSourceClass source = new FakeSourceClass()
            {
                Name = FakeTestConstants.Name,
                Age = FakeTestConstants.AgeOffset,
            };

            // Act
            FakeDestinationClass dest = this.Convert(source);

            // Assert
            Assert.IsNotNull(dest);
            Assert.AreEqual($"{FakeTestConstants.Name}{FakeTestConstants.TextSuffix}", dest.Name);
            Assert.AreEqual(31, dest.Age);
        }

        /// <inheritdoc/>
        protected override FakeDestinationClass InitializeDestination()
        {
            return new FakeDestinationClass();
        }
    }
}