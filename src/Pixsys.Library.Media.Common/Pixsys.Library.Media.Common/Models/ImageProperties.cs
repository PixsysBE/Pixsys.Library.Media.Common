// -----------------------------------------------------------------------
// <copyright file="ImageProperties.cs" company="Pixsys">
// Copyright (c) Pixsys. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Pixsys.Library.Media.Common.Models
{
    /// <summary>
    /// The image properties.
    /// </summary>
    public class ImageProperties
    {
        /// <summary>
        /// Gets or sets the folder.
        /// </summary>
        /// <value>
        /// The folder.
        /// </value>
        public DirectoryInfo? Folder { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string? FileName { get; set; }
    }
}