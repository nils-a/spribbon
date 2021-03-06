﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentRibbon.Definitions;

namespace FluentRibbon.Libraries
{
    /// <summary>
    /// Library with image definitions (contains predefined <see cref="ImageDefinition"/> instances)
    /// </summary>
    public class ImageLibrary
    {
        /// <summary>
        /// <para>Returns ImageDefinition for standard image formatmap32x32.png &amp; formatmap16x16.png.</para>
        /// <para>Caution: if you have non-english SharePoint installation, and don't have English language pack,
        /// this will not work. Use overload with 3 parameters.</para>
        /// </summary>
        /// <param name="x">X-coordinate of image thumbnail on composite image</param>
        /// <param name="y">Y-coordinate of image thumbnail on composite image</param>
        /// <returns>ImageDefinition instanse for standard image with specified coordinates</returns>
        public static ImageDefinition GetStandardImage(int x, int y)
        {
            return new ImageDefinition()
                {
                    Url16 = "/_LAYOUTS/15/1033/images/formatmap16x16.png",
                    Url32 = "/_LAYOUTS/15/1033/images/formatmap32x32.png",
                    X = x,
                    Y = y
                };
        }

        /// <summary>
        /// <para>Returns ImageDefinition for standard image formatmap32x32.png &amp; formatmap16x16.png.</para>
        /// </summary>
        /// <param name="x">X-coordinate of image thumbnail on composite image</param>
        /// <param name="y">Y-coordinate of image thumbnail on composite image</param>
        /// <param name="lcid">Locale ID of current web</param>
        /// <returns>ImageDefinition instanse for standard image with specified coordinates</returns>
        public static ImageDefinition GetStandardImage(int x, int y, int lcid)
        {
            return new ImageDefinition()
            {
                Url16 = "/_LAYOUTS/15/" + lcid.ToString() + "/images/formatmap16x16.png",
                Url32 = "/_LAYOUTS/15/" + lcid.ToString() + "/images/formatmap32x32.png",
                X = x,
                Y = y
            };
        }

    }
}
