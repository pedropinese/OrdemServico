using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemServico
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacao = 99, numero_os = 1;
            Area a = new Area();
            Os os = new Os();
            os.listaOsAbertas = new List<Os>();
            os.listaOsFechadas = new List<Os>();
            while (operacao != 0)
            {
                Console.Clear();
                Console.WriteLine("\t\tORDEM DE SERVICO");
                Console.WriteLine("\n\t0 - Sair\n\t1 - Criar OS\n\t2 - Listar OS's\n\t3 - Encerrar OS\n\t4 - Nova area na OS");
                Console.Write("\n\tSelecione a operacao: ");
                operacao = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (operacao)
                {
                    case 0:
                        {
                            Console.WriteLine("\t\tORDEM DE SERVICO");
                            Console.WriteLine("\n\tPressione qualquer tecla para sair..");
                            break;
                        }
                    case 1:
                        {
                            try
                            {
                                Os nova_os = new Os();
                                nova_os = os.criar_os();
                                nova_os.numero = numero_os;
                                if (nova_os.data_encerramento.Equals(null)) //verifica se a os tem encerramento ou nao
                                {
                                    os.listaOsAbertas.Add(nova_os);
                                }
                                else
                                {
                                    os.listaOsFechadas.Add(nova_os);
                                }
                                Console.Clear();
                                Console.WriteLine("\t\tORDEM DE SERVICO");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n\tOS cadastrada com sucesso!");
                                Console.ResetColor();
                                numero_os++;
                            }
                            catch (FormatException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (OverflowException ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                mostra_erro(ex.Message);
                            }
                            break;
                        }
                    case 2:
                        {

                            break;
                        }
                    case 3:
                        {

                            break;
                        }
                    case 4:
                        {

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\t\tORDEM DE SERVICO");
                            mostra_erro("Opcao invalida!");
                            break;
                        }
                }
                Console.ReadKey();
            }
        }

        public static void mostra_erro(string msg_erro)
        {
            Console.Clear();
            Console.WriteLine("\t\tORDEM DE SERVICO");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\tErro!\n\n\tMotivo: " + msg_erro);
            Console.ResetColor();
        }
    }
}
