using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prMaseczka = new Product(1, "Maseczka", 1);
            Product prRyz = new Product(2, "Ryż", 2.53);
            Product prPapier = new Product(3, "Papier toaletowy", 12.99, "Regina - 3 warstwy");

            Order order = new Order();
            order.AddProduct(prMaseczka, 10);
            order.AddProduct(prPapier, 2);
            order.AddProduct(prRyz, 1);

            order.AddProduct(prPapier, 3);

            order.RemoveProduct(prMaseczka, 5);
            order.RemoveProduct(prRyz);

            order.Print();
            Console.ReadKey();

        }
    }
}
