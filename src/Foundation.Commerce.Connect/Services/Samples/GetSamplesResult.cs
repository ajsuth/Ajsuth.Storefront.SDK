// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetSamplesResult.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Foundation.Commerce.Connect.Services.Samples
{
    using Foundation.Commerce.Connect.Entities;
    using Sitecore.Commerce.Services;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The sample result.
    /// </summary>
    public class GetSamplesResult : ServiceProviderResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSamplesResult" /> class.
        /// </summary>
        public GetSamplesResult()
        {
            Samples = Enumerable.Empty<Sample>();
        }

        /// <summary>
        /// Gets or sets the samples.
        /// </summary>
        public IEnumerable<Sample> Samples { get; set; }
    }
}
