using System;
using System.ComponentModel.DataAnnotations;

namespace DesafioBootcamp2.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Nome do Curso é obrigatório")]
        public string Nome { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFinal { get; set; }
        public string status { get; set; }

    }
}
