// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISampleManager.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Foundation.Commerce.Connect.Managers
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
        /// Get the sample for the given visitor context.
        /// </summary>
        /// <param name="visitorContext">The visitor context.</param>
        /// <param name="storefrontContext">The storefront context.</param>
        /// <param name="propertyBag">The property bag.</param>
        /// <returns>
        /// The sample for the given visitor context.
        /// </returns>
        public virtual ManagerResponse<SampleResult, Sample> GetSample(IVisitorContext visitorContext, IStorefrontContext storefrontContext, StringPropertyCollection propertyBag = null)
        {
            Assert.ArgumentNotNull(visitorContext, nameof(visitorContext));
            Assert.ArgumentNotNull(storefrontContext, nameof(storefrontContext));

            var request = new SampleRequest("sample")
            {
                CustomerId = visitorContext.CustomerId
            };
            request.CopyPropertyBag(propertyBag);

            var response = SampleServiceProvider.GetSample(request);

            return new ManagerResponse<SampleResult, Sample>(response, response.Sample);
        }

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
                CustomerId = visitorContext.CustomerId
            };
            request.CopyPropertyBag(propertyBag);

            var response = SampleServiceProvider.GetSamples(request);
            return new ManagerResponse<GetSamplesResult, IEnumerable<Sample>>(response, response.Samples);
        }
    }
}