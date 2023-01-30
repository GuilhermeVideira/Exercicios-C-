using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Carro : Veiculo
    {
        int capacidadePortaMala; 
        bool bagageiro;
        bool tetoSolar; 
        bool desembacadorTraseiro;
        
        public Carro() : base()
        {
            this.capacidadePortaMala = 0;
            this.bagageiro = false;
            this.tetoSolar = false;
            this.desembacadorTraseiro = false;
        }
        
        public int CapacidadePortaMala
        { 
          get { return capacidadePortaMala; }
          set { capacidadePortaMala = value; } 
        }
        
        public bool Bagageiro
        {
          get { return bagageiro; }
          set { bagageiro = value; }
        }

        public bool TetoSolar
        {
           get { return tetoSolar; }
           set { tetoSolar = value; }
        }

        public bool DesembacadorTraseiro
        {
          get { return desembacadorTraseiro; }
          set { desembacadorTraseiro = value; }
        }

        public override string ToString()
        {
           return (base.ToString() + String.Format(" Capacidade do Porta-mala: {0}", capacidadePortaMala) + (bagageiro ? " Bagageiro" : " Sem bagageiro") + (tetoSolar ? " teto Solar" : " Sem teto Solar") + (desembacadorTraseiro ? " desembacador Traseiro" : " Sem desembacador Traseiro"));
         } 


    }
}
