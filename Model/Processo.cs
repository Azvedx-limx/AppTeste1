using Microsoft.AspNetCore.Http.HttpResults;

namespace appTeste.Model
{
    public class Processo
    {
        public int Id { get; set; }
        public string Numero { get; set; } = string.Empty;
        public DateOnly Data { get; set; }

        public string Interresado { get; set; } = string.Empty;

        public string Assunto { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        public string Situacao { get; set; } = "aberto";
    }
}

/* Create table Processos(
id_pro int auto_increment primary key,
numero_pro varchar (200) not null,
interresado_pro varchar (200),
assunto_pro varchar (300) not null,
descricao_pro text not null,
sintuacao_pro varchar (50) not null default "aberto"
);*/