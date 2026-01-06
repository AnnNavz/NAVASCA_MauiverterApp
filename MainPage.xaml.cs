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

		

        private void information_Clicked(object sender, EventArgs e)
        {
            var button = (ImageButton)sender;

            string option = char.ToUpper(button.StyleId[0]) + button.StyleId.Substring(1);


            var converterView = new ConVERT
            {
                BindingContext = new ConverterViewModel(option)
            };

            Navigation.PushAsync(converterView);
        }

    }
}
