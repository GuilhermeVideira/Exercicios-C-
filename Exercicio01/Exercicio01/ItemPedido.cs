using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class ItemPedido
    {
        private int codigo;
        private String produto;
        private int quantidade;
        private double valorUnitario;
        public ItemPedido()
        {
            this.codigo = 0;
            this.produto = null;
            this.quantidade = 0;
            this.valorUnitario = 0;
        }
        public ItemPedido(int codigo, String produto, int quantidade, double valorUnitario)
        {
            this.codigo = codigo;
            this.produto = produto;
            this.quantidade = quantidade;
            this.valorUnitario = valorUnitario;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public String Produto
        {
            get { return produto; }
            set { produto = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public double ValorUnitario
        {
            get { return valorUnitario; }
            set { valorUnitario = value; }

        }
    }
}
