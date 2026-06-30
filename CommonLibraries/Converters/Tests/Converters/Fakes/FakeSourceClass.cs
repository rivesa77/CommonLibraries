// <copyright file="FakeSourceClass.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters.Test.Converters.Fakes
{
    /// <summary>
    ///     Represents a fake source class for testing purposes.
    /// </summary>
    public class FakeSourceClass
    {
        /// <summary>
        ///     Gets or sets the name of the source class instance. This property is used to test the conversion of string properties from
        ///     the source class to the destination class.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the age of the source class instance. This property is used to test the conversion of integer properties from
        ///     the source class to the destination class.
        /// </summary>
        public int Age { get; set; }
    }
}