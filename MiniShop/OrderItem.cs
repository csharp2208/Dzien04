using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class OrderItem
    {
        private Product product;
        private int qnty;

        public int Qnty { 
            get { return qnty; }  
            set { qnty = value; }
        }
        public Product Product { get { return product; } }

        public OrderItem(Product p, int q)
        {
            product = p;
            qnty = q;
        }

    }
}
