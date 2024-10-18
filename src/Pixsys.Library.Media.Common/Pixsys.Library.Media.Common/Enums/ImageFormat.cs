// -----------------------------------------------------------------------
// <copyright file="ImageFormat.cs" company="Pixsys">
// Copyright (c) Pixsys. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Pixsys.Library.Media.Common.Enums
{
    /// <summary>
    /// The image format.
    /// </summary>
    public enum ImageFormat
    {
        /// <summary>
        /// The bitmap format is based on image points (pixels) and has a relatively simple structure.
        /// </summary>
        Bmp = 0,

        /// <summary>
        /// The GIF format is used for simple web graphics with limited color choices.
        /// </summary>
        Gif = 1,

        /// <summary>
        /// The digital image format supports the full color spectrum. It is the most compatible and universally usable image format.
        /// </summary>
        Jpg = 2,

        /// <summary>
        /// The digital image format supports the full color spectrum. It is the most compatible and universally usable image format.
        /// </summary>
        Jpeg = 3,

        /// <summary>
        /// The PBM format.
        /// </summary>
        Pbm = 4,

        /// <summary>
        /// This format is not compatible with all applications. However, it offers the possibility of using small files with consistently high quality.
        /// </summary>
        Png = 5,

        /// <summary>
        /// The tga format.
        /// </summary>
        Tga = 6,

        /// <summary>
        /// Unlike JPEG, this format does not lose any Info through compression. It is intended to maintain quality. TIFF files usually require a lot of storage space.
        /// </summary>
        Tiff = 7,

        /// <summary>
        /// The webp format.
        /// </summary>
        Webp = 8,
    }
}