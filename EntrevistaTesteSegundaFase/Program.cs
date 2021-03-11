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
            //Parte 1 - Crie um menu de console para que o usuario possa escolher apertando botões 1, 2 e 3
            // 1 para sair do programa, 2 para o exercicio parte 2, 3 para o exercicio parte 3 e 4 para o exericio parte 4
            // Dica use Console.WriteLine() e Console.ReadLine()

            ExercicioParte2();

            ExercicioParte3();

            ExercicioParte4();
        }

        private static void ExercicioParte2()
        {
            //1 - Altere o formato de data para o padrão brasileiro (dd/mm/aaaa)
            //2 - A data de amanhã está errada, faça com que a data de amanhã seja mostrada corretamente.
            var dataDeHoje = DateTime.Now;

            Console.WriteLine($"A data de hoje é: {dataDeHoje.ToString("yyyy/MM/dd")}");

            Console.WriteLine($"A data de amanhã é: {dataDeHoje.ToString("yyyy/MM/dd")}");

            Console.ReadKey();

        }

        private static void ExercicioParte3()
        {
            //1 - ordene os numeros de maneira decrescente e mostre no console o resultado.
            var numeros = new int[] { 18, 92, 43, 11, 90, 56, 87, 78, 11, 18, 56};

            //2 - Com o vetor ordenado remova os números repetidos e mostre no console o resultado.

        }

        private static void ExercicioParte4()
        {
            //1 - Extraia o texto do arquivo 'Texto Ipsum.txt' e atribua-o a variável texto
            //DICA: Coloque o caminho do arquivo Texto Ipsum na variavel caminhoArquivoIpsum
            //DICA 2: Use a classe File para extrair o texto
            string caminhoArquivoIpsum = @"";
            string texto = default;

            //2 - Mostre o texto do arquivo no console

            //3 - No meio do texto tem o valor {Referencia: 958220}.
            //    Extraia o valor 958220 direto do texto e atribua-o a variável referencia.
            //Dica use texto.Substring() para extrair o texto desejado
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
