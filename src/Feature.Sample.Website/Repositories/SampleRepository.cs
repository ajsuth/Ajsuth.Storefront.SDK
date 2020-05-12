// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SampleRepository.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Feature.Samples.Website.Repositories
{
    using Feature.Samples.Website.Models;
    using Feature.Samples.Website.Models.InputModels;
    using Feature.Samples.Website.Models.JsonResults;
    using Foundation.Commerce.Connect.Managers;
    using Sitecore.Commerce.XA.Foundation.Common;
    using Sitecore.Commerce.XA.Foundation.Common.Context;
    using Sitecore.Commerce.XA.Foundation.Common.Models;
    using Sitecore.Commerce.XA.Foundation.Common.Repositories;
    using Sitecore.Commerce.XA.Foundation.Connect;
    using Sitecore.Diagnostics;
    using Sitecore.XA.Foundation.SitecoreExtensions.Interfaces;
    using System;

    /// <summary>
    /// The repository for performing CRUD operations on sample data.
    /// </summary>
    public class SampleRepository : BaseCommerceModelRepository, ISampleRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleRepository" /> class.
        /// </summary>
        /// <param name="modelProvider">The model provider.</param>
        /// <param name="storefrontContext">The storefront context.</param>
        /// <param name="sampleManager">The sample manager.</param>
        public SampleRepository(
            IModelProvider modelProvider,
            IStorefrontContext storefrontContext,
            ISampleManager sampleManager)
        {
            Assert.ArgumentNotNull(modelProvider, "modelProvider");
            Assert.ArgumentNotNull(storefrontContext, "storefrontContext");
            Assert.ArgumentNotNull(sampleManager, "sampleManager");

            ModelProvider = modelProvider;
            StorefrontContext = storefrontContext;
            SampleManager = sampleManager;
        }

        /// <summary>
        /// Gets or sets the model provider.
        /// </summary>
        /// <value>
        /// The model provider.
        /// </value>
        public IModelProvider ModelProvider { get; protected set; }

        /// <summary>
        /// Gets or sets the storefront context.
        /// </summary>
        /// <value>
        /// The storefront context.
        /// </value>
        public IStorefrontContext StorefrontContext { get; protected set; }

        /// <summary>
        /// Gets or sets the sample manager.
        /// </summary>
        /// <value>
        /// The sample manager.
        /// </value>
        public ISampleManager SampleManager { get; protected set; }

        /// <summary>
        /// Gets the sample rendering model.
        /// </summary>
        /// <param name="rendering">The rendering.</param>
        /// <param name="propertyBag">The property bag.</param>
        /// <returns>
        /// An initilaized sample rendering model is returned.
        /// </returns>
        public SampleJsonResult GetSample(IVisitorContext visitorContext, StringPropertyCollection propertyBag = null)
        {
            var jsonResult = ModelProvider.GetModel<SampleJsonResult>();

            if (IsEdit)
            {
                try
                {
                    var response = SampleManager.GetSample(visitorContext, StorefrontContext, propertyBag);
                    if (!response.ServiceProviderResult.Success)
                    {
                        jsonResult.SetErrors(response.ServiceProviderResult);
                        return jsonResult;
                    }

                    var sample = response.Result;
                    if (sample != null)
                    {
                        jsonResult.Initialize(sample);
                    }
                }
                catch (Exception e)
                {
                    Log.Error(e.Message, e, this);
                    jsonResult.SetErrors("GetSample", e);
                    return jsonResult;
                }
            }

            return jsonResult;
        }

        /// <summary>
        /// Gets the sample rendering model.
        /// </summary>
        /// <param name="rendering">The rendering.</param>
        /// <param name="propertyBag">The property bag.</param>
        /// <returns>
        /// An initilaized sample rendering model is returned.
        /// </returns>
        public SamplesJsonResult GetSamples(IVisitorContext visitorContext, GetSamplesInputModel inputModel, StringPropertyCollection propertyBag = null)
        {
            Assert.ArgumentNotNull(inputModel, nameof(inputModel));

            var jsonResult = ModelProvider.GetModel<SamplesJsonResult>();

            try
            {
                var response = SampleManager.GetSamples(StorefrontContext.CurrentStorefront, visitorContext, propertyBag);
                if (!response.ServiceProviderResult.Success)
                {
                    jsonResult.SetErrors(response.ServiceProviderResult);
                    return jsonResult;
                }

                var samples = response.Result;
                if (samples != null)
                {
                    jsonResult.Initialize(samples);
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message, e, this);
                jsonResult.SetErrors("GetSample", e);
                return jsonResult;
            }

            return jsonResult;
        }

        /// <summary>
        /// Gets the delivery data.
        /// </summary>
        /// <param name="visitorContext">The visitor context.</param>
        /// <param name="propertyBag">The property bag.</param>
        /// <returns>
        /// The sample.
        /// </returns>
        public SampleRenderingModel GetSampleRenderingModel(IRendering rendering, StringPropertyCollection propertyBag = null)
        {
            var model = ModelProvider.GetModel<SampleRenderingModel>();

            Init(model);

            model.Initialize(rendering);

            return model;
        }
    }
}