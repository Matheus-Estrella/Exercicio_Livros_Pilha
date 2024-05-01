using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Livros_Pilha
{
    internal class Pilha_Livro
    {
        Livro topo;

        public Pilha_Livro()
        {
            this.topo = null;
            Console.WriteLine("\nPilha criada com sucesso\n");
        }

        public void Push(Livro novo_livro)
        {
            if (Vazia())
            {
                topo = novo_livro;
            }
            else
            {
                novo_livro.Set_Anterior(topo);
                topo = novo_livro;
            }

        }

        public void Print()
        {
            Livro novo_livro = topo;
            if (Vazia())
            {
                Console.WriteLine("\n  A pilha esta vazia\n  É impossível imprimir");
                Console.Clear();
                Jump();
            }
            else
            {
                do
                {
                    Console.WriteLine(novo_livro.ToString());
                    novo_livro = novo_livro.Get_Proximo();

                } while (novo_livro != null);
                if (novo_livro == null)
                {
                    Console.WriteLine("\nFim da impressão");
                    Jump();
                    Console.Clear();
                }
            }
        }

        public void pop()
        {
            if (Vazia())
            {
                Console.WriteLine("\n  A pilha esta vazia!!!");
                Jump();
            }
            else
            {
                topo = topo.Get_Proximo();
            }
        }
        Boolean Vazia()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void Jump()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

        }

        public void Buscar_Livro(int i)
        {
            Livro novo_livro = topo; 
            int posicao = 0;
            Console.Write("\nInforme o título do livro a procurar: ");
            string titulo = Console.ReadLine();
            int qnt_titulo = 0;

            if (Vazia())
            {
                Console.WriteLine("\n  A pilha esta vazia\n  Não há livros a procurar");
                Console.Clear();
                Jump();
            }
            else
            {
                do
                {
                    posicao++;
                    if (titulo == novo_livro.Get_Titulo())
                    {
                        if (i == 1)
                        {
                            Console.WriteLine($"\nO título {titulo} esta na {posicao}ª posição da pilha");
                        }
                        qnt_titulo++;
                    }
                    novo_livro = novo_livro.Get_Proximo();
                } while (novo_livro != null);
                if (qnt_titulo != 0 && i == 2)
                {
                    Console.WriteLine($"Há {qnt_titulo} livros com este título");
                }
                if (novo_livro == null)
                {
                    Console.WriteLine("\nNão há mais pesquisas compatíveis com o título");
                    Jump();
                    Console.Clear();
                }
            }
        }
    }
}
