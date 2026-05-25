namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public int QntdAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime? DataCheckIn { get; set; }
        public DateTime? DataCheckOut { get; set; }
        public int Estadia
        {
            get => DataCheckOut.Value.Subtract(DataCheckIn.Value).Days;
        }
        public double ValorTotal
        {
            get

            {
                double valor_adultos = QntdAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;
                double total = (valor_adultos + valor_criancas) * Estadia;
                return total;



            }
        }

    }
}
