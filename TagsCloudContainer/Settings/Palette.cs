﻿using System.Drawing;

namespace TagsCloudContainer.Settings
{
    public class Palette : IPalette
    {
        public Color FontColor { get; set; }
        public Color BackGroundColor { get; set; }

        public Palette()
        {
            FontColor = Color.Aqua;
            BackGroundColor = Color.Black;
        }
    }
}