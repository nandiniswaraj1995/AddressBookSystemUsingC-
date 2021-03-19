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
            Console.WriteLine("Enter the name fo the address book you want to edit.");
            String bookToEdit = Console.ReadLine();
            Console.WriteLine("Enter the first name of the person whose record you want to edit.");
            String recordNameToEdit = Console.ReadLine();
            AddressBook.editRecordUsingFisrtName(recordNameToEdit, bookToEdit);
            Console.WriteLine("Enter name of the address book you want to delete record in.");
            String bookToDeleteIn = Console.ReadLine();
            Console.WriteLine("Enter first name of the person whose record you want to delete.");
            String recordNameToDelete = Console.ReadLine();
            AddressBook.deleteRecord(recordNameToDelete, bookToDeleteIn);





        }
    }
}
