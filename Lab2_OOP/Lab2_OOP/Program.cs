using System;

namespace Lab2_OOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Lab02_OOP
    {
        //Определить класс, указанный в варианте
        //геттеры, сеттеры
        //pertial
        public partial class Book
        {
            int numberOfBooks = 0;

            private readonly int id;

            private string title;
            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            private string author;
            public string Author
            {
                get { return author; }
                set { author = value; }
            }

            private string publishingHouse;
            public string PublishingHouse
            {
                get { return publishingHouse; }
                set { publishingHouse = value; }
            }

            private int theYearOfPublishing;
            public int TheYearOfPublishing
            {
                get { return theYearOfPublishing; }
                set { theYearOfPublishing = value; }
            }

            private int numberOfPages;
            public int NumberOfPages
            {
                get { return numberOfPages; }
                set { numberOfPages = value; }
            }

            private int price;
            public int Price
            {
                get { return price; }
                //ограничение доступа по set
                protected set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Ошибка. такой цены нет.");
                    }
                }
            }

            private string bindingType;
            public string BindingType
            {
                get { return bindingType; }
                set { bindingType = value; }
            }

            //Не менее трех конструкторов(с параметрами и без, а также с параметрами по умолчанию);
            //полный конструктор с параметрами по умолчанию
            public Book(int id, string title1, string author1, string publishingHouse1, int numberOfPages1, int theYearOfPublishing1, int price1, string bindingType1)
            {
                title = title1;
                author = author1;
                publishingHouse = publishingHouse1;
                theYearOfPublishing = theYearOfPublishing1;
                numberOfPages = numberOfPages1;
                price = price1;
                bindingType = bindingType1;
                id = this.GetHashCode();
                numberOfBooks++;
            }
            //конструктор с неполными парметрами
            public Book(int id, string author1)
            {
                id = this.GetHashCode();
                author = author1;/////
                numberOfBooks++;
            }
            //конструктор без параметров
            public Book()
            {
                title = "неизвестно";
                author = "неизвестно";
                publishingHouse = "неизвестно";
                theYearOfPublishing = 0;
                numberOfPages = 0;
                price = 0;
                bindingType = "неизвестно";
                id = this.GetHashCode();
                numberOfBooks++;
            }
            //статический конструктор
            static Book()
            {
                Console.WriteLine(" ya sтатический конструктор");
            }
            //закрытый конструктор
            private Book(string title1, string author1, int price1)
            {
                title = title1;
                author = author1;
                price = price1;
                numberOfBooks++;
                id = this.GetHashCode();
            }
            //ref out (надо поправить)
            public void GetSurname(ref string sname)
            {
                Console.WriteLine($"Фамилия: {sname}");
            }
            public void GetUniversity(out string result)
            {
                result = "БГТУ";
            }
            //поле константа
            public const string library = "National Library";
            //статический метод вывода информации о классе
            public static void PrintInfo(Book book)
            {
                Console.WriteLine();
                Console.WriteLine("НАзвание: " + book.title + "\nАвтор: " + book.author + "\nИздательство: " + book.publishingHouse);
                Console.WriteLine("Год издания: " + book.theYearOfPublishing + "\nКоличество страниц: " + book.numberOfBooks + "\nЦена: " + book.price);
                Console.WriteLine("Тип переплета: " );
                Console.WriteLine("Униальный номер (ID)" + book.id);
            }
        }

    }
}
