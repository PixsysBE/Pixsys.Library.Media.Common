// -----------------------------------------------------------------------
// <copyright file="ImageProperties.cs" company="Pixsys">
// Copyright (c) Pixsys. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

namespace Pixsys.Library.Media.Common.Models
{
    /// <summary>
    /// The image properties.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1206:DeclarationKeywordsMustFollowOrder", Justification = "Reviewed.")]
    public class ImageProperties
    {
        /// <summary>
        /// Gets or sets the folder.
        /// </summary>
        /// <value>
        /// The folder.
        /// </value>
        public required DirectoryInfo Folder { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public required string FileName { get; set; }
    }
}