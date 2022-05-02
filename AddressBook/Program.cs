// See https://aka.ms/new-console-template for more information
using AddressBook;
Console.WriteLine("Welcome to ADDRESS BOOK !");
Contact obj = new Contact();
CreateContact cont = new CreateContact();
Console.WriteLine("Enter \n1 for CREATE CONTACT IN ADDRESSBOOK PROGRAM \n2 for USER INPUT CONTACT IN ADDRESSBOOK PROGRAM \n3 for EDIT CONTACTS IN ADDRESSBOOK PROGRAM\n");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        cont.createContactMethod();
        cont.printContact();
        break;

    case 2:
        AddContactUserInput obj2 = new AddContactUserInput();
        obj2.addContact();
        obj2.printAddedContact();
        break;

    case 3:
        EditContacts obj3 = new EditContacts();
        obj3.editContacts();
        break;
}