using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    abstract class Veiculo
    {
        string modelo;
        string fabricante;
        int ano;
        string cor;
        int numero_portas;
        string placa;

        public Veiculo()
        {
            this.modelo = null;
            this.fabricante = null;
            this.ano = 0;
            this.cor = null;
            this.numero_portas = 0;
            this.placa = null;
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public int Numero_portas
        {
            get { return numero_portas; }
            set { numero_portas = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public override string ToString()
        {
            return (String.Format(" Modelo: {0}", modelo) + String.Format(" Cor: {0}", cor) + String.Format(" Placa: {0}", placa) +
            String.Format(" Fabricante: {0}", fabricante) + " Ano: " + ano + " Numero de portas: " + numero_portas);

        }
    }
}
