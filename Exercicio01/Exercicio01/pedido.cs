using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Pedido
    {

        private int codigo; 
        private String nomeCliente;
        
        private List <ItemPedido> itensPedido = new List <ItemPedido> ();
        public Pedido()
        {
            this.codigo = 0;
            this.nomeCliente = null;
        }
        public Pedido (int codigo, String nomeCliente)
        {
            this.codigo = codigo;
            this.nomeCliente = nomeCliente;
        }

        public int Codigo
        { 
        get { return codigo; }
        set { codigo = value; } 
        } 

        public String NomeCliente
        {
        get { return nomeCliente; }
        set { nomeCliente = value; }
        }

       public void addItem(ItemPedido itemPedido)
       {
       this.itensPedido.Add(itemPedido);
       }


       //Impressão do pedido 
       public void ToString()
       {

        Console.WriteLine("---Impressão de pedido---\n");
        Console.WriteLine("Codigo pedido: " + this.codigo + " Nome Cliente: " + this.nomeCliente + "\n");
    
            
            for (int i = 0; i < itensPedido.Count(); i++)
            {
              Console.WriteLine((i + 1).ToString() + ") " + "" + itensPedido.ElementAt(i).Codigo + " - " + itensPedido.ElementAt(i).Produto + " - " + itensPedido.ElementAt(i).Quantidade + " - " + itensPedido.ElementAt(i).ValorUnitario);
            }
       } 
    }  
} 

    

