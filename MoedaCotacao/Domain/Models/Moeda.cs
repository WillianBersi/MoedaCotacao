using System.ComponentModel.DataAnnotations;

namespace MoedaCotacao.Domain.Models
{
    public class Moeda
    {
        [Key]
        public int Id { get; set; }
        public int Grupo { get; set; }
        public string moeda { get; set; }
        public string Data_inicio { get; set; }
        public string Data_fim { get; set; }
    }
}
