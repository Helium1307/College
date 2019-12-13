using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static List<string> contatos = new List<string>();
        static void Main(string[] args)
        {
            int menu, id = 0;
            string nome;

            do
            {
                Console.WriteLine("============================Menu============================");
                Console.WriteLine("");
                Console.WriteLine("[1] Inserir nome   [2] Alterar nome   [3] Consultar nome existente  ");
                Console.WriteLine("[4] Remover nome  [5] Listar todos os nomes   [0] Sair");
                Console.WriteLine("");
                Console.Write("Escolha uma opção: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        inserir();
                        Console.Clear();
                        id++;
                        break;
                    case 2:
                        Console.Clear();
                        alterar();
                        Console.Clear();
                        
                        break;
                    case 3:
                        Console.Clear();
                        consultarNome();
                            Console.Clear();
                            
                        break;
                    case 4:
                        Console.Clear();
                        excluirNome();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        listar();
                        Console.Clear();
                        break;

                }

            } while (menu != 0);

        }

        static void inserir()
        {
            Console.WriteLine("Digite o nome que deseja inserir: ");
            contatos.Add(Console.ReadLine());
            
        }

        static void alterar()
        {
            int id0=1,posicao;
            string newname;
            foreach (var names in contatos)
            {

                Console.WriteLine(id0+" - " + names);
                Console.WriteLine("========================");
                id0++;
            }
            Console.WriteLine("Qual posição deseja alterar ?");
            posicao = int.Parse(Console.ReadLine());


            posicao -= 1;
            contatos.RemoveAt(posicao);
            Console.Clear();
            Console.WriteLine("Digite o novo nome: ");
            newname = Console.ReadLine();

            
            contatos.Insert(posicao,newname);
            
        }

        static void consultarNome()
        {
            int id0=1;           
            char nameverif;

            List<string> consultar = new List<string>();

            Console.WriteLine("Digite a letra do nome à ser consultado: ");
            nameverif = char.Parse(Console.ReadLine());
            consultar = contatos.FindAll(x => x[0] == nameverif);

            
                foreach(var nomeAparecer in consultar)
                {
                    Console.WriteLine(id0+" - "+nomeAparecer);
                    Console.WriteLine("========================");
                    id0++;
                    
                }
                Console.ReadKey();
            
           
        }

        static void excluirNome()
        {
            int id0=1,tamanho,posicao;
            string nameremov;

            Console.WriteLine("Digite o número de caracteres possui o nome: ");
            tamanho = int.Parse(Console.ReadLine());
            Console.Clear();

             List<string> mostrar = contatos.FindAll(x => x.Length == tamanho);
                foreach(var visualizar in mostrar)
                {
                    Console.WriteLine(id0+" - "+visualizar);
                    Console.WriteLine("========================");
                id0++;
                }
            Console.WriteLine("");
            Console.Write("Qual nome deseja ser removido: ");
            posicao = int.Parse(Console.ReadLine());


            posicao -= 1;
            contatos.RemoveAt(posicao);
            Console.WriteLine("Nome removido com sucesso");
            


                

        }

        static void listar()
        {
            int id0 = 1;
            
            foreach (var names in contatos)
            {

                Console.WriteLine(id0 + " - " + names);
                Console.WriteLine("========================");
                id0++;
            }
            Console.ReadKey();
        }

    }
}
