// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommerceRequest.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Foundation.Commerce.Connect.Services.Samples
{
    using Sitecore.Commerce.Services;
    using Sitecore.Diagnostics;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the SampleRequest class.
    /// </summary>
    public class CommerceRequest : ServiceProviderRequest
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CommerceRequest"/>
        /// </summary>
        public CommerceRequest()
        {
            UserId = string.Empty;
            CustomerId = string.Empty;
        }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        /// <value>The user ID</value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the customer ID.
        /// </summary>
        /// <value>The customer ID</value>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>The language</value>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the policy keys.
        /// </summary>
        /// <value>The policy keys</value>
        public string PolicyKeys { get; set; }
    }
}
