using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = -1, n = 0, c = 0;
            Carro[] car = new Carro[300];
            Caminhao[] cam = new Caminhao[200];
            do
            {
                op = menu();
                switch (op)
                {
                    case 1:
                        {
                            if (c < 300)
                            {
                                car[c] = new Carro();

                                Console.Clear();

                                Console.WriteLine("Digite a placa :");
                                car[c].Placa = Console.ReadLine();

                                Console.WriteLine("Digite o fabricante :");
                                car[c].Fabricante = Console.ReadLine();

                                Console.WriteLine("Digite o modelo ");
                                car[c].Modelo = (Console.ReadLine());

                                Console.WriteLine("Digite a cor ");
                                car[c].Cor = Console.ReadLine();

                                Console.WriteLine("Digite o ano do carro ");
                                car[c].Ano = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite número de portas: ");
                                car[c].Numero_portas = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite capacidade Porta Mala: ");
                                car[c].CapacidadePortaMala = int.Parse(Console.ReadLine());

                                Console.WriteLine("Tem bagageiro ( s / n ) ? ");
                                car[c].Bagageiro = Console.ReadLine().ToUpper() == "S" ? true : false;

                                Console.WriteLine("Tem teto Solar ( s / n ) ? ");
                                car[c].TetoSolar = Console.ReadLine().ToUpper() == "S" ? true : false;

                                Console.WriteLine("Tem desembacador Traseiro ( s / n ) ? ");
                                car[c].DesembacadorTraseiro = Console.ReadLine().ToUpper() == "S" ? true : false;

                                Console.WriteLine(n + " carro cadastrado ");
                                c++; // proxima posição 
                            }
                            break;
                        }
                         case 2:
                        {
                            if (n < 200)
                            {
                                cam[n] = new Caminhao();

                                Console.Clear();

                                Console.WriteLine("Digite a placa :");
                                cam[n].Placa = Console.ReadLine();

                                Console.WriteLine("Digite o fabricante :");
                                cam[n].Fabricante = Console.ReadLine();

                                Console.WriteLine("Digite o modelo ");
                                cam[n].Modelo = (Console.ReadLine());

                                Console.WriteLine("Digite a cor ");
                                cam[n].Cor = Console.ReadLine();

                                Console.WriteLine("Digite o ano do caminhão ");
                                cam[n].Ano = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite número de portas: ");
                                cam[n].Numero_portas = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite numero eixos: ");
                                cam[n].Numero_eixos = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite peso_maximo_carga: ");
                                cam[n].Peso_maximo_carga = double.Parse(Console.ReadLine());

                                Console.WriteLine("É veiculo Composto ( s / n ) ? ");
                                cam[n].VeiculoComposto = Console.ReadLine().ToUpper() == "S" ? true : false;

                                Console.WriteLine(n + " caminhão cadastrado ");
                                n++; // proxima posição 
                            }
                            break;
                        }
                          case 3:
                        {
                            consPlaca(cam, n, car, c); //Consulta por placa 
                            break;
                        }
                             case 4: //Consulta Caminhão por modelo/fabricante 
                        {
                            consCam(cam, n); break;
                        }
                           case 5: { listarCor(car, c); break; }
                           case 6: listarCar(car, c); break;
                           case 7: listarCam(cam, n); break;
                           case 0: Console.WriteLine("Fim do aplicativo! - tecle algo..."); break;
                }
            } while (op != 0);
            Console.ReadKey();
        }


        // Metódos -->
        static int menu() // Metódo menu
        {
            int o = -1;
            while (o < 0 || o > 7)
            {
                Console.Clear();
                Console.WriteLine("Escolha a opção desejada:\n" +
                "1 - Cadastrar carro\n" +
                "2 - Cadastro de Caminhão\n" +
                "3 - Consulta por placa\n" +
                "4 - Consulta Caminhão por modelo/fabricante\n" +
                "5 - Consultar Carro por cor\n" +
                "6 - Exibir todos os carros cadastrados\n" +
                "7 - Exibir todos os caminhões cadastrados\n" +
                "0 - Sair\n");
                o = int.Parse(Console.ReadLine());
                if (o < 0 || o > 7)
                {
                    Console.WriteLine("Opção inválida...");
                    Console.ReadKey();
                    break;
                }
            }
            return o;
        }


        static void consPlaca(Caminhao[] c, int qt, Carro[] m, int t)  // Metódo Consultar Placa
        {
            int i, q = 0;
            String pl;
            Console.Clear();
            Console.WriteLine("\nQual é a placa desejada?");
            pl = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n\nCarros com placa " + pl + " : ");
            for (i = 0; i < t; i++)
            {
                if (m[i].Placa == pl)
                {
                    Console.WriteLine("Carro " + i + " : " + m[i].ToString());
                    q++;
                }
            }
            Console.WriteLine("\n\nCaminhões com placa " + pl + " : ");
            for (i = 0; i < qt; i++)
            {
                if (c[i].Placa == pl)
                {
                    Console.WriteLine("Caminhão " + i + " : " + c[i].ToString());
                    q++;
                }
            }
            Console.WriteLine("\nTotal de Caminhoes/Carros com placa " + pl + " : " + q);
            Console.ReadKey();
        }


        static void consCam(Caminhao[] c, int qt) // Metódo Consultar Caminhão
        {
            int i, q = 0;
            string mod = "", fab = "";
            Console.Clear();
            Console.WriteLine("Digite o modelo ");
            mod = Console.ReadLine();
            Console.WriteLine("Digite o fabricante ");
            fab = Console.ReadLine();
            Console.WriteLine("\n\nCaminhoes do modelo/fabricante " + mod + " : ");
            for (i = 0; i < qt; i++)
            {
                if (c[i].Modelo == mod && c[i].Fabricante == fab)
                {
                    Console.WriteLine("Caminhoes " + i + " : " + c[i].ToString());
                    q++;
                }
            }
            Console.WriteLine("\nTotal de Caminhoes do modelo/fabricante " + mod + " : " + q);
            Console.ReadKey();
        }


        static void listarCor(Carro[] c, int qt) // Metódo Listar Pela Cor
        {
            int i, q = 0;
            string cor = "";
            Console.Clear();
            Console.WriteLine("\nDigite a cor ");
            cor = Console.ReadLine();
            Console.WriteLine("\n\nCarros de cor " + cor + " : ");
            for (i = 0; i < qt; i++)
            {
                if (c[i].Cor == cor)
                {
                    Console.WriteLine("Carro " + i + " : " + c[i].ToString());
                    q++;
                }
            }
            Console.WriteLine("\nTotal de Carros do modelo " + cor + " : " + q);
            Console.ReadKey();
        }


        static void listarCar(Carro[] c, int qt) // Metódo Listar Carros
        {
            int i;
            Console.Clear();
            Console.WriteLine("\n\nCarros cadastrados:");
            for (i = 0; i < qt; i++)
            {
                Console.WriteLine("Carro " + (i + 1) + " : " + c[i].ToString());
            }
            Console.ReadKey();
        }


        static void listarCam(Caminhao[] c, int qt) // Metódo Listar Caminhão
        {
            int i;
            Console.Clear();
            Console.WriteLine("\n\nCaminhões cadastrados:");
            for (i = 0; i < qt; i++)
            {
                Console.WriteLine("Caminhao " + (i + 1) + " : " + c[i].ToString());
            }
            Console.ReadKey();


        }
    }
}

