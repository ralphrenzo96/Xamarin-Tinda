using System;
using Xamarin.Forms;

namespace tinda.Controls.Images
{
    public class LeftNavImage : Image
    {
        public LeftNavImage()
        {
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.NumberOfTapsRequired = 1;
            tapGestureRecognizer.Tapped += OnClicked;

            this.GestureRecognizers.Add(tapGestureRecognizer);
        }

		public async void OnClicked(Object sender, EventArgs e)
		{
            Image button = (Image)sender;

			await button.RotateTo(360, 1000);
			button.Rotation = 0;
		}
    }
}
