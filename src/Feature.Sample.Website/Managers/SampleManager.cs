// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISampleManager.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Feature.Samples.Website.Managers
{
    using Foundation.Commerce.Connect.Entities;
    using Foundation.Commerce.Connect.Providers;
    using Foundation.Commerce.Connect.Services.Samples;
    using Sitecore.Commerce.XA.Foundation.Common;
    using Sitecore.Commerce.XA.Foundation.Common.Context;
    using Sitecore.Commerce.XA.Foundation.Common.Models;
    using Sitecore.Commerce.XA.Foundation.Connect;
    using Sitecore.Commerce.XA.Foundation.Connect.ExtensionMethods;
    using Sitecore.Commerce.XA.Foundation.Connect.Managers;
    using Sitecore.Diagnostics;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the sample manager implementation.
    /// </summary>
    public class SampleManager : ISampleManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleManager" /> class.
        /// </summary>
        /// <param name="connectServiceProvider">Connect Service Provider</param>
        public SampleManager(ICommerceConnectServiceProvider commerceConnectServiceProvider)
        {
            Assert.ArgumentNotNull(commerceConnectServiceProvider, "commerceConnectServiceProvider");

            SampleServiceProvider = commerceConnectServiceProvider.GetSampleServiceProvider();
        }

        /// <summary>
        /// Gets or sets the Connect sample service provider.
        /// </summary>
        /// <value>
        /// The sample service provider.
        /// </value>
        public SampleServiceProvider SampleServiceProvider { get; set; }

        /// <summary>
        /// Get the samples for the given visitor context
        /// </summary>
        /// <param name="storefront">The storefront</param>
        /// <param name="visitorContext">The visitor context.</param>
        /// <param name="propertyBag">The property bag.</param>
        /// <returns>
        /// samples for the given visitor context
        /// </returns>
        public virtual ManagerResponse<GetSamplesResult, IEnumerable<Sample>> GetSamples(CommerceStorefront storefront, IVisitorContext visitorContext, StringPropertyCollection propertyBag = null)
        {
            Assert.ArgumentNotNull(storefront, nameof(storefront));
            Assert.ArgumentNotNull(visitorContext, nameof(visitorContext));

            var request = new GetSamplesRequest()
            {
                CustomerIds = new[]
                {
                    visitorContext.CustomerId
                }
            };
            request.CopyPropertyBag(propertyBag);

            var response = SampleServiceProvider.GetSamples(request);
            return new ManagerResponse<GetSamplesResult, IEnumerable<Sample>>(response, response.Samples);
        }
    }
}