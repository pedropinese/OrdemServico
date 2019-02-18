using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemServico
{
    class Os
    {
        public int numero { get; set; }
        public DateTime data_abertura { get; set; }
        public DateTime? data_encerramento { get; set; }
        public string responsavel{ get; set; }
        public List<Area> listaAreas { get; set; }
        public List<Os> listaOsAbertas { get; set; }
        public List<Os> listaOsFechadas { get; set; }

        public Os()
        {
            
        }

        public Os(int numero, DateTime data_abertura, DateTime? data_encerramento, string responsavel, List<Area> listaAreas, List<Os> listaOsAbertas, List<Os> listaOsFechadas)
        {
            this.numero = numero;
            this.data_abertura = data_abertura;
            this.data_encerramento = data_encerramento;
            this.responsavel = responsavel;
            this.listaAreas = listaAreas;
            this.listaOsAbertas = listaOsAbertas;
            this.listaOsFechadas = listaOsFechadas;
        }

        public Os criar_os()
        {
            Os os = new Os();
            Console.Clear();
            Console.WriteLine("\t\tORDEM DE SERVICO");
            Console.Write("\nDigite a data de abertura: ");
            os.data_abertura = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\nDigite o nome do responsavel: ");
            os.responsavel = Console.ReadLine();
            Area area = new Area();
            os.listaAreas = area.inserir_areas();
            char escolha;
            do
            {
                Console.WriteLine("\nDeseja encerrar essa OS? (s/n)");
                escolha = Convert.ToChar(Console.ReadLine());
                if (escolha == 's')
                {
                    Console.Write("\nDigite a data de encerramento: ");
                    os.data_encerramento = Convert.ToDateTime(Console.ReadLine());
                }
                else if (escolha == 'n')
                {
                    Console.WriteLine("\nOrdem de Serviço sem data de encerramento!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tErro!\n\n\tMotivo: Escolha uma das opcoes 's' ou 'n'");
                    Console.ResetColor();
                }
            } while (escolha != 's' && escolha != 'n');
            return os;
        }
    }
}
