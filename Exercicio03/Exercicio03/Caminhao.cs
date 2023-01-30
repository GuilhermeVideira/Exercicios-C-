using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Caminhao : Veiculo
    {
        int numero_eixos; 
        double peso_maximo_carga; 
        bool veiculoComposto; 

        public Caminhao() : base()
        {
            this.numero_eixos = 0;
            this.veiculoComposto = false;
            this.peso_maximo_carga = 0;
        }

        public int Numero_eixos
        { 
           get { return numero_eixos; }
           set { numero_eixos = value; } 
        }
        
        public double Peso_maximo_carga
        {
            get { return peso_maximo_carga; }
            set { peso_maximo_carga = value; }
        }

        public bool VeiculoComposto
        {
            get { return veiculoComposto; }
            set { veiculoComposto = value; }
        }

        public override string ToString()
        {
            return (base.ToString() + " Numero eixos: {0}" + numero_eixos + "," + (veiculoComposto ? " veiculo Composto" : " Não é veiculo Composto") + " Peso maximo da carga: " + peso_maximo_carga);
        } 

    }
}
