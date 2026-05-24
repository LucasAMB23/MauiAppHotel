namespace MauiAppHotel.Views;

public partial class PedidoHospedagem : ContentPage
{
    App PropriedadesApp;
	public PedidoHospedagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        picker_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dt_checkin.MinimumDate = DateTime.Now;
        dt_checkin.MaximumDate = new DateTime(DateTime.Today.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		 Navigation.PushAsync(new Views.Sobre());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

        Navigation.PushAsync(new HospedagemContratada());
    }
}