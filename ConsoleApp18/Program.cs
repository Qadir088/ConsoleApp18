using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Electronic electronic = new Electronic();
        }
        interface Product
        {
            double GetPrice(double b);
            int ReduceStock(int i);

        }
        class Book : Product
        {
            public double GetPrice()
            {
                return 0;
            }

            public double GetPrice(double b)
            {
                throw new NotImplementedException();
            }

            public int ReduceStock(int i)
            {
                return 0;
            }
        }
        class Electronic :Product
            {
            public double GetPrice(double b)
            {
                return 0;
            }

            public int ReduceStock(int i)
            {
                return 0;
            }
        }
        public int GetPrice()
            {
                return 0;
            }
            public void ReduceStock()
            {

            }
    }
}  


