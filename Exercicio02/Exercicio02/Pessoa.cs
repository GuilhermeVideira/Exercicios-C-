using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Pessoa
    {
        //cria os atributos da classe 
        public string nome;
        public string sobrenome;
        //construtor da classe com parâmetros 
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }
        //método que exibirá o nome (precedido pela string “Nome: “ – enviada pelo delegate) 
        public void mostraNome(string msg)
        {
            Console.WriteLine(msg + this.nome);
        }
        //método que exibirá o sobrenome (precedido pela string “Sobrenome: “ – enviada pelo delegate) 
        public void mostraSobrenome(string msg)
        {
            Console.WriteLine(msg + this.sobrenome);
        }

    }
}
