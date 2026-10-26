namespace appTeste.DAO;
using appTeste.Configs;
using appTeste.Model;

public class ProcessoDAO
{
    private readonly Conexao _conexao;
    public ProcessoDAO(Conexao conexao)
    {
        _conexao = conexao;
    }

    public void Inserir(Processo processo)
    {
        using var con = _conexao.GetConnection();

        // Garante que a conexão seja aberta antes da execução
        if (con.State != System.Data.ConnectionState.Open)
        {
            con.Open();
        }

        string sql = @"INSERT INTO processos
    (numero_pro, data_pro, interresado_pro, assunto_pro, descricao_pro, situacao_pro)
    VALUES
    (@numero, @data, @Interresado, @assunto, @descricao, @situacao)";

        using var comando = con.CreateCommand();
        comando.CommandText = sql;
        comando.Parameters.AddWithValue("@numero", processo.Numero);
        comando.Parameters.AddWithValue("@data", processo.Data!.Value.ToDateTime(TimeOnly.MinValue));
        comando.Parameters.AddWithValue("@interessado", processo.Interresado);
        comando.Parameters.AddWithValue("@assunto", processo.Assunto);
        comando.Parameters.AddWithValue("@descricao", processo.Descricao ?? "");
        comando.Parameters.AddWithValue("@situacao", processo.Situacao);

        comando.ExecuteNonQuery();
    }
    //Interresado
    public List<Processo> Listar()
    {
        try
        {
            var lista = new List<Processo>();

            // Buscando e abrindo a conexão com o banco de dados
            using var con = _conexao.GetConnection();

            string sql = "SELECT * FROM processos";
            using var comando = con.CreateCommand();
            comando.CommandText = sql;

            using var leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                var processo = new Processo();
                processo.Id = leitor.GetInt32("id_pro");
                processo.Numero = leitor.GetString("numero_pro");
                processo.Interresado = leitor.GetString("interresado_pro");
                processo.Assunto = leitor.GetString("assunto_pro");
                processo.Descricao = leitor.GetString("descricao_pro");
                processo.Situacao = leitor.GetString("sintuacao_pro");

                lista.Add(processo);
            }

            return lista;

        }

        catch
        {
            throw;
        }
    }

    public Processo? ObterPorId (int id)
    {
        using var con = _conexao.GetConnection();
        const string sql = @"SELECT id_pro, numero_pro, data_pro, interresado_pro, assunto_pro, descricao_pro, situacao_pro FROM processos WHERE id_pro = @id";

        using var comando = con.CreateCommand();
        comando.CommandText = sql;
        comando.Parameters.AddWithValue("@id", id);

        using var leitor = comando.ExecuteReader();
        if (!leitor.Read())
        {
            return null;
        }

        return new Processo
        {
            Id = leitor.GetInt32("id_pro"),
            Numero = leitor.GetString("numero_pro"),
            Data = DateOnly.FromDateTime(leitor.GetDateTime("data_pro")),
            Interresado = leitor.GetString("interresado_pro"),
            Assunto = leitor.GetString("assunto_pro"),
            Descricao = leitor.GetString("descricao_pro"),
            Situacao = leitor.GetString("situacao_pro")
        };
    }

    public void Atualizar (Processo processo)
    {
        using var con = _conexao.GetConnection();
        const string sql = @"UPDATE processos SET numero_pro = @numero, data_pro = @data, interresado_pro = @interresado, assunto_pro = @assunto, descricao_pro = @descricao, situacao_pro = @situacao WHERE id_pro = @id";

        using var comando = con.CreateCommand();
        comando.CommandText = sql;
        comando.Parameters.AddWithValue("@numero", processo.Numero);
        comando.Parameters.AddWithValue("@data", processo.Data!.Value.ToDateTime(TimeOnly.MinValue));
        comando.Parameters.AddWithValue("@interresado", processo.Interresado);
        comando.Parameters.AddWithValue("@assunto", processo.Assunto);
        comando.Parameters.AddWithValue("@descricao", processo.Descricao ?? "");
        comando.Parameters.AddWithValue("@situacao", processo.Situacao);
        comando.Parameters.AddWithValue("@id", processo.Id);

        comando.ExecuteNonQuery();
    }
}
