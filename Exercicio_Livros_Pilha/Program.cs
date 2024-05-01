namespace Exercicio_Livros_Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha_Livro minha_pilha = new Pilha_Livro();
            int op;
            do
            {
                do
                {
                    Console.Write("\nMenu principal - Pilha de Livros\n\nInsira uma opção válida\n\n" +
                        "1-) Inserir Livro\n2-) Remover Livro\n3-) Imprimir Pilha\n4-) Contar Livros\n5-) Procurar Título\n6-) Sair\n: ");
                    op = int.Parse(Console.ReadLine());
                } while ((op < 1) || (op > 6));
                switch (op)
                {
                    case 1:
                        minha_pilha.Push(Cadastro_Livro());
                        break;
                    case 2:
                        minha_pilha.pop();
                        break;
                    case 3:
                        minha_pilha.Print();
                        break;
                    case 4:
                        minha_pilha.Buscar_Livro(2);
                        break;
                    case 5:
                        minha_pilha.Buscar_Livro(1);
                        break;
                    case 6:
                        Console.WriteLine("\nEncerrando o do Programa...");
                        Environment.Exit(0);
                        break;
                }

                op = 0;
                Console.WriteLine("\nDeseja continuar a usar o programa?\n1-) Sim\n2-) Não\n: ");
                op = int.Parse(Console.ReadLine());
                if (op < 1 || op > 6)
                {
                    Console.WriteLine("\nInsira uma opção válida");
                }
                Console.Clear();
            } while (op == 1);

        }

        static Livro Cadastro_Livro()
        {
            Console.Write("\nInsira o título do livro: ");
            return new Livro(Console.ReadLine());
        }
    }
}
