// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sample.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Foundation.Commerce.Connect.Entities
{
    using Sitecore.Commerce.Entities;
    using System;

    /// <summary>
    /// Represents a sample mapped entity.
    /// </summary>
    [Serializable]
    public class Sample : MappedEntity
    {
        /// <summary>
        /// Gets or sets the date created.
        /// </summary>
        /// <value>
        /// The date created.
        /// </value>
        public DateTimeOffset? DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the date updated.
        /// </summary>
        /// <value>
        /// The date updated.
        /// </value>
        public DateTimeOffset? DateUpdated { get; set; }
    }
}
