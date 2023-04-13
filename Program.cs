using System;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductUser<string> user1 = new ProductUser<string>();
            user1.SetLogin("Матвей");
            user1.SetPassword("password1");
            user1.SetTitle("О дивный новый мир!");
            user1.SetAuthor("Олдос Хаксли");
            user1.SetPublicationDate("01.01.1932");
            user1.SetPageCount(337);
            user1.Buy();

            ProductUser<int> user2 = new ProductUser<int>();
            user2.SetLogin(1234);
            user2.SetPassword("password2");
            user2.SetTitle("1984");
            user2.SetAuthor("Джордж Оруэлл");
            user2.SetPublicationDate(01011949);
            user2.SetPageCount(401);
            user2.Buy();
        }
    }

    interface IPublisher
    {
        void SetTitle(string title);
        void SetAuthor(string author);
    }

    interface IBook<T> : IPublisher
    {
        void SetPublicationDate(T publicationDate);
        void SetPageCount(int pageCount);
    }

    interface IUser<T>
    {
        void SetLogin(T login);
        void SetPassword(string password);
    }

    interface IProductUser<T> : IBook<T>, IUser<T>
    {
        void Buy();
    }

    class Book<T> : IBook<T>
    {
        private string title;
        private string author;
        private T publicationDate;
        private int pageCount;

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public void SetPublicationDate(T publicationDate)
        {
            this.publicationDate = publicationDate;
        }

        public void SetPageCount(int pageCount)
        {
            this.pageCount = pageCount;
        }
    }

    class User<T> : IUser<T>
    {
        private T login;
        private string password;

        public void SetLogin(T login)
        {
            this.login = login;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }
    }

    class ProductUser<T> : IProductUser<T>
    {
        private string title;
        private string author;
        private T publicationDate;
        private int pageCount;
        private T login;
        private string password;

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public void SetPublicationDate(T publicationDate)
        {
            this.publicationDate = publicationDate;
        }

        public void SetPageCount(int pageCount)
        {
            this.pageCount = pageCount;
        }

        public void SetLogin(T login)
        {
            this.login = login;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public void Buy()
        {
            Console.WriteLine($"Пользователь {login} купил книгу {title} автор - {author}.");
        }
    }
}


