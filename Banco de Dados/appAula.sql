create database psdAula;
use psdAula;

Create table Processos(
id_pro int auto_increment primary key,
numero_pro varchar (200) not null, 
interresado_pro varchar (200),
assunto_pro varchar (300) not null,
descricao_pro text not null, 
sintuacao_pro varchar (50) not null default "aberto"
);

Insert Into Processos (numero_pro, interresado_pro, assunto_pro, descricao_pro, sintuacao_pro) 
values ('2026/0001', 'João da Silva', 'Solicitação de documento', 'Solicitação de emissão de documento administrativo.', 'aberto');

Insert Into Processos (numero_pro, interresado_pro, assunto_pro, descricao_pro, sintuacao_pro) 
values ('2026/0002', 'Maria Oliveira', 'Pedido de revisão', 'Pedido de revisão de processo administrativo.', 'aberto');

Insert Into Processos (numero_pro, interresado_pro, assunto_pro, descricao_pro, sintuacao_pro) 
values ('2026/0003', 'Carlos Santos', 'Reclamação de serviço', 'Reclamação referente à prestação de serviço público.', 'em análise');

Insert Into Processos (numero_pro, interresado_pro, assunto_pro, descricao_pro, sintuacao_pro) 
values ('2026/0004', 'Ana Souza', 'Solicitação de informação', 'Solicitação de informações sobre um procedimento administrativo.', 'aberto');

Insert Into Processos (numero_pro, interresado_pro, assunto_pro, descricao_pro, sintuacao_pro) 
values ('2026/0005', 'Pedro Almeida', 'Recurso administrativo', 'Apresentação de recurso contra decisão administrativa.', 'em análise');

Insert Into Processos (numero_pro, interresado_pro, assunto_pro, descricao_pro, sintuacao_pro) 
values ('2026/0006', 'Juliana Costa', 'Atualização cadastral', 'Solicitação de atualização de dados cadastrais.', 'concluído');

Insert Into Processos (numero_pro, interresado_pro, assunto_pro, descricao_pro, sintuacao_pro) 
values ('2026/0007', 'Rafael Pereira', 'Pedido de atendimento', 'Solicitação de atendimento junto ao setor responsável.', 'aberto');

Insert Into Processos (numero_pro, interresado_pro, assunto_pro, descricao_pro, sintuacao_pro) 
values ('2026/0008', 'Fernanda Lima', 'Solicitação de benefício', 'Pedido de análise para concessão de benefício.', 'em análise');

Insert Into Processos (numero_pro, interresado_pro, assunto_pro, descricao_pro, sintuacao_pro) 
values ('2026/0009', 'Lucas Martins', 'Regularização de cadastro', 'Solicitação de regularização de cadastro administrativo.', 'aberto');

Insert Into Processos (numero_pro, interresado_pro, assunto_pro, descricao_pro, sintuacao_pro) 
values ('2026/0010', 'Beatriz Ferreira', 'Encerramento de processo', 'Solicitação de encerramento de processo após conclusão das atividades.', 'concluído');

