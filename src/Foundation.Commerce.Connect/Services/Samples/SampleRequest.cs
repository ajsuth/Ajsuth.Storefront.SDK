// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetSampleRequest.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Foundation.Commerce.Connect.Services.Samples
{
    using Sitecore.Commerce.Services;
    using Sitecore.Diagnostics;

    /// <summary>
    /// Defines the SampleRequest class.
    /// </summary>
    public class SampleRequest : ServiceProviderRequest
    {
        /// <summary>
        /// Initializes a new instance of <see cref="SampleRequest"/>
        /// </summary>
        /// <param name="sample">The sample</param>
        public SampleRequest(string sample)
        {
            Assert.ArgumentNotNull(sample, nameof(sample));

            Sample = sample;
        }

        /// <summary>
        /// Gets or sets the sample
        /// </summary>
        public string Sample { get; set; }
    }
}
