// <copyright file="FakeTestConstants.cs" company="Ricardo">
//     Copyright (c) Ricardo. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Converters.Test.Converters.Fakes.Constants
{
    /// <summary>
    ///     Contains constant values used in the fake converter tests.
    /// </summary>
    internal static class FakeTestConstants
    {
        /// <summary>
        ///     The suffix appended to string properties during conversion in the fake converter tests.
        /// </summary>
        public const string TextSuffix = "_Converted";

        /// <summary>
        ///     The offset added to integer properties during conversion in the fake converter tests.
        /// </summary>
        public const int AgeOffset = 30;

        /// <summary>
        ///     The name of the property being converted in the fake converter tests.
        /// </summary>
        public const string Name = "Name";
    }
}