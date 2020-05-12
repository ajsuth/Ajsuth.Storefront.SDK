// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SamplesJsonResult.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Feature.Samples.Website.Models.JsonResults
{
    using Foundation.Commerce.Connect.Entities;
    using Sitecore.Commerce.XA.Foundation.Common.Context;
    using Sitecore.Commerce.XA.Foundation.Common.Models;
    using Sitecore.Commerce.XA.Foundation.Common.Models.JsonResults;
    using Sitecore.Diagnostics;
    using System.Collections.Generic;
    using System.Web.Script.Serialization;

    /// <summary>
    /// The sample 
    /// </summary>
    public class SamplesJsonResult : BaseJsonResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleJsonResult" /> class.
        /// </summary>
        /// <param name="context">The sitecore context.</param>
        /// <param name="storefrontContext">The storefront context.</param>
        public SamplesJsonResult(IContext context, IStorefrontContext storefrontContext, IModelProvider modelProvider)
            : base(context, storefrontContext)
        {
            Assert.ArgumentNotNull(modelProvider, "modelProvider");

            ModelProvider = modelProvider;
        }

        /// <summary>
        /// Gets or sets the model provider.
        /// </summary>
        /// <value>
        /// The model provider.
        /// </value>
        [ScriptIgnore]
        public IModelProvider ModelProvider { get; protected set; }

        /// <summary>
        /// Gets or sets the samples property.
        /// </summary>
        /// <value>
        /// The samples property.
        /// </value>
        public IEnumerable<SampleJsonResult> SamplesProperty { get; set; }

        /// <summary>
        /// Initialises the model.
        /// </summary>
        /// <param name="cart"></param>
        /// <param name="visitorContext"></param>
        public virtual void Initialize(IEnumerable<Sample> samples)
        {
            Assert.ArgumentNotNull(samples, nameof(samples));

            foreach (var sample in samples)
            {
                var sampleJsonResult = ModelProvider.GetModel<SampleJsonResult>();
                sampleJsonResult.Initialize(sample);
            }
        }
    }
}