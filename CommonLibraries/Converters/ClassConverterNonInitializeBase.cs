// <copyright file="ClassConverterNonInitializeBase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters.Converters
{
    using System.Collections.Generic;

    /// <inheritdoc/>
    public abstract class ClassConverterNonInitializeBase<TSourceClass, TDestinationClass, TPropertyConverter> :
        IClassConverter<TSourceClass, TDestinationClass>
        where TSourceClass : class
        where TDestinationClass : class
        where TPropertyConverter : IClassPropertyConverter<TSourceClass, TDestinationClass>
    {
        private readonly IEnumerable<TPropertyConverter> propertyConverters;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ClassConverterNonInitializeBase{TSourceClass, TDestinationClass,
        ///     TPropertyConverter}"/> class with the specified property converters. The property converters are used to convert individual
        ///     properties from the source class to the destination class. The conversion logic for each property should be implemented in
        ///     the classes that implement the <see cref="IClassPropertyConverter{TSourceClass, TDestinationClass}"/> interface.
        /// </summary>
        /// <param name="propertyConverters"> The collection of <typeparamref name="TPropertyConverter"/>. </param>
        protected ClassConverterNonInitializeBase(IEnumerable<TPropertyConverter> propertyConverters)
        {
            this.propertyConverters = propertyConverters;
        }

        /// <inheritdoc/>
        public TDestinationClass Convert(TSourceClass source)
        {
            TDestinationClass result = this.InitializeDestination();

            foreach (TPropertyConverter propertyConverter in this.propertyConverters)
            {
                propertyConverter.Convert(source, result);
            }

            return result;
        }

        /// <summary>
        ///     Initializes the <typeparamref name="TDestinationClass"/>.
        /// </summary>
        /// <returns> The initialized <typeparamref name="TDestinationClass"/>. </returns>
        protected abstract TDestinationClass InitializeDestination();
    }
}