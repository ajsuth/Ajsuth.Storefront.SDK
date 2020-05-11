// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetSamples.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Foundation.Commerce.Connect.Pipelines.Samples
{
    using Foundation.Commerce.Connect.Entities;
    using Foundation.Commerce.Connect.Services.Samples;
    using Sitecore.Commerce.Engine.Connect.Pipelines;
    using Sitecore.Commerce.Pipelines;
    using Sitecore.Commerce.ServiceProxy;
    using Sitecore.Commerce.Services;
    using Sitecore.Diagnostics;
    using System;
    using System.Collections.Generic;
    using PipelineUtility = Foundation.Commerce.Connect.Pipelines.PipelineUtility;

    /// <summary>
    /// Defines the get carts pipeline processor.
    /// </summary>
    /// <seealso cref="Sitecore.Commerce.Engine.Connect.Pipelines.Carts.CartProcessor" />
#pragma warning disable CA1724
    public class GetSamples : PipelineProcessor
#pragma warning restore CA1724
    {
        /// <summary>
        /// Process the Pipeline event
        /// </summary>
        /// <param name="args">The arguments.</param>
        public override void Process(ServicePipelineArgs args)
        {
            GetSamplesRequest request;
            GetSamplesResult result;
            PipelineUtility.ValidateArguments(args, out request, out result);

            try
            {
                //Assert.IsNotNull(request.Sample, "request.Sample");

                var container = GetContainer(request.GetShopName(), request.UserId, request.CustomerId, request.Language, request.CurrencyCode, DateTime.Now, request.PolicyKeys);
                SampleEntity sample = null;
                //sample = Proxy.GetValue(container.Samples.ByKey(request.Sample));

                if (sample != null)
                {
                    result.Samples = new List<Sample> {
                        TranslateSampleToConnectEntity(sample)
                    };
                }
                else
                {
                    result.Success = false;
                }
            }
            catch (ArgumentException e)
            {
                result.Success = false;
                result.SystemMessages.Add(PipelineUtility.CreateSystemMessage(e));
            }
            catch (AggregateException e)
            {
                result.Success = false;
                result.SystemMessages.Add(PipelineUtility.CreateSystemMessage(e));
            }

            base.Process(args);
        }

        /// <summary>
        /// Translates a <see cref="SampleEntity"/> to a <see cref="Sample" /> connect entity.
        /// </summary>
        /// <param name="cart">The sample object to translate.</param>
        /// <returns>
        /// The translated <see cref="Sample" /> entity.
        /// </returns>
        protected virtual Sample TranslateSampleToConnectEntity(SampleEntity sampleEntity)
        {
            var connectEntity = new Sample
            {
                ExternalId = sampleEntity.Id,
                DateCreated = sampleEntity.DateCreated,
                DateUpdated = sampleEntity.DateUpdated
            };
            
            return connectEntity;
        }
    }
}
