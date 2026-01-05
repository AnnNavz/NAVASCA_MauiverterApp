using Microsoft.VisualBasic;
using NAVASCA_MauiverterApp.Pages;
using NAVASCA_MauiverterApp.ViewModel;

namespace NAVASCA_MauiverterApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

		

		private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
		{
			var element = (Grid)sender;
			var option = ((Label)element.Children.LastOrDefault()).Text;

			var converterView = new ConVERT
			{
				BindingContext = new ConverterViewModel(option)
			};

			Navigation.PushAsync(converterView);
		}
    }
}
