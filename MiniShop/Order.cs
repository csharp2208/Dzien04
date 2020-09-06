using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    enum OrderStatus
    {
        NewOrder = 10, 
        Complete = 20, 
        Confirmed = 30,
        Shipped = 40,
        Returned = 50,
        Cancelled = 60
    }
    class Order
    {
        private String orderNumber;
        private String customerName;
        private String shipAddress;
        private DateTime orderDate;
        private OrderStatus status = OrderStatus.NewOrder;
        private byte discount = 0;
        private List<OrderItem> items = new List<OrderItem>();

        /// <summary>
        /// usuwa wszystkie elementy z zamówienia
        /// </summary>
        /// <returns></returns>
        public bool Clear()
        {
            if (status==OrderStatus.NewOrder)
            {
                items.Clear();
                return true;
            } else
            {
                return false;
            }
        }

        private int GetProductIndex(Product product)
        {
            int result = -1;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Product.Name.Equals(product.Name)) {
                    return i;
                }
            }
            return result;
        }

        /// <summary>
        /// Dodaje produkt do listy w zamówieniu
        /// </summary>
        /// <param name="product"></param>
        /// <param name="qnty"></param>
        /// <returns></returns>
        public bool AddProduct(Product product, int qnty)
        {
            if (product != null && qnty > 0 && status == OrderStatus.NewOrder)
            {
                //int productIndex = GetProductIndex(product);
                int productIndex = items.FindIndex(x => x.Product.Name.Equals(product.Name));
                if (productIndex == -1)
                {
                    items.Add(new OrderItem(product, qnty));
                } else
                {
                    items[productIndex].Qnty += qnty;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Usuwa produkt z listy zamówienia
        /// </summary>
        /// <param name="product"></param>
        /// <param name="qnty"></param>
        /// <returns></returns>
        public bool RemoveProduct(Product product, int qnty=0)
        {
            if (product != null && qnty >= 0 && status == OrderStatus.NewOrder)
            {
                //int productIndex = GetProductIndex(product);
                int productIndex = items.FindIndex(x => x.Product.Name.Equals(product.Name));
                if (productIndex == -1) return false;
                if (qnty > items[productIndex].Qnty) return false;
                
                if (qnty==0 || qnty== items[productIndex].Qnty)
                {
                    items.RemoveAt(productIndex);
                    return true;
                }
                items[productIndex].Qnty -= qnty;

                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Wartość zamówienia
        /// </summary>
        /// <returns></returns>
        public double CalcTotalAmount()
        {
            double amount = 0.0;
            items.ForEach(e => amount += e.Product.Price * e.Qnty);
            //foreach (var item in items)
            //{
            //    amount += item.Qnty * item.Product.Price;
            //}
            if (discount>0 && discount<=100)
            {
                amount *= (100 - discount) / 100.0;
            }
            return amount;
        }

        /// <summary>
        /// wypisuje na konsoli pozycje zamówienia
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Elementy zamówienia");
            //foreach (var item in items)
            //{
            //    Console.WriteLine("{0,-40}|{1,10}|{2,10:0.00}|{3,12:0.00}",
            //        item.Product.Name, item.Qnty, item.Product.Price,
            //        item.Qnty * item.Product.Price);
            //}
            items.ForEach(item => Console.WriteLine("{0,-40}|{1,10}|{2,10:0.00}|{3,12:0.00}",
                    item.Product.Name, item.Qnty, item.Product.Price,
                    item.Qnty * item.Product.Price));
            Console.WriteLine("Do zapłaty: {0:0.00}", CalcTotalAmount() );
        }

    }
}
