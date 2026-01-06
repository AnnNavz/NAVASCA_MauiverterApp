using NAVASCA_MauiverterApp.ViewModel;

namespace NAVASCA_MauiverterApp.Pages;

public partial class ConVERT : ContentPage
{
	public ConVERT()
	{
		InitializeComponent();
	}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
	{
		var viewModel = (ConverterViewModel)BindingContext;
		viewModel.Convert();
	}
}