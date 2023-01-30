using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pedido pedido = new Pedido(1, "Alysson");

            ItemPedido itemPedido1 = new ItemPedido(1, "martelo", 2, 10);
            ItemPedido itemPedido2 = new ItemPedido(2, "parafuso", 30, 4.5);
            ItemPedido itemPedido3 = new ItemPedido(3, "furadeira", 2, 200);

            pedido.addItem(itemPedido1);
            pedido.addItem(itemPedido2);
            pedido.addItem(itemPedido3);

            pedido.ToString();
            Console.ReadKey();


        }
    }
}
