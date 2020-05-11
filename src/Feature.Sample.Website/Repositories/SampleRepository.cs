// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SampleRepository.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Feature.Sample.Website.Repositories
{
    using Feature.Sample.Website.Models;
    using Feature.Sample.Website.Models.JsonResults;
    using Sitecore.Commerce.XA.Foundation.Common;
    using Sitecore.Commerce.XA.Foundation.Connect;
    using Sitecore.XA.Foundation.SitecoreExtensions.Interfaces;

    /// <summary>
    /// The repository for performing CRUD operations on sample data.
    /// </summary>
    public class SampleRepository : ISampleRepository
    {
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
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }
    }
}