using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    public class Contact
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public string toString()
        {
            return "First_Name: " + first_name + "\nLast_Name: " + last_name + "\nAddress: " + address + "\nCity: " + city + "\nState: " + state +
                   "\nZIP: " + zip + "\nPhone_Number: " + phoneNumber + " \nEmail: " + email;
        }



    }
}
