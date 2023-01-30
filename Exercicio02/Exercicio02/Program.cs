using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cria uma instancia (objeto) da classe pessoa e atribui valores aos atributos nome e sobrenome 
            Pessoa pes = new Pessoa("Ricardo", "Brunhara");

            //cria uma instancia do Delegate que aponta para o método que mostra o nome 
            ExDelegate nDelegate = new ExDelegate(pes.mostraNome);

            //executa o método via Delegate
            nDelegate("Nome: ");

            //cria outra instancia do Delegate que aponta para o método que mostra o sobrenome 
            nDelegate = new ExDelegate(pes.mostraSobrenome);

            //executa o método via Delegate
            nDelegate("Sobrenome: ");

            Console.ReadKey();

        }
    }
}

public delegate void ExDelegate(string msg);

