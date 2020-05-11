// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommerceConnectServiceProvider.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2020
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Foundation.Commerce.Connect.Providers
{
    using Foundation.Commerce.Connect.Services.Samples;
    using Sitecore.Commerce.XA.Foundation.Connect.Providers;

    /// <summary>
    /// The commerce connect service provider implementation.
    /// </summary>
    /// <seealso cref="ICommerceConnectServiceProvider" />
    public class CommerceConnectServiceProvider : ConnectServiceProvider, ICommerceConnectServiceProvider
    {
        /// <summary>
        /// Gets the Connect sample service provider.
        /// </summary>
        /// <returns>
        /// The Connect sample service provider.
        /// </returns>
        public SampleServiceProvider GetSampleServiceProvider()
        {
            return this.GetConnectServiceProvider<SampleServiceProvider>(ConnectConstants.ServiceProviders.SampleServiceProvider);
        }
    }
}