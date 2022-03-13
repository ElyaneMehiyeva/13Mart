using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mesajlar 
            string command1 = "Qiymete gore filtirle";
            string command2 = "Adina gore axtaris et";
            string command3 = "Butun kitablara bax";
            string command0 = "Programi Bagla";
            Console.WriteLine("Element Sayini Daxil Edin :");
            //int sizeArray = int.Parse(Console.ReadLine());
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            while (sizeArray < 0)
            {
                Console.WriteLine("Element Sayini Daxil Edin :");
                sizeArray = int.Parse(Console.ReadLine());                
            }
            Book[] Array = new Book[sizeArray];
            int index = 0;
            while (sizeArray > 0)
            {
                Console.WriteLine("Kitabin Adini Daxil Edin");
                string bookName = Console.ReadLine();
                while(bookName.Length < 3 || bookName.Length > 50)
                {
                    Console.WriteLine("Kitabin Adini Daxil Edin");
                    bookName = Console.ReadLine();
                }
                // Book Name +
                Console.WriteLine("Kitabin Nomresini Daxil Edin:");
                int bookNo = int.Parse(Console.ReadLine());
                while (bookNo < 0)
                {
                    Console.WriteLine("Kitabin Nomresini Daxil Edin:");
                    bookNo = int.Parse(Console.ReadLine());
                }
                // Book No +
                Console.WriteLine("Kitabin Qiymetini Daxil Edin :");
                double bookPrice = double.Parse(Console.ReadLine());
                while (bookPrice < 0)
                {
                    Console.WriteLine("Kitabin Qiymetini Daxil Edin :");
                    bookPrice = double.Parse(Console.ReadLine());
                }
                // Book Price +
                Console.WriteLine("Kitab Sayin Daxil Edin :");
                int bookCount = int.Parse(Console.ReadLine());
                while (bookCount < 0) 
                {
                    Console.WriteLine("Kitab Sayin Daxil Edin :");
                    bookCount = int.Parse(Console.ReadLine());
                }
                // Book Count +
                Console.WriteLine("Kitabin Janrini Daxil Edin :");
                string bookGenre = Console.ReadLine();
                while(bookGenre.Length <3)
                {
                    Console.WriteLine("Kitabin Janrini Daxil Edin :");
                    bookGenre = Console.ReadLine();
                }
                // Book Genre +
                Book obyekt = new Book(bookGenre, bookNo, bookName, bookPrice)
                {
                    Count = bookCount,
                };


                Array[index] = obyekt;



                index++;
                sizeArray--;
            }
            Console.WriteLine("\nKitab Depolanmasi Bitdi!\n");

            while (true)
            {
                Console.WriteLine($"1 - {command1}\n2 - {command2}\n3 - {command3}\n0 - {command0}");
                int menu = int.Parse(Console.ReadLine());
                if(menu == 0)
                {
                    Console.WriteLine("Program Dayandirildi");
                    break;
                }
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Minimum Qiymeti Daxil Edin");
                        double minPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine("Maksimum Qiymeti Daxil Edin");
                        double maxPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine("Daxil etdiyiniz qiymete uygun kitablar");

                        foreach (Book book in filtrForPrice(Array, minPrice, maxPrice))
                        {
                            Console.WriteLine(book.GetInfo());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Axtardiginiz kitabin adini yazin");
                        
                        string searchingBook = Console.ReadLine();
                        Console.WriteLine("Axtarisin Neticeleri");
                        foreach (Book book in filterForName(Array,searchingBook))
                        {
                            Console.WriteLine(book.GetInfo());
                        }
                        break;
                    case 3:
                        foreach (Book book in Array)
                        {
                            Console.WriteLine(book.GetInfo());
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        static Book[] filtrForPrice(Book[] Massiv,double minPrice, double maxPrice)
        {
            int count = 0;
            foreach (Book book in Massiv)
            {
                if(book.Price > minPrice && book.Price < maxPrice)
                {
                    count++;
                }
            }
            Book[] newArray = new Book[count];
            int index = 0;
            foreach (Book book in Massiv)
            {
                if (book.Price > minPrice && book.Price < maxPrice)
                {
                    newArray[index] = book;
                    index++;
                }
            }
            return newArray;
        }
        static Book[] filterForName(Book[] Massiv,string name)
        {
            int count = 0;
            foreach (Book book in Massiv)
            {
                if (book.Name==name)
                {
                    count++;
                }
            }
            Book[] newArray = new Book[count];
            int index = 0;
            foreach (Book book in Massiv)
            {
                if (book.Name == name)
                {
                    newArray[index] = book;
                    index++;
                }
            }
            return newArray;
        }
       


    }
}
