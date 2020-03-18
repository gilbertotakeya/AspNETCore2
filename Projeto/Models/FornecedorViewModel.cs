using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class FornecedorViewModel
    {
        [Key]
        public int Id { get; set; }

        private const string NomeFantasiaLabel = "Nome Fantasia";
        [Required(ErrorMessage = NomeFantasiaLabel)]
        [Display(Description = NomeFantasiaLabel, Name = NomeFantasiaLabel)]
        [MaxLength(256, ErrorMessage = "Campo Nome Fantasia do Fornecedor tem o limite máximo de 256 caracteres!")]
        public string NomeFantasia { get; set; }

        private const string RazaoSocialLabel = "Razão Social";
        [Required(ErrorMessage = RazaoSocialLabel)]
        [Display(Description = RazaoSocialLabel, Name = RazaoSocialLabel)]
        [MaxLength(256, ErrorMessage = "Campo Razão Social do Fornecedor tem o limite máximo de 256 caracteres!")]
        public string RazaoSocial { get; set; }

        private const string CNPJCPFLabel = "CNPJ/CPF";
        [Required(ErrorMessage = CNPJCPFLabel)]
        [Display(Description = CNPJCPFLabel, Name = CNPJCPFLabel)]
        public int CNPJCPF { get; set; }

        private const string TelefoneLabel = "Telefone";
        [Required(ErrorMessage = TelefoneLabel)]
        [Display(Description = TelefoneLabel, Name = TelefoneLabel)]
        public string Telefone { get; set; }

        private const string NomeContatoLabel = "Nome do Contato";
        [Required(ErrorMessage = NomeContatoLabel)]
        [Display(Description = NomeContatoLabel, Name = NomeContatoLabel)]
        public string NomeContato { get; set; }

        private const string CEPLabel = "CEP";
        [Required(ErrorMessage = CEPLabel)]
        [Display(Description = CEPLabel, Name = CEPLabel)]
        public string CEP { get; set; }

        private const string EnderecoLabel = "Endereço";
        [Required(ErrorMessage = EnderecoLabel)]
        [Display(Description = EnderecoLabel, Name = EnderecoLabel)]
        public string Endereco { get; set; }

        private const string BairroLabel = "Bairro";
        [Required(ErrorMessage = BairroLabel)]
        [Display(Description = BairroLabel, Name = BairroLabel)]
        public string Bairro { get; set; }

        private const string CidadeLabel = "Cidade";
        [Required(ErrorMessage = CidadeLabel)]
        [Display(Description = CidadeLabel, Name = CidadeLabel)]
        public string Cidade { get; set; }
    }
}