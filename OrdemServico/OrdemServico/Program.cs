using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrdemServico
{
    class Program
    {
        public static int numero_os = 1;

        static void Main(string[] args)
        {
            string operacao = "";
            Area a = new Area();
            Os os = new Os();
            os.listaOsAbertas = new List<Os>();
            os.listaOsFechadas = new List<Os>();
            while (operacao != "0")
            {
                titulo("0 - Sair\n\t1 - Criar OS\n\t2 - Listar OS's\n\t3 - Encerrar OS\n\t4 - Nova area na OS");
                Console.Write("\n\tSelecione a operacao: ");
                operacao = Console.ReadLine();
                Console.Clear();
                switch (operacao)
                {
                    case "0":
                        {
                            titulo("Pressione qualquer tecla para sair..");
                            break;
                        }
                    case "1":
                        {
                            try
                            {
                                Os nova_os = new Os();
                                nova_os = criar_os();
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
                                mostra_sucesso("OS cadastrada com sucesso!");
                                Interlocked.Increment(ref numero_os);
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
                    case "2":
                        {
                            try
                            {
                                double soma_areas;
                                int x;
                                if (os.listaOsAbertas.Count() == 0 && os.listaOsFechadas.Count() == 0)
                                {
                                    mostra_erro("Nenhuma OS cadastrada!");
                                    break;
                                }
                                titulo("1 - OS Abertas\n\t2 - OS Fechadas\n\t3 - Todas as OS");
                                Console.Write("\n\tSelecione a operacao: ");
                                int op = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("\t\tORDEM DE SERVICO");
                                if (op == 1)
                                {
                                    foreach (Os ordemServico in os.listaOsAbertas)
                                    {
                                        x = 1;
                                        soma_areas = 0;
                                        Console.Write("_____________________________\n");
                                        Console.WriteLine("Nº OS: {0}\nData Abertura: {1}\nResponsavel: {2}", ordemServico.numero, ordemServico.data_abertura.ToString("dd/MM/yyy"), ordemServico.responsavel);
                                        foreach (Area area in ordemServico.listaAreas)
                                        {
                                            Console.WriteLine("\tCodigo area {0}: {1}", x, area.codigo);
                                            Console.WriteLine("\tTamanho: {0}", area.area);
                                            soma_areas = soma_areas + area.area;
                                            x++;
                                        }
                                        Console.WriteLine("Soma todas areas: " + soma_areas);
                                    }
                                }
                                else if (op == 2)
                                {
                                    foreach (Os ordemServico in os.listaOsFechadas)
                                    {
                                        x = 1;
                                        soma_areas = 0;
                                        Console.Write("_____________________________\n");
                                        Console.WriteLine("Nº OS: {0}\nData Abertura: {1}\nData Encerramento: {2}\nResponsavel: {3}", ordemServico.numero, ordemServico.data_abertura.ToString("dd/MM/yyy"), ordemServico.data_encerramento, ordemServico.responsavel);
                                        foreach (Area area in ordemServico.listaAreas)
                                        {
                                            Console.WriteLine("\tCodigo area {0}: {1}", x, area.codigo);
                                            Console.WriteLine("\tTamanho: {0}", area.area);
                                            soma_areas = soma_areas + area.area;
                                            x++;
                                        }
                                        Console.WriteLine("Soma todas areas: " + soma_areas);
                                    }
                                }
                                else if (op == 3)
                                {
                                    titulo(">>>>>>ABERTAS<<<<<<\n");
                                    foreach (Os ordemServico in os.listaOsAbertas)
                                    {
                                        x = 1;
                                        soma_areas = 0;
                                        Console.Write("_____________________________\n");
                                        Console.WriteLine("Nº OS: {0}\nData Abertura: {1}\nResponsavel: {2}", ordemServico.numero, ordemServico.data_abertura.ToString("dd/MM/yyy"), ordemServico.responsavel);
                                        foreach (Area area in ordemServico.listaAreas)
                                        {
                                            Console.WriteLine("\tCodigo area {0}: {1}", x, area.codigo);
                                            Console.WriteLine("\tTamanho: {0}", area.area);
                                            soma_areas = soma_areas + area.area;
                                            x++;
                                        }
                                        Console.WriteLine("Soma todas areas: " + soma_areas);
                                    }
                                    Console.WriteLine("\n\t>>>>>>FECHADAS<<<<<<\n");
                                    foreach (Os ordemServico in os.listaOsFechadas)
                                    {
                                        x = 1;
                                        soma_areas = 0;
                                        Console.Write("_____________________________\n");
                                        Console.WriteLine("Nº OS: {0}\nData Abertura: {1}\nData Encerramento: {2}\nResponsavel: {3}", ordemServico.numero, ordemServico.data_abertura, ordemServico.data_encerramento, ordemServico.responsavel);
                                        foreach (Area area in ordemServico.listaAreas)
                                        {
                                            Console.WriteLine("\tCodigo area {0}: {1}", x, area.codigo);
                                            Console.WriteLine("\tTamanho: {0}", area.area);
                                            soma_areas = soma_areas + area.area;
                                            x++;
                                        }
                                        Console.WriteLine("Soma todas areas: " + soma_areas);
                                    }
                                }
                                else
                                {
                                    mostra_erro("Opcao Invalida!");
                                }
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
                    case "3":
                        {
                            try
                            {
                                if (os.listaOsAbertas.Count() == 0)
                                {
                                    mostra_erro("Nenhuma OS aberta!");
                                    break;
                                }
                                titulo("Digite o numero da OS que deseja encerrar: ");
                                int num_digitado = Convert.ToInt32(Console.ReadLine());
                                int x = 0;
                                foreach (Os ordemServico in os.listaOsAbertas)
                                {
                                    if (num_digitado == ordemServico.numero)
                                    {
                                        do
                                        {
                                            titulo("Digite a data de encerramento: ");
                                            ordemServico.data_encerramento = Convert.ToDateTime(Console.ReadLine());
                                            if (ordemServico.data_encerramento < ordemServico.data_abertura)
                                            {
                                                mostra_erro("Data de encerramento deve ser posterior a de abertura");
                                                Console.ReadKey();
                                            }
                                        } while (ordemServico.data_encerramento < ordemServico.data_abertura);

                                        os.listaOsFechadas.Add(ordemServico);
                                        os.listaOsAbertas.Remove(ordemServico);
                                        mostra_sucesso("Data inserida com sucesso");
                                        break;

                                    }
                                    else
                                    {
                                        x++;
                                        if (x == os.listaOsAbertas.Count)
                                        {
                                            mostra_erro("Numero invalido!");
                                        }

                                    }
                                }
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
                    case "4":
                        {
                            try
                            {
                                if (os.listaOsAbertas.Count() == 0)
                                {
                                    mostra_erro("Nenhuma OS aberta!");
                                    break;
                                }
                                titulo("Digite o numero da OS que deseja adicionar: ");
                                int num_digitado = Convert.ToInt32(Console.ReadLine());
                                int x = 0;
                                foreach (Os ordemServico in os.listaOsAbertas)
                                {
                                    if (num_digitado == ordemServico.numero)
                                    {
                                        Area a1 = new Area();
                                        Console.Write("\nDigite o codigo da area: ");
                                        a1.codigo = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("\nDigite o tamanho da area: ");
                                        a1.area = Convert.ToDouble(Console.ReadLine());
                                        ordemServico.listaAreas.Add(a1);
                                        mostra_sucesso("Area inserida com sucesso");
                                        break;
                                    }
                                    else
                                    {
                                        x++;
                                        if (x == os.listaOsAbertas.Count)
                                        {
                                            mostra_erro("Numero invalido!\n\t\t(Verifique se essa OS continua aberta)");
                                        }

                                    }
                                }
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

        public static void mostra_sucesso(string msg_sucesso)
        {
            Console.Clear();
            Console.WriteLine("\t\tORDEM DE SERVICO");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tPronto!\n\n\t" + msg_sucesso);
            Console.ResetColor();
        }

        public static Os criar_os()
        {
            Os os = new Os();
            titulo("");
            Console.Write("Digite a data de abertura: ");
            os.data_abertura = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\nDigite o nome do responsavel: ");
            os.responsavel = Console.ReadLine();
            os.listaAreas = inserir_areas();
            char escolha;
            do
            {
                Console.WriteLine("\nDeseja encerrar essa OS? (s/n)");
                escolha = Convert.ToChar(Console.ReadLine());
                if (escolha == 's')
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\t\tORDEM DE SERVICO");
                        Console.Write("\nDigite a data de encerramento: ");
                        os.data_encerramento = Convert.ToDateTime(Console.ReadLine());
                        if (os.data_encerramento < os.data_abertura)
                        {
                            mostra_erro("Data de encerramento deve ser posterior a de abertura");
                            Console.ReadKey();
                        }
                    } while (os.data_encerramento < os.data_abertura);
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

        public static List<Area> inserir_areas()
        {
            Area a = new Area();
            a.listaAreas = new List<Area>();
            Console.Write("\nDigite quantas areas deseja inserir: ");
            int qtde_areas = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < qtde_areas; i++)
            {
                Area a1 = new Area();
                Console.Write("\nDigite o codigo da {0}º area: ", i + 1);
                a1.codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nDigite o tamanho da {0}º area: ", i + 1);
                a1.area = Convert.ToDouble(Console.ReadLine());
                a.listaAreas.Add(a1);
            }
            return a.listaAreas;
        }

        public static void titulo (string texto)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\tORDEM DE SERVICO");
            Console.ResetColor();
            Console.WriteLine("\n\t"+texto);            
        }

    }
}
