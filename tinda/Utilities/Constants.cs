﻿using System;
using Xamarin.Forms;

namespace tinda.Utilities
{
    public class Constants
    {
        public static Color THEME_COLOR = Color.FromHex("#34495E");
        public static Color THEME_COLOR_DARK = Color.FromHex("#2C3E50");

		public static double DEFAULT_TEMPLATE_HEIGHT = Device.RuntimePlatform == Device.Android ? 50 : 60;
    }
}
