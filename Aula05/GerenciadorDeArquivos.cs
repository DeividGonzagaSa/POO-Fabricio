public class GerenciadorDeArquivos
{
    public string LerConteudo(string caminho)
    {
        StreamReader leitor = null;

        try
        {
            Console.WriteLine($"\nIniciando leitura do arquivo: {caminho}");
            
            // Pode gerar erro se o arquivo não existir ou estiver em uso
            leitor = new StreamReader(caminho);
            string conteudo = leitor.ReadToEnd();

            // Regra de negócio: Consideramos corrompido se estiver vazio
            if (string.IsNullOrWhiteSpace(conteudo))
            {
                throw new ArquivoCorrompidoException("O conteúdo do arquivo está vazio ou inválido.", caminho);
            }

            return conteudo;
        }
        catch (FileNotFoundException ex)
        {
            // Trata o erro específico de arquivo não encontrado
            LoggerSimulado.LogError("Arquivo não localizado no disco.", ex);
            throw; // Rethrow: repassa o erro para a camada superior sem perder o stack trace
        }
        catch (IOException ex)
        {
            // Trata erros gerais de I/O (ex: arquivo trancado por outro processo)
            LoggerSimulado.LogError("Falha de I/O ao tentar ler o arquivo.", ex);
            
            // Traduz o erro técnico para um erro de domínio de negócio
            throw new ArquivoCorrompidoException("Não foi possível ler o arquivo. Ele pode estar corrompido ou em uso.", caminho, ex);
        }
        finally
        {
            // O bloco finally SEMPRE executa, garantindo que o arquivo não fique "preso" na memória
            if (leitor != null)
            {
                leitor.Close();
                Console.WriteLine("-> [FINALLY] Recurso liberado: Conexão com o arquivo fechada.");
            }
        }
    }
}