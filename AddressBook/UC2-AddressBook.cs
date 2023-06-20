public class EditContactUC
{
    public static void EditContact(AddressBook addressBook, string name, ContactPerson updatedPerson)
    {
        addressBook.EditContact(name, updatedPerson);
    }
}