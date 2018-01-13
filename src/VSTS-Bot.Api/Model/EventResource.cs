﻿// ———————————————————————————————
// <copyright file="EventResource.cs">
// Licensed under the MIT License. See License.txt in the project root for license information.
// </copyright>
// <summary>
// Represents the resource of an event.
// </summary>
// ———————————————————————————————
namespace Vsar.TSBot
{
    using Microsoft.VisualStudio.Services.ReleaseManagement.WebApi;

    /// <summary>
    /// Represents the resource of an event.
    /// </summary>
    public class EventResource
    {
        /// <summary>
        /// Gets or sets the approval.
        /// </summary>
        public ReleaseApproval Approval { get; set; }
    }
}