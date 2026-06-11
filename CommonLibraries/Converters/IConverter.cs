// <copyright file="IConverter.cs" company="Ricardo">
// Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters
{
    /// <summary>
    /// Defines the interface for a converter that can convert between different types.
    /// </summary>
    /// <typeparam name="TSourceClass">The type of the source object.</typeparam>
    /// <typeparam name="TResultClass">The type of the result object.</typeparam>
    public interface IConverter<in TSourceClass, out TResultClass>
        where TSourceClass : class
        where TResultClass : class
    {
    }
}