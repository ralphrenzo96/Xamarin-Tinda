using System;
using Xamarin.Forms;

namespace tinda.Utilities
{
    public class Constants
    {
        public static Color THEME_COLOR = Color.FromHex("00CECC");

        public static double DEFAULT_TEMPLATE_HEIGHT = Device.RuntimePlatform == Device.Android ? 46 : 64;
    }
}
