// -----------------------------------------------------------------------
// <copyright file="ImageProperties.cs" company="Pixsys">
// Copyright (c) Pixsys. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using SixLabors.ImageSharp;
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
        /// Gets or sets the location.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        public required ImageLocation Location { get; set; }

        /// <summary>
        /// Gets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public required int Height { init; get; }

        /// <summary>
        /// Gets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public required int Width { init; get; }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public required Size Size { init; get; }

        /// <summary>
        /// Gets or sets the list of thumbnails linked to this image.
        /// </summary>
        public List<ImageProperties>? Thumbnails { get; set; }
    }
}