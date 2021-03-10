using EntrevistaTesteSegundaFase.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrevistaTesteSegundaFase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Durante a realização dos Exercicios fique a vontate para criar pastas e classes
            //Parte 1 - Crie um menu para que o usuario possa escolher apertando botões 1, 2 e 3
            // 1 para sair do programa, 2 para o exercicio parte 2 e 3 para o exercicio parte 3


            ExercicioParte2();

            ExercicioParte3();
        }

        private static void ExercicioParte2()
        {
            //1 - ordene os numeros de maneira decrescente e mostre no console o resultado.
            var numeros = new int[] { 18, 92, 43, 11, 90, 56, 87, 78, 11, 18, 56};

            //2 - Com o vetor ordenado remova os números repetidos e mostre no console o resultado.

        }

        private static void ExercicioParte3()
        {
            //1 - Extraia o texto do arquivo 'Texto Ipsum.txt' e atribua-o a variável texto
            //DICA: Coloque o caminho do arquivo Texto Ipsum na variavel caminhoArquivoIpsum
            //DICA 2: Use a classe File para extrair o texto
            string caminhoArquivoIpsum = @"";
            string texto = default;

            //2 - Mostre o texto do arquivo no console

            //3 - No meio do texto tem o valor {Referencia: 958220}.
            //    Extraia o valor 958220 direto do texto e atribua-o a variavel referencia.
            string referencia = default;


            //Salve o texto da variável relatório em um novo arquivo de texto na pasta documentos do windows
            // O nome do arquivo de texto será: relatorio_referencia_958220.txt
            //Dica: use a variavel caminhoPastaDocumento, nela está o caminho para a pasta documentos do windows
            var relatorioService = new RelatorioService();
            var relatorio = relatorioService.GetTexto(referencia);
            var caminhoPastaDocumento = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
