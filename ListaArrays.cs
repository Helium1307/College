using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmSala
{
    class Program
    {
        static void Main(string[] args)
        {

                int menu;


            do
            {
                Console.WriteLine("        =======================================");
                Console.WriteLine("        |                                     |");
                Console.WriteLine("        | Lista de Questões utilizando Arrays |");
                Console.WriteLine("        |                                     |");
                Console.WriteLine("        =======================================");
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine("[1]- Ler um número indeterminado de idades, e fazer a média das mesmas quando um número negativo for digitado.");
                Console.WriteLine("");
                Console.WriteLine("[2]- Ler dois números e mostrar a soma dos ímpares entre os números digitados.");
                Console.WriteLine("");
                Console.WriteLine("[3]- Ir lendo números e mostrando o quadrado deles. Apertando zero, vai retornar ao menu.");
                Console.WriteLine("");
                Console.WriteLine("[4]- Ler três números e mostrar os multiplos do primeiro no intervalo do segundo e do terceiro.");
                Console.WriteLine("");
                Console.WriteLine("[5]- Ler dois números flutuantes e dividir o primeiro pelo segundo.");
                Console.WriteLine("");
                Console.WriteLine("[6]- Contabilizar a quantidade de vezes que foram escolhidos entre Álcool, gasolina e Diesel.");
                Console.WriteLine("");
                Console.WriteLine("[7]- Ler uma senha até a mesma ser igual a predefinada.");
                Console.WriteLine("");
                Console.WriteLine("[0]- Sair do Programa");
                Console.WriteLine("");
                Console.Write("Selecione uma das questões: ");
                menu = int.Parse(Console.ReadLine());



                switch (menu)
                {

                    case 1:
                        //PRIMEIRA QUESTÃO
                        double[] idades = new double[4];

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Vai digitando idades ai: ");
                              idades[0] = double.Parse(Console.ReadLine());

                            if (idades[0] < 0)
                            {
                                Console.WriteLine("Foi mal, mas número negativo não é idade :), Bye");
                                  Console.ReadKey();
                                   Console.Clear();
                                Console.WriteLine("Mas antes. A média aritmética de tudo foi: " + idades[3]);
                                  Console.ReadKey();
                                   break;
                            }

                            idades[1]++;

                            idades[2] += idades[0];
                            idades[0] = 1;
                            idades[3] = idades[2] / idades[1];

                        } while (idades[0] >= 0);
                        Console.Clear();
                        break;





                    case 2:
                        //SEGUNDA QUESTÃO
                        int[] escolhaDeImpar = new int[4];
                        
                        Console.Clear();
                        Console.WriteLine("Digite o primeiro número: ");
                          escolhaDeImpar[0] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite um segundo número: ");
                          escolhaDeImpar[1] = int.Parse(Console.ReadLine());
                            Console.Clear();

                        for (int cont = 0; escolhaDeImpar[0] <= escolhaDeImpar[1]; escolhaDeImpar[0]++)
                        {
                            if (escolhaDeImpar[0] % 2 != 0 && escolhaDeImpar[0] % 2 == 1)
                            {
                                escolhaDeImpar[2] += escolhaDeImpar[0];
                            }

                        }
                        Console.WriteLine("A soma dos impares é igual a: " + escolhaDeImpar[2]);
                            Console.ReadKey();
                                Console.Clear();
                        break;




                    case 3:
                        //TERCEIRA QUESTÃO
                        double[] numquad = new double[2];

                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Digite um numero e saiba o quadrado dele: ");
                              numquad[0] = int.Parse(Console.ReadLine());
                            numquad[1] = Math.Pow(numquad[0], 2);
                            if (numquad[0] == 0)
                            {
                                Console.WriteLine("Inválido");
                                Console.ReadKey();
                                break;
                            }

                            Console.Clear();
                            Console.WriteLine("O quadrado de " + numquad[0] + " é: " + numquad[1]);
                              Console.ReadKey();
                             numquad[0] = 1;




                        } while (numquad[0] != 0);
                            Console.Clear();
                        break;

                    case 4:
                        //QUARTA QUESTÃO
                        int[] numeros = new int[5];

                        Console.Clear();
                        Console.WriteLine("Digite o primeiro número: ");
                          numeros[0] = int.Parse(Console.ReadLine());
                           Console.Clear();
                        Console.WriteLine("Digite o segundo número: ");
                          numeros[1] = int.Parse(Console.ReadLine());
                           Console.Clear();
                        Console.WriteLine("Digite o terceiro número: ");
                          numeros[2] = int.Parse(Console.ReadLine());
                           Console.Clear();
                        numeros[3] = numeros[0];

                        for (; numeros[0] <= numeros[2]; numeros[0]++)
                        {
                            if (numeros[0] % numeros[3] == 0)
                            {
                                Console.WriteLine(numeros[0]);

                            }
                        }
                            Console.ReadKey();
                                Console.Clear();
                        break;


                    case 5:
                        //QUINTA QUESTÃO
                        //DDR SIGNIFICA = DIVIDENDO, DIVISOR  E RESULTADO
                        double[] ddr = new double[3];

                        Console.Clear();
                        Console.WriteLine("Digite um número: ");
                          ddr[0] = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro número");
                          ddr[1] = double.Parse(Console.ReadLine());

                        ddr[2] = ddr[0] / ddr[1];
                        if (ddr[1] == 0)
                        {
                            Console.WriteLine("Não existe resultado");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("O resultado é: " + String.Format("{0:0.000}", ddr[2]));
                              Console.ReadKey();
                        }
                            Console.Clear();
                        break;




                    case 6:
                        //SEXTA QUESTÃO
                        int[] escolhas = new int[3] { 0, 0, 0 };
                        int menu2;


                        do
                        {
                            Console.Clear();
                            Console.WriteLine("[1]- Álcool          [2]- Gasolina");
                            Console.WriteLine("[3]- Diesel          [4]- Sair");
                            Console.WriteLine("");
                            Console.WriteLine("Selecione uma opção: ");
                              menu2 = int.Parse(Console.ReadLine());
                            if (menu2 != 1 && menu2 != 2 && menu2 != 3 && menu2 != 4)
                            {
                                Console.WriteLine("Código Invalido");
                                Console.ReadKey();
                            }

                            switch (menu2)
                            {

                                case 1:
                                    escolhas[0]++;
                                    break;
                                case 2:
                                    escolhas[1]++;
                                    break;
                                case 3:
                                    escolhas[2]++;
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("Muito Obrigado");
                                    Console.WriteLine("Álcool: " + escolhas[0]);
                                    Console.WriteLine("Gasolina: " + escolhas[1]);
                                    Console.WriteLine("Diesel: " + escolhas[2]);
                                    Console.ReadKey();
                                    break;

                            }
                        } while (menu2 != 4);
                            Console.Clear();
                                break;






                    case 7:
                        //SÉTIMA QUESTÃO
                        int[] senha = new int[2];

                        senha[1] = 2002;


                        do
                        {
                            Console.Clear();
                            Console.Write("Digite a senha correta: ");
                              senha[0] = int.Parse(Console.ReadLine());

                            if (senha[0] != senha[1])
                            {

                                Console.Write("Senha incorreta");
                                  Console.ReadKey();
                                senha[0] = 0;
                            }
                            else
                            {
                                Console.Write("Acesso permitido");
                                Console.ReadKey();
                                break;

                            }





                        } while (senha[0] == 0);
                        Console.Clear();
                        break;

                    case 0:
                        Console.WriteLine("Obrigado e volte sempre. :)");
                        break;
                }


            } while (menu != 0);




        } 

    }
}
