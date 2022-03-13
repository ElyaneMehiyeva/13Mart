using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Book:Product
    {
        public Book(string Genre,int No,string Name,double Price):base(No,Name,Price)
        {
            this.Genre = Genre;
        }
        public string Genre;
        public string GetInfo()
        {
            string info = $"Book Name : {Name}\nBook Price : {Price}\nBook No : {No}\nBook Genre : {this.Genre}\nBook Count : {Count}";
            return info;
        }
    }
}
