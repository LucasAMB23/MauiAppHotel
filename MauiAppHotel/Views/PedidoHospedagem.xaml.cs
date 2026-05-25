namespace MauiAppHotel.Views;

using MauiAppHotel.Models;
using System;

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

        dt_checkout.MinimumDate = dt_checkin.Date.Value.AddDays(1);
        dt_checkout.MaximumDate = dt_checkin.Date.Value.AddMonths(6);
	}

    private void Button_Clicked(object sender, EventArgs e) // navegação página Sobre
    {
		 Navigation.PushAsync(new Views.Sobre());
    }

    private async void Button_Clicked_1(object sender, EventArgs e) // armazena contexto hospedagem e navega p/ page HospedagemContratada
    {

        try
        {
            Hospedagem h = new Hospedagem
            {
                QuartoSelecionado = (Quarto)picker_quarto.SelectedItem,
                QntdAdultos = Convert.ToInt32(stp_adultos.Value),
                QntCriancas = Convert.ToInt32(stp_criancas.Value),
                DataCheckIn = dt_checkin.Date,
                DataCheckOut = dt_checkout.Date
            };

            await Navigation.PushAsync(new HospedagemContratada()
            {
                BindingContext = h
            });

        } catch (Exception ex)
        {

           await DisplayAlertAsync("Ops", ex.Message, "OK");
        }



        
    }

    private void dt_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime? checkin_dataselecionada = elemento.Date;

        dt_checkout.MinimumDate = checkin_dataselecionada.Value.AddDays(1);
        dt_checkout.MaximumDate = checkin_dataselecionada.Value.AddMonths(6);
    }

}