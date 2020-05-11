// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SampleController.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Feature.Sample.Website
{
    using Feature.Sample.Website.Repositories;
    using Sitecore.Commerce.XA.Foundation.Common.Context;
    using Sitecore.Commerce.XA.Foundation.Common.Controllers;
    using Sitecore.Commerce.XA.Foundation.Common.Models;
    using Sitecore.Diagnostics;

    /// <summary>
    /// Sample controller.
    /// </summary>
    /// <seealso cref="Sitecore.Commerce.XA.Foundation.Common.Controllers.BaseCommerceStandardController" />
    public class SampleController : BaseCommerceStandardController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartController" /> class.
        /// </summary>
        /// <param name="storefrontContext">The storefront sitecoreContext.</param>
        /// <param name="modelProvider">The model provider.</param>
        /// <param name="sampleRepository">The sample repository.</param>
        /// <param name="sitecoreContext">sitecore sitecoreContext</param>
        public SampleController(
            IStorefrontContext storefrontContext,
            IModelProvider modelProvider,
            ISampleRepository sampleRepository,
            IContext sitecoreContext)
            : base(storefrontContext, sitecoreContext)
        {
            Assert.ArgumentNotNull(modelProvider, nameof(modelProvider));
            Assert.ArgumentNotNull(sampleRepository, nameof(sampleRepository));

            ModelProvider = modelProvider;
            SampleRepository = sampleRepository;
            VisitorContext = Foundation.Connect.VisitorContext.Current;
        }

        /// <summary>
        /// Gets or sets the model provider.
        /// </summary>
        /// <value>
        /// The model provider.
        /// </value>
        public IModelProvider ModelProvider { get; protected set; }

        /// <summary>
        /// Gets or sets the sample repository.
        /// </summary>
        /// <value>
        /// The sample repository.
        /// </value>
        public ISampleRepository SampleRepository { get; protected set; }
    }
}