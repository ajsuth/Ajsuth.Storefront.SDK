// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SampleRenderingModel.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Feature.Samples.Website.Models
{
    using Sitecore.Commerce.XA.Foundation.Common.Models;
    using Sitecore.XA.Foundation.SitecoreExtensions.Interfaces;

    public class SampleRenderingModel : BaseCommerceRenderingModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleRenderingModel"/> class.
        /// </summary>
        public SampleRenderingModel()
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
        /// Initializes the specified rendering.
        /// </summary>
        /// <param name="rendering">The rendering.</param>
        public virtual void Initialize(IRendering rendering)
        {
            SampleProperty = "sample";
        }
    }
}