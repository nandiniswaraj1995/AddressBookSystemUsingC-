using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        public static Dictionary<string, List<Contact>> addressBookStore = new Dictionary<string, List<Contact>>();


        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to address book system program !");
            Console.WriteLine("Enter name of the address book in which you want to add record.");
            String bookName = Console.ReadLine();
            AddressBook.addBook(bookName);


        }
    }
}
