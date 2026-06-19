// <copyright file="IClassConverter.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters
{
    /// <inheritdoc/>
    public interface IClassConverter<in TSourceClass, out TDestinationClass> :
        IConverter<TSourceClass, TDestinationClass>
    {
    }
}