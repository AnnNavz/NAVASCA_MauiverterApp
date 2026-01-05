using Microsoft.VisualBasic;
using NAVASCA_MauiverterApp.Pages;

namespace NAVASCA_MauiverterApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

		private async void information_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConVERT());
		}

		private async void volume_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConVERT());
		}

		private async void length_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConVERT());
		}

		private async void mass_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConVERT());
		}

		private async void temperature_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConVERT());
		}

		private async void energy_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConVERT());
		}

		private async void area_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConVERT());
		}

		private async void speed_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConVERT());
		}

		private async void duration_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConVERT());
		}
    }
}
