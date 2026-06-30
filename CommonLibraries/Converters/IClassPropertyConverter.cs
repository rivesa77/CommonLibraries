// <copyright file="IClassPropertyConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters.Converters
{
    /// <summary>
    ///     Defines the interface for a converter that can convert between different types of class properties. This interface is intended
    ///     to be used for converting properties of classes, rather than entire classes. The conversion logic should be implemented in the
    ///     classes that implement this interface.
    /// </summary>
    /// <typeparam name="TSourceClass"> The type of the source class. </typeparam>
    /// <typeparam name="TDestinationClass"> The type of the destination class. </typeparam>
    public interface IClassPropertyConverter<in TSourceClass, TDestinationClass>
    {
        /// <summary>
        ///     Converts the specified source object to the result type.
        /// </summary>
        /// <param name="source"> The source object to convert. </param>
        /// <param name="result"> The destination object to convert to. </param>
        void Convert(TSourceClass source, in TDestinationClass result);
    }
}