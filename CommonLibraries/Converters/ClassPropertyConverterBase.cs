// <copyright file="ClassPropertyConverterBase.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters
{
    /// <inheritdoc/>
    public abstract class ClassPropertyConverterBase<
            TSourceClass,
            TDestinationClass,
            TPropertyClass> :
        IClassPropertyConverter<TSourceClass, TDestinationClass>
    {
        /// <inheritdoc/>
        public void Convert(TSourceClass source, in TDestinationClass result)
        {
            if (!HasValue(source))
            {
                return;
            }

            TPropertyClass propertyValue = this.GetPropertyValue(source);

            if (!HasValue(propertyValue))
            {
                return;
            }

            this.SetPropertyValue(in result, propertyValue);
        }

        /// <summary>
        /// Gets the value of the property from the source class instance. The logic for retrieving the property value should be
        /// implemented in the classes that inherit from this base class.
        /// </summary>
        /// <param name="source">TheThe <typeparamref name="TSourceClass"/>.</param>
        /// <returns>The <typeparamref name="TPropertyClass"/>.</returns>
        protected abstract TPropertyClass GetPropertyValue(TSourceClass source);

        /// <summary>
        /// Sets the value of the property on the destination class instance. The logic for setting the property value should be
        /// implemented in the classes that inherit from this base class.
        /// </summary>
        /// <param name="result">The destination class instance.</param>
        /// <param name="propertyValue">The property value to set.</param>
        protected abstract void SetPropertyValue(in TDestinationClass result, TPropertyClass propertyValue);

        /// <summary>
        /// Determines whether the specified value has a valid value that can be converted. This method checks if the value is null,
        /// if it is an array with a length greater than 0, or if it is not equal to the default value of the source class type.
        /// </summary>
        /// <param name="value">The source value to evaluate. Returns false if null, an empty array, or equal to
        /// default(TSourceClass); true otherwise.</param>
        /// <returns>True when the provided value contains meaningful data that can be converted; otherwise false.</returns>
        private static bool HasValue<TValueType>(TValueType value)
        {
            if (value is null)
            {
                return false;
            }

            if (value is Array valuesString)
            {
                return valuesString.Length > 0;
            }

            return !value.Equals(default(TSourceClass));
        }
    }
}