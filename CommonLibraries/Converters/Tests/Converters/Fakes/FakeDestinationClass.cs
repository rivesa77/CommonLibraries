// <copyright file="FakeDestinationClass.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters.Test.Converters.Fakes
{
    /// <summary>
    ///     Represents a fake destination class for testing purposes.
    /// </summary>
    public class FakeDestinationClass
    {
        /// <summary>
        ///     Gets or sets the name of the destination class instance. This property is used to test the conversion of string properties
        ///     from the destination class to the destination class.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the age of the destination class instance. This property is used to test the conversion of integer properties
        ///     from the destination class to the destination class.
        /// </summary>
        public int Age { get; set; }
    }
}