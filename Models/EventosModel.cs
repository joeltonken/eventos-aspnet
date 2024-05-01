using System.ComponentModel.DataAnnotations;

namespace EventoApplication.Models
{
    public class EventosModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do Contratante!")]
        public string Contratante { get; set; }

        [Required(ErrorMessage = "Digite o nome da Empresa!")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "Digite o nome do Evento!")]
        public string Evento { get; set; }

        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now;

    }
}
