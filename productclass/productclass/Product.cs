using System;
using System.Collections.Generic;
using System.Text;

namespace productclass
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double Totalincome { get; set; }

        public Product (string name)
        {
            Name = name;
        }
        public void Satish ()
        {
            if(Count > 0)
            {
                Count--;
                Totalincome += Price;

            }
            else
            {
                Console.WriteLine("secdiyiniz mehsuldan qalmayib.");
            }
        }

    }
}
