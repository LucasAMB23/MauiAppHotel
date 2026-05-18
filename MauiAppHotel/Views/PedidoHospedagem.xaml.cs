namespace MauiAppHotel.Views;

public partial class PedidoHospedagem : ContentPage
{
	public PedidoHospedagem()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Views.Sobre());
    }
}