using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Livros_Pilha
{
    internal class Livro
    {
        Livro proximo;
        string titulo;

        public Livro(string titulo)
        {
            this.titulo = titulo;
            proximo = null;
        }

        public override string? ToString()
        {
            return $"\nTítulo do livro: {titulo}";
        }

        public void Set_Anterior(Livro livro_abaixo)
        {
            this.proximo = livro_abaixo;
        }

        public Livro Get_Proximo()
        {
            return proximo;
        }

        public string Get_Titulo()
        {
            return titulo;
        }

    }
}
