using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
             string menu,nome;
            double num1, num2;


            //Menu da Calculadora





            Console.Write("Olá, digite seu nome por favor: ");
            nome = Console.ReadLine();
            Console.Clear();

            do
            {
                
                
                Console.Clear();
                Console.WriteLine("                 *******************************************************");
                Console.WriteLine("                 |                 Calculadora Aritmética              |");
                Console.WriteLine("                 ******************************************************* ");
                Console.WriteLine();
                Console.WriteLine("[1]-Adição    [2]-Subtração     ");
                Console.WriteLine("");
                Console.WriteLine("[3]-Multiplicação    [4]-Divisão ");
                Console.WriteLine("");
                Console.WriteLine("[5]-Potenciação     [6]-Radiciação     [7]-Sair do programa");
                Console.WriteLine("");
                Console.Write("Selecione uma opção: ");
                  menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.Clear();
                         Console.WriteLine("Olá " + nome + ", digite o primeiro número desejado: ");
                          num1 = double.Parse(Console.ReadLine());
                           Console.Clear();
                         Console.WriteLine("Digite o segundo número desejado: ");
                          num2 = double.Parse(Console.ReadLine());

                        somar(num1, num2);

                        break;

                    case "2":
                        Console.Clear();
                         Console.WriteLine("Olá " + nome + ", digite o primeiro numero desejado: ");
                          num1 = double.Parse(Console.ReadLine());
                           Console.Clear();
                         Console.WriteLine("Digite o segundo numero desejado: ");
                          num2 = double.Parse(Console.ReadLine());

                        subtrair(num1, num2);

                        break;

                    case "3":
                        Console.Clear();
                         Console.WriteLine("Olá " + nome + ", digite o primeiro número desejado: ");
                          num1 = double.Parse(Console.ReadLine());
                           Console.Clear();
                         Console.WriteLine("Digite o segundo número desejado: ");
                          num2 = double.Parse(Console.ReadLine());

                        multiplicar(num1, num2);
                        break;

                    case "4":
                        Console.Clear();
                         Console.WriteLine("Olá " + nome + ", digite o dividendo(numero a qual será dividido) desejado: ");
                          num1 = double.Parse(Console.ReadLine());
                           Console.Clear();
                         Console.WriteLine("Digite o divisor(numero que dividirá o anterior) desejado: ");
                          num2 = double.Parse(Console.ReadLine());

                        dividir(num1, num2);
                        break;

                    case "5":
                        Console.Clear();
                         Console.WriteLine("Olá " + nome + ", digite o número base desejado: ");
                          num1 = double.Parse(Console.ReadLine());
                           Console.Clear();
                         Console.WriteLine("Digite o expoente (numero que elevará o anterior) desejado: ");
                          num2 = double.Parse(Console.ReadLine());

                        potencia(num1, num2);
                        break;

                    case "6":
                        Console.Clear();
                         Console.WriteLine("Olá " + nome + ", o radicando desejado: ");
                          num1 = double.Parse(Console.ReadLine());
                           Console.Clear();
                         Console.WriteLine("Digite o indice(numero que determinará se a raiz é quadrada ou outro numero) ou  desejado: ");
                          num2 = double.Parse(Console.ReadLine());

                        raiz(num1, num2);
                        break;



                }
            }
            while (menu != "7");



        }
        //Metodo para somar
        public static void somar(double num1, double num2)
        {
           double total = num1 + num2;
            Console.Clear();
             Console.WriteLine("O resultado da soma é igual a: " + total);
              Console.ReadKey();
        }

        //Metodo para subtração
        public static void subtrair(double num1, double num2)
        {
            double total = num1 - num2;
            Console.Clear();
             Console.WriteLine("O resultado da subtração é igual a: " + total);
              Console.ReadKey();
        }
        //Metodo para multiplicação
        public static void multiplicar(double num1, double num2)
        {
            double total = num1*num2;
            Console.Clear();
             Console.WriteLine("O resultado da multiplicação é igual a: " + total);
              Console.ReadKey();
        }
        //Metodo para divisão
        public static void dividir(double num1, double num2)
        {
            double total = num1/num2;
            Console.Clear();
             Console.WriteLine("O resultado da divisão é igual a: " + total);
              Console.ReadKey();
        }
        //Metodo para potenciação
        public static void potencia(double num1, double num2)
        {
            double total = Math.Pow(num1,num2);
            Console.Clear();
             Console.WriteLine("O resultado da potenciação é igual a: " + total);
              Console.ReadKey();
        }
        //Metodo para radiciação
        public static void raiz(double num1, double num2)
        {
            double total = Math.Pow(num1,(1/num2));
            Console.Clear();
             Console.WriteLine("O resultado da radiciação é igual a: "+ total);
              Console.ReadKey();
        

            












        }

            




    }   
}
