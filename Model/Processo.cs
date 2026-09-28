using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;

namespace appTeste.Model
{
    public class Processo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O número do processo é obrigatorio.")]
        [StringLength(200, ErrorMessage = "O número deve ter no máximo 200 caracteres.")]

        public string Numero { get; set; } = string.Empty;
        [Required(ErrorMessage = "A data do processo é obrigatoria.")]

        public DateOnly Data { get; set; }
        [Required(ErrorMessage = "O interessado do processo é obrigatorio.")]

        public string Interresado { get; set; } = string.Empty;
        [Required(ErrorMessage = "O assunto do processo é obrigatorio.")]

        public string Assunto { get; set; } = string.Empty;
        [Required(ErrorMessage = "A descrição do processo é obrigatoria.")]

        public string Descricao { get; set; } = string.Empty;
        [Required(ErrorMessage = "A situação do processo é obrigatoria.")]

        public string Situacao { get; set; } = "aberto";
    }
}