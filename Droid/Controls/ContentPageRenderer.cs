using System;
using tinda.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ContentPage), typeof(ContentPageRenderer))]
namespace tinda.Droid.Controls
{
    public class ContentPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            ViewGroup.SetBackgroundColor(Color.White.ToAndroid());
        }
    }
}
