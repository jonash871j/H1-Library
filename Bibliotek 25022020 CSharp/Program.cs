using System;
using System.Collections.Generic;

class Program
{
    static void PrintBookStack(Stack<Book> bookStack)
    {
        int i = 0;
        foreach (Book book in bookStack)
        {
            Console.WriteLine(i + ".\n" + book.GetInfomation());
            i++;
        }
    }
    static void PrintBookList(List<Book> bookList)
    {
        int i = 0;
        foreach (Book book in bookList)
        {
            Console.WriteLine(i + ".\n" + book.GetInfomation());
            i++;
        }
    }

    static void Main(string[] args)
    {
        Book book01 = new Book("A Book", "Danish", BookGenre.Adventure, 128);
        Book book02 = new Book("Scary", "English", BookGenre.Horror, 166);
        Book book03 = new Book("Dummy Book", "English", BookGenre.Fantasy, 10);

        Stack<Book> user = new Stack<Book>();
        List<Book> system = new List<Book>() { book01, book02, book03 };

        while (true)
        {
            Console.WriteLine(" - Book System");
            PrintBookList(system);

            Console.WriteLine("\n - User");
            PrintBookStack(user);

            Console.WriteLine("-1 to put all book back.");
            Console.Write("Loan choice: ");
            
            try
            {
                int choice = int.Parse(Console.ReadLine());

                if (choice == -1)
                {
                    int length = user.Count;
                    for (int i = 0; i < length; i++)
                        system.Add(user.Pop());
                }
                else
                {
                    user.Push(system[choice]);
                    system.RemoveAt(choice);
                }
            }
            catch
            {
                Console.WriteLine("Failed...");
                Console.ReadKey();
            }
            Console.Clear();
        }
    }
}