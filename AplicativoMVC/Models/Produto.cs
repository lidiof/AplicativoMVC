using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplicativoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name ="Descrição")]
        [Required(ErrorMessage = "Esse campo e obrigatorio!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Esse campo e obrigatorio!")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}
