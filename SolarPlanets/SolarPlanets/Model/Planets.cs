﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Planets
    {
        public string Name { get; set; }
        public string Subtitle { get; set; }

        public string HeroImage { get; set; }
        public string Description { get; set; }
        public Color AccentColorStart { get; set; }
        public Microsoft.Maui.Graphics.Color AccentColorEnd { get; set; }
        public List<string> Images { get; set; }

    }
}
