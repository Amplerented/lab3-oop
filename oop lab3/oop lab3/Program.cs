using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создать класс Book: id, Название, Автор (ы),
 Издательство, Год издания, Количество страниц, Цена,
Тип переплета. Свойства и конструкторы должны
обеспечивать проверку корректности. 
Создать массив объектов. Вывести:
a) список книг заданного автора;
b) список книг, выпущенных после заданного года.*/

namespace lab3
{
    public partial class Book
    {
        public string surnameOfAuthor, nameOfAuthor, publishingHouse, valuePage, price, typeBinding, nameOfBook;
        public int date, id;
        private const string universitylib = "Библиотека БГТУ";



    }
    public partial class Book
    {
        public Book()
        {
            id = GetHashCode();
            nameOfAuthor = "Иван";
            surnameOfAuthor = "Иванов";
            date = 1900;
            publishingHouse = "Эксмо";
            valuePage = "200";
            price = "100 бел.руб";
            nameOfBook = "Лес и море";
            typeBinding = "Твердый переплет";

        }

        public Book(string a, string b, int d, string e, string f, string g, string h, string k)
        {
            Console.WriteLine();
            nameOfAuthor = a;
            surnameOfAuthor = b;
            date = d;
            publishingHouse = e;
            valuePage = f;
            price = g;
            nameOfBook = h;
            typeBinding = k;
            id = GetHashCode();

        }


        public void Info()
        {
            Console.WriteLine($"id   {id}");
            Console.WriteLine($"Имя автора  {nameOfAuthor}");
            Console.WriteLine($"Фамилия автора   {surnameOfAuthor}");
            Console.WriteLine($"Год издания       {date}");
            Console.WriteLine($"Издательство       {publishingHouse}");
            Console.WriteLine($"Количество страниц     {valuePage}");
            Console.WriteLine($"Цена   {price}");
            Console.WriteLine($"Название книги   {nameOfBook}");
            Console.WriteLine($"Тип переплета   {typeBinding}");
            Console.WriteLine($"Библиотека   {universitylib}");
        }

    }



    class Cmin
    {
        public static int min(int x, int y)
        {
            int z = (x < y) ? x : y;
            return z;
        }
        public static int minabs(ref int x, ref int y)
        {
            x = (x < 0) ? -x : x; y = (y < 0) ? -y : y;
            int z = (x < y) ? x : y;
            return z;
        }
        public static void Sum(ref int x, ref int y, out int a)
        {
            a = x + y;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Console.WriteLine();
            book1.Info();

            Book[] arr = new Book[6];
            arr[0] = new Book("Петр", "Петров", 1980, "Эксмо", "431", "51 бел.руб", "Грех", "Твердый");
            arr[1] = new Book("Василий", "Васильев", 2000, "ЛитБел", "342", "15 бел.руб", "Доля", "Твердый");
            arr[2] = new Book("Андрей", "Андреев", 1941, "Эксмо", "543", "7 бел.руб", "Сын и дочь", "Мягкий");
            arr[3] = new Book("Леонид", "Леонидов", 1967, "ЛитБел", "169", "12 бел.руб", "Лето", "Мягкий");
            arr[4] = new Book("Антон", "Антонов", 1983, "Эксмо", "241", "9 бел.руб", "Зов", "Мягкий");
            arr[5] = new Book("Генадий", "Генадьев", 1992, "ЛитБел", "821", "72 бел.руб", "Утюг", "Твердый");

            Book book2 = new Book();
            book2.nameOfAuthor = "Максим";
            book2.surnameOfAuthor = "Максимов";
            book2.date = 1970;
            book2.publishingHouse = "ЛитБел";
            book2.valuePage = "395";
            book2.price = "36 бел.руб";
            book2.nameOfBook = "Роза";
            book2.typeBinding = "Мягкий переплет";
            book2.Info();
            Console.WriteLine();

            Console.WriteLine("book1==book2?  " + book1.Equals(book2));
            Console.WriteLine("book1 " + book1.GetType());
            Console.WriteLine(book1.GetHashCode());
            Console.WriteLine(book1.ToString() + "\n");


            int a = -4;
            int b = 2;
            int z;
            Console.WriteLine("a={0}  b={1}", a, b);
            int k = Cmin.min(a, b);
            Console.WriteLine("k=" + k);
            k = Cmin.minabs(ref a, ref b);
            Console.WriteLine("a={0}  b={1}", a, b);
            Console.WriteLine("k=" + k);
            Cmin.Sum(ref a, ref b, out z);
            Console.WriteLine("a+b={0}", z);
            Console.WriteLine();

            Console.Write("Введите год издания: ");
            string year1 = Console.ReadLine();
            int year = Convert.ToInt32(year1);


            Console.WriteLine(" ");
            Console.WriteLine($"Год издания {year}:   ");
            Console.WriteLine("");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].date > year)
                {
                    arr[i].Info();
                    Console.WriteLine(" ");
                }
                else
                {
                    if (arr[i].date < year)
                    Console.WriteLine("Таких книг в библиотеке нет");
                }

            }

            Console.Write("Введите имя автора: ");
            string name = Console.ReadLine();


            Console.WriteLine(" ");
            Console.WriteLine($"Автор {name}:   ");
            Console.WriteLine(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].nameOfAuthor == name)
                {
                    arr[i].Info();
                }
            }
            Console.ReadLine();
        }
    }
}