// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetSamplesInputModel.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Feature.Samples.Website.Models.InputModels
{
    using Sitecore.Commerce.XA.Foundation.Common.Models.InputModels;
    using System.ComponentModel.DataAnnotations;

    public class GetSamplesInputModel : BaseInputModel
    {
        /// <summary>
        /// Gets or sets the type of sample.
        /// </summary>
        /// <value>
        /// The type of the sample.
        /// </value>
        [Required]
        public string SampleType { get; set; }
    }
}