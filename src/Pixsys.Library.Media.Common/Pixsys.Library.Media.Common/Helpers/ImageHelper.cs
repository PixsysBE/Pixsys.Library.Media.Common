// -----------------------------------------------------------------------
// <copyright file="ImageHelper.cs" company="Pixsys">
// Copyright (c) Pixsys. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using Pixsys.Library.Media.Common.Enums;
using Pixsys.Library.Media.Common.Extensions;
using Pixsys.Library.Media.Common.Models;

namespace Pixsys.Library.Media.Common.Helpers
{
    /// <summary>
    /// An helper for processing images.
    /// </summary>
    public static class ImageHelper
    {
        /// <summary>
        /// Gets the <see cref="ImageProperties"/> based on parameters.
        /// </summary>
        /// <param name="destinationFolder">The destination folder.</param>
        /// <param name="destinationFileName">Name of the destination file.</param>
        /// <param name="imageSuffix">The image suffix.</param>
        /// <param name="format">The format.</param>
        /// <returns>The image output properties.</returns>
        public static async Task<ImageLocation> GetImageLocation(DirectoryInfo destinationFolder, string destinationFileName, string imageSuffix, ImageFormat format)
        {
            return await Task.Run(() =>
            {
                string fileName = string.Concat(Path.GetFileNameWithoutExtension(destinationFileName), imageSuffix, format.GetExtension());
                return new ImageLocation
                {
                    FullPath = Path.Combine(destinationFolder.FullName, fileName),
                    Directory = destinationFolder,
                    Name = fileName,
                };
            });
        }
    }
}