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
       
        public List<Contact> ContactBook= new List<Contact>();
        public void createContactMethod()
        {
            Contact obj1 = new Contact();
            obj1.FirstName = "Rahul";
            obj1.LastName = "Rawat";
            obj1.City = "Chandigarh";
            obj1.State = "Punjab";
            obj1.ZipCode = "110087";
            obj1.PhoneNumber = " 9876554321";
            obj1.E_Mail = "PunjabThePower@344";
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
