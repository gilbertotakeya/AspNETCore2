using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class ProdutoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome", Description = "Nome")]
        [Required(ErrorMessage ="Preencha o campo Nome")]
        [StringLength(30, MinimumLength = 3)]
        public string Nome { get; set; }

        [Display(Name = "Descrição", Description = "Descrição")]
        [Required(ErrorMessage = "Descrição do produto")]
        [StringLength(256, MinimumLength = 10, ErrorMessage ="O campo descrição é obrigatório")]
        public string Descricao { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode =true)]
        [Display(Name ="Data de validade", Description = "Data de validade")]
        [Required(ErrorMessage = "Data de validade")]
        public DateTime DataValidade { get; set; }

        [Required(ErrorMessage = "O campo valor é obrigatório")]
        [Display(Name = "Valor de venda", Description = "Valor de venda")]
        public double ValorVenda { get; set; }

        public int Estoque { get; set; }
    }
}