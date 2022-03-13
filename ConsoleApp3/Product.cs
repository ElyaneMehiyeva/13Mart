using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Product
    {
        // constructor - qurucu metod Mecburi olan Parametrleri isteyir ve class cagrildigda ilk ise dusen budur
        public Product(int No, string Name, double Price)
        {
            this.No = No;
            this.Name = Name;
            this.Price = Price;
        }
        public int No;
        public string Name;
        public double Price;
        public int Count;
    }
}
