// <copyright file="MoqExtension.cs" company="PlaceholderCompany">
//     Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ricardo.CommonLibraries.Extensions.Tests.Mocks
{
    using global::Moq;

    /// <summary>
    ///     Moq extensions.
    /// </summary>
    public static class MoqExtension
    {
        /// <summary>
        ///     Verify all and other calls.
        /// </summary>
        /// <typeparam name="T"> The mocked type. </typeparam>
        /// <param name="mock"> The instance of <see cref="Mock{T}"/>. </param>
        /// <returns> The <see cref="Mock{T}"/>. </returns>
        public static Mock<T> VerifyAllAndOtherCalls<T>(this Mock<T> mock)
            where T : class
        {
            mock.Verify();
            mock.VerifyNoOtherCalls();

            return mock;
        }
    }
}