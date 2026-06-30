// <copyright file="ClassConverterBase.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters.Converters
{
    /// <inheritdoc/>
    public abstract class ClassConverterBase<TSourceClass, TDestinationClass, TPropertyConverter> :
        ClassConverterNonInitializeBase<TSourceClass, TDestinationClass, TPropertyConverter>
        where TSourceClass : class
        where TDestinationClass : class, new()
        where TPropertyConverter : IClassPropertyConverter<TSourceClass, TDestinationClass>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ClassConverterBase{TSourceClass, TDestinationClass, TPropertyConverter}"/> class.
        /// </summary>
        /// <param name="propertyConverters"> The collection of <typeparamref name="TPropertyConverter"/>. </param>
        protected ClassConverterBase(IEnumerable<TPropertyConverter> propertyConverters)
            : base(propertyConverters)
        {
        }

        /// <summary>
        ///     Initializes the <typeparamref name="TDestinationClass"/>.
        /// </summary>
        /// <returns> The initialized <typeparamref name="TDestinationClass"/>. </returns>
        protected override TDestinationClass InitializeDestination()
        {
            return new TDestinationClass();
        }
    }
}
