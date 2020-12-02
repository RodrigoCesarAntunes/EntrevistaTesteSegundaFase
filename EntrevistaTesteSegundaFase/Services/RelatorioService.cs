using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrevistaTesteSegundaFase.Services
{
    public class RelatorioService
    {
        public string GetTexto(string referencia)
        {
            if (referencia == "958220")
                return "Relatorio de gastos\n" +
                    "IPI: 50 ICMS: 200 II: 600 Mercadoria: 1000 Tota: 1850";

            return "Erro referência não encontrada";
        }
    }
}
