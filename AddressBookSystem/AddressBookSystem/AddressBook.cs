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

        public static void editRecord(string recordNameToEdit, string bookToEdit)
        {

            if (Program.addressBookStore.ContainsKey(bookToEdit))
            {
                List<Contact> book = Program.addressBookStore[bookToEdit];
                foreach (Contact record in book)
                {
                    if (book.Contains(record))
                    {
                        Console.WriteLine("Select Which Data You Want To Update \n1.First_Name \n2.Last_Name \n3.Address" +
                                               "\n4.City \n5.State \n6.Zip \n7.PhoneNumber \n8.Email");
                        string selection = Console.ReadLine();
                        string newData;
                        switch (selection)
                        {
                            case "1":
                                Console.WriteLine("Enter First_Name");
                                newData = Console.ReadLine();
                                record.first_name = newData;
                                Console.WriteLine("Your Updated  Records :\n" + record.toString());

                                break;
                            case "2":
                                Console.WriteLine("Enter Last_Name");
                                newData = Console.ReadLine();
                                record.last_name = newData;
                                Console.WriteLine("Your Updated  Records :\n" + record.toString());

                                break;
                            case "3":
                                Console.WriteLine("Enter Address");
                                newData = Console.ReadLine();
                                record.address = newData;
                                Console.WriteLine("Your Updated  Records :\n" + record.toString());

                                break;
                            case "4":
                                Console.WriteLine("Enter City");
                                newData = Console.ReadLine();
                                record.city = newData;
                                Console.WriteLine("Your Updated  Records :\n" + record.toString());

                                break;
                            case "5":
                                Console.WriteLine("Enter State");
                                newData = Console.ReadLine();
                                record.state = newData;
                                Console.WriteLine("Your Updated  Records :\n" + record.toString());

                                break;
                            case "6":
                                Console.WriteLine("Enter Zip");
                                newData = Console.ReadLine();
                                record.zip = newData;
                                Console.WriteLine("Your Updated  Records :\n" + record.toString());

                                break;
                            case "7":
                                Console.WriteLine("Enter PhoneNumber");
                                newData = Console.ReadLine();
                                record.phoneNumber = newData;
                                Console.WriteLine("Your Updated  Records :\n" + record.toString());

                                break;
                            case "8":
                                Console.WriteLine("Enter Email");
                                newData = Console.ReadLine();
                                record.email = newData;
                                Console.WriteLine("Your Updated  Records :\n" + record.toString());

                                break;
                            default:
                                Console.WriteLine("Invalid Selection Input");
                                break;
                        }
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No Such BookAddress Found");
            }



        }


    }
}
