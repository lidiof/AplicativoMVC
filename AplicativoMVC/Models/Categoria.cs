using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplicativoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Esse campo e obrigatorio!")]
        public string Descricao { get; set; }
        [Range(1,20,ErrorMessage = "Valor invalido!")]
        [Required(ErrorMessage = "Esse campo e obrigatorio!")]
        public int Valor { get; set; }
        //public List<Produto> Produtos { get; set; }
    }
}
