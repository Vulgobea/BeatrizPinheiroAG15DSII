namespace BeatrizPinheiroAG15DSII.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        public int DuracaoEvento => (DataCheckOut - DataCheckIn).Days;
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }

}
