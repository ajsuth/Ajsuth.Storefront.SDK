// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISampleRepository.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Feature.Samples.Website.Repositories
{
    using Feature.Samples.Website.Models;
    using Feature.Samples.Website.Models.InputModels;
    using Feature.Samples.Website.Models.JsonResults;
    using Sitecore.Commerce.XA.Foundation.Common;
    using Sitecore.Commerce.XA.Foundation.Connect;
    using Sitecore.XA.Foundation.SitecoreExtensions.Interfaces;

    /// <summary>
    /// The sample repository interface
    /// </summary>
    public interface ISampleRepository
    {
        /// <summary>
        /// Gets the sample.
        /// </summary>
        /// <param name="visitorContext">The visitor context.</param>
        /// <param name="propertyBag">The property bag.</param>
        /// <returns>
        /// The sample.
        /// </returns>
        SampleJsonResult GetSample(IVisitorContext visitorContext, StringPropertyCollection propertyBag = null);

        /// <summary>
        /// Gets the samples.
        /// </summary>
        /// <param name="visitorContext">The visitor context.</param>
        /// <param name="inputModel">The input model.</param>
        /// <param name="propertyBag">The property bag.</param>
        /// <returns>
        /// The sample.
        /// </returns>
        SamplesJsonResult GetSamples(IVisitorContext visitorContext, GetSamplesInputModel inputModel, StringPropertyCollection propertyBag = null);

        /// <summary>
        /// Gets the sample rendering model.
        /// </summary>
        /// <param name="rendering">The rendering.</param>
        /// <param name="propertyBag">The property bag.</param>
        /// <returns>
        /// An initilaized sample rendering model is returned.
        /// </returns>
        SampleRenderingModel GetSampleRenderingModel(IRendering rendering, StringPropertyCollection propertyBag = null);
    }
}