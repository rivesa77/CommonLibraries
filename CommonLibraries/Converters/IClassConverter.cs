// <copyright file="IClassConverter.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters
{
    /// <summary>
    /// Defines the interface for a converter that can convert between different types.
    /// </summary>
    /// <typeparam name="TSourceClass">The type of the source object.</typeparam>
    /// <typeparam name="TDestinationClass">The type of the result object.</typeparam>
    public interface IClassConverter<in TSourceClass, out TDestinationClass> : IConverter<TSourceClass, TDestinationClass>
        where TSourceClass : class
        where TDestinationClass : class
    {
    }
}