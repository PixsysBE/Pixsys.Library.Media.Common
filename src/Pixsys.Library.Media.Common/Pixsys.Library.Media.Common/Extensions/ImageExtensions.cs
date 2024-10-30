// -----------------------------------------------------------------------
// <copyright file="ImageExtensions.cs" company="Pixsys">
// Copyright (c) Pixsys. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using Pixsys.Library.Media.Common.Enums;
using Pixsys.Library.Media.Common.Helpers;
using Pixsys.Library.Media.Common.Models;
using SixLabors.ImageSharp;

namespace Pixsys.Library.Media.Common.Extensions
{
    /// <summary>
    /// The image extensions.
    /// </summary>
    public static class ImageExtensions
    {
        /// <summary>
        /// Gets the extension.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The extension.</returns>
        public static string GetExtension(this ImageFormat format, System.Globalization.CultureInfo? culture = null)
        {
            return "." + format.ToString().ToLower(culture ?? System.Globalization.CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Saves the image asynchronously.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="destinationFolder">The destination folder.</param>
        /// <param name="destinationFileName">Name of the destination file.</param>
        /// <param name="imageSuffix">The image suffix.</param>
        /// <param name="format">The format.</param>
        /// <returns>The new <see cref="ImageProperties"/>.</returns>
        /// <exception cref="NotSupportedException">Image Format not supported.</exception>
        /// <exception cref="InvalidOperationException">Error while getting image properties.</exception>
        public static async Task<ImageProperties> SaveImageAsync(this Image image, DirectoryInfo destinationFolder, string destinationFileName, string imageSuffix, ImageFormat format)
        {
            try
            {
                ImageLocation location = await ImageHelper.GetImageLocation(destinationFolder, destinationFileName, imageSuffix, format);
                switch (format)
                {
                    case ImageFormat.Bmp: await image.SaveAsBmpAsync(location.FullPath); break;
                    case ImageFormat.Gif: await image.SaveAsGifAsync(location.FullPath); break;
                    case ImageFormat.Jpg:
                    case ImageFormat.Jpeg: await image.SaveAsJpegAsync(location.FullPath); break;
                    case ImageFormat.Pbm: await image.SaveAsPbmAsync(location.FullPath); break;
                    case ImageFormat.Png: await image.SaveAsPngAsync(location.FullPath); break;
                    case ImageFormat.Tga: await image.SaveAsTgaAsync(location.FullPath); break;
                    case ImageFormat.Tiff: await image.SaveAsTiffAsync(location.FullPath); break;
                    case ImageFormat.Webp: await image.SaveAsWebpAsync(location.FullPath); break;
                    default: throw new NotSupportedException("Image Format not supported");
                }

                return new ImageProperties { Location = location, Width = image.Width, Height = image.Height, Size = image.Size };
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error while getting image properties.", ex);
            }
        }
    }
}