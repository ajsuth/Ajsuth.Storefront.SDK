// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SampleResult.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Foundation.Commerce.Connect.Services.Samples
{
    using Foundation.Commerce.Connect.Entities;
    using Sitecore.Commerce.Services;

    /// <summary>
    /// The sample result.
    /// </summary>
    public class SampleResult : ServiceProviderResult
    {
        /// <summary>
        /// Gets or sets the sample
        /// </summary>
        public Sample Sample { get; set; }
    }
}
