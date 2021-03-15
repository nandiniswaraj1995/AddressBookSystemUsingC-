using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public static void contactDetails(string bookName)
        {
            Contact person = new Contact();

            Console.WriteLine("Enter All Details Like: ");
            Console.WriteLine("Enter First_Name: ");
            person.first_name = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            person.last_name = Console.ReadLine();
            Console.WriteLine("Enter Addree :");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter City Name:");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter State Name:");
            person.state = Console.ReadLine();
            Console.WriteLine("Enter pin Number:");
            person.zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number:");
            person.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            person.email = Console.ReadLine();

            addRecord(Program.addressBookStore[bookName], bookName, person);
            Console.WriteLine("Your Data :\n"+person.toString());


        }

        public static void addRecord(List<Contact> book, string bookName, Contact newRecord)
        {
            bool recordPresentInBook = false;
            foreach (Contact record in book)
            {
                Contact recordCheck = record;
                if (record == newRecord)
                {
                    recordPresentInBook = true;
                    break;
                }
            }
            if (recordPresentInBook)
            {
                Console.WriteLine("Record already exists in address book " + bookName);
            }
            else
            {
                book.Add(newRecord);
                Console.WriteLine("Record added to address book " + bookName);
            }

        }
        // initialize book if not present allready
        public static void addRecord(string bookName)
        {
            if (!Program.addressBookStore.ContainsKey(bookName))
            {
                Program.addressBookStore.Add(bookName, new List<Contact>());
            }

            contactDetails(bookName);
        }

    }
}
