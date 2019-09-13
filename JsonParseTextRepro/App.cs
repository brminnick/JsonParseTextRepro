using Xamarin.Forms;

namespace JsonParseTextRepro
{
    public class App : Application
    {
        public App() => MainPage = new DemoPage();

        class DemoPage : ContentPage
        {
            readonly Label _statusLabel = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            public DemoPage() => Content = _statusLabel;

            protected override async void OnAppearing()
            {
                base.OnAppearing();

                _statusLabel.Text = "Accessing API";

                try
                {
                    var response = await ApiService.GetPun();

                    _statusLabel.Text = "Success";
                }
                catch (System.Exception e)
                {
                    _statusLabel.Text = $"Exception: {e}";
                }
            }
        }
    }
}
