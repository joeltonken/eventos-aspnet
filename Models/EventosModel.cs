namespace EventoApplication.Models
{
    public class EventosModel
    {
        public int Id { get; set; }
        public string Contratante { get; set; }
        public string Empresa { get; set; }
        public string Evento { get; set; }
        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now;

    }
}
