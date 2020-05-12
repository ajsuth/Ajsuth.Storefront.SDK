// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SampleController.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Feature.Samples.Website.Controllers
{
    using Feature.Samples.Website.Models.InputModels;
    using Feature.Samples.Website.Repositories;
    using Sitecore.Commerce.XA.Foundation.Common.Attributes;
    using Sitecore.Commerce.XA.Foundation.Common.Context;
    using Sitecore.Commerce.XA.Foundation.Common.Controllers;
    using Sitecore.Commerce.XA.Foundation.Common.Models;
    using Sitecore.Commerce.XA.Foundation.Common.Models.JsonResults;
    using Sitecore.Commerce.XA.Foundation.Connect;
    using Sitecore.Diagnostics;
    using System.Web.Mvc;
    using System.Web.SessionState;
    using System.Web.UI;

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
        /// <param name="visitorContext">The visitor context.</param>
        /// <param name="sitecoreContext">sitecore sitecoreContext</param>
        public SampleController(
            IStorefrontContext storefrontContext,
            IModelProvider modelProvider,
            ISampleRepository sampleRepository,
            IVisitorContext visitorContext,
            IContext sitecoreContext)
            : base(storefrontContext, sitecoreContext)
        {
            Assert.ArgumentNotNull(modelProvider, nameof(modelProvider));
            Assert.ArgumentNotNull(sampleRepository, nameof(sampleRepository));

            ModelProvider = modelProvider;
            SampleRepository = sampleRepository;
            VisitorContext = visitorContext;
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

        /// <summary>
        /// Gets or sets the visitor sitecoreContext.
        /// </summary>
        /// <value>
        /// The visitor sitecoreContext.
        /// </value>
        public IVisitorContext VisitorContext { get; protected set; }

        /// <summary>
        /// Gets the sample rendering model
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [StorefrontSessionState(SessionStateBehavior.ReadOnly)]
        public ActionResult Sample()
        {
            var model = SampleRepository.GetSampleRenderingModel(Rendering);

            return View(GetRenderingView("Sample"), model);
        }

        /// <summary>
        /// Get the sample model
        /// </summary>
        /// <returns></returns>
        [ValidateHttpPostHandler]
        [ValidateJsonAntiForgeryToken]
        [AllowAnonymous]
        [HttpPost]
        [OutputCache(NoStore = true, Location = OutputCacheLocation.None)]
        [StorefrontSessionState(SessionStateBehavior.ReadOnly)]
        public JsonResult GetSample()
        {
            var jsonData = SampleRepository.GetSample(VisitorContext);

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Get the sample models
        /// </summary>
        /// <returns></returns>
        [ValidateHttpPostHandler]
        [ValidateJsonAntiForgeryToken]
        [AllowAnonymous]
        [HttpPost]
        [OutputCache(NoStore = true, Location = OutputCacheLocation.None)]
        [StorefrontSessionState(SessionStateBehavior.ReadOnly)]
        public JsonResult GetSamples(GetSamplesInputModel inputModel)
        {
            var validationModel = new BaseJsonResult(SitecoreContext, StorefrontContext);
            ValidateModel(validationModel);
            if (validationModel.HasErrors)
            {
                return Json(validationModel);
            }

            var jsonData = SampleRepository.GetSamples(VisitorContext, inputModel);

            return Json(jsonData);
        }

    }
}