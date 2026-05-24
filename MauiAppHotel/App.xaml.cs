using MauiAppHotel.Models;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>()
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 120.0,
                ValorDiariaCrianca = 60.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 100.0,
                ValorDiariaCrianca = 50.0
            },
            new Quarto()
            {
                Descricao = "Suíte Econômica",
                ValorDiariaAdulto = 70.0,
                ValorDiariaCrianca = 35.0
            }



        };

        public App()
        {
             InitializeComponent();

            
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new Views.PedidoHospedagem()));
        }
    }
}