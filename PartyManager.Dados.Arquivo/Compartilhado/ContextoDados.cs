using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;
using PartyManager.Dominio.ModuloTema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PartyManager.Dados.Arquivo.Compartilhado
{
    public class ContextoDados
    {
        private const string CAMINHO_ARQUIVO = "Compartilhado\\PartyManager.json";

        public List<Cliente> clientes;
        public List<Tema> temas;
        public List<Festa> festas;

        public ContextoDados()
        {
            clientes = new List<Cliente>();
            temas = new List<Tema>();
            festas = new List<Festa>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarArquivoJson();
        }

        public void GravarArquivoJson()
        {
            JsonSerializerOptions configuracoes = ConfigurarSerializadorJson();

            string registrosJson = JsonSerializer.Serialize(this, configuracoes);

            File.WriteAllText(CAMINHO_ARQUIVO, registrosJson);
        }

        private void CarregarArquivoJson()
        {
            JsonSerializerOptions configuracoes = ConfigurarSerializadorJson();

            if (File.Exists(CAMINHO_ARQUIVO))
            {
                string registrosJson = File.ReadAllText(CAMINHO_ARQUIVO);

                if (registrosJson.Length > 0)
                {
                    ContextoDados dadosJson = JsonSerializer.Deserialize<ContextoDados>(registrosJson, configuracoes);

                    clientes = dadosJson.clientes;
                    temas = dadosJson.temas;
                    festas = dadosJson.festas;
                }
            }
        }

        private static JsonSerializerOptions ConfigurarSerializadorJson()
        {
            JsonSerializerOptions configuracoes = new JsonSerializerOptions();
            configuracoes.IncludeFields = true;
            configuracoes.WriteIndented = true;
            configuracoes.ReferenceHandler = ReferenceHandler.Preserve;

            return configuracoes;
        }
    }
}
