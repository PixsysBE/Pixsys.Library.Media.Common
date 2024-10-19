// -----------------------------------------------------------------------
// <copyright file="ImageLocation.cs" company="Pixsys">
// Copyright (c) Pixsys. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

namespace Pixsys.Library.Media.Common.Models
{
    /// <summary>
    /// The image location.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1206:DeclarationKeywordsMustFollowOrder", Justification = "Reviewed.")]
    public class ImageLocation
    {
        /// <summary>
        /// Gets or sets the full path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        public required string FullPath { get; set; }

        /// <summary>
        /// Gets or sets the directory.
        /// </summary>
        /// <value>
        /// The directory.
        /// </value>
        public required DirectoryInfo Directory { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public required string Name { get; set; }
    }
}