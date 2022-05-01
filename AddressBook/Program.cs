// See https://aka.ms/new-console-template for more information
using AddressBook;
Console.WriteLine("Welcome to ADDRESS BOOK !");
CreateContact cont = new CreateContact();
cont.createContactMethod();
cont.printContact();