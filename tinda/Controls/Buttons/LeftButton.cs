using System;
using Xamarin.Forms;

namespace tinda.Controls.Buttons
{
    public class LeftButton : Button
    {
        LeftButton()
        {
            Clicked += OnClicked;
        }

        public async void OnClicked(Object sender, EventArgs e)
        {
            Button button = (Button)sender;

            await button.RotateTo(360, 500);
            button.Rotation = 0;
        }
    }
}
