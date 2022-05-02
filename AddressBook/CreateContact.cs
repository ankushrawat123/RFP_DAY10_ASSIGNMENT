using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    // Ability to create a contact

    public class CreateContact
    {

        public List<Contact> ContactBook = new List<Contact>();
        public void createContactMethod()
        {
            Contact obj1 = new Contact();
            obj1.FirstName = "Ankush";
            obj1.LastName = "Rawat";
            obj1.City = "Delhi";
            obj1.State = "Delhi";
            obj1.ZipCode = "110096";
            obj1.PhoneNumber = "9876554321";
            obj1.E_Mail = "ankushrwt344@gmail.com";
            ContactBook.Add(obj1);
            Console.WriteLine("\nADDRESS BOOK Is Created ");
        }

        //Printing ContactBook
        public void printContact()
        {
            Console.WriteLine("\nPrinting Contact information ..................................\n");
            foreach (var obje in ContactBook)
            {
                Console.WriteLine("FirstName is "+ obje.FirstName);
                Console.WriteLine("LastName is "+ obje.LastName);
                Console.WriteLine("City is "+ obje.City);
                Console.WriteLine("State is "+ obje.State);
                Console.WriteLine("ZipCode is "+ obje.ZipCode);
                Console.WriteLine("PhoneNumber is "+ obje.PhoneNumber);
                Console.WriteLine("E_Mail is "+ obje.E_Mail);      
            }
        }
    }
}
