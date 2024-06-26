using PAMII_FlipCoin.ViewModels;

namespace PAMII_FlipCoin.Views;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
		CoinFacePicker.SelectedIndex = 1;
		BindingContext = new CoinViewModel();
	}
}