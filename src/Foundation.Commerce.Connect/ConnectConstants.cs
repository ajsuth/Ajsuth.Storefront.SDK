// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConnectConstants.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Foundation.Commerce.Connect
{
    /// <summary>
    /// The connect constants.
    /// </summary>
    public class ConnectConstants
    {
        /// <summary>
        /// The names of the pipelines.
        /// </summary>
        public static class Pipelines
        {
            /// <summary>
            /// The get samples pipeline name.
            /// </summary>
            public const string GetSamples = "commerce.samples.getSamples";

            /// <summary>
            /// The sample pipeline name.
            /// </summary>
            public const string Sample = "commerce.samples.Sample";
        }

        /// <summary>
        /// The names of the service providers.
        /// </summary>
        public static class ServiceProviders
        {
            /// <summary>
            /// The sample service provider.
            /// </summary>
            public const string SampleServiceProvider = "SampleServiceProvider";
        }
    }
}
