using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório Informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o placa!")]
        public string Placa { get; set; }
    }
}
