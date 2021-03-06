﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SampleServiceProvider.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Foundation.Commerce.Connect.Services.Samples
{
    using Sitecore.Commerce.Services;

    /// <summary>
    /// Defines the sample service provider
    /// </summary>
    public class SampleServiceProvider : ServiceProvider
    {
        /// <summary>
        /// Get Sample
        /// </summary>
        /// <param name="request">The request</param>
        /// <returns>A <see cref="SampleResult"/></returns>
        public virtual SampleResult GetSample(SampleRequest request)
        {
            return this.RunPipeline<SampleRequest, SampleResult>(ConnectConstants.Pipelines.Sample, request);
        }

        /// <summary>
        /// Get Samples 
        /// </summary>
        /// <param name="request">The request</param>
        /// <returns>A <see cref="GetSamplesResult"/></returns>
        public virtual GetSamplesResult GetSamples(GetSamplesRequest request)
        {
            return this.RunPipeline<GetSamplesRequest, GetSamplesResult>(ConnectConstants.Pipelines.GetSamples, request);
        }
    }
}