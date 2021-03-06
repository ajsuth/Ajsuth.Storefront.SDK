﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SampleJsonResult.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Feature.Samples.Website.Models.JsonResults
{
    using Foundation.Commerce.Connect.Entities;
    using Sitecore.Commerce.XA.Foundation.Common.Context;
    using Sitecore.Commerce.XA.Foundation.Common.Models.JsonResults;
    using Sitecore.Diagnostics;

    /// <summary>
    /// The sample 
    /// </summary>
    public class SampleJsonResult : BaseJsonResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleJsonResult" /> class.
        /// </summary>
        /// <param name="context">The sitecore context.</param>
        /// <param name="storefrontContext">The storefront context.</param>
        public SampleJsonResult(IContext context, IStorefrontContext storefrontContext)
            : base(context, storefrontContext)
        {
        }

        /// <summary>
        /// Gets or sets the sample property.
        /// </summary>
        /// <value>
        /// The sample property.
        /// </value>
        public string SampleProperty { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>
        /// The creation date.
        /// </value>
        public string CreationDate { get; set; }

        /// <summary>
        /// Initialises the model.
        /// </summary>
        /// <param name="cart"></param>
        /// <param name="visitorContext"></param>
        public virtual void Initialize(Sample sample)
        {
            Assert.ArgumentNotNull(sample, nameof(sample));

            SampleProperty = sample.ExternalId;
            CreationDate = sample.DateCreated.ToString();
        }

    }
}