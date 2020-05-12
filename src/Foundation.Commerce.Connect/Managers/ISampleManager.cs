// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISampleManager.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Foundation.Commerce.Connect.Managers
{
    using Foundation.Commerce.Connect.Entities;
    using Foundation.Commerce.Connect.Services.Samples;
    using Sitecore.Commerce.XA.Foundation.Common;
    using Sitecore.Commerce.XA.Foundation.Common.Context;
    using Sitecore.Commerce.XA.Foundation.Common.Models;
    using Sitecore.Commerce.XA.Foundation.Connect;
    using Sitecore.Commerce.XA.Foundation.Connect.Managers;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the sample manager interface.
    /// </summary>
    public interface ISampleManager
    {
        /// <summary>
        /// Gets the sample for the given visitor context.
        /// </summary>
        /// <param name="visitorContext">The visitor context.</param>
        /// <param name="storefrontContext">The storefront context.</param>
        /// <param name="propertyBag">The property bag.</param>
        /// <returns>
        /// The sample for the given visitor context.
        /// </returns>
        ManagerResponse<SampleResult, Sample> GetSample(IVisitorContext visitorContext, IStorefrontContext storefrontContext, StringPropertyCollection propertyBag);

        /// <summary>
        /// Get the samples for the given visitor context
        /// </summary>
        /// <param name="storefront">The storefront</param>
        /// <param name="visitorContext">The visitor context.</param>
        /// <param name="propertyBag">The property bag.</param>
        /// <returns>
        /// samples for the given visitor context
        /// </returns>
        ManagerResponse<GetSamplesResult, IEnumerable<Sample>> GetSamples(CommerceStorefront storefront, IVisitorContext visitorContext, StringPropertyCollection propertyBag = null);
    }
}